using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using NetCoreForum.Entites;
using NetCoreForum.Mapping;
using NetCoreForum.Repositories.Abstract;
using NetCoreForum.Repositories.Concrete;
using NetCoreForum.Services.SMTPMailServer.Abstract;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration["ConnectionStrings:SqlServer"]));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireDigit = false;

    options.User.RequireUniqueEmail = true;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnoprstuvyzqxw";

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options.SignIn.RequireConfirmedEmail = true;
});

builder.Services.AddScoped<IEmailSender, EmailSender>();

builder.Services.AddScoped<ISiteSettingsRepository, SiteSettingsRepository>();
builder.Services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();
builder.Services.AddScoped<IPendingUserRepository, PendingUserRepository>();
builder.Services.AddScoped<IErrorMessageRepository, ErrorMessageRepository>();
builder.Services.AddScoped<ITopicRepository, TopicRepository>();
builder.Services.AddScoped<IReplyRepository, ReplyRepository>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Topic}/{action=Index}/{id?}");


app.Run();
