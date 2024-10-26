using Azure.Core;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Constants.ClaimTypes;
using NetCoreForum.Data;
using NetCoreForum.DTOs.PendingUserDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Helpers;
using NetCoreForum.Repositories.Abstract;
using NetCoreForum.ViewModels.UserViewModels;
using System.Security.Claims;
using System.Security.Principal;

namespace NetCoreForum.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;
        private readonly IEmailTemplateRepository _emailTemplateRepository;
        private readonly ISiteSettingsRepository _siteSettingsRepository;
        private readonly IPendingUserRepository _pendingUserRepository;
        private readonly IInfoMessageRepository _infoMessageRepository;
        public AuthController(
            UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            ApplicationDbContext context, IEmailSender emailSender,
            IEmailTemplateRepository emailTemplateRepository, ISiteSettingsRepository siteSettingsRepository,
            IPendingUserRepository pendingUserRepository, IInfoMessageRepository infoMessageRepository
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _emailSender = emailSender;
            _emailTemplateRepository = emailTemplateRepository;
            _siteSettingsRepository = siteSettingsRepository;
            _pendingUserRepository = pendingUserRepository;
            _infoMessageRepository = infoMessageRepository;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = userRegisterViewModel.UserName,
                    Email = userRegisterViewModel.Email,
                };
                IdentityResult result = await _userManager.CreateAsync(user, userRegisterViewModel.Password);
                if (result.Succeeded)
                {
                    var welcomeEmail = await _emailTemplateRepository.GetEmailTemplateByTemplateNameAsync("Welcome");
                    await _emailSender.SendEmailAsync(user.Email, welcomeEmail.Subject, $"{welcomeEmail.Body}");

                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Auth", new { user.Id, token });

                    var email = await _emailTemplateRepository.GetEmailTemplateByTemplateNameAsync("EmailConfirmation");
                    await _emailSender.SendEmailAsync(user.Email, email.Subject, $"{email.Body} <br> <a href='http://localhost:5146{url}'>Tıkla</a>");

                    var siteSettings = await _siteSettingsRepository.GetSiteSettingsAsync();
                    if (siteSettings.RequireAdminApproval)
                    {
                        var AccountPendingApprovalMail = await _emailTemplateRepository.GetEmailTemplateByTemplateNameAsync("AccountPendingApproval");
                        await _emailSender.SendEmailAsync(user.Email, AccountPendingApprovalMail.Subject, $"{AccountPendingApprovalMail.Body}");
                        await _pendingUserRepository.CreatePendingUserAsync(new CreatePendingUserDTO
                        {
                            AppUser = user,
                            AppUserID = user.Id,
                            RegistrationDate = DateTime.Now,
                        });
                    }

                    return RedirectToAction("Login", "Auth");
                }
                else
                {
                    foreach (IdentityError err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                    return View(userRegisterViewModel);
                }

            }
            return View(userRegisterViewModel);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userLoginViewModel);
            }

            var user = await _userManager.FindByEmailAsync(userLoginViewModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("", await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("EmailNotFound"));
                return View(userLoginViewModel);
            }

            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("UserNotConfirmed"));
                return View(userLoginViewModel);
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, userLoginViewModel.Password, lockoutOnFailure: true);
            if (!signInResult.Succeeded)
            {
                if (signInResult.IsLockedOut)
                {
                    ModelState.AddModelError("", await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("AccountLocked"));
                }
                else
                {
                    ModelState.AddModelError("", await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("InvalidEmailOrPassword"));
                }
                return View(userLoginViewModel);
            }

            var isPending = await _context.PendingUsers.FirstOrDefaultAsync(x => x.AppUser == user);
            if (isPending != null)
            {
                ModelState.AddModelError("", await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("AccountPendingApproval"));
                return View(userLoginViewModel);
            }

            await _signInManager.SignOutAsync();
            await _signInManager.PasswordSignInAsync(user, userLoginViewModel.Password, userLoginViewModel.RememberMe, true);

            // Kullanıcı kimlik bilgilerini ayarlama
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName ?? "Unknown"),
                new Claim(ClaimTypes.Email, user.Email ?? "unknown@email.com"),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim("UserSignature", user.UserSignature ?? "Default Signature"),
                new Claim("UserBiography", user.UserBiography ?? "Default Biography"),
                new Claim("UserPhoto", user.UserPhoto ?? "DefaultPhoto")
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = userLoginViewModel.RememberMe,
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(30)
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties
            );

            await _userManager.ResetAccessFailedCountAsync(user);
            await _userManager.SetLockoutEndDateAsync(user, null);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ConfirmEmail(string Id, string Token)
        {
            if (Id == null | Token == null)
            {
                TempDataHelper.SetTempDataMessage(this, "Geçersiz token bilgisi", "warning");
                return View();
            }
            var user = await _userManager.FindByIdAsync(Id);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, Token);
                if (result.Succeeded)
                {
                    TempDataHelper.SetTempDataMessage(this, await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("EmailConfirmed"), "success");
                    return View();
                }
            }
            TempDataHelper.SetTempDataMessage(this, await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("UserNotFound"), "error");
            return View();
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                TempDataHelper.SetTempDataMessage(this, await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("RequiredEmailAddress"), "warning");
                return RedirectToAction("ForgotPassword");
            }
            var user = await _userManager.FindByEmailAsync(Email);
            if (user == null)
            {
                TempDataHelper.SetTempDataMessage(this, await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("EmailNotFound"), "warning");
                return RedirectToAction("ForgotPassword");
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Auth", new { user.Id, token });
            var ForgotPasswordEmailTemplate = await _emailTemplateRepository.GetEmailTemplateByTemplateNameAsync("ForgotPassword");
            await _emailSender.SendEmailAsync(Email, ForgotPasswordEmailTemplate.Subject, ForgotPasswordEmailTemplate.Body + $"<a href='http://localhost:5146{url}'>Linke tıklayınız</a>");

            TempDataHelper.SetTempDataMessage(this, await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("SendEmailForNewPassword"), "success");
            return View();
        }
        public IActionResult ResetPassword(string Id, string Token)
        {
            if (Id == null || Token == null)
            {
                return NotFound();
            }
            var model = new ResetPasswordViewModel { Token = Token };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                TempDataHelper.SetTempDataMessage(this, await _infoMessageRepository.GetInfoMessageByInfoMessageNameToStringAsync("SuccessfullyChangePassword"), "success");
                return RedirectToAction("Login");
            }
            foreach (IdentityError err in result.Errors)
            {
                ModelState.AddModelError("", err.Description);
                return View();
            }

            return RedirectToAction("Index");

        }
    }
}