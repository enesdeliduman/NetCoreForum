using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreForum.Data.Migrations
{
    /// <inheritdoc />
    public partial class @fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SiteSettingID",
                table: "SiteSettings",
                newName: "SiteSettingsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SiteSettingsID",
                table: "SiteSettings",
                newName: "SiteSettingID");
        }
    }
}
