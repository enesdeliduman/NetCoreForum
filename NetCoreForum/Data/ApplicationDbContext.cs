using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Entites;
using NetCoreForum.Entities;

namespace NetCoreForum.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EmailConfiguration> EmailConfigurations { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<InfoMessage> InfoMessages { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PendingUser> PendingUsers { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SiteSettings> SiteSettings { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicType> TopicTypes { get; set; }
        public DbSet<Warning> Warnings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reply>()
                .HasOne(r => r.Topic)
                .WithMany(t => t.Replies)
                .HasForeignKey(r => r.TopicID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reply>()
                .HasOne(r => r.AppUser)
                .WithMany(u => u.Replies)
                .HasForeignKey(r => r.AppUserID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<EmailTemplate>().HasData(
                new EmailTemplate
                {
                    EmailTemplateID = 1,
                    TemplateName = "ForgotPassword",
                    ViewedTemplateName = "Şifremi Unuttum",
                    Subject = "Şifre Sıfırlama Talebi",
                    Body = "Şifrenizi sıfırlamak için lütfen aşağıdaki bağlantıyı tıklayın:",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 2,
                    TemplateName = "Welcome",
                    ViewedTemplateName = "Hoş Geldiniz",
                    Subject = "Hoş geldiniz!",
                    Body = "Kayıt olduğunuz için teşekkürler! Hesabınıza hoş geldiniz.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 3,
                    TemplateName = "ChangePassword",
                    ViewedTemplateName = "Şifre Değişikliği",
                    Subject = "Şifre Değişikliğiniz Başarılı",
                    Body = "Şifreniz başarıyla değiştirildi. Herhangi bir sorunla karşılaşırsanız, lütfen bizimle iletişime geçin.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 4,
                    TemplateName = "ConfirmAccount",
                    ViewedTemplateName = "Hesap Onayı",
                    Subject = "Hesabınız Onaylandı",
                    Body = "Hesabınız başarıyla onaylandı. Artık sitemizi kullanabilirsiniz.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 5,
                    TemplateName = "AccountPendingApproval",
                    ViewedTemplateName = "Hesap Beklemede",
                    Subject = "Hesap Onayınızı Bekliyor",
                    Body = "Foruma üye olduğunuz için teşekkürler! Hesabınız yönetici onayını bekliyor. Onaylandıktan sonra giriş yapabilirsiniz.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 6,
                    TemplateName = "AccountApproved",
                    ViewedTemplateName = "Hesap Onaylandı",
                    Subject = "Hesabınız Onaylandı",
                    Body = "Tebrikler! Hesabınız başarıyla onaylandı ve artık foruma giriş yapabilirsiniz. Hoş geldiniz!",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 7,
                    TemplateName = "AccountNotApproved",
                    ViewedTemplateName = "Hesap Onaylanmadı",
                    Subject = "Hesabınız Onaylanmadı",
                    Body = "Üzgünüz, hesabınız onaylanmadı. Daha fazla bilgi almak için lütfen yönetici ile iletişime geçin.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 8,
                    TemplateName = "AccountDeleted",
                    ViewedTemplateName = "Hesap Silindi",
                    Subject = "Hesabınız Silindi",
                    Body = "Hesabınız silindi. Eğer bu işlem siz tarafından yapılmadıysa lütfen bizimle iletişime geçin.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 9,
                    TemplateName = "WarningEmail",
                    ViewedTemplateName = "Uyarı Mesajı",
                    Subject = "Uyarı Aldınız - {warning_count}. Uyarı",
                    Body = "Merhaba {username}, \n\nBu size gönderilen {warning_count}. uyarıdır. 5 uyarıya ulaştığınızda hesabınız otomatik olarak silinecektir. Lütfen site kurallarına uyun.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 10,
                    TemplateName = "AccountDeletedDueToWarnings",
                    ViewedTemplateName = "Hesap Silindi",
                    Subject = "Hesabınız Silindi",
                    Body = "Merhaba, \n\nMaksimum uyarı sayısına ulaştığınız için kalıcı olarak hesabınız askıya alınmıştır. Eğer bu işlem hakkında sorularınız varsa, lütfen bizimle iletişime geçin.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 11,
                    TemplateName = "EmailConfirmation",
                    ViewedTemplateName = "E-posta Onayı",
                    Subject = "E-posta Onayı Gerekli",
                    Body = "Merhaba, Kayıt işleminizi tamamlamak için lütfen aşağıdaki bağlantıya tıklayarak e-posta adresinizi onaylayın:",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );


            modelBuilder.Entity<SiteSettings>().HasData(
                new SiteSettings
                {
                    SiteSettingsID = 1,
                    SiteName = "NetCoreForum",
                    LogoPath = "forum-logo.png",
                    FaviconPath = "forum-favicon.png",
                    ContactEmail = "mail@mail.com",
                    ContactPhone = "0555 555 55 55",
                    FooterText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    MaxWarningCountForAppUser = 5,
                    RequireAdminApproval = false
                }
            );


            modelBuilder.Entity<EmailConfiguration>().HasData(
                new EmailConfiguration
                {
                    EmailConfigurationID = 1,
                    Port = 587,
                    SmtpServer = "mail.enesdeliduman.com",
                    SenderName = "İletişimm",
                    SenderEmail = "iletisim@enesdeliduman.com",
                    SenderPassword = "124124262114Ee",
                    UseSSL = true,
                }
            );

            // InfoMessage verisini ekleme

            modelBuilder.Entity<InfoMessage>().HasData(new[]
            {
                new InfoMessage { InfoMessageID = 1, InfoMessageName = "NotFound", InfoMessageDescription = "Aradığınız kayıt bulunamadı." },
                new InfoMessage { InfoMessageID = 2, InfoMessageName = "UnauthorizedAccess", InfoMessageDescription = "Bu işlemi gerçekleştirmek için yetkiniz yok." },
                new InfoMessage { InfoMessageID = 3, InfoMessageName = "ServerError", InfoMessageDescription = "Bir hata oluştu. Lütfen daha sonra tekrar deneyin." },
                new InfoMessage { InfoMessageID = 4, InfoMessageName = "ValidationError", InfoMessageDescription = "Formda hatalar var. Lütfen kontrol edin." },
                new InfoMessage { InfoMessageID = 5, InfoMessageName = "InvalidLogin", InfoMessageDescription = "Giriş bilgileri hatalı. Lütfen tekrar deneyin." },
                new InfoMessage { InfoMessageID = 6, InfoMessageName = "AccountLocked", InfoMessageDescription = "Hesabınız kilitlenmiştir. Lütfen destek ile iletişime geçin." },
                new InfoMessage { InfoMessageID = 7, InfoMessageName = "PasswordTooWeak", InfoMessageDescription = "Parola en az 6 karakter olmalıdır ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir." },
                new InfoMessage { InfoMessageID = 8, InfoMessageName = "EmailAlreadyUsed", InfoMessageDescription = "Bu e-posta adresi zaten kullanılıyor." },
                new InfoMessage { InfoMessageID = 9, InfoMessageName = "UserNotConfirmed", InfoMessageDescription = "Lütfen e-posta adresinizi onaylayınız. Mail kutunuzu kontrol ediniz." },
                new InfoMessage { InfoMessageID = 10, InfoMessageName = "InvalidEmailOrPassword", InfoMessageDescription = "E-posta adresi veya parola hatalı." },
                new InfoMessage { InfoMessageID = 11, InfoMessageName = "AccountPendingApproval", InfoMessageDescription = "Hesabınız henüz onaylanmamıştır ve bekleme listesinde bulunmaktadır. Lütfen biraz daha bekleyin." },
                new InfoMessage { InfoMessageID = 12, InfoMessageName = "DuplicateEntry", InfoMessageDescription = "Bu kayıt zaten mevcut." },
                new InfoMessage { InfoMessageID = 13, InfoMessageName = "RegistrationFailed", InfoMessageDescription = "Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin." },
                new InfoMessage { InfoMessageID = 14, InfoMessageName = "PasswordChangeFailed", InfoMessageDescription = "Şifre değişikliği sırasında bir hata oluştu." },
                new InfoMessage { InfoMessageID = 15, InfoMessageName = "OldPasswordIncorrect", InfoMessageDescription = "Eski şifreniz hatalı." },
                new InfoMessage { InfoMessageID = 16, InfoMessageName = "EmailSendFailed", InfoMessageDescription = "E-posta gönderme işlemi sırasında bir hata oluştu." },
                new InfoMessage { InfoMessageID = 17, InfoMessageName = "EmailNotFound", InfoMessageDescription = "Bu e-posta adresine ait bir hesap bulunamadı." },
                new InfoMessage { InfoMessageID = 18, InfoMessageName = "RequiredField", InfoMessageDescription = "Bu alanın doldurulması zorunludur." },
                new InfoMessage { InfoMessageID = 19, InfoMessageName = "InvalidFormat", InfoMessageDescription = "Geçersiz format. Lütfen kontrol edin." },
                new InfoMessage { InfoMessageID = 20, InfoMessageName = "OperationFailed", InfoMessageDescription = "İşlem gerçekleştirilemedi. Lütfen daha sonra tekrar deneyin." },
                new InfoMessage { InfoMessageID = 21, InfoMessageName = "InvalidRequest", InfoMessageDescription = "Geçersiz istek. Lütfen kontrol edin." },
                new InfoMessage { InfoMessageID = 22, InfoMessageName = "ActionNotAllowed", InfoMessageDescription = "Bu eylem izin verilenler arasında değil." },
                new InfoMessage { InfoMessageID = 23, InfoMessageName = "FileUploadFailed", InfoMessageDescription = "Dosya yükleme işlemi sırasında bir hata oluştu." },
                new InfoMessage { InfoMessageID = 24, InfoMessageName = "FileTypeNotAllowed", InfoMessageDescription = "Bu dosya türü desteklenmiyor." },
                new InfoMessage { InfoMessageID = 25, InfoMessageName = "FileSizeExceeded", InfoMessageDescription = "Dosya boyutu limitini aşıyor." },
                new InfoMessage { InfoMessageID = 26, InfoMessageName = "EmailConfirmed", InfoMessageDescription = "Email adresiniz başarıyla onaylandı." },
                new InfoMessage { InfoMessageID = 27, InfoMessageName = "UserNotFound", InfoMessageDescription = "Böyle bir kullanıcı bulamadık" },
                new InfoMessage { InfoMessageID = 28, InfoMessageName = "RequiredEmailAddress", InfoMessageDescription = "Lütfen email adresinizi giriniz" },
                new InfoMessage { InfoMessageID = 29, InfoMessageName = "SendEmailForNewPassword", InfoMessageDescription = "Parolanızı yenileyembilmeniz için email gönderildi. Lütfen kutunuzu kontrol edin" },
                new InfoMessage { InfoMessageID = 30, InfoMessageName = "SuccessfullyChangePassword", InfoMessageDescription = "Parolanız başarıyla değiştirildi." },
            });
        }
    }
}