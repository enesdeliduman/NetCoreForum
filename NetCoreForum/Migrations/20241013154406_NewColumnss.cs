using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreForum.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ErrorMessageContent",
                table: "ErrorMessages");

            migrationBuilder.UpdateData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 18, 44, 5, 913, DateTimeKind.Local).AddTicks(8212), new DateTime(2024, 10, 13, 18, 44, 5, 913, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7970), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7974), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7977), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7979), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7984), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7992), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7995), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7997), new DateTime(2024, 10, 13, 15, 44, 5, 913, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 1,
                column: "ErrorMessageDescription",
                value: "Aradığınız kayıt bulunamadı.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 2,
                column: "ErrorMessageDescription",
                value: "Bu işlemi gerçekleştirmek için yetkiniz yok.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 3,
                column: "ErrorMessageDescription",
                value: "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 4,
                column: "ErrorMessageDescription",
                value: "Formda hatalar var. Lütfen kontrol edin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 5,
                column: "ErrorMessageDescription",
                value: "Giriş bilgileri hatalı. Lütfen tekrar deneyin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 6,
                column: "ErrorMessageDescription",
                value: "Hesabınız kilitlenmiştir. Lütfen destek ile iletişime geçin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 7,
                column: "ErrorMessageDescription",
                value: "Parola en az 6 karakter olmalıdır ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 8,
                column: "ErrorMessageDescription",
                value: "Bu e-posta adresi zaten kullanılıyor.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 9,
                column: "ErrorMessageDescription",
                value: "Hesabınız henüz onaylanmamıştır. Lütfen e-posta adresinizi kontrol edin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 10,
                column: "ErrorMessageDescription",
                value: "E-posta adresi veya parola hatalı.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 11,
                column: "ErrorMessageDescription",
                value: "Hesabınız henüz onaylanmamıştır ve bekleme listesinde bulunmaktadır. Lütfen biraz daha bekleyin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 12,
                column: "ErrorMessageDescription",
                value: "Bu kayıt zaten mevcut.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 13,
                column: "ErrorMessageDescription",
                value: "Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 14,
                column: "ErrorMessageDescription",
                value: "Şifre değişikliği sırasında bir hata oluştu.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 15,
                column: "ErrorMessageDescription",
                value: "Eski şifreniz hatalı.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 16,
                column: "ErrorMessageDescription",
                value: "E-posta gönderme işlemi sırasında bir hata oluştu.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 17,
                column: "ErrorMessageDescription",
                value: "Bu e-posta adresine ait bir hesap bulunamadı.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 18,
                column: "ErrorMessageDescription",
                value: "Bu alanın doldurulması zorunludur.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 19,
                column: "ErrorMessageDescription",
                value: "Geçersiz format. Lütfen kontrol edin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 20,
                column: "ErrorMessageDescription",
                value: "İşlem gerçekleştirilemedi. Lütfen daha sonra tekrar deneyin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 21,
                column: "ErrorMessageDescription",
                value: "Geçersiz istek. Lütfen kontrol edin.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 22,
                column: "ErrorMessageDescription",
                value: "Bu eylem izin verilenler arasında değil.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 23,
                column: "ErrorMessageDescription",
                value: "Dosya yükleme işlemi sırasında bir hata oluştu.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 24,
                column: "ErrorMessageDescription",
                value: "Bu dosya türü desteklenmiyor.");

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 25,
                column: "ErrorMessageDescription",
                value: "Dosya boyutu limitini aşıyor.");

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 18, 44, 5, 913, DateTimeKind.Local).AddTicks(8175), new DateTime(2024, 10, 13, 18, 44, 5, 913, DateTimeKind.Local).AddTicks(8189) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ErrorMessageContent",
                table: "ErrorMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9115) });

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

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 1,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Aradığınız kayıt bulunamadı.", "Kullanıcı tarafından istenen kaynak sistemde mevcut değil." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 2,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bu işlemi gerçekleştirmek için yetkiniz yok.", "Kullanıcının bu işlemi yapma yetkisi yok." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 3,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.", "Beklenmeyen bir sunucu hatası meydana geldi." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 4,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Formda hatalar var. Lütfen kontrol edin.", "Kullanıcı tarafından doldurulan formda geçersiz bilgiler var." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 5,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Giriş bilgileri hatalı. Lütfen tekrar deneyin.", "Kullanıcı adı veya şifre hatalı." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 6,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Hesabınız kilitlenmiştir. Lütfen destek ile iletişime geçin.", "Hesap güvenlik nedenleriyle kilitlenmiştir." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 7,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Parola en az 6 karakter olmalıdır ve en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.", "Kullanıcının belirlediği parola güvenlik standartlarına uymuyor." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 8,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bu e-posta adresi zaten kullanılıyor.", "Başka bir hesapta aynı e-posta adresi kullanılmış." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 9,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Hesabınız henüz onaylanmamıştır. Lütfen e-posta adresinizi kontrol edin.", "Kullanıcı, e-posta doğrulama adımını tamamlamıştır." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 10,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "E-posta adresi veya parola hatalı.", "Kullanıcı giriş bilgileri hatalı." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 11,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Hesabınız henüz onaylanmamıştır ve bekleme listesinde bulunmaktadır. Lütfen biraz daha bekleyin.", "Kullanıcının hesabı henüz onaylanmamıştır." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 12,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bu kayıt zaten mevcut.", "Kullanıcının girmeye çalıştığı kayıt sistemde zaten mevcut." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 13,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Kullanıcı kaydı sırasında beklenmeyen bir hata meydana geldi." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 14,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Şifre değişikliği sırasında bir hata oluştu.", "Şifre değişikliği işlemi başarısız oldu." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 15,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Eski şifreniz hatalı.", "Kullanıcının girdiği eski şifre sistemdeki ile eşleşmiyor." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 16,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "E-posta gönderme işlemi sırasında bir hata oluştu.", "E-posta gönderilirken bir hata meydana geldi." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 17,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bu e-posta adresine ait bir hesap bulunamadı.", "Kullanıcının belirttiği e-posta adresi ile ilişkilendirilmiş bir hesap bulunamıyor." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 18,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bu alanın doldurulması zorunludur.", "Kullanıcı tarafından doldurulması gereken bir alan boş bırakılmış." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 19,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Geçersiz format. Lütfen kontrol edin.", "Kullanıcının girdiği veri formatı beklenen formatla uyuşmuyor." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 20,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "İşlem gerçekleştirilemedi. Lütfen daha sonra tekrar deneyin.", "Kullanıcının gerçekleştirmeye çalıştığı işlem başarıyla tamamlanamadı." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 21,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Geçersiz istek. Lütfen kontrol edin.", "Kullanıcı tarafından gönderilen istek geçersiz." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 22,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bu eylem izin verilenler arasında değil.", "Kullanıcının gerçekleştirmeye çalıştığı eylem sistemde izin verilmemiş." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 23,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Dosya yükleme işlemi sırasında bir hata oluştu.", "Kullanıcının yüklemeye çalıştığı dosya başarısız oldu." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 24,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Bu dosya türü desteklenmiyor.", "Kullanıcının yüklemeye çalıştığı dosya türü sistemde desteklenmiyor." });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 25,
                columns: new[] { "ErrorMessageContent", "ErrorMessageDescription" },
                values: new object[] { "Dosya boyutu limitini aşıyor.", "Kullanıcının yüklemeye çalıştığı dosyanın boyutu belirlenen limitin üzerinde." });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 10, 13, 18, 13, 35, 696, DateTimeKind.Local).AddTicks(9080) });
        }
    }
}
