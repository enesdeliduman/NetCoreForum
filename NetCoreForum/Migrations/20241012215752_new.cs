using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreForum.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(235), new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(237), new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(242), new DateTime(2024, 10, 12, 21, 57, 51, 766, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.InsertData(
                table: "SiteSettings",
                columns: new[] { "SiteSettingsID", "ContactEmail", "ContactPhone", "CreatedAt", "FaviconPath", "FooterText", "LogoPath", "MaxWarningCountForAppUser", "RequireAdminApproval", "SiteName", "UpdatedAt" },
                values: new object[] { 1, "mail@mail.com", "0555 555 55 55", new DateTime(2024, 10, 13, 0, 57, 51, 766, DateTimeKind.Local).AddTicks(365), "forum-favicon.png", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries", "forum-logo.png", 5, false, "NetCoreForum", new DateTime(2024, 10, 13, 0, 57, 51, 766, DateTimeKind.Local).AddTicks(377) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SiteSettings",
                keyColumn: "SiteSettingsID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6606), new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6609), new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6612), new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6615), new DateTime(2024, 10, 12, 21, 49, 55, 405, DateTimeKind.Utc).AddTicks(6615) });
        }
    }
}
