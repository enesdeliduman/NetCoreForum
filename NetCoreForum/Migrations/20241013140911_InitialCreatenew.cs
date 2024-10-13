using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetCoreForum.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatenew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "PendingUsers");

            migrationBuilder.AlterColumn<string>(
                name: "TemplateName",
                table: "EmailTemplates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "EmailTemplates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "EmailTemplates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ViewedTemplateName",
                table: "EmailTemplates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt", "ViewedTemplateName" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6024), "ForgotPassword", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6025), "Şifremi Unuttum" });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt", "ViewedTemplateName" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6028), "Welcome", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6029), "Hoş Geldiniz" });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt", "ViewedTemplateName" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6031), "ChangePassword", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6032), "Şifre Değişikliği" });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt", "ViewedTemplateName" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6034), "ConfirmAccount", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6034), "Hesap Onayı" });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateID", "Body", "CreatedAt", "Subject", "TemplateName", "UpdatedAt", "ViewedTemplateName" },
                values: new object[,]
                {
                    { 5, "Foruma üye olduğunuz için teşekkürler! Hesabınız yönetici onayını bekliyor. Onaylandıktan sonra giriş yapabilirsiniz.", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6036), "Hesap Onayınızı Bekliyor", "AccountPendingApproval", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6037), "Hesap Beklemede" },
                    { 6, "Tebrikler! Hesabınız başarıyla onaylandı ve artık foruma giriş yapabilirsiniz. Hoş geldiniz!", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6039), "Hesabınız Onaylandı", "AccountApproved", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6039), "Hesap Onaylandı" },
                    { 7, "Üzgünüz, hesabınız onaylanmadı. Daha fazla bilgi almak için lütfen yönetici ile iletişime geçin.", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6041), "Hesabınız Onaylanmadı", "AccountNotApproved", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6042), "Hesap Onaylanmadı" },
                    { 8, "Hesabınız silindi. Eğer bu işlem siz tarafından yapılmadıysa lütfen bizimle iletişime geçin.", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6044), "Hesabınız Silindi", "AccountDeleted", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6044), "Hesap Silindi" },
                    { 9, "Merhaba {username}, \n\nBu size gönderilen {warning_count}. uyarıdır. 5 uyarıya ulaştığınızda hesabınız otomatik olarak silinecektir. Lütfen site kurallarına uyun.", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6046), "Uyarı Aldınız - {warning_count}. Uyarı", "WarningEmail", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6047), "Uyarı Mesajı" },
                    { 10, "Merhaba, \n\nMaksimum uyarı sayısına ulaştığınız için kalıcı olarak hesabınız askıya alınmıştır. Eğer bu işlem hakkında sorularınız varsa, lütfen bizimle iletişime geçin.", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6049), "Hesabınız Silindi", "AccountDeletedDueToWarnings", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6049), "Hesap Silindi" },
                    { 11, "Merhaba Kayıt işleminizi tamamlamak için lütfen aşağıdaki bağlantıya tıklayarak e-posta adresinizi onaylayın:", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6051), "E-posta Onayı Gerekli", "EmailConfirmation", new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6052), "E-posta Onayı" }
                });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 9, 9, 985, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 10, 13, 17, 9, 9, 985, DateTimeKind.Local).AddTicks(6276) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "ViewedTemplateName",
                table: "EmailTemplates");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "PendingUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "TemplateName",
                table: "EmailTemplates",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "EmailTemplates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "EmailTemplates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(235), "Şifremi Unuttum", new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(237), "Hoş Geldiniz", new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(240), "Şifre Değişikliği", new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TemplateName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(242), "Hesap Onayı", new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 57, 51, 766, DateTimeKind.Local).AddTicks(365), new DateTime(2024, 10, 13, 0, 57, 51, 766, DateTimeKind.Local).AddTicks(377) });
        }
    }
}
