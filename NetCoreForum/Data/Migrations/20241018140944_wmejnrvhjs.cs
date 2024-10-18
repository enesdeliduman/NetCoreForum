using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetCoreForum.Data.Migrations
{
    /// <inheritdoc />
    public partial class wmejnrvhjs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserBiography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "EmailConfigurations",
                columns: table => new
                {
                    EmailConfigurationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmtpServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<int>(type: "int", nullable: false),
                    SenderEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseSSL = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfigurations", x => x.EmailConfigurationID);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    EmailTemplateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewedTemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.EmailTemplateID);
                });

            migrationBuilder.CreateTable(
                name: "ErrorMessages",
                columns: table => new
                {
                    ErrorMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorMessageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorMessages", x => x.ErrorMessageID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageSenderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageReceiverID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageIsRead = table.Column<bool>(type: "bit", nullable: false),
                    MessageSentAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    SiteSettingsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaviconPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxWarningCountForAppUser = table.Column<int>(type: "int", nullable: false),
                    RequireAdminApproval = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.SiteSettingsID);
                });

            migrationBuilder.CreateTable(
                name: "TopicTypes",
                columns: table => new
                {
                    TopicTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicTypes", x => x.TopicTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_Logs_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationIsRead = table.Column<bool>(type: "bit", nullable: false),
                    NotificationCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PendingUsers",
                columns: table => new
                {
                    PendingUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingUsers", x => x.PendingUserID);
                    table.ForeignKey(
                        name: "FK_PendingUsers_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedEntityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedEntityId = table.Column<int>(type: "int", nullable: false),
                    ReportAdditionalDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportIsReviewed = table.Column<bool>(type: "bit", nullable: false),
                    ReportCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Warnings",
                columns: table => new
                {
                    WarningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarningTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarningDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarningCreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warnings", x => x.WarningID);
                    table.ForeignKey(
                        name: "FK_Warnings_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicLikeCount = table.Column<int>(type: "int", nullable: false),
                    TopicViewCount = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    TopicTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicID);
                    table.ForeignKey(
                        name: "FK_Topics_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Topics_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Topics_TopicTypes_TopicTypeID",
                        column: x => x.TopicTypeID,
                        principalTable: "TopicTypes",
                        principalColumn: "TopicTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    ReplyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplyLikeCount = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TopicID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.ReplyID);
                    table.ForeignKey(
                        name: "FK_Replies_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Replies_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmailConfigurations",
                columns: new[] { "EmailConfigurationID", "CreatedAt", "Port", "SenderEmail", "SenderName", "SenderPassword", "SmtpServer", "UpdatedAt", "UseSSL" },
                values: new object[] { 1, new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8787), 587, "iletisim@enesdeliduman.com", "İletişimm", "124124262114Ee", "mail.enesdeliduman.com", new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8787), true });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "EmailTemplateID", "Body", "CreatedAt", "Subject", "TemplateName", "UpdatedAt", "ViewedTemplateName" },
                values: new object[,]
                {
                    { 1, "Şifrenizi sıfırlamak için lütfen aşağıdaki bağlantıyı tıklayın: {reset_link}", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8303), "Şifre Sıfırlama Talebi", "ForgotPassword", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8304), "Şifremi Unuttum" },
                    { 2, "Kayıt olduğunuz için teşekkürler! Hesabınıza hoş geldiniz.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8309), "Hoş geldiniz!", "Welcome", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8310), "Hoş Geldiniz" },
                    { 3, "Şifreniz başarıyla değiştirildi. Herhangi bir sorunla karşılaşırsanız, lütfen bizimle iletişime geçin.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8313), "Şifre Değişikliğiniz Başarılı", "ChangePassword", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8313), "Şifre Değişikliği" },
                    { 4, "Hesabınız başarıyla onaylandı. Artık sitemizi kullanabilirsiniz.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8316), "Hesabınız Onaylandı", "ConfirmAccount", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8317), "Hesap Onayı" },
                    { 5, "Foruma üye olduğunuz için teşekkürler! Hesabınız yönetici onayını bekliyor. Onaylandıktan sonra giriş yapabilirsiniz.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8320), "Hesap Onayınızı Bekliyor", "AccountPendingApproval", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8320), "Hesap Beklemede" },
                    { 6, "Tebrikler! Hesabınız başarıyla onaylandı ve artık foruma giriş yapabilirsiniz. Hoş geldiniz!", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8324), "Hesabınız Onaylandı", "AccountApproved", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8324), "Hesap Onaylandı" },
                    { 7, "Üzgünüz, hesabınız onaylanmadı. Daha fazla bilgi almak için lütfen yönetici ile iletişime geçin.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8327), "Hesabınız Onaylanmadı", "AccountNotApproved", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8328), "Hesap Onaylanmadı" },
                    { 8, "Hesabınız silindi. Eğer bu işlem siz tarafından yapılmadıysa lütfen bizimle iletişime geçin.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8331), "Hesabınız Silindi", "AccountDeleted", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8331), "Hesap Silindi" },
                    { 9, "Merhaba {username}, \n\nBu size gönderilen {warning_count}. uyarıdır. 5 uyarıya ulaştığınızda hesabınız otomatik olarak silinecektir. Lütfen site kurallarına uyun.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8334), "Uyarı Aldınız - {warning_count}. Uyarı", "WarningEmail", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8335), "Uyarı Mesajı" },
                    { 10, "Merhaba, \n\nMaksimum uyarı sayısına ulaştığınız için kalıcı olarak hesabınız askıya alınmıştır. Eğer bu işlem hakkında sorularınız varsa, lütfen bizimle iletişime geçin.", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8338), "Hesabınız Silindi", "AccountDeletedDueToWarnings", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8339), "Hesap Silindi" },
                    { 11, "Merhaba, Kayıt işleminizi tamamlamak için lütfen aşağıdaki bağlantıya tıklayarak e-posta adresinizi onaylayın:", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8341), "E-posta Onayı Gerekli", "EmailConfirmation", new DateTime(2024, 10, 18, 14, 9, 43, 144, DateTimeKind.Utc).AddTicks(8342), "E-posta Onayı" }
                });

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

            migrationBuilder.InsertData(
                table: "SiteSettings",
                columns: new[] { "SiteSettingsID", "ContactEmail", "ContactPhone", "CreatedAt", "FaviconPath", "FooterText", "LogoPath", "MaxWarningCountForAppUser", "RequireAdminApproval", "SiteName", "UpdatedAt" },
                values: new object[] { 1, "mail@mail.com", "0555 555 55 55", new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8726), "forum-favicon.png", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "forum-logo.png", 5, false, "NetCoreForum", new DateTime(2024, 10, 18, 17, 9, 43, 144, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_AppUserID",
                table: "Logs",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AppUserID",
                table: "Notifications",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PendingUsers_AppUserID",
                table: "PendingUsers",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_AppUserID",
                table: "Replies",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_TopicID",
                table: "Replies",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_AppUserID",
                table: "Reports",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_AppUserID",
                table: "Topics",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CategoryID",
                table: "Topics",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_TopicTypeID",
                table: "Topics",
                column: "TopicTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Warnings_AppUserID",
                table: "Warnings",
                column: "AppUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EmailConfigurations");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "ErrorMessages");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PendingUsers");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "Warnings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TopicTypes");
        }
    }
}
