using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgressLevel = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgeRestrictions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeRestrictions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUsernameChangedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommercialPackages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommercialPackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "BanHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnbanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BannedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BannedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BanHistories_AspNetUsers_BannedByUserId",
                        column: x => x.BannedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BanHistories_AspNetUsers_BannedUserId",
                        column: x => x.BannedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AchievementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements", x => new { x.UserId, x.AchievementId });
                    table.ForeignKey(
                        name: "FK_UserAchievements_Achievements_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "Achievements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievements_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFollows",
                columns: table => new
                {
                    FollowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FolloweeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollows", x => new { x.FollowerId, x.FolloweeId });
                    table.ForeignKey(
                        name: "FK_UserFollows_AspNetUsers_FolloweeId",
                        column: x => x.FolloweeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFollows_AspNetUsers_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    YoutubeChannelLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastPingAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserProfiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Wallets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageProof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RejectReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandledAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WithdrawRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstallInstruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowDonation = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Visibility = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CensorStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    NumberOfDownloads = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CensoredAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AverageSession = table.Column<double>(type: "float", nullable: false),
                    AgeRestrictionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeveloperId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_AgeRestrictions_AgeRestrictionId",
                        column: x => x.AgeRestrictionId,
                        principalTable: "AgeRestrictions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_AspNetUsers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommercialRegistrations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommercialPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommercialRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommercialRegistrations_CommercialPackages_CommercialPackageId",
                        column: x => x.CommercialPackageId,
                        principalTable: "CommercialPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommercialRegistrations_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DownloadSlots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DownloadAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownloadSlots_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DownloadSlots_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameCensorLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CensoredAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CensorReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CensorStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModeratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCensorLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameCensorLogs_AspNetUsers_ModeratorId",
                        column: x => x.ModeratorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameCensorLogs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameImages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameLanguages",
                columns: table => new
                {
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLanguages", x => new { x.GameId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_GameLanguages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(51)", maxLength: 51, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatforms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GamePriceLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePriceLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePriceLogs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameRecommendations",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameRecommendations", x => new { x.GameId, x.UserId });
                    table.ForeignKey(
                        name: "FK_GameRecommendations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameRecommendations_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameTags",
                columns: table => new
                {
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTags", x => new { x.GameId, x.TagId });
                    table.ForeignKey(
                        name: "FK_GameTags_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchasedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_Libraries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Libraries_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommercialPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommercialRegistrationStartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CommercialRegistrationEndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_CommercialPackages_CommercialPackageId",
                        column: x => x.CommercialPackageId,
                        principalTable: "CommercialPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CensoredAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => new { x.GameId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Wishlists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishlists_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderCode = table.Column<long>(type: "bigint", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_PurchaseUserId",
                        column: x => x.PurchaseUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostReactions",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReactions", x => new { x.PostId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PostReactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportingUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_ReportingUserId",
                        column: x => x.ReportingUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_PostComments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "PostComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_ReportTypes_ReportReasonId",
                        column: x => x.ReportReasonId,
                        principalTable: "ReportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "Image", "IsDeleted", "Name", "ProgressLevel", "Type" },
                values: new object[,]
                {
                    { new Guid("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"), "https://indiegamezone.blob.core.windows.net/indiegamezone/10likes.png", false, "Like 10 Posts", 10.0, "Like" },
                    { new Guid("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), "https://indiegamezone.blob.core.windows.net/indiegamezone/50comments.png", false, "Comment 50 Times", 50.0, "Comment" },
                    { new Guid("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/50posts.png", false, "Make 50 Posts", 50.0, "Post" },
                    { new Guid("5291fbd1-9926-4904-92bc-7f36c738c189"), "https://indiegamezone.blob.core.windows.net/indiegamezone/10posts.png", false, "Make 10 Posts", 10.0, "Post" },
                    { new Guid("56e5cd8d-2d46-45dc-9006-f71920beea40"), "https://indiegamezone.blob.core.windows.net/indiegamezone/10games.png", false, "Buy 10 Games", 10.0, "GamePurchase" },
                    { new Guid("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/50dev.png", false, "Follow 50 Developers", 50.0, "Follow" },
                    { new Guid("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"), "https://indiegamezone.blob.core.windows.net/indiegamezone/firstlike.png", false, "Like first Post", 1.0, "Like" },
                    { new Guid("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/50games.png", false, "Buy 50 Games", 50.0, "GamePurchase" },
                    { new Guid("b0ea7c96-6d5c-4199-9029-7f04e7502f66"), "https://indiegamezone.blob.core.windows.net/indiegamezone/firstposts.png", false, "Make first Post", 1.0, "Post" },
                    { new Guid("b186aeb1-033f-4937-a24c-d11b1989e7e2"), "https://indiegamezone.blob.core.windows.net/indiegamezone/10dev.png", false, "Follow 10 Developers", 10.0, "Follow" },
                    { new Guid("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), "https://indiegamezone.blob.core.windows.net/indiegamezone/5dev.png", false, "Follow 5 Developers", 5.0, "Follow" },
                    { new Guid("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"), "https://indiegamezone.blob.core.windows.net/indiegamezone/50likes.png", false, "Like 50 Posts", 50.0, "Like" },
                    { new Guid("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/10comments.png", false, "Comment 10 Times", 10.0, "Comment" },
                    { new Guid("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/firstcomment.png", false, "Comment first time", 1.0, "Comment" },
                    { new Guid("fef0c70d-cf7b-4c90-9865-383e660fda8a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/firstgame.png", false, "First Purchase", 1.0, "GamePurchase" }
                });

            migrationBuilder.InsertData(
                table: "AgeRestrictions",
                columns: new[] { "Id", "Code", "Description", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("32d6d768-d670-4ef5-acaa-fcfe4c8167d3"), "PEGI 12", "May contain violence of a more graphic nature towards fantasy characters, or mild bad language.", false },
                    { new Guid("3df25298-5f31-4639-a3a0-425ae4db72ca"), "PEGI 16", "More realistic violence, sexual activity, use of tobacco or alcohol, and stronger language.", false },
                    { new Guid("92ca7f1e-94c3-4c48-a468-61d3bab8f0b9"), "PEGI 18", "Depictions of gross violence, sexual violence, or content that glamorizes illegal drug use.", false },
                    { new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), "PEGI 7", "May contain some frightening scenes or sounds.", false },
                    { new Guid("c91901a1-1b27-4e42-9b6f-869c920b1b1c"), "PEGI 3", "Suitable for all age groups. No sounds or pictures likely to frighten young children.", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("51999f00-0f63-4236-8c81-94c43fcf7586"), null, "Player", "PLAYER" },
                    { new Guid("6f7b3f0c-3f54-4fb8-a215-33cd496c3be7"), null, "Admin", "ADMIN" },
                    { new Guid("7211a346-6e23-431c-a6bd-2f02aa5de68a"), null, "Moderator", "MODERATOR" },
                    { new Guid("b86a5b00-0393-4524-9f56-fa7ca800e79c"), null, "Developer", "DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "JoinedDate", "LastLogin", "LastUsernameChangedDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), 0, "90ac0562-fd2f-46f5-9cd1-4aecf9e65776", "player1@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 485, DateTimeKind.Local).AddTicks(7764), null, null, true, null, "PLAYER1@GMAIL.COM", "PLAYER1", "AQAAAAIAAYagAAAAEPBl9150Pm8HVH3tJi/c5PLfxm+inoMaYLz6OTpPiGfEFNaIs2Eiks9b3fBCQsyAbQ==", null, false, null, null, "bc11b227-c962-4757-ac2d-9550a778e38e", false, "player1" },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), 0, "aa7d9ea6-1fa2-4808-ab81-e7fc636ec986", "developer1@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 709, DateTimeKind.Local).AddTicks(69), null, null, true, null, "DEVELOPER1@GMAIL.COM", "DEVELOPER1", "AQAAAAIAAYagAAAAEK7yjCAXMzs/5qzRxnJ+Vy6ubakrxp95lspXPOshZ/L+UzNb9Zrjz3pihNBD1jCp8Q==", null, false, null, null, "2453903b-030d-4477-82d5-115ac6638bc9", false, "developer1" },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), 0, "57c5db57-2cb4-48fa-a3bc-d890df0e702e", "developer2@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 778, DateTimeKind.Local).AddTicks(475), null, null, true, null, "DEVELOPER2@GMAIL.COM", "DEVELOPER2", "AQAAAAIAAYagAAAAECUuw+IzT5eEEtJGDBUViBb6Tqf1W0oxmXbGPBa4WFaxW0ampXd6gQsOBvCCGZ6cSA==", null, false, null, null, "c6ac52b3-d961-472c-af2b-5426b3071006", false, "developer2" },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), 0, "9271ab76-f841-435b-b495-dbdf17e70d53", "moderator@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 401, DateTimeKind.Local).AddTicks(2753), null, null, true, null, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAIAAYagAAAAEN0x7nSjvjiqB+5cb6Lq7QKbhD47PcbRvBCsoERUEw0YYRPNApPZ+81PahKW7p+FHw==", null, false, null, null, "d279efb9-0ffc-42da-a422-31997d4c0f6d", false, "moderator" },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), 0, "40f21595-7059-4515-b7ca-c41e4eff18c4", "player3@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 632, DateTimeKind.Local).AddTicks(6101), null, null, true, null, "PLAYER3@GMAIL.COM", "PLAYER3", "AQAAAAIAAYagAAAAEHWF12ktTf8UsjA0nIz2+avSvzlHF778R8+9TRZ4MmYksYyNdyvQ9j2kC6tAhP+T6g==", null, false, null, null, "2b0e8cb1-821f-4e6a-bc5f-65bf6e99c510", false, "player3" },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), 0, "c77ec0cd-e8ca-4d0e-aca5-9d3ac56f1c3d", "player2@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 566, DateTimeKind.Local).AddTicks(9642), null, null, true, null, "PLAYER2@GMAIL.COM", "PLAYER2", "AQAAAAIAAYagAAAAEN2bBpt8olrFXgffwVWbVqKINDzdt7GIpxvjQjEiqayDKLM/PS4fuEcEXMz7Q5tVrA==", null, false, null, null, "01a1097e-2f51-4b75-9b19-5a39cd5ef007", false, "player2" },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), 0, "57b9ace4-4883-4520-bccf-db2a581e49b9", "developer3@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 847, DateTimeKind.Local).AddTicks(6265), null, null, true, null, "DEVELOPER3@GMAIL.COM", "DEVELOPER3", "AQAAAAIAAYagAAAAECCSqgEfGc5unV15On5c7Llwbf7olwBft8dsmTqv+RRAbp/KX4PxAsmnVdBtEZHWsQ==", null, false, null, null, "e48e39df-66e1-4fb4-9f55-76bfd38ff5eb", false, "developer3" },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), 0, "1ca94b63-9ceb-40d0-a821-91294d499d9e", "admin@gmail.com", true, true, new DateTime(2025, 8, 14, 0, 48, 43, 325, DateTimeKind.Local).AddTicks(4232), null, null, true, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEENfL6v7FZx6Jim8/8GoyqSIH64pJzPDjYp6pkP7G6c1EGzWFCWNsM1sm+1sKOKulw==", null, false, null, null, "5fddb535-5b66-4b66-b05f-14d18aa5e8b4", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), false, "Simulation" },
                    { new Guid("3623f541-4b87-4174-bfce-dd2b027c7a33"), false, "Sports" },
                    { new Guid("39b71d75-ed24-461a-8dbf-e4fa9ae425fc"), false, "Platformer" },
                    { new Guid("4d84bb23-8644-4720-8344-d4a9d0433d35"), false, "Shooter" },
                    { new Guid("592e7334-c896-46f6-ad6c-a781a2ab7219"), false, "Card Game" },
                    { new Guid("5e1afbc9-31dd-417d-ae49-baa45d6d5797"), false, "Education" },
                    { new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), false, "Visual Novel" },
                    { new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), false, "Action" },
                    { new Guid("88fd3b90-179a-4c18-8c3a-5f3929992e0a"), false, "Racing" },
                    { new Guid("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"), false, "Role-Playing" },
                    { new Guid("929c6ef0-41e5-4bc5-9ef9-86f0703b9c20"), false, "Strategy" },
                    { new Guid("a5a8e1af-bbea-4029-99fe-42912e7c7ba2"), false, "Rhythm" },
                    { new Guid("ab34908d-20dc-43bd-b80d-eac5b59d6238"), false, "Survival" },
                    { new Guid("b277ba85-f89b-4617-a464-49cda6e8d387"), false, "Fighting" },
                    { new Guid("bca8721b-c323-44a1-afcf-876e206ab035"), false, "Puzzle" },
                    { new Guid("cd1fb8a2-c34e-4fc4-bbbd-9931a0c6ce0e"), false, "Interactive Fiction" },
                    { new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), false, "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "CommercialPackages",
                columns: new[] { "Id", "Description", "Duration", "IsDeleted", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("0efbfb71-599d-4233-a598-1595615810e1"), "Displays a banner on a category page for 7 days.", 7, false, "Category Banner - Weekly", 60000.0, "CategoryBanner" },
                    { new Guid("4bfbc5f2-bef6-44ff-a5c4-baaff953f651"), "Displays a banner on the homepage for 7 days.", 7, false, "Homepage Banner - Weekly", 80000.0, "HomepageBanner" },
                    { new Guid("854bb0e5-ecf6-4bc8-a5f7-1d9e27d27e73"), "Displays a banner on a category page for 1 day.", 1, false, "Category Banner - Daily", 10000.0, "CategoryBanner" },
                    { new Guid("856314ae-b364-4d83-94ba-f11600c88cff"), "Displays a banner on the homepage for 1 day.", 1, false, "Homepage Banner - Daily", 20000.0, "HomepageBanner" },
                    { new Guid("8f451273-fe64-4c67-80e9-84ee20733ddd"), "Displays a banner on the homepage for 30 days.", 30, false, "Homepage Banner - Monthly", 310000.0, "HomepageBanner" },
                    { new Guid("a9758e65-b0d6-4dd1-8272-fe1f2cb4794e"), "Displays a banner on a category page for 30 days.", 30, false, "Category Banner - Monthly", 230000.0, "CategoryBanner" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("04adfb56-cb77-4209-8fc3-a7b96b768784"), false, "Japanese" },
                    { new Guid("11a64feb-23f6-41ad-a55f-a9f487d04a85"), false, "Chinese" },
                    { new Guid("149615f6-6214-4e42-a016-1dba7d248c0f"), false, "Korean" },
                    { new Guid("2f98f2c8-2640-4cff-a8eb-ed61d9179dcb"), false, "Spanish" },
                    { new Guid("3ec80948-8c1a-46aa-9fd6-01feeb273c22"), false, "Russian" },
                    { new Guid("73b3d9d2-ecbf-4d91-95ad-e9a48b7e54cd"), false, "German" },
                    { new Guid("80e3581d-3836-4921-a838-b7d917b5e11f"), false, "Vietnamese" },
                    { new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527"), false, "English" },
                    { new Guid("ae4f3cfb-6dd6-473b-a1c6-695f9edce11e"), false, "French" },
                    { new Guid("ca29265a-4bab-4aa1-a819-9636878b50da"), false, "Portuguese" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("574cb883-e637-4f18-9518-269e4d22312c"), false, "MacOS" },
                    { new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), false, "Windows" },
                    { new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), false, "Linux" }
                });

            migrationBuilder.InsertData(
                table: "ReportTypes",
                columns: new[] { "Id", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("1c0d2f16-1f4a-4c5e-9c26-2e86e0cfa28f"), false, "Malicious Behavior", "Game" },
                    { new Guid("32992805-dcef-427a-afb8-239c79cb4de9"), false, "Offensive Language", "Post" },
                    { new Guid("3f36c22a-5f0d-4f02-ab65-b47a22ae81a7"), false, "Political or Religious Extremism", "Post" },
                    { new Guid("4f1491bf-15be-4e7a-83b4-c20a8017bf59"), false, "Offensive Language", "Comment" },
                    { new Guid("59eff953-9268-4488-9f2a-0ce3a5b80ac3"), false, "Scam or Fraud", "Game" },
                    { new Guid("77cf1c6b-bc98-4c98-8a7e-27f2c4b45377"), false, "Inappropriate Content", "Post" },
                    { new Guid("78e8165a-c263-4790-b0f4-21d2398c3d82"), false, "Performance Issues", "Game" },
                    { new Guid("7fb483f2-3499-4f56-a22f-af191fac0411"), false, "False Information", "Post" },
                    { new Guid("8b92d32e-0aa0-4f88-bc43-0e04c4121e0e"), false, "Copyright Infringement", "Game" },
                    { new Guid("93d1432e-880f-4b87-b2fc-20e7d01b17b7"), false, "Political or Religious Extremism", "Comment" },
                    { new Guid("a8eae5df-0705-4021-835c-75c12df9b2f2"), false, "Off-topic", "Post" },
                    { new Guid("b348e5d5-55ea-48ed-a5fe-b3cc56c8a7b1"), false, "Harassment", "Post" },
                    { new Guid("b7ae8b62-4cc1-4e45-9515-2c9a1a6e71b1"), false, "False Information", "Comment" },
                    { new Guid("cf9fce91-e2d6-46b1-baa3-c0a11eb96c30"), false, "Inappropriate Content", "Comment" },
                    { new Guid("d2ebbb20-5e8c-4d8e-aace-d499e04862a2"), false, "Harassment", "Comment" },
                    { new Guid("e85da0be-4fe1-42b1-8260-97a13e82ae5c"), false, "Off-topic", "Comment" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("048cbb0b-d39e-4f1d-b1d7-e28aeb6fc6e6"), false, "Grayscale", "Game" },
                    { new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3"), false, "First-Person", "Game" },
                    { new Guid("130d3ae5-7c92-4d37-9082-13226dd0d9af"), false, "Platformer", "Game" },
                    { new Guid("1c175c84-379e-43dc-a95a-aafd910d6a00"), false, "Action", "Game" },
                    { new Guid("229ef81c-f48f-49ae-a9a1-149f71d54d77"), false, "Showcase 🎨", "Post" },
                    { new Guid("22ad33b0-8358-4054-aa6b-59a2b5296842"), false, "Isometric", "Game" },
                    { new Guid("37223e27-41ad-44cb-9332-d985dbc9f708"), false, "Pixel Art", "Game" },
                    { new Guid("3e7412cc-2817-4d03-9dcf-7c3c7e619186"), false, "16-Bit", "Game" },
                    { new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f"), false, "3D", "Game" },
                    { new Guid("41c1f4f5-4cf0-411b-bb15-e59f15b04762"), false, "Fighting", "Game" },
                    { new Guid("46c0001e-beb3-4291-885a-f076e53f40fd"), false, "Survival", "Game" },
                    { new Guid("48239920-0a09-438e-8320-6b822e01f8bb"), false, "Two Colors", "Game" },
                    { new Guid("4d1a6086-ed27-4767-8fb6-4c4af12c384c"), false, "Role-Playing", "Game" },
                    { new Guid("510d85f4-c8dc-4228-93cb-311809751bed"), false, "Multiplayer", "Game" },
                    { new Guid("5452906a-03b1-45df-b4f0-a65398885171"), false, "Visual Novel", "Game" },
                    { new Guid("569a2ff2-5259-4467-9824-a3f2c5a595f7"), false, "1-Bit", "Game" },
                    { new Guid("611e1869-df31-4ec1-b063-7c9ae49bfb30"), false, "RPG Maker", "Game" },
                    { new Guid("621f12a7-89cb-4b97-83c0-cd3e84774dd4"), false, "Third-Person", "Game" },
                    { new Guid("62c2fe13-f1d2-4905-b3e1-166598e091fb"), false, "8x8", "Game" },
                    { new Guid("6cc4c52b-3b0e-4641-9997-8a1e6c29753b"), false, "Godot", "Game" },
                    { new Guid("71918e61-bb0b-4ca1-975a-616d869769bf"), false, "Puzzle", "Game" },
                    { new Guid("7cc2168e-4ad6-409f-9868-bd59df589d8c"), false, "Guide 📖", "Post" },
                    { new Guid("7d5d4e96-d0fa-440e-914f-1667b6ef54c1"), false, "Unreal Engine", "Game" },
                    { new Guid("7e3be5eb-bf83-4450-9ecb-70535267d3ea"), false, "Flat-Shading", "Game" },
                    { new Guid("85a1abde-9980-4cc7-976e-1d4135ffddff"), false, "Review ★", "Post" },
                    { new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac"), false, "Colorful", "Game" },
                    { new Guid("8c202501-893d-427e-9faf-47e2f1d6ba2d"), false, "Education", "Game" },
                    { new Guid("8db1d14f-c82c-4a06-bd60-456350a62594"), false, "Non-Eucledian", "Game" },
                    { new Guid("8fdfc2fc-b9ae-49a4-9aa5-e986cdf9f65a"), false, "Neon", "Game" },
                    { new Guid("9636813b-f393-4adb-b9a7-44f877f67ae5"), false, "8-Bit", "Game" },
                    { new Guid("9c685bd3-c75f-48df-8043-20c2fe181e7f"), false, "Watercolor", "Game" },
                    { new Guid("a0f1e28b-a439-4e72-aed8-0baddbb515c2"), false, "Rhythm", "Game" },
                    { new Guid("a137e663-30d5-4ed9-8aa3-b9b500f18de7"), false, "Card Game", "Game" },
                    { new Guid("aa580b0a-12c6-4d95-8d4f-c68fdd8cfbd9"), false, "32x32", "Game" },
                    { new Guid("aa592c96-400a-4c67-bf18-3b82823e9ef9"), false, "Racing", "Game" },
                    { new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769"), false, "Cartoon", "Game" },
                    { new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301"), false, "Singleplayer", "Game" },
                    { new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d"), false, "Horror", "Game" },
                    { new Guid("b6dd9e32-eaf5-4942-9c18-566421ca2e90"), false, "Top-Down", "Game" },
                    { new Guid("b9e9a223-25b3-491b-ba92-e185a74d82ab"), false, "Simulation", "Game" },
                    { new Guid("bc50196f-6aa1-49c2-9347-33f4ef15b8d6"), false, "Black and White", "Game" },
                    { new Guid("c04cba4a-a827-4a49-b61b-f02798ef17c9"), false, "Shooter", "Game" },
                    { new Guid("c7cee309-8f38-43fd-8512-e40e4d6f1ccd"), false, "Strategy", "Game" },
                    { new Guid("cd37e2fc-cb7e-45c3-90d6-87c690a2aaf3"), false, "Ren’Py", "Game" },
                    { new Guid("cd543d0f-1761-4874-945b-53863f00942b"), false, "Adventure", "Game" },
                    { new Guid("da2b3f32-20fc-4a62-a16f-f87fbe4696fb"), false, "Question ❓", "Post" },
                    { new Guid("e27b19a2-12d7-4a55-a8e4-7ff3487db712"), false, "Pastel", "Game" },
                    { new Guid("e4e35307-2071-4a75-88fc-579db0077703"), false, "Unity", "Game" },
                    { new Guid("e50d38ef-93f6-4f52-a55b-0dbf8188f91f"), false, "Discussion 💬", "Post" },
                    { new Guid("f3527a12-03c3-417d-9dd1-6130e7fcfe3e"), false, "16x16", "Game" },
                    { new Guid("f503a37e-dff0-45a8-8ae8-58ccefa4c9d3"), false, "Low-Poly", "Game" },
                    { new Guid("f57af0bf-7612-4b08-84f3-be98a842f932"), false, "Interactive Fiction", "Game" },
                    { new Guid("f8d13d4f-1a7b-406b-aa6e-4f37d8cebacf"), false, "Hand-Drawn", "Game" },
                    { new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b"), false, "2D", "Game" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("51999f00-0f63-4236-8c81-94c43fcf7586"), new Guid("23879117-e09e-40f1-b78f-1493d81baf49") },
                    { new Guid("b86a5b00-0393-4524-9f56-fa7ca800e79c"), new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f") },
                    { new Guid("b86a5b00-0393-4524-9f56-fa7ca800e79c"), new Guid("34670beb-a794-4419-adf8-0465eea22a78") },
                    { new Guid("7211a346-6e23-431c-a6bd-2f02aa5de68a"), new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037") },
                    { new Guid("51999f00-0f63-4236-8c81-94c43fcf7586"), new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("51999f00-0f63-4236-8c81-94c43fcf7586"), new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("b86a5b00-0393-4524-9f56-fa7ca800e79c"), new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe") },
                    { new Guid("6f7b3f0c-3f54-4fb8-a215-33cd496c3be7"), new Guid("e5d8947f-6794-42b6-ba67-201f366128b8") }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRestrictionId", "AllowDonation", "AverageSession", "CategoryId", "CensorStatus", "CensoredAt", "CoverImage", "CreatedAt", "Description", "DeveloperId", "InstallInstruction", "IsDeleted", "Name", "NumberOfDownloads", "Price", "ShortDescription", "Status", "UpdatedAt", "VersionDescription", "VideoLink", "Visibility" },
                values: new object[,]
                {
                    { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(7997), "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!!&nbsp;<a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Latestop", 300.0, 100000.0, "Chill mold-cleaning arcade", "Released", null, "", "https://www.youtube.com/watch?v=WJKp2xT4QTs", "Public" },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8171), "<h2>``ATLYSS``</h2><h4>SOLO DEVELOPMENT ACTION ORPG PROJECT</h4><p><em><strong>A work in progress / under development game made by Kiseff</strong></em><em><br /></em></p><h4>Core Game Info</h4><ul><li>\"ATLYSS\" is a (Single-player + Multi-player)&nbsp;<strong>A</strong>ction&nbsp;<strong>O</strong>nline&nbsp;<strong>R</strong>ole&nbsp;<strong>P</strong>laying&nbsp;<strong>G</strong>ame</li><li>Enriched, instanced maps to discover</li><li>Equipment, Trade Items and Consumables to collect</li><li>Many Character Customization options with&nbsp;<strong>5 races</strong>&nbsp;to choose from</li><li>3 Primary Classes to become at lv-10 (<strong>Fighter</strong>,&nbsp;<strong>Bandit</strong>,&nbsp;<strong>Mystic</strong>)</li><li>Skill load-out system for making builds to suit your game-play style</li><li>Character stat progression / leveling systems / attributes</li><li>7 Weapon types to use in combat (Katars, Heavy Melee, Scepters, and more)</li><li>Repeatable Questing / Single Quests to complete</li><li><strong>Aesthetics inspired by 6th Generation video games</strong></li></ul><h4>Media / Promotion</h4><p><a href=\"https://www.patreon.com/Kiseff?fan_landing=true\" target=\"_blank\" rel=\"nofollow noopener\"><strong>If you'd like to support my game-dev work and other assorted projects, you can do so via my Patreon!</strong></a></p><p>For more instant information / updates / development progress, you can:</p><p><a href=\"https://twitter.com/kis_soft\" target=\"_blank\" rel=\"nofollow noopener\"><strong>Follow @kis_soft on Twitter</strong></a><strong><br /></strong></p><p><strong><a href=\"https://discord.gg/vScP5yUbtk\" target=\"_blank\" rel=\"nofollow noopener\">Join the KisSoft Underground Server to receive progression updates and notes, including announcements first hand! Community links are provided in the Discord's promotional links channel.</a></strong></p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Atlyss", 150.0, 60000.0, "", "Released", null, "", "https://www.youtube.com/watch?v=example", "Public" },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8156), "<h1><em>Dispatched!&nbsp;</em></h1><h3>\"The Hungry Hungry Hippos of late-stage capitalism.\"</h3><p>From the same idiots who made 'Plane Food Simulator':&nbsp;<a href=\"https://sheepandram.itch.io/pfs2021\">https://sheepandram.itch.io/pfs2021</a></p><p><strong>Platform =</strong>&nbsp;PC and Android App&nbsp;Store<br /><strong><br /></strong><strong>Full Description:</strong></p><p>In&nbsp;<em>Dispatched!</em>&nbsp;the aim of the game is to mail as many parcels as you can within the allocated time! Be careful you don't confuse the priority boxes, and make sure you bring an empty bottle.</p><p><strong>PC Controls:<br /></strong>Begin Game: Enter<br />Dispatch Parcel (Employee Left): Q<br />Dispatch Parcel (Employee Right): P<br /><strong><br /></strong><strong>Android/Phone Controls:</strong><br />Start Game = Tap Screen<br />Dispatch Parcel&nbsp;(Employee Left) = Tap Screen (Left hand side)<br />Dispatch Parcel (Employee Right) = Tap Screen (Right hand side)<br /><strong><br /></strong></p><p><strong>Executive Imagineer Enhancement Architect</strong><br />Chris Ramsden&nbsp;<a href=\"https://chris-ramsden.neocities.org/\" rel=\"nofollow noopener\">Neocities</a><br /><strong><br /></strong><strong>Executive Code Architect and Fulfilment Developer&nbsp;</strong><br />Sheps&nbsp;<a href=\"https://linktr.ee/thesheps\" rel=\"nofollow noopener\">https://linktr.ee/thesheps</a></p><p><strong>Executive Experience Enhancement Officer&nbsp;</strong><br />Max Blake</p><p><strong>Soundtrack Specialist</strong><br />The Gasman <a href=\"https://thegasman.bandcamp.com/music\" rel=\"nofollow noopener\">https://thegasman.bandcamp.com/music</a></p><p><strong>Special Thanks&nbsp;</strong>:&nbsp;<a href=\"https://freetousesounds.bandcamp.com/\" rel=\"nofollow noopener\">https://freetousesounds.bandcamp.com/</a></p><p><strong>All essential workers and distribution staff. Thanks for halting the societal collapse of 2020/21!</strong></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Dispatched", 100.0, 85000.0, "The Hungry Hungry Hippos of late-stage capitalism.", "Released", null, "", "", "Public" },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8124), "<p><strong><em>On Friday night, just past midnight, the people of Thunderhead screamed in terror.</em></strong></p><p><strong><em>Their end began four days earlier, when a strange hill appeared at the edge of the cemetery.</em></strong></p><p><strong><em>Maybe it began even further back - but our story begins the next morning, when the first light touched a town stained by horror.</em></strong></p><p><strong><em>What happened in Thunderhead was first told by the man who delivers milk every Friday to towns too quiet to matter.</em></strong></p><h2>FEATURES</h2><ul><li><strong><em>A&nbsp;Milk-Delivery Western Horror!</em></strong></li><li><em><strong>Driving!&nbsp;</strong></em>Take the wheel of your rusty old van.</li><li><strong><em>Delivering!</em></strong>&nbsp;Bring milk and orange juice to a tiny, forgotten Western town.<em><br /></em></li><li><strong><em>Fixing!</em></strong>&nbsp;The van's temperamental&mdash;sometimes it needs a whack with a wrench.</li><li><strong><em>Mystery!&nbsp;</em></strong>The town is empty. Where did everyone go? Why are there crosses everywhere? Who left behind those torn clothes? What happened here?</li><li><strong><em>Spectacle!</em></strong>&nbsp;Phenomenal music by&nbsp;<a href=\"https://voltzsupreme.itch.io/\">Voltz Supreme</a>, immersive sound design and an epic, cinematic finale.</li><li><strong><em>Retro graphics!</em></strong>&nbsp;Soak in the PSX-style aesthetic - on the prairie!</li></ul><h2>SOUNDTRACK</h2><p><a href=\"https://open.spotify.com/playlist/4ZiuqrgseeMUVCzz7oZI1D?si=42f92c241bdb4c7f&amp;nd=1&amp;dlsi=acab8f98a54b45e5\" rel=\"nofollow noopener\">You can listen to the soundtrack here.</a></p><h2>FOUND A BUG?&nbsp;</h2><p>Please let me know in the comments.&nbsp;</p><h2>FOLLOW ME</h2><table><tbody><tr><td><a href=\"https://bsky.app/profile/roawrvideostore.bsky.social\" rel=\"nofollow noopener\">Bluesky</a></td><td><a href=\"https://www.instagram.com/roawrvideostore/\" rel=\"nofollow noopener\">Instagram</a></td><td><a href=\"https://www.threads.net/@roawrvideostore\" rel=\"nofollow noopener\">Threads</a></td></tr></tbody></table>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Thunderhead", 400.0, 90000.0, "A Milk-Delivery Western Horror.", "Released", null, "", "https://www.youtube.com/watch?v=c8JdCXw4l3k", "Public" },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8005), "<h3>ABOUT:</h3><p>A short,&nbsp;psychological horror experience where you, player, quickly age to see how's your family doing now.</p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"MouseMemoirs\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Crouch</td><td>Ctrl</td></tr><tr><td>Interaction</td><td>E</td></tr></tbody></table><h3>NOTE:</h3><p>Game has a bit of experimentation going on in it and I tried some new stuff, like moving away from retro graphics, experimenting with movement and colors etc. and I sincerely hope that you will like what you see!</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "QuietPlace", 300.0, 50000.0, "Short and strange psychological horror", "Released", null, "", "https://www.youtube.com/watch?v=gjV5Vdf04UY&t=1s", "Public" },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftCoverImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(7927), "<p><strong>Announcement</strong>: Midnight Shift 1.2 has been released.</p><ul><li>Enhanced 4:3 VHS / found footage appearance.</li><li>The animation for the ending has been updated.</li><li>Increased field-of-view.</li><li>Updated main menu.</li></ul><p><strong>Synopsis</strong></p><p><em>Midnight Shift</em>&nbsp;puts players in the role as an ordinary security guard for a mannequin storage facility. At the end of a seemingly ordinary shift, strange things begin to happen in the facility. Leaving won't be easy as the keys required for the exit doors have been misplaced.</p><p><strong>Development</strong></p><p>This was my first Unity project I created during my time at Edmonton Digital Arts College. The project has eight weeks of development time with seldom game engine and coding experience.</p><p><strong>Developer's Note</strong></p><p>Thanks for 25,000+ Midnight Shift downloads! I appreciate all the support and your interest in my projects.</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "MidnightShift", 150.0, 150000.0, "Escape a mannequin storage facility.", "Released", null, "", "https://www.youtube.com/watch?v=v1oeNEKiwTg", "Public" },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatCoverImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(7912), "<h4>Steam release features Hard Mode, as well as double the story!</h4><p>You are in the backseat of your parent's car during a long drive. As your parents begin fighting, your hand-held game is your only source of entertainment. But the game begins to mirror real life... Collect items on your hand-held game to send them to the backseat and use them to defend against the monstrosity that's trying to make its way into the backseat with you.</p><h4>SURVIVE THE NIGHT DRIVE</h4><p>Your drive home from grandma's is interrupted by an unexpected detour. Play a hand-held game in the backseat as your parent's drive.</p><h4>RETRO GAMING</h4><p>Your hand-held game is beginning to mirror reality... Supplies you collect in the game will be sent to the backseat.</p><h4>TRAPPED IN THE DEADSEAT</h4><p>A deadly monstrosity wants to join you in the backseat. Juggle your supplies and defend all sides. In this car, there&rsquo;s only onwards to drive, and nowhere to run.</p><h4>THE STORY</h4><p>Your parents can't get along, and you can&rsquo;t ignore it, no matter how deep you immerse yourself in your game. If only you could get away from it all and escape to somewhere better. And seemingly, the voice in your game says you can.</p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "The Deadseat", 100.0, 100000.0, "A short horror game where you play a hand-held game in the backseat during a long drive home.", "Released", null, "", "https://www.youtube.com/watch?v=Q4A2c8-BN78&t=2s", "Public" },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 3.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelicCoverImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(7980), "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!! <a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Broken Relic", 200.0, 200000.0, "First day on the job. You broke a seal, unleashed a dark power, and may have doomed everyone.", "Released", null, "", "https://www.youtube.com/watch?v=ColSNi0XD6Q", "Public" },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 2.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8115), "<p><em>Warning: Contains blood, violence, strong language and disturbing imagery.</em></p><h1><em>Dated November 4th, 1988.</em></h1><h2>MASSACRE AT DAYTON COUNTY MALL! HUNDREDS DEAD, OVER 350 INJURED.</h2><h2>EXPERTS ARE STILL INVESTIGATING WHAT EXACTLY HAPPENED, BUT IT APPEARS A... DINOSAUR?... MATERIALISED IN THE MALL AND WENT FERAL...</h2><p><em>This is a breaking story - more information soon.</em></p><p><strong>Special thanks:</strong></p><ul><li>3D Art assistance - Anders Brynildsen</li></ul><p><strong>Voicing:</strong></p><ul><li>Han Davies</li><li>Ned Sanders</li><li>Will Aryitey</li><li>Figerox Studios</li></ul><p>This game was heavily inspired by the legend,&nbsp;Puppet Combo.</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Bloodmall", 350.0, 80000.0, "It came without warning. Put an end to the massacre, and hunt down the dinosaur.", "Released", null, "", "https://www.youtube.com/watch?v=1fYf3Rt7guw", "Public" },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8255), "<p>After a long day, you take the subway home. The train is late, but everything seems normal&mdash;until the doors close. Among the passengers, one man starts acting strange... There's nowhere to run.</p><h3>Features:</h3><p>Average playtime: 5&ndash;10 minutes</p><p>Four original endings + secret ending</p><p>PSX retro style</p><p>Original story</p><p><strong>Streamer-YouTuber friendly: non-copyright music</strong></p><p>Completely translated to Portuguese, Spanish, Turkish, Polish, Russian, German, Korean, Italian and French!</p><h3>Controls:</h3><p>Movement: WASD</p><p>Run: Shift</p><p>Interact: E</p><p>Next dialogue/Move objects: Left mouse button</p><p>Stand up: Space</p><h3>About:</h3><p>DISCLAIMER: This game displays your pc's name so if you don't want your real name to be displayed you should change your pc's name or just don't play the game on stream.</p><p>If you liked this game, you should check out:</p><p><a href=\"https://riversoftware.itch.io/on-my-way-home\">On My Way Home by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/neighbournextdoor\">Neighbour Next Door by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/tv-night\">TV Night by RiverSoftware</a></p><h3>Known Issues:</h3><p>Gameplay limited to 100fps due to a bug with player controller</p><p>Some lights may not work if you select the low graphics option</p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "TheStation", 200.0, 65000.0, "Just a typical subway ride...", "Released", null, "", "", "Public" },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8148), "<h3>ABOUT:</h3><p>A short, atmospheric horror experience where you and a friend are tasked with digging up two bodies,&nbsp;<strong>but something isn&rsquo;t right.</strong></p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"November\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Interaction</td><td>E</td></tr><tr><td>Attack</td><td>LMB</td></tr></tbody></table><h3>WARNING:</h3><p>The game features mild gore, loud sound effects and everything that comes with horror genre. Player discretion is advised.</p><h3>NOTE:</h3><p>Game has a bit of comedy in it and I hope that I did good job with implementing it!</p><p>Don't harass me over voice acting :D , Neither me, or my friend are native English speakers, but we gave it our best and had a lot of fun doing it!</p><p>Most of the&nbsp;<strong>models&nbsp;</strong>(4 that aren't are aptly credited),&nbsp;<strong>music&nbsp;</strong>and&nbsp;<strong>scripts</strong>&nbsp;in&nbsp;the game are made by me, textures are from&nbsp;<a href=\"https://ambientcg.com/\" target=\"_blank\" rel=\"nofollow noopener\">AmbeintCG</a>.</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p><h3>UPDATE:</h3><p>CaseOh, being an absolute legend that he is, played another one of my games on his stream, this is snippet of the live where he plays this game, thanks CaseOh!</p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "DiggingHour", 700.0, 85000.0, "Atmospheric horror experience where you and your friend have to dig some bodies, but something is wrong.", "Released", null, "", "https://www.youtube.com/watch?v=tNoPejgMaB0", "Public" },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8041), "<p>a short&nbsp;<strong>vn style game</strong>&nbsp;made in rpgmaker in which you try to find out what happened to your missing friend.</p><p><strong>contains: mild blood, needles, a yandere, and a little bit of comedy</strong></p><p>this game's super short,&nbsp;<strong>5 endings</strong>, maybe around 10 to 15 minutes to complete?</p><p>sorry if there's errors and stuff, i made the entire thing in one night and im very sleep deprived&nbsp;</p><p>if there's any major errors or bugs lmk i'll try to get to fixing that asap okay dokay</p><p><strong>credits</strong></p><p>art and music: me</p><p>plugins: galv and that YEP message core thingy</p><p><strong>and btw.....!</strong></p><p>if you wanna follow along the development of the main game that this one is based off of, come&nbsp;<a href=\"https://discord.gg/MGzVp9JSsK\" target=\"_blank\" rel=\"nofollow noopener\">join my discord server!!</a></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Missing", 150.0, 60000.0, "Your friend's gone missing. You're out to find out what happened to them.", "Released", null, "", "", "Public" },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage.jpg", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8026), "<h3>Help Sheepy, an abandoned plushy brought to life, as he explores a forgotten and broken world. Sheepy: A Short Adventure is the first short game from MrSuicideSheep.</h3><h2>Independently Handcrafted</h2><p>A short, handcrafted, fully independent pixel art platformer, spanning several zones with unique skills to unlock. Discover an abandoned world full of secrets and lore influenced by themes driven by the music and community of MrSuicideSheep for more than 10 years.&nbsp;</p><h2>An Original Soundtrack</h2><p>Weaved into the world is an incredible original soundtrack created by Seeking Blue artists Tal Richards, Hahlweg and Yoe Mase availble to stream and purchase here.</p><h2>Mailing List</h2><p>Join the Mailing List and be the first to learn about future happenings with Sheepy!</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Sheepy", 500.0, 75000.0, "Help Sheepy, as he explores a forgotten an broken world.", "Released", null, "", "https://www.youtube.com/watch?v=RRs_AI96h-w", "Public" },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8164), "<p><strong>Security Booth is a VHS PSX Horror Game.&nbsp;</strong></p><p>Based in 1996, you are working for a company known as Nova Nexus, you play as a security guard.<br />Your job role is to make sure that only the right authorized personnel are getting into the facility.&nbsp;</p><p>The game has a total of&nbsp;<strong>2 endings.<br /></strong></p><p><strong>Average Game Time - 10 Minutes&nbsp;</strong></p><p><strong>Game Controls&nbsp;</strong></p><table><tbody><tr><td>Walk</td><td>Look Around</td><td>Interact</td><td>FlashLight</td></tr><tr><td>W,A,S,D</td><td>Mouse</td><td>E</td><td>F</td></tr></tbody></table><p><strong>Menu/UI Controls</strong></p><table><tbody><tr><td>Select Option</td><td>Go To Option Right/Next Page</td><td>Go To Option Left/Previous Page</td><td>Go To Option Up Or Down</td></tr><tr><td>E</td><td>D</td><td>A</td><td>W - UP<br />S - Down</td></tr></tbody></table><p>*The Mouse will never show up in game*</p><p>--------------------------------------------------------------------</p><p>Want more?<br />Security Booth:&nbsp;Director's Cut is OUT NOW!<br />Check out the Steam store or grab it here on Itch.io.</p><p>Follow my twitter for future games that I am making.<br /><a href=\"https://twitter.com/KyleHorwood\" rel=\"nofollow noopener\">https://twitter.com/KyleHorwood</a></p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "SecurityBooth", 200.0, 70000.0, "A Short VHS PSX Horror Game.", "Released", null, "", "https://www.youtube.com/watch?v=wYnJD9Pteis", "Public" },
                    { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.0, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8034), "<p><em>Donation is not necessary to play the game, but definitely much appreciated for me to keep making games.</em></p><p>---</p><h2><strong>DAUGHTER</strong></h2><p>Your daughter went to a sleepover birthday party at her friend's house, what could go wrong?</p><p>This is a short horror game about you trying to rescuing your daughter from a creepy house.</p><p>The story might feel incomplete as&nbsp;Daughter is a submission to the Lost Relic Games Game Jam 2022 and was made in a week. The theme is \"connection\" and I'm going for a more abstract route about the connection between the father and the daughter.</p><p>Your comments and feedbacks are very much appreciated as I might be updating this game after the Jam.</p><p>---</p><p><strong>BUGS</strong></p><ul><li>If you have a hard time reading the notes, close the flashlight before you interact with it.</li></ul><p>---</p><h2>BASIC CONTROLS</h2><p>Only support keyboard and mouse.</p><p>W,A,S,D - Walk</p><p>LEFT SHIFT - Sprint</p><p>F / E / LMB&nbsp;- Interact</p><p>G - Flashlight</p><p>Left CTRL - Crouch</p><p>---</p><p><strong>If you enjoy my game,&nbsp;you can follow my development on X:&nbsp;<a href=\"https://x.com/MikeTenDev\" rel=\"nofollow noopener\">https://x.com/MikeTenDev</a></strong></p><p>---</p><h2>CREDITS</h2><p><strong>TOOLS USED:&nbsp;</strong>Unreal Engine, Blender and Audacity</p><p><strong>ASSETS USED:</strong></p><p>Modular PSX Architecture Pack:&nbsp;<a href=\"https://comp3interactive.itch.io/modular-psx-architecture-kit\">https://comp3interactive.itch.io/modular-psx-architecture-kit</a></p><p>Retro PSX Style Tree Pack:&nbsp;<a href=\"https://elegantcrow.itch.io/psx-retro-style-tree-pack\">https://elegantcrow.itch.io/psx-retro-style-tree-pack</a></p><p>Retro House Pack: <a href=\"https://elegantcrow.itch.io/retro-house-pack\">https://elegantcrow.itch.io/retro-house-pack</a></p><p>Tiny Texture Pack 1:&nbsp;<a href=\"https://screamingbrainstudios.itch.io/tiny-texture-pack\">https://screamingbrainstudios.itch.io/tiny-texture-pack</a></p><p>Deceitful Castle in Dungeon Music Pack:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599</a></p><p>Fantasy Sound Bundle:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-193760\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-19376</a></p><p>Happy Birthday Whistle:&nbsp;<a href=\"https://freesound.org/people/gaiterjay/sounds/617576/\" rel=\"nofollow noopener\">https://freesound.org/people/gaiterjay/sounds/617576/</a></p><p>Requiem in d minor:&nbsp;<a href=\"https://musopen.org/music/43683-requiem-in-d-minor-k-626/\" rel=\"nofollow noopener\">https://musopen.org/music/43683-requiem-in-d-minor-k-626/</a></p><p>Biblical Goth Girl:&nbsp;<a href=\"https://crimsongcat.itch.io/biblical-goth-angel-girl\">https://crimsongcat.itch.io/biblical-goth-angel-girl</a></p><p>Brush Strokes:&nbsp;<a href=\"https://www.freepik.com/vectors/japanese-brush\" rel=\"nofollow noopener\">https://www.freepik.com/vectors/japanese-brush</a></p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Daughter", 200.0, 75000.0, "A short horror game", "Released", null, "", "", "Public" },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8132), "<h1>Evaluation</h1><p>A short PS1-inspired third person adventure game about growing up&nbsp;and finding your place in reality.<br />The game focuses on rewarding exploration, features NPCs and platforming elements, all supported by the narrative and a strong eerie atmosphere.</p><p>Evaluation is my first game&nbsp;project. It was a wild ride, way longer to finalize than I expected, but I learnt so much along the way, and hope to do more in the future!</p><h1>Controls</h1><p>WASD/Arrow keys - Move<br />MOUSE - Look around /&nbsp;click advances dialogue<br />SPACE - Jump<br />E - Talk/Interact<br />ESCAPE - Skip Cutscene<br />R - Respawn (if you get stuck)</p><h1>Credits</h1><p>I crafted as much as I could do from scratch, however the following external assets were of invaluable help on pulling off the game as I imagined it:<br /><a href=\"https://hutonggames.com/\" rel=\"nofollow noopener\">Playmaker - Huton Games</a><br /><a href=\"https://www.w3schools.com/\" rel=\"nofollow noopener\">PSX Effects - Triple Axis</a><br /><a href=\"https://assetstore.unity.com/packages/tools/physics/character-movement-fundamentals-144966\" rel=\"nofollow noopener\">Character Movement Fundamentals - Jan OTT</a><br /><a href=\"https://assetstore.unity.com/packages/3d/animations/basic-motions-free-154271\" rel=\"nofollow noopener\">Basic Motions - Kevin Iglesias</a></p><h1>More</h1><p>Find me on&nbsp;<a href=\"https://www.instagram.com/vivivivitotototo/\" rel=\"nofollow noopener\">Instagram</a>,&nbsp;<a href=\"https://twitter.com/vtrmrl\" rel=\"nofollow noopener\">Twitter</a>,&nbsp;<a href=\"https://soundcloud.com/zerocrossingpoint\" rel=\"nofollow noopener\">Soundcloud</a></p><p>Let me know if you find any bugs!</p><p><br /><br /></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Evaluation", 500.0, 90000.0, "A short PS1-inspired third person adventure & exploration game about growth", "Released", null, "", "", "Public" },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(7989), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Moldwasher", 250.0, 120000.0, "", "Released", null, "", "https://www.youtube.com/watch?v=6KGgPoY7TbY", "Public" },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8247), "<p>Your mum is cooking dinner. Saddened by the amount of leftover and not wanting it to go to waste, she tasked you the job to give it all away to your neighbours.</p><p>You, who was just minding your own business watching cartoons. You who your mum have told many times to not talk to strangers. But yet, you have no right to deny the request.&nbsp;</p><p>Armed with limited skills of communication, meet all the quirky and creepy neighbours to finish the task before your mum finish you first...literally.</p><p>Created for SCREAM JAM 2021&nbsp;by:</p><ul><li>Realmpact - Programmer</li><li>Skekarin - Artist, Writer and Games Designer</li></ul><p><strong>Disclaimer</strong></p><p>The WebGL version of the game is meant for users who are not using a Windows machine. For the best experience, we would recommend downloading the Windows version instead.</p><p>FAQ</p><ul><li>Help! I cannot show the leftovers!<ul><li>Press Q during the prompt to show leftovers&nbsp;to continue the conversation as if you showed it.</li></ul></li></ul>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Leftovers", 100.0, 50000.0, "Don't talk to strangers, unless your mother needs you to.", "Released", null, "", "", "Public" },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.5, new Guid("5e1afbc9-31dd-417d-ae49-baa45d6d5797"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage.jpg", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8179), "<h4>\"Welcome to my game, buddy!\"</h4><p>Mr. TomatoS is glad to see you! He waited a long time for someone to visit him! Feel like at home and get ready for endless f̶u̶n̶ !</p><p>Mr. TomatoS needs YOUR help! looks like he had not eaten for ages! Of course not, he has no hands!</p><p>Feed Mr. Tomatos with big variety of food, combine it with blender, and use different items to help you with this task!</p><h4>\"But why should I do this?\"</h4><p>Glad you asked! By helping him you can earn a lot of points to spend them in the shop later! Everyone loves to earn points, right?</p><h4>\"Why am i always d̶y̶i̶n̶g̶ losing?\"</h4><p>Glad you asked, my dear friend! j̶u̶s̶t̶ d̶o̶n̶t̶ d̶o̶w̶n̶l̶o̶a̶d̶ i̶t̶ you need a strategy to finish the game! without a strategy, everything can go wrong.</p><p>Manage your resources correctly to s̶t̶a̶y̶ a̶l̶i̶v̶e̶ win!)</p><p>unless you want to make Mr. TomatoS angry.</p><p>This game is made in the style of old web flash games, what sets it apart from other new games!</p><p>Feel the atmosphere of old flash games!</p><p>You can complete the game only ONCE, that means that you won't have a second chance. And how you will complete YOUR game - depends only on YOU. Try your best. Good luck.</p><p>Main theme by:&nbsp;<strong>Cnupoc (</strong><span title=\"https://freesound.org/people/Cnupoc/\"><a href=\"https://freesound.org/people/Cnupoc/\" rel=\"nofollow noopener\">https://freesound.org/people/Cnupoc/</a></span><strong>)</strong></p><p>Game theme by:&nbsp;<strong>Sirkoto51 (</strong><span title=\"https://freesound.org/people/Sirkoto51/\"><a href=\"https://freesound.org/people/Sirkoto51/\" rel=\"nofollow noopener\">https://freesound.org/people/Sirkoto51/</a></span><strong>)</strong></p><p><strong>Sirkoto51 soundcloud :&nbsp;</strong>&nbsp;<span title=\"https://soundcloud.com/sirkoto51\"><a href=\"https://soundcloud.com/sirkoto51\" rel=\"nofollow noopener\">https://soundcloud.com/sirkoto51</a></span></p><p>Some sounds by:&nbsp;<strong>InspectorJ(</strong>Jonathan Shaw<strong>) (</strong><span title=\"https://freesound.org/people/InspectorJ/\"><a href=\"https://freesound.org/people/InspectorJ/\" rel=\"nofollow noopener\">https://freesound.org/people/InspectorJ/</a></span><strong>)</strong></p><p><strong>InspectorJ patreon:&nbsp;</strong><span title=\"https://www.patreon.com/JonathanShaw\"><a href=\"https://www.patreon.com/JonathanShaw\" rel=\"nofollow noopener\">https://www.patreon.com/JonathanShaw</a></span></p><h3>MrTomatoS</h3><p>- standard version of the game.</p><h3>MrTomatoS++</h3><h4>\" Oh oh, it looks like someone messed up the game code!&nbsp;\"</h4><p>- Now you can reset your game progress after completion to get more endings</p><p>- You can download this version even if you already played in standart version, and completed it</p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Tomato", 300.0, 75000.0, "Welcome to my game, buddy!", "Released", null, "", "", "Public" },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("bca8721b-c323-44a1-afcf-876e206ab035"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8140), "<p><strong>DOMINOID&nbsp;</strong>is an arcade-styled&nbsp;puzzle game about stacking dominids!&nbsp;<strong>CLEAR&nbsp;</strong>pieces by forming&nbsp;<strong>RINGS&nbsp;</strong>with matching tiles. Create huge&nbsp;<strong>COMBOS&nbsp;</strong>by stacking dominids effectively. Collect&nbsp;<strong>BADGES&nbsp;</strong>for major accomplishments.&nbsp;Earn&nbsp;<strong>EXP&nbsp;</strong>by clearing dominids to go towards a&nbsp;<strong>LEVEL UP</strong>. Can you get all the way to&nbsp;<strong>LEVEL 10</strong>?</p><p>The game features gamepad support as well as remappable controls for both keyboard and gamepad. There's support for custom music packs, sound effect packs, background sets, and pieces. Multiple sets of backgrounds and pieces come included with the game. The game also comes with an&nbsp;instruction book and wallpaper bundle.</p><p><img src=\"https://img.itch.zone/aW1nLzIxNDg1MzM4LnBuZw==/original/TVLouX.png\" alt=\"\" /></p><p>Additional art by : Julian</p><p>Audio by : Dim&nbsp;Widdy</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Dominoid", 600.0, 95000.0, "An arcade-styled falling block puzzle game. Stack DOMINIDS, form RINGS, build COMBOS, & earn EXP to LEVEL UP!", "Released", null, "", "", "Public" },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage.png", new DateTime(2025, 8, 14, 0, 48, 43, 296, DateTimeKind.Local).AddTicks(8013), "<h3>Welcome to PAC-SIDE</h3><p>PAC-SIDE is a fast-paced pacman-based horror game, where you can meet your old yellow friend! Wait.. It looks like something bad&nbsp;happened with him..</p><h3>Controls</h3><table><tbody><tr><td><strong>W, A,&nbsp;S, D</strong></td><td>Movement</td></tr><tr><td><strong>Mouse</strong></td><td>Look Around</td></tr><tr><td><strong>Left Shift</strong></td><td>Run</td></tr></tbody></table><h3>Epilepsy Warning!</h3><p>This game contains flashing lights and images, which is&nbsp;<strong>NOT RECOMMENDED</strong>&nbsp;for sensitive people.</p><h3>Developer</h3><p>Game by&nbsp;<strong>SeriousDaniel</strong></p><p>Made with Unreal Engine</p><p><strong>This game is a fan-game and does NOT related to the original Pac-Man or its developers. All rights to the original characters, sounds and graphics&nbsp;belong to Bandai Namco.</strong></p><p>Follow me on X&nbsp;<a href=\"https://x.com/serious_voice\" rel=\"nofollow noopener\">https://x.com/serious_voice</a></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Pacside", 400.0, 75000.0, "A pac-man horror game", "Released", null, "", "https://www.youtube.com/watch?v=yxt7w5VRQ_w", "Public" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "UserId", "Avatar", "BankAccountName", "BankAccountNumber", "BankBin", "BankCode", "BankName", "BankShortName", "Bio", "Birthday", "FacebookLink", "Fullname", "LastPingAt", "YoutubeChannelLink" },
                values: new object[,]
                {
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Player1", null, "" },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Developer1", null, "" },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Developer2", null, "" },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Moderator", null, "" },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Player3", null, "" },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Player2", null, "" },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Developer3", null, "" },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", "", "", "", "", new DateOnly(2002, 1, 23), "", "Admin", null, "" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "UserId", "Balance" },
                values: new object[,]
                {
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), 1000000.0 },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), 1000000.0 },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), 0.0 },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), 0.0 },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), 0.0 },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), 0.0 },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), 0.0 },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "EndDate", "GameId", "Percentage" },
                values: new object[] { new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"), new DateOnly(2025, 8, 24), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), 10.0 });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("02c460f0-9019-4eff-ad72-f94a22856482"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("03849a30-ac31-4993-b892-aedc6303d513"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("06541d91-0ce8-43e9-aa12-aedabb12ad0e"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("07ce08a2-e61a-4ca2-b27a-ae8f3344b2ca"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("08056ce6-e314-4b81-9c67-4be3b6c13330"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("1e9e0a9f-7f15-4384-8d30-b01632fbfffe"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("2212b056-b7e1-4bd4-a258-aae3e24f9a87"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage1.png" },
                    { new Guid("223d05f9-9e8d-49d5-b534-d23ae2f4fefa"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("2246c708-20d2-4d57-af2f-32f8a5c32cbd"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("2c0a5e4c-e7cd-4917-a0d6-2f38fcb80400"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("2f4497b4-f98f-406b-be93-43280ada9852"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("30f5534c-a5a1-41fd-b019-e440c783d157"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("327bf3b4-dd42-4bbc-9617-f2d86ae41079"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("357fc00d-b595-4e83-b631-b301ab12b4b8"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("36d9bcbb-53df-4c86-b66c-0ae8b0469e5e"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("3741b097-4961-479d-8fca-32f4ee14cc23"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("396cf491-b737-4983-a65e-42ecd36080d7"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage2.png" },
                    { new Guid("42158d6b-1059-497e-b64b-e950f953a49d"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("461d67a2-eddd-47ba-bf82-3c0bdca2cdfa"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("46d5b756-acd6-4800-a16c-19524a8b90fd"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("4fe28e73-fc60-4523-bbb1-75e314e4a8ab"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("507b2f97-fb35-4a1b-b472-217f5bafde63"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("50845404-3939-45ff-a4c9-edcca2d57024"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("54990ef4-a883-4790-8b8a-5abcbc18884e"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("55085436-f52c-4a65-899a-e23a2c2a6289"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("5dee2c8c-da3f-41f1-b47b-73fdf44e9aff"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("6a44efc5-efcd-421e-9be2-b5e4df216d79"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("6cc46628-c593-4b5a-957c-75c45639261e"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("71d3e2c3-a9e3-4cdc-9779-4d921cb184b4"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("757c6835-0ae8-4ec4-8cd7-d253298959fd"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("770df97b-cac5-4a9f-af58-9a58f9ae668b"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("7c611b46-f27d-4f65-9086-49a0f1e006b7"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("81738026-cd42-482c-a692-f080a6fe9240"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage4.png" },
                    { new Guid("86d00d08-e146-4623-aaa4-c4e345d1440e"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("9136ae14-7047-44cd-8059-ced95048d6f0"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("93f0680c-aa4a-455b-86a7-f72c25ed62a3"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("9df063ed-0e62-4613-8086-727c7f89d207"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("9efaa4f0-7e7d-4ae6-abfe-9ed4531c3fe6"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("a13af1d3-632d-454b-97f5-6d86c05c6ede"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("a42c88bb-3675-4859-81b7-68d889a887ec"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("aa25507c-4f47-483b-8860-caf2d0a5ccbc"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("ae93343c-c7ac-4aab-980d-85f286a94414"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("b9966b3f-07c2-4749-abc4-7a0d4b08d324"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("b9b5d586-13ec-49c4-9117-9fed650ecd54"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("bb846913-f151-43e6-89b8-d5386d3949d8"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("bb9b7bd6-5b22-471b-beeb-e36a9200689e"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("bd350b42-b6a4-47c0-b5c2-c6250115954d"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("d3e36747-a19a-41ff-b8a1-1c274e378dab"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage5.png" },
                    { new Guid("d49388db-9006-413e-bd8f-edb8b5a4e693"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("d54a0181-0752-4cf9-9a0b-ecc76eadd676"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("d6502460-f71e-44d0-9dfc-c8abc10c766f"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("d686ebdb-404f-4d77-8ae6-62b757c0e8a3"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("d6a3fac8-8ba5-4ac7-9ea3-0988423bd1a5"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("dc51c2cb-b4e9-4467-a8fb-0f87d4a41995"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("dc5e81ec-24b6-4109-ba9f-e9de4ad9a855"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage3.png" },
                    { new Guid("dce84788-61b5-4605-957e-b64bc3049f4b"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("ed65f4be-14f9-40f9-b96f-01654069a5c2"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("ee6e9e62-a4e7-4f91-b21f-c613c3884463"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("ee94b715-e3a9-4223-bfc9-f4874c89409d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("eff2544a-b68d-461d-9b10-7d2382fa2085"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("f132f8c5-519e-47d3-9134-795a17e946ea"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("f57df1fc-67ce-4bcc-834f-de8cb6e6023a"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("f5d92dfc-33f8-4f2a-970b-49ab4be0dd86"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("f622d2ff-be4c-40f0-92ec-559e7b155f6b"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("f67cde9b-6750-4e43-95f4-c194aa9ed30b"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("f74933a1-97f3-4b0c-a1e6-9dafeb3e22a8"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("fee2f916-89db-4c0f-8a1a-22a8ba7f21d6"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" }
                });

            migrationBuilder.InsertData(
                table: "GameLanguages",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("0106c63f-9123-4942-8c3f-50a32becf896"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("03c0f132-6601-4500-8e7e-4359f8cf74e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("0bab745f-0831-4cbc-be5a-c0bcd60363ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("2066f8f6-2e34-4426-a2f7-2e73438ded76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("251afaf3-d86c-4bb9-9dcf-22a658707029"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("472049f7-a066-453e-a37a-904770810489"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("4d4e9027-63b0-4d09-95ad-b11b7b61f1ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("5dfd6a2a-2cd7-4692-ab10-63de73f95ef0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("5f39cbb1-418f-40c9-bd8d-bba604aff5a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("6fe034af-b235-4c05-bd13-3ac667a80f21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("717cd019-8fd2-4b80-8028-88c7bd6f702c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("7e2a684d-32c2-4f6e-af30-fc896f993881"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("80958a40-fdfa-4723-9c24-6373ce5048d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("8d24036f-50d1-49b4-9454-66e595630c64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("a7a05acd-eeee-4640-b993-ce38ad7ab4eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("b73791f7-aa64-4926-a7e7-32d0c2203b8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("bb630fd9-e84a-4671-9efd-734cc8d300ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("c0309c18-5362-453e-b01b-4c7a6b6c03f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("c38a6cd9-8986-40fb-9c8e-d506b287ade8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("cc5252c8-9d08-4e78-96e7-0ad73ca49876"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("ce258340-a4fc-4ac2-aca9-aedc09c7c865"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("e7355e53-e9dd-4347-8b79-86a1495f97c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("ed7bef79-3d86-435a-a2ec-6df409e1a86e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("ed838d58-6e82-4326-8ea3-ad5647bdde29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("efbaf930-e2af-4b15-9d10-b2de2e6428e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "GameId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("7d5d4e96-d0fa-440e-914f-1667b6ef54c1") },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769") },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac") },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("1c175c84-379e-43dc-a95a-aafd910d6a00") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("b9e9a223-25b3-491b-ba92-e185a74d82ab") },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") },
                    { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("7d5d4e96-d0fa-440e-914f-1667b6ef54c1") },
                    { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("46c0001e-beb3-4291-885a-f076e53f40fd") },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("6cc4c52b-3b0e-4641-9997-8a1e6c29753b") },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac") },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("8c202501-893d-427e-9faf-47e2f1d6ba2d") },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c2a96f4-5aa4-457e-9588-afac54a5784a"), "This is the best game I have ever seen", new DateTime(2025, 8, 14, 0, 48, 43, 307, DateTimeKind.Local).AddTicks(7643), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") },
                    { new Guid("82169af4-d7bd-4c7a-8259-e86e653f6220"), "This game is good, but it has some bugs", new DateTime(2025, 8, 14, 0, 48, 43, 307, DateTimeKind.Local).AddTicks(7667), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("c7131700-79d0-4297-8fb2-187c41f04d13"), "This game gives me a cozy vibe", new DateTime(2025, 8, 14, 0, 48, 43, 307, DateTimeKind.Local).AddTicks(7662), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") }
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                name: "IX_BanHistories_BannedByUserId",
                table: "BanHistories",
                column: "BannedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BanHistories_BannedUserId",
                table: "BanHistories",
                column: "BannedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommercialRegistrations_CommercialPackageId",
                table: "CommercialRegistrations",
                column: "CommercialPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CommercialRegistrations_GameId",
                table: "CommercialRegistrations",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_GameId",
                table: "Discounts",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_DownloadSlots_GameId",
                table: "DownloadSlots",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_DownloadSlots_UserId",
                table: "DownloadSlots",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GameCensorLogs_GameId",
                table: "GameCensorLogs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameCensorLogs_ModeratorId",
                table: "GameCensorLogs",
                column: "ModeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_GameImages_GameId",
                table: "GameImages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguages_LanguageId",
                table: "GameLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_GameId",
                table: "GamePlatforms",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_PlatformId",
                table: "GamePlatforms",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePriceLogs_GameId",
                table: "GamePriceLogs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameRecommendations_UserId",
                table: "GameRecommendations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_AgeRestrictionId",
                table: "Games",
                column: "AgeRestrictionId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CategoryId",
                table: "Games",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_DeveloperId",
                table: "Games",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_GameTags_TagId",
                table: "GameTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Libraries_GameId",
                table: "Libraries",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CommercialPackageId",
                table: "Orders",
                column: "CommercialPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GameId",
                table: "Orders",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_PostId",
                table: "PostComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_UserId",
                table: "PostComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PostId",
                table: "PostImages",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_UserId",
                table: "PostReactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_GameId",
                table: "Posts",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CommentId",
                table: "Reports",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_GameId",
                table: "Reports",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_PostId",
                table: "Reports",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportingUserId",
                table: "Reports",
                column: "ReportingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportReasonId",
                table: "Reports",
                column: "ReportReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UsersId",
                table: "Reports",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_GameId",
                table: "Transactions",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrderCode",
                table: "Transactions",
                column: "OrderCode",
                unique: true,
                filter: "[OrderCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrderId",
                table: "Transactions",
                column: "OrderId",
                unique: true,
                filter: "[OrderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PurchaseUserId",
                table: "Transactions",
                column: "PurchaseUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollows_FolloweeId",
                table: "UserFollows",
                column: "FolloweeId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_UserId",
                table: "Wishlists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawRequests_UserId",
                table: "WithdrawRequests",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BanHistories");

            migrationBuilder.DropTable(
                name: "CommercialRegistrations");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "DownloadSlots");

            migrationBuilder.DropTable(
                name: "GameCensorLogs");

            migrationBuilder.DropTable(
                name: "GameImages");

            migrationBuilder.DropTable(
                name: "GameLanguages");

            migrationBuilder.DropTable(
                name: "GamePlatforms");

            migrationBuilder.DropTable(
                name: "GamePriceLogs");

            migrationBuilder.DropTable(
                name: "GameRecommendations");

            migrationBuilder.DropTable(
                name: "GameTags");

            migrationBuilder.DropTable(
                name: "Libraries");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserAchievements");

            migrationBuilder.DropTable(
                name: "UserFollows");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "WithdrawRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "ReportTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "CommercialPackages");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "AgeRestrictions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
