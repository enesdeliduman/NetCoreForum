using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreForum.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateneww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmailConfigurations",
                columns: new[] { "EmailConfigurationID", "CreatedAt", "Port", "SenderEmail", "SenderName", "SenderPassword", "SmtpServer", "UpdatedAt", "UseSSL" },
                values: new object[] { 1, new DateTime(2024, 10, 13, 17, 17, 36, 849, DateTimeKind.Local).AddTicks(6496), 587, "iletisim@enesdeliduman.com", "İletişimm", "124124262114Ee", "mail.enesdeliduman.com", new DateTime(2024, 10, 13, 17, 17, 36, 849, DateTimeKind.Local).AddTicks(6497), false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6024), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6028), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6031), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6034), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6039), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6046), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6049), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6051), new DateTime(2024, 10, 13, 14, 9, 9, 985, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 9, 9, 985, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 10, 13, 17, 9, 9, 985, DateTimeKind.Local).AddTicks(6276) });
        }
    }
}
