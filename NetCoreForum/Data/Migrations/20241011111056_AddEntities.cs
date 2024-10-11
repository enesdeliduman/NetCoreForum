using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreForum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxWarningCountForAppUser",
                table: "SiteSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "RequireAdminApproval",
                table: "SiteSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_Logs_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PendingUsers",
                columns: table => new
                {
                    PendingUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingUsers", x => x.PendingUserID);
                    table.ForeignKey(
                        name: "FK_PendingUsers_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warnings",
                columns: table => new
                {
                    WarningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarningTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarningDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarningCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warnings", x => x.WarningID);
                    table.ForeignKey(
                        name: "FK_Warnings_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logs_AppUserID",
                table: "Logs",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PendingUsers_AppUserID",
                table: "PendingUsers",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Warnings_AppUserID",
                table: "Warnings",
                column: "AppUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "PendingUsers");

            migrationBuilder.DropTable(
                name: "Warnings");

            migrationBuilder.DropColumn(
                name: "MaxWarningCountForAppUser",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "RequireAdminApproval",
                table: "SiteSettings");
        }
    }
}
