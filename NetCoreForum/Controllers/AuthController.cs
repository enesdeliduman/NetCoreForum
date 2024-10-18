using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using NetCoreForum.DTOs.PendingUserDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Repositories.Abstract;
using NetCoreForum.Repositories.Concrete;
using NetCoreForum.ViewModels.UserViewModels;
using System.Security.Claims;

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
        private readonly IErrorMessageRepository _errorMessageRepository;
        public AuthController(
            UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            ApplicationDbContext context, IEmailSender emailSender,
            IEmailTemplateRepository emailTemplateRepository, ISiteSettingsRepository siteSettingsRepository,
            IPendingUserRepository pendingUserRepository, IErrorMessageRepository errorMessageRepository
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _emailSender = emailSender;
            _emailTemplateRepository = emailTemplateRepository;
            _siteSettingsRepository = siteSettingsRepository;
            _pendingUserRepository = pendingUserRepository;
            _errorMessageRepository = errorMessageRepository;
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
                    await _emailSender.SendEmailAsync(user.Email, email.Subject, $"{email.Body} <br> <a href='http://localhost:5222{url}'>Tıkla</a>");

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
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(userLoginViewModel.Email);

                if (user != null)
                {
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError("", await _errorMessageRepository.GetErrorMessageByErrorMessageNameToStringAsync("UserNotConfirmed"));
                        return View(userLoginViewModel);
                    }
                    else
                    {
                        var isTrueEmailAndPassword = await _signInManager.CheckPasswordSignInAsync(user, userLoginViewModel.Password, lockoutOnFailure: true);
                        if (isTrueEmailAndPassword.Succeeded)
                        {
                            var isPending = await _context.PendingUsers.FirstOrDefaultAsync(x => x.AppUser == user);
                            if (isPending != null)
                            {
                                ModelState.AddModelError("", await _errorMessageRepository.GetErrorMessageByErrorMessageNameToStringAsync("AccountPendingApproval"));
                                return View(userLoginViewModel);
                            }
                            await _signInManager.SignOutAsync();
                            var result = await _signInManager.PasswordSignInAsync(user, userLoginViewModel.Password, userLoginViewModel.RememberMe, true);
                            if (result.Succeeded)
                            {
                                var userClaims = new List<Claim>
                                {
                                    new(ClaimTypes.NameIdentifier,user.Id.ToString()),
                                    new (ClaimTypes.Name, user.UserName ?? ""),
                                    new (ClaimTypes.UserData, user.UserPhoto?? ""),
                                };


                                await _userManager.ResetAccessFailedCountAsync(user);
                                await _userManager.SetLockoutEndDateAsync(user, null);
                                return RedirectToAction("Index", "Home");
                            }
                            else if (result.IsLockedOut)
                            {
                                ModelState.AddModelError("", await _errorMessageRepository.GetErrorMessageByErrorMessageNameToStringAsync("AccountLocked"));
                                return View(userLoginViewModel);

                            }
                        }
                        ModelState.AddModelError("", await _errorMessageRepository.GetErrorMessageByErrorMessageNameToStringAsync("InvalidEmailOrPassword"));
                        return View(userLoginViewModel);

                    }
                }
                ModelState.AddModelError("", await _errorMessageRepository.GetErrorMessageByErrorMessageNameToStringAsync("EmailNotFound"));
            }
            return View(userLoginViewModel);
        }
    }
}