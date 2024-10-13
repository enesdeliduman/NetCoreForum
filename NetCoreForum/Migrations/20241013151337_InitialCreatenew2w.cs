using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetCoreForum.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatenew2w : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountLockedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "ActionNotAllowedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "DuplicateEntryMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "EmailAlreadyUsedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "EmailNotFoundMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "EmailSendFailedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "FileSizeExceededMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "FileTypeNotAllowedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "FileUploadFailedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "InvalidEmailOrPasswordMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "InvalidFormatMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "InvalidLoginMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "InvalidRequestMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "NotFoundMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "OldPasswordIncorrectMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "OperationFailedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "PasswordChangeFailedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "PasswordTooWeakMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "RegistrationFailedMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "RequiredFieldMessage",
                table: "ErrorMessages");

            migrationBuilder.DropColumn(
                name: "ServerErrorMessage",
                table: "ErrorMessages");

            migrationBuilder.RenameColumn(
                name: "ValidationErrorMessage",
                table: "ErrorMessages",
                newName: "ErrorMessageName");

            migrationBuilder.RenameColumn(
                name: "UserNotConfirmedMessage",
                table: "ErrorMessages",
                newName: "ErrorMessageDescription");

            migrationBuilder.RenameColumn(
                name: "UnauthorizedAccessMessage",
                table: "ErrorMessages",
                newName: "ErrorMessageContent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ErrorMessages",
                newName: "ErrorMessageID");

            migrationBuilder.UpdateData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "UseSSL" },
                values: new object[] { new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9115), true });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8833), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8836), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8840), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8843), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8848), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8851), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8854), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8856), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8859), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8861), new DateTime(2024, 10, 13, 15, 13, 35, 696, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.InsertData(
                table: "ErrorMessages",
                columns: new[] { "ErrorMessageID", "ErrorMessageContent", "ErrorMessageDescription", "ErrorMessageName" },
                values: new object[,]
                {
                    { 1, "Aradığınız kayıt bulunamadı.", "Kullanıcı tarafından istenen kaynak sistemde mevcut değil.", "NotFound" },
                    { 2, "Bu işlemi gerçekleştirmek için yetkiniz yok.", "Kullanıcının bu işlemi yapma yetkisi yok.", "UnauthorizedAccess" },
                    { 3, "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.", "Beklenmeyen bir sunucu hatası meydana geldi.", "ServerError" },
                    { 4, "Formda hatalar var. Lütfen kontrol edin.", "Kullanıcı tarafından doldurulan formda geçersiz bilgiler var.", "ValidationError" },
                    { 5, "Giriş bilgileri hatalı. Lütfen tekrar deneyin.", "Kullanıcı adı veya şifre hatalı.", "InvalidLogin" },
                    { 6, "Hesabınız kilitlenmiştir. Lütfen destek ile iletişime geçin.", "Hesap güvenlik nedenleriyle kilitlenmiştir.", "AccountLocked" },
                    { 7, "Parola en az 6 karakter olmalıdır ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "Kullanıcının belirlediği parola güvenlik standartlarına uymuyor.", "PasswordTooWeak" },
                    { 8, "Bu e-posta adresi zaten kullanılıyor.", "Başka bir hesapta aynı e-posta adresi kullanılmış.", "EmailAlreadyUsed" },
                    { 9, "Hesabınız henüz onaylanmamıştır. Lütfen e-posta adresinizi kontrol edin.", "Kullanıcı, e-posta doğrulama adımını tamamlamıştır.", "UserNotConfirmed" },
                    { 10, "E-posta adresi veya parola hatalı.", "Kullanıcı giriş bilgileri hatalı.", "InvalidEmailOrPassword" },
                    { 11, "Hesabınız henüz onaylanmamıştır ve bekleme listesinde bulunmaktadır. Lütfen biraz daha bekleyin.", "Kullanıcının hesabı henüz onaylanmamıştır.", "AccountPendingApproval" },
                    { 12, "Bu kayıt zaten mevcut.", "Kullanıcının girmeye çalıştığı kayıt sistemde zaten mevcut.", "DuplicateEntry" },
                    { 13, "Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Kullanıcı kaydı sırasında beklenmeyen bir hata meydana geldi.", "RegistrationFailed" },
                    { 14, "Şifre değişikliği sırasında bir hata oluştu.", "Şifre değişikliği işlemi başarısız oldu.", "PasswordChangeFailed" },
                    { 15, "Eski şifreniz hatalı.", "Kullanıcının girdiği eski şifre sistemdeki ile eşleşmiyor.", "OldPasswordIncorrect" },
                    { 16, "E-posta gönderme işlemi sırasında bir hata oluştu.", "E-posta gönderilirken bir hata meydana geldi.", "EmailSendFailed" },
                    { 17, "Bu e-posta adresine ait bir hesap bulunamadı.", "Kullanıcının belirttiği e-posta adresi ile ilişkilendirilmiş bir hesap bulunamıyor.", "EmailNotFound" },
                    { 18, "Bu alanın doldurulması zorunludur.", "Kullanıcı tarafından doldurulması gereken bir alan boş bırakılmış.", "RequiredField" },
                    { 19, "Geçersiz format. Lütfen kontrol edin.", "Kullanıcının girdiği veri formatı beklenen formatla uyuşmuyor.", "InvalidFormat" },
                    { 20, "İşlem gerçekleştirilemedi. Lütfen daha sonra tekrar deneyin.", "Kullanıcının gerçekleştirmeye çalıştığı işlem başarıyla tamamlanamadı.", "OperationFailed" },
                    { 21, "Geçersiz istek. Lütfen kontrol edin.", "Kullanıcı tarafından gönderilen istek geçersiz.", "InvalidRequest" },
                    { 22, "Bu eylem izin verilenler arasında değil.", "Kullanıcının gerçekleştirmeye çalıştığı eylem sistemde izin verilmemiş.", "ActionNotAllowed" },
                    { 23, "Dosya yükleme işlemi sırasında bir hata oluştu.", "Kullanıcının yüklemeye çalıştığı dosya başarısız oldu.", "FileUploadFailed" },
                    { 24, "Bu dosya türü desteklenmiyor.", "Kullanıcının yüklemeye çalıştığı dosya türü sistemde desteklenmiyor.", "FileTypeNotAllowed" },
                    { 25, "Dosya boyutu limitini aşıyor.", "Kullanıcının yüklemeye çalıştığı dosyanın boyutu belirlenen limitin üzerinde.", "FileSizeExceeded" }
                });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9080) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 25);

            migrationBuilder.RenameColumn(
                name: "ErrorMessageName",
                table: "ErrorMessages",
                newName: "ValidationErrorMessage");

            migrationBuilder.RenameColumn(
                name: "ErrorMessageDescription",
                table: "ErrorMessages",
                newName: "UserNotConfirmedMessage");

            migrationBuilder.RenameColumn(
                name: "ErrorMessageContent",
                table: "ErrorMessages",
                newName: "UnauthorizedAccessMessage");

            migrationBuilder.RenameColumn(
                name: "ErrorMessageID",
                table: "ErrorMessages",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "AccountLockedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActionNotAllowedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DuplicateEntryMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAlreadyUsedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailNotFoundMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailSendFailedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileSizeExceededMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileTypeNotAllowedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileUploadFailedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvalidEmailOrPasswordMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvalidFormatMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvalidLoginMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvalidRequestMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NotFoundMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OldPasswordIncorrectMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationFailedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordChangeFailedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordTooWeakMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationFailedMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredFieldMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServerErrorMessage",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "UseSSL" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 17, 36, 849, DateTimeKind.Local).AddTicks(6496), new DateTime(2024, 10, 13, 17, 17, 36, 849, DateTimeKind.Local).AddTicks(6497), false });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6254), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6261), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6263), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6266), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6269), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6271), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6274), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6276), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6279), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6281), new DateTime(2024, 10, 13, 14, 17, 36, 849, DateTimeKind.Utc).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 17, 36, 849, DateTimeKind.Local).AddTicks(6456), new DateTime(2024, 10, 13, 17, 17, 36, 849, DateTimeKind.Local).AddTicks(6470) });
        }
    }
}
