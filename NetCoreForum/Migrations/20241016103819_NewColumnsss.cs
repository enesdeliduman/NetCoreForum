using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreForum.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmailConfigurations",
                keyColumn: "EmailConfigurationID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 38, 18, 156, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 10, 16, 13, 38, 18, 156, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5040), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5044), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5047), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5049), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5051), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5054), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5056), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5102), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5104), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5107), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5109), new DateTime(2024, 10, 16, 10, 38, 18, 156, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "ErrorMessages",
                keyColumn: "ErrorMessageID",
                keyValue: 9,
                column: "ErrorMessageDescription",
                value: "Lütfen e-posta adresinizi onaylayınız. Mail kutunuzu kontrol ediniz.");

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 38, 18, 156, DateTimeKind.Local).AddTicks(5267), new DateTime(2024, 10, 16, 13, 38, 18, 156, DateTimeKind.Local).AddTicks(5278) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Topics");

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
                keyValue: 9,
                column: "ErrorMessageDescription",
                value: "Hesabınız henüz onaylanmamıştır. Lütfen e-posta adresinizi kontrol edin.");

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 18, 44, 5, 913, DateTimeKind.Local).AddTicks(8175), new DateTime(2024, 10, 13, 18, 44, 5, 913, DateTimeKind.Local).AddTicks(8189) });
        }
    }
}
