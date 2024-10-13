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
        public DbSet<ErrorMessage> ErrorMessages { get; set; }
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
                    Body = "Şifrenizi sıfırlamak için lütfen aşağıdaki bağlantıyı tıklayın: {reset_link}",
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
                    Body = $"Merhaba, \n\nMaksimum uyarı sayısına ulaştığınız için kalıcı olarak hesabınız askıya alınmıştır. Eğer bu işlem hakkında sorularınız varsa, lütfen bizimle iletişime geçin.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new EmailTemplate
                {
                    EmailTemplateID = 11,
                    TemplateName = "EmailConfirmation",
                    ViewedTemplateName = "E-posta Onayı",
                    Subject = "E-posta Onayı Gerekli",
                    Body = "Merhaba Kayıt işleminizi tamamlamak için lütfen aşağıdaki bağlantıya tıklayarak e-posta adresinizi onaylayın:",
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
                    FooterText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries",
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

            modelBuilder.Entity<ErrorMessage>().HasData(new[]
            {
                new ErrorMessage
                {
                    ErrorMessageID = 1, ErrorMessageName = "NotFound",
                    ErrorMessageDescription = "Aradığınız kayıt bulunamadı.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 2, ErrorMessageName = "UnauthorizedAccess",
                    ErrorMessageDescription = "Bu işlemi gerçekleştirmek için yetkiniz yok.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 3, ErrorMessageName = "ServerError",
                    ErrorMessageDescription = "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 4, ErrorMessageName = "ValidationError",
                    ErrorMessageDescription = "Formda hatalar var. Lütfen kontrol edin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 5, ErrorMessageName = "InvalidLogin",
                    ErrorMessageDescription = "Giriş bilgileri hatalı. Lütfen tekrar deneyin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 6, ErrorMessageName = "AccountLocked",
                    ErrorMessageDescription = "Hesabınız kilitlenmiştir. Lütfen destek ile iletişime geçin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 7, ErrorMessageName = "PasswordTooWeak",
                    ErrorMessageDescription = "Parola en az 6 karakter olmalıdır ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 8, ErrorMessageName = "EmailAlreadyUsed",
                    ErrorMessageDescription = "Bu e-posta adresi zaten kullanılıyor.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 9, ErrorMessageName = "UserNotConfirmed",
                    ErrorMessageDescription = "Lütfen e-posta adresinizi onaylayınız. Mail kutunuzu kontrol ediniz.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 10, ErrorMessageName = "InvalidEmailOrPassword",
                    ErrorMessageDescription = "E-posta adresi veya parola hatalı.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 11, ErrorMessageName = "AccountPendingApproval",
                    ErrorMessageDescription = "Hesabınız henüz onaylanmamıştır ve bekleme listesinde bulunmaktadır. Lütfen biraz daha bekleyin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 12, ErrorMessageName = "DuplicateEntry",
                    ErrorMessageDescription = "Bu kayıt zaten mevcut.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 13, ErrorMessageName = "RegistrationFailed",
                    ErrorMessageDescription = "Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 14, ErrorMessageName = "PasswordChangeFailed",
                    ErrorMessageDescription = "Şifre değişikliği sırasında bir hata oluştu.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 15, ErrorMessageName = "OldPasswordIncorrect",
                    ErrorMessageDescription = "Eski şifreniz hatalı.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 16, ErrorMessageName = "EmailSendFailed",
                    ErrorMessageDescription = "E-posta gönderme işlemi sırasında bir hata oluştu.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 17, ErrorMessageName = "EmailNotFound",
                    ErrorMessageDescription = "Bu e-posta adresine ait bir hesap bulunamadı.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 18, ErrorMessageName = "RequiredField",
                    ErrorMessageDescription = "Bu alanın doldurulması zorunludur.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 19, ErrorMessageName = "InvalidFormat",
                    ErrorMessageDescription = "Geçersiz format. Lütfen kontrol edin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 20, ErrorMessageName = "OperationFailed",
                    ErrorMessageDescription = "İşlem gerçekleştirilemedi. Lütfen daha sonra tekrar deneyin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 21, ErrorMessageName = "InvalidRequest",
                    ErrorMessageDescription = "Geçersiz istek. Lütfen kontrol edin.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 22, ErrorMessageName = "ActionNotAllowed",
                    ErrorMessageDescription = "Bu eylem izin verilenler arasında değil.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 23, ErrorMessageName = "FileUploadFailed",
                    ErrorMessageDescription = "Dosya yükleme işlemi sırasında bir hata oluştu.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 24, ErrorMessageName = "FileTypeNotAllowed",
                    ErrorMessageDescription = "Bu dosya türü desteklenmiyor.",
                },

                new ErrorMessage
                {
                    ErrorMessageID = 25, ErrorMessageName = "FileSizeExceeded",
                    ErrorMessageDescription = "Dosya boyutu limitini aşıyor.",
                }
            });
        }
    }
}
