using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetCoreForum.Data.Migrations
{
    /// <inheritdoc />
    public partial class naber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorMessages");

            migrationBuilder.CreateTable(
                name: "InfoMessages",
                columns: table => new
                {
                    InfoMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfoMessageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoMessageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoMessages", x => x.InfoMessageID);
                });

            migrationBuilder.UpdateData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 32, 27, 661, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 10, 20, 16, 32, 27, 661, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8284), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8287), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8293), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8295), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8297), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8300), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8302), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8304), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8307), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8309), new DateTime(2024, 10, 20, 13, 32, 27, 661, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.InsertData(
                table: "InfoMessages",
                columns: new[] { "InfoMessageID", "InfoMessageDescription", "InfoMessageName" },
                values: new object[,]
                {
                    { 1, "Aradığınız kayıt bulunamadı.", "NotFound" },
                    { 2, "Bu işlemi gerçekleştirmek için yetkiniz yok.", "UnauthorizedAccess" },
                    { 3, "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.", "ServerError" },
                    { 4, "Formda hatalar var. Lütfen kontrol edin.", "ValidationError" },
                    { 5, "Giriş bilgileri hatalı. Lütfen tekrar deneyin.", "InvalidLogin" },
                    { 6, "Hesabınız kilitlenmiştir. Lütfen destek ile iletişime geçin.", "AccountLocked" },
                    { 7, "Parola en az 6 karakter olmalıdır ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "PasswordTooWeak" },
                    { 8, "Bu e-posta adresi zaten kullanılıyor.", "EmailAlreadyUsed" },
                    { 9, "Lütfen e-posta adresinizi onaylayınız. Mail kutunuzu kontrol ediniz.", "UserNotConfirmed" },
                    { 10, "E-posta adresi veya parola hatalı.", "InvalidEmailOrPassword" },
                    { 11, "Hesabınız henüz onaylanmamıştır ve bekleme listesinde bulunmaktadır. Lütfen biraz daha bekleyin.", "AccountPendingApproval" },
                    { 12, "Bu kayıt zaten mevcut.", "DuplicateEntry" },
                    { 13, "Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "RegistrationFailed" },
                    { 14, "Şifre değişikliği sırasında bir hata oluştu.", "PasswordChangeFailed" },
                    { 15, "Eski şifreniz hatalı.", "OldPasswordIncorrect" },
                    { 16, "E-posta gönderme işlemi sırasında bir hata oluştu.", "EmailSendFailed" },
                    { 17, "Bu e-posta adresine ait bir hesap bulunamadı.", "EmailNotFound" },
                    { 18, "Bu alanın doldurulması zorunludur.", "RequiredField" },
                    { 19, "Geçersiz format. Lütfen kontrol edin.", "InvalidFormat" },
                    { 20, "İşlem gerçekleştirilemedi. Lütfen daha sonra tekrar deneyin.", "OperationFailed" },
                    { 21, "Geçersiz istek. Lütfen kontrol edin.", "InvalidRequest" },
                    { 22, "Bu eylem izin verilenler arasında değil.", "ActionNotAllowed" },
                    { 23, "Dosya yükleme işlemi sırasında bir hata oluştu.", "FileUploadFailed" },
                    { 24, "Bu dosya türü desteklenmiyor.", "FileTypeNotAllowed" },
                    { 25, "Dosya boyutu limitini aşıyor.", "FileSizeExceeded" },
                    { 26, "Email adresiniz başarıyla onaylandı.", "EmailConfirmed" }
                });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 32, 27, 661, DateTimeKind.Local).AddTicks(8551), new DateTime(2024, 10, 20, 16, 32, 27, 661, DateTimeKind.Local).AddTicks(8562) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoMessages");

            migrationBuilder.CreateTable(
                name: "ErrorMessages",
                columns: table => new
                {
                    ErrorMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorMessageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorMessages", x => x.ErrorMessageID);
                });

            migrationBuilder.UpdateData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8303), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8309), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8313), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8316), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8324), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8327), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8331), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8334), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8338), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8341), new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.InsertData(
                table: "ErrorMessages",
                columns: new[] { "ErrorMessageID", "ErrorMessageDescription", "ErrorMessageName" },
                values: new object[,]
                {
                    { 1, "Aradığınız kayıt bulunamadı.", "NotFound" },
                    { 2, "Bu işlemi gerçekleştirmek için yetkiniz yok.", "UnauthorizedAccess" },
                    { 3, "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.", "ServerError" },
                    { 4, "Formda hatalar var. Lütfen kontrol edin.", "ValidationError" },
                    { 5, "Giriş bilgileri hatalı. Lütfen tekrar deneyin.", "InvalidLogin" },
                    { 6, "Hesabınız kilitlenmiştir. Lütfen destek ile iletişime geçin.", "AccountLocked" },
                    { 7, "Parola en az 6 karakter olmalıdır ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "PasswordTooWeak" },
                    { 8, "Bu e-posta adresi zaten kullanılıyor.", "EmailAlreadyUsed" },
                    { 9, "Lütfen e-posta adresinizi onaylayınız. Mail kutunuzu kontrol ediniz.", "UserNotConfirmed" },
                    { 10, "E-posta adresi veya parola hatalı.", "InvalidEmailOrPassword" },
                    { 11, "Hesabınız henüz onaylanmamıştır ve bekleme listesinde bulunmaktadır. Lütfen biraz daha bekleyin.", "AccountPendingApproval" },
                    { 12, "Bu kayıt zaten mevcut.", "DuplicateEntry" },
                    { 13, "Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "RegistrationFailed" },
                    { 14, "Şifre değişikliği sırasında bir hata oluştu.", "PasswordChangeFailed" },
                    { 15, "Eski şifreniz hatalı.", "OldPasswordIncorrect" },
                    { 16, "E-posta gönderme işlemi sırasında bir hata oluştu.", "EmailSendFailed" },
                    { 17, "Bu e-posta adresine ait bir hesap bulunamadı.", "EmailNotFound" },
                    { 18, "Bu alanın doldurulması zorunludur.", "RequiredField" },
                    { 19, "Geçersiz format. Lütfen kontrol edin.", "InvalidFormat" },
                    { 20, "İşlem gerçekleştirilemedi. Lütfen daha sonra tekrar deneyin.", "OperationFailed" },
                    { 21, "Geçersiz istek. Lütfen kontrol edin.", "InvalidRequest" },
                    { 22, "Bu eylem izin verilenler arasında değil.", "ActionNotAllowed" },
                    { 23, "Dosya yükleme işlemi sırasında bir hata oluştu.", "FileUploadFailed" },
                    { 24, "Bu dosya türü desteklenmiyor.", "FileTypeNotAllowed" },
                    { 25, "Dosya boyutu limitini aşıyor.", "FileSizeExceeded" }
                });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8726), new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8740) });
        }
    }
}
