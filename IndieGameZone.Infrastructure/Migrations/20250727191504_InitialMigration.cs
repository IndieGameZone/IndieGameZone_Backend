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
                    ProgressLevel = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DiscountAward = table.Column<double>(type: "float", nullable: false),
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
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupons_AspNetUsers_UserId",
                        column: x => x.UserId,
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
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ImageProof = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTransfered = table.Column<bool>(type: "bit", nullable: false),
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
                name: "CommercialRegistration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommercialPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommercialRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommercialRegistration_CommercialPackages_CommercialPackageId",
                        column: x => x.CommercialPackageId,
                        principalTable: "CommercialPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommercialRegistration_Games_GameId",
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
                    OrderCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommercialPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommercialRegistrationStartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CommercialRegistrationEndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderCode);
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
                        name: "FK_Orders_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
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
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_Transactions_Orders_OrderCode",
                        column: x => x.OrderCode,
                        principalTable: "Orders",
                        principalColumn: "OrderCode",
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
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
                columns: new[] { "Id", "DiscountAward", "IsDeleted", "Name", "ProgressLevel", "Type" },
                values: new object[,]
                {
                    { new Guid("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"), 5.0, false, "Like 10 Posts", 10.0, "Like" },
                    { new Guid("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), 7.0, false, "Comment 50 Times", 50.0, "Comment" },
                    { new Guid("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"), 7.0, false, "Make 50 Posts", 50.0, "Post" },
                    { new Guid("5291fbd1-9926-4904-92bc-7f36c738c189"), 5.0, false, "Make 10 Posts", 10.0, "Post" },
                    { new Guid("56e5cd8d-2d46-45dc-9006-f71920beea40"), 5.0, false, "Buy 10 Games", 10.0, "GamePurchase" },
                    { new Guid("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), 7.0, false, "Follow 50 Developers", 50.0, "Follow" },
                    { new Guid("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"), 3.0, false, "Like first Post", 1.0, "Like" },
                    { new Guid("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"), 7.0, false, "Buy 50 Games", 50.0, "GamePurchase" },
                    { new Guid("b0ea7c96-6d5c-4199-9029-7f04e7502f66"), 3.0, false, "Make first Post", 1.0, "Post" },
                    { new Guid("b186aeb1-033f-4937-a24c-d11b1989e7e2"), 5.0, false, "Follow 10 Developers", 10.0, "Follow" },
                    { new Guid("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), 3.0, false, "Follow 5 Developers", 5.0, "Follow" },
                    { new Guid("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"), 7.0, false, "Like 50 Posts", 50.0, "Like" },
                    { new Guid("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), 5.0, false, "Comment 10 Times", 10.0, "Comment" },
                    { new Guid("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), 3.0, false, "Comment first time", 1.0, "Comment" },
                    { new Guid("fef0c70d-cf7b-4c90-9865-383e660fda8a"), 3.0, false, "First Purchase", 1.0, "GamePurchase" }
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
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), 0, "0e8f4a2e-f6c7-4f71-bfac-72f67607bc9f", "player1@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 334, DateTimeKind.Local).AddTicks(3684), null, null, true, null, "PLAYER1@GMAIL.COM", "PLAYER1", "AQAAAAIAAYagAAAAEPccnAU0FgIdE5fGlXBNtctrZm71TQx3rh91NXlyqORBw86axmUh1kgkmTQDYMw5MQ==", null, false, null, null, "03b9d052-4d22-4047-8645-ca8b3470d0bf", false, "player1" },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), 0, "c28aabb4-cb74-4265-a1cc-a49cc543e460", "developer1@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 510, DateTimeKind.Local).AddTicks(6082), null, null, true, null, "DEVELOPER1@GMAIL.COM", "DEVELOPER1", "AQAAAAIAAYagAAAAEGi85uP1WB38AriLice6esEpB1ro4uz0EfMP/GmXHQFcWL0qg5BVQcd1lGdLipLtvQ==", null, false, null, null, "d33d3efe-4f23-4aa3-891b-acdc3ae61f9c", false, "developer1" },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), 0, "89cca560-38cf-4e3c-a3ab-5fb1ba6db513", "developer2@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 572, DateTimeKind.Local).AddTicks(1527), null, null, true, null, "DEVELOPER2@GMAIL.COM", "DEVELOPER2", "AQAAAAIAAYagAAAAEE1l0N1XpVNmR5bFEPOoMi2AkayDAeIJ1GBz9bdnesM15RsGLP6PUDTcr69l53LA9g==", null, false, null, null, "3ea9eb3d-d1f0-4042-a820-c15146c840e9", false, "developer2" },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), 0, "8b84317f-1201-43eb-b7d8-5f0cdcd9621f", "moderator@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 270, DateTimeKind.Local).AddTicks(7555), null, null, true, null, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAIAAYagAAAAEMhex9YW1X34F3gR50RgrKx9b9SN6BAMIbFSNvZySkEP6B9bEE55suMwcMEOP25Afw==", null, false, null, null, "d76b3f0d-1907-4562-863d-3922dd9c1b14", false, "moderator" },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), 0, "6a4f3640-c83f-4c2f-802d-a1af56ca1c0c", "player3@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 452, DateTimeKind.Local).AddTicks(2935), null, null, true, null, "PLAYER3@GMAIL.COM", "PLAYER3", "AQAAAAIAAYagAAAAEPPd+QG0KWbnYvjU5EOh5o/NvfJsbF09kjXi27xyLG2CKOAU+1Yk7stw98i5p4L67w==", null, false, null, null, "38c929ea-76f5-4810-808b-0951d1d52ca1", false, "player3" },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), 0, "6ba1b29a-1350-4f5b-90fd-89231ae1f102", "player2@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 393, DateTimeKind.Local).AddTicks(5539), null, null, true, null, "PLAYER2@GMAIL.COM", "PLAYER2", "AQAAAAIAAYagAAAAEPgxI14lru+xcG3PgmRPHLOUBYc8oQiHYlT1U3TRVv8htNDpGH4AQnXp3+nGLssLag==", null, false, null, null, "ba22c248-cf7e-45a4-8381-bf4b0ec00cc0", false, "player2" },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), 0, "f521e327-2b84-43c9-873d-a485eb2f9fb5", "developer3@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 632, DateTimeKind.Local).AddTicks(614), null, null, true, null, "DEVELOPER3@GMAIL.COM", "DEVELOPER3", "AQAAAAIAAYagAAAAEDMqTZW72T9LiuScjBhIOCp5mwlR2TfMmcryAoeaqUYJlo1dN1AjoK1pKGGD7a64HA==", null, false, null, null, "f930f839-d778-4b30-9dd6-79aeabd76e30", false, "developer3" },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), 0, "ae155b2e-ab62-4e50-9354-7629175f5e44", "admin@gmail.com", true, true, new DateTime(2025, 7, 28, 2, 15, 3, 215, DateTimeKind.Local).AddTicks(1563), null, null, true, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEF3aailGFHMFOuIMJ2BIFy/4xmWYhRhvQeYY2/6P0S5Yhg09udw0ksquPvLjs0h92A==", null, false, null, null, "8badf6dd-b6cb-44cf-947a-2710f35704c6", false, "admin" }
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
                    { new Guid("b86a5b00-0393-4524-9f56-fa7ca800e79c"), new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe") },
                    { new Guid("6f7b3f0c-3f54-4fb8-a215-33cd496c3be7"), new Guid("e5d8947f-6794-42b6-ba67-201f366128b8") }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRestrictionId", "AllowDonation", "AverageSession", "CategoryId", "CensorStatus", "CensoredAt", "CoverImage", "CreatedAt", "Description", "DeveloperId", "InstallInstruction", "IsDeleted", "Name", "NumberOfDownloads", "Price", "ShortDescription", "Status", "UpdatedAt", "VersionDescription", "VideoLink", "Visibility" },
                values: new object[,]
                {
                    { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5778), "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!!&nbsp;<a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Latestop", 300.0, 100000.0, "Chill mold-cleaning arcade", "Released", null, "", "https://www.youtube.com/watch?v=WJKp2xT4QTs", "Public" },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5916), "<h2>``ATLYSS``</h2><h4>SOLO DEVELOPMENT ACTION ORPG PROJECT</h4><p><em><strong>A work in progress / under development game made by Kiseff</strong></em><em><br /></em></p><h4>Core Game Info</h4><ul><li>\"ATLYSS\" is a (Single-player + Multi-player)&nbsp;<strong>A</strong>ction&nbsp;<strong>O</strong>nline&nbsp;<strong>R</strong>ole&nbsp;<strong>P</strong>laying&nbsp;<strong>G</strong>ame</li><li>Enriched, instanced maps to discover</li><li>Equipment, Trade Items and Consumables to collect</li><li>Many Character Customization options with&nbsp;<strong>5 races</strong>&nbsp;to choose from</li><li>3 Primary Classes to become at lv-10 (<strong>Fighter</strong>,&nbsp;<strong>Bandit</strong>,&nbsp;<strong>Mystic</strong>)</li><li>Skill load-out system for making builds to suit your game-play style</li><li>Character stat progression / leveling systems / attributes</li><li>7 Weapon types to use in combat (Katars, Heavy Melee, Scepters, and more)</li><li>Repeatable Questing / Single Quests to complete</li><li><strong>Aesthetics inspired by 6th Generation video games</strong></li></ul><h4>Media / Promotion</h4><p><a href=\"https://www.patreon.com/Kiseff?fan_landing=true\" target=\"_blank\" rel=\"nofollow noopener\"><strong>If you'd like to support my game-dev work and other assorted projects, you can do so via my Patreon!</strong></a></p><p>For more instant information / updates / development progress, you can:</p><p><a href=\"https://twitter.com/kis_soft\" target=\"_blank\" rel=\"nofollow noopener\"><strong>Follow @kis_soft on Twitter</strong></a><strong><br /></strong></p><p><strong><a href=\"https://discord.gg/vScP5yUbtk\" target=\"_blank\" rel=\"nofollow noopener\">Join the KisSoft Underground Server to receive progression updates and notes, including announcements first hand! Community links are provided in the Discord's promotional links channel.</a></strong></p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Atlyss", 150.0, 60000.0, "", "Released", null, "", "https://www.youtube.com/watch?v=example", "Public" },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5901), "<h1><em>Dispatched!&nbsp;</em></h1><h3>\"The Hungry Hungry Hippos of late-stage capitalism.\"</h3><p>From the same idiots who made 'Plane Food Simulator':&nbsp;<a href=\"https://sheepandram.itch.io/pfs2021\">https://sheepandram.itch.io/pfs2021</a></p><p><strong>Platform =</strong>&nbsp;PC and Android App&nbsp;Store<br /><strong><br /></strong><strong>Full Description:</strong></p><p>In&nbsp;<em>Dispatched!</em>&nbsp;the aim of the game is to mail as many parcels as you can within the allocated time! Be careful you don't confuse the priority boxes, and make sure you bring an empty bottle.</p><p><strong>PC Controls:<br /></strong>Begin Game: Enter<br />Dispatch Parcel (Employee Left): Q<br />Dispatch Parcel (Employee Right): P<br /><strong><br /></strong><strong>Android/Phone Controls:</strong><br />Start Game = Tap Screen<br />Dispatch Parcel&nbsp;(Employee Left) = Tap Screen (Left hand side)<br />Dispatch Parcel (Employee Right) = Tap Screen (Right hand side)<br /><strong><br /></strong></p><p><strong>Executive Imagineer Enhancement Architect</strong><br />Chris Ramsden&nbsp;<a href=\"https://chris-ramsden.neocities.org/\" rel=\"nofollow noopener\">Neocities</a><br /><strong><br /></strong><strong>Executive Code Architect and Fulfilment Developer&nbsp;</strong><br />Sheps&nbsp;<a href=\"https://linktr.ee/thesheps\" rel=\"nofollow noopener\">https://linktr.ee/thesheps</a></p><p><strong>Executive Experience Enhancement Officer&nbsp;</strong><br />Max Blake</p><p><strong>Soundtrack Specialist</strong><br />The Gasman <a href=\"https://thegasman.bandcamp.com/music\" rel=\"nofollow noopener\">https://thegasman.bandcamp.com/music</a></p><p><strong>Special Thanks&nbsp;</strong>:&nbsp;<a href=\"https://freetousesounds.bandcamp.com/\" rel=\"nofollow noopener\">https://freetousesounds.bandcamp.com/</a></p><p><strong>All essential workers and distribution staff. Thanks for halting the societal collapse of 2020/21!</strong></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Dispatched", 100.0, 85000.0, "The Hungry Hungry Hippos of late-stage capitalism.", "Released", null, "", "", "Public" },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5821), "<p><strong><em>On Friday night, just past midnight, the people of Thunderhead screamed in terror.</em></strong></p><p><strong><em>Their end began four days earlier, when a strange hill appeared at the edge of the cemetery.</em></strong></p><p><strong><em>Maybe it began even further back - but our story begins the next morning, when the first light touched a town stained by horror.</em></strong></p><p><strong><em>What happened in Thunderhead was first told by the man who delivers milk every Friday to towns too quiet to matter.</em></strong></p><h2>FEATURES</h2><ul><li><strong><em>A&nbsp;Milk-Delivery Western Horror!</em></strong></li><li><em><strong>Driving!&nbsp;</strong></em>Take the wheel of your rusty old van.</li><li><strong><em>Delivering!</em></strong>&nbsp;Bring milk and orange juice to a tiny, forgotten Western town.<em><br /></em></li><li><strong><em>Fixing!</em></strong>&nbsp;The van's temperamental&mdash;sometimes it needs a whack with a wrench.</li><li><strong><em>Mystery!&nbsp;</em></strong>The town is empty. Where did everyone go? Why are there crosses everywhere? Who left behind those torn clothes? What happened here?</li><li><strong><em>Spectacle!</em></strong>&nbsp;Phenomenal music by&nbsp;<a href=\"https://voltzsupreme.itch.io/\">Voltz Supreme</a>, immersive sound design and an epic, cinematic finale.</li><li><strong><em>Retro graphics!</em></strong>&nbsp;Soak in the PSX-style aesthetic - on the prairie!</li></ul><h2>SOUNDTRACK</h2><p><a href=\"https://open.spotify.com/playlist/4ZiuqrgseeMUVCzz7oZI1D?si=42f92c241bdb4c7f&amp;nd=1&amp;dlsi=acab8f98a54b45e5\" rel=\"nofollow noopener\">You can listen to the soundtrack here.</a></p><h2>FOUND A BUG?&nbsp;</h2><p>Please let me know in the comments.&nbsp;</p><h2>FOLLOW ME</h2><table><tbody><tr><td><a href=\"https://bsky.app/profile/roawrvideostore.bsky.social\" rel=\"nofollow noopener\">Bluesky</a></td><td><a href=\"https://www.instagram.com/roawrvideostore/\" rel=\"nofollow noopener\">Instagram</a></td><td><a href=\"https://www.threads.net/@roawrvideostore\" rel=\"nofollow noopener\">Threads</a></td></tr></tbody></table>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Thunderhead", 400.0, 90000.0, "A Milk-Delivery Western Horror.", "Released", null, "", "https://www.youtube.com/watch?v=c8JdCXw4l3k", "Public" },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5784), "<h3>ABOUT:</h3><p>A short,&nbsp;psychological horror experience where you, player, quickly age to see how's your family doing now.</p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"MouseMemoirs\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Crouch</td><td>Ctrl</td></tr><tr><td>Interaction</td><td>E</td></tr></tbody></table><h3>NOTE:</h3><p>Game has a bit of experimentation going on in it and I tried some new stuff, like moving away from retro graphics, experimenting with movement and colors etc. and I sincerely hope that you will like what you see!</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "QuietPlace", 300.0, 50000.0, "Short and strange psychological horror", "Released", null, "", "https://www.youtube.com/watch?v=gjV5Vdf04UY&t=1s", "Public" },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftCoverImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5716), "<p><strong>Announcement</strong>: Midnight Shift 1.2 has been released.</p><ul><li>Enhanced 4:3 VHS / found footage appearance.</li><li>The animation for the ending has been updated.</li><li>Increased field-of-view.</li><li>Updated main menu.</li></ul><p><strong>Synopsis</strong></p><p><em>Midnight Shift</em>&nbsp;puts players in the role as an ordinary security guard for a mannequin storage facility. At the end of a seemingly ordinary shift, strange things begin to happen in the facility. Leaving won't be easy as the keys required for the exit doors have been misplaced.</p><p><strong>Development</strong></p><p>This was my first Unity project I created during my time at Edmonton Digital Arts College. The project has eight weeks of development time with seldom game engine and coding experience.</p><p><strong>Developer's Note</strong></p><p>Thanks for 25,000+ Midnight Shift downloads! I appreciate all the support and your interest in my projects.</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "MidnightShift", 150.0, 150000.0, "Escape a mannequin storage facility.", "Released", null, "", "https://www.youtube.com/watch?v=v1oeNEKiwTg", "Public" },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatCoverImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5705), "<h4>Steam release features Hard Mode, as well as double the story!</h4><p>You are in the backseat of your parent's car during a long drive. As your parents begin fighting, your hand-held game is your only source of entertainment. But the game begins to mirror real life... Collect items on your hand-held game to send them to the backseat and use them to defend against the monstrosity that's trying to make its way into the backseat with you.</p><h4>SURVIVE THE NIGHT DRIVE</h4><p>Your drive home from grandma's is interrupted by an unexpected detour. Play a hand-held game in the backseat as your parent's drive.</p><h4>RETRO GAMING</h4><p>Your hand-held game is beginning to mirror reality... Supplies you collect in the game will be sent to the backseat.</p><h4>TRAPPED IN THE DEADSEAT</h4><p>A deadly monstrosity wants to join you in the backseat. Juggle your supplies and defend all sides. In this car, there&rsquo;s only onwards to drive, and nowhere to run.</p><h4>THE STORY</h4><p>Your parents can't get along, and you can&rsquo;t ignore it, no matter how deep you immerse yourself in your game. If only you could get away from it all and escape to somewhere better. And seemingly, the voice in your game says you can.</p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "The Deadseat", 100.0, 100000.0, "A short horror game where you play a hand-held game in the backseat during a long drive home.", "Released", null, "", "https://www.youtube.com/watch?v=Q4A2c8-BN78&t=2s", "Public" },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 3.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelicCoverImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5723), "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!! <a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Broken Relic", 200.0, 200000.0, "First day on the job. You broke a seal, unleashed a dark power, and may have doomed everyone.", "Released", null, "", "https://www.youtube.com/watch?v=ColSNi0XD6Q", "Public" },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 2.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5815), "<p><em>Warning: Contains blood, violence, strong language and disturbing imagery.</em></p><h1><em>Dated November 4th, 1988.</em></h1><h2>MASSACRE AT DAYTON COUNTY MALL! HUNDREDS DEAD, OVER 350 INJURED.</h2><h2>EXPERTS ARE STILL INVESTIGATING WHAT EXACTLY HAPPENED, BUT IT APPEARS A... DINOSAUR?... MATERIALISED IN THE MALL AND WENT FERAL...</h2><p><em>This is a breaking story - more information soon.</em></p><p><strong>Special thanks:</strong></p><ul><li>3D Art assistance - Anders Brynildsen</li></ul><p><strong>Voicing:</strong></p><ul><li>Han Davies</li><li>Ned Sanders</li><li>Will Aryitey</li><li>Figerox Studios</li></ul><p>This game was heavily inspired by the legend,&nbsp;Puppet Combo.</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Bloodmall", 350.0, 80000.0, "It came without warning. Put an end to the massacre, and hunt down the dinosaur.", "Released", null, "", "https://www.youtube.com/watch?v=1fYf3Rt7guw", "Public" },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5934), "<p>After a long day, you take the subway home. The train is late, but everything seems normal&mdash;until the doors close. Among the passengers, one man starts acting strange... There's nowhere to run.</p><h3>Features:</h3><p>Average playtime: 5&ndash;10 minutes</p><p>Four original endings + secret ending</p><p>PSX retro style</p><p>Original story</p><p><strong>Streamer-YouTuber friendly: non-copyright music</strong></p><p>Completely translated to Portuguese, Spanish, Turkish, Polish, Russian, German, Korean, Italian and French!</p><h3>Controls:</h3><p>Movement: WASD</p><p>Run: Shift</p><p>Interact: E</p><p>Next dialogue/Move objects: Left mouse button</p><p>Stand up: Space</p><h3>About:</h3><p>DISCLAIMER: This game displays your pc's name so if you don't want your real name to be displayed you should change your pc's name or just don't play the game on stream.</p><p>If you liked this game, you should check out:</p><p><a href=\"https://riversoftware.itch.io/on-my-way-home\">On My Way Home by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/neighbournextdoor\">Neighbour Next Door by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/tv-night\">TV Night by RiverSoftware</a></p><h3>Known Issues:</h3><p>Gameplay limited to 100fps due to a bug with player controller</p><p>Some lights may not work if you select the low graphics option</p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "TheStation", 200.0, 65000.0, "Just a typical subway ride...", "Released", null, "", "", "Public" },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5895), "<h3>ABOUT:</h3><p>A short, atmospheric horror experience where you and a friend are tasked with digging up two bodies,&nbsp;<strong>but something isn&rsquo;t right.</strong></p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"November\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Interaction</td><td>E</td></tr><tr><td>Attack</td><td>LMB</td></tr></tbody></table><h3>WARNING:</h3><p>The game features mild gore, loud sound effects and everything that comes with horror genre. Player discretion is advised.</p><h3>NOTE:</h3><p>Game has a bit of comedy in it and I hope that I did good job with implementing it!</p><p>Don't harass me over voice acting :D , Neither me, or my friend are native English speakers, but we gave it our best and had a lot of fun doing it!</p><p>Most of the&nbsp;<strong>models&nbsp;</strong>(4 that aren't are aptly credited),&nbsp;<strong>music&nbsp;</strong>and&nbsp;<strong>scripts</strong>&nbsp;in&nbsp;the game are made by me, textures are from&nbsp;<a href=\"https://ambientcg.com/\" target=\"_blank\" rel=\"nofollow noopener\">AmbeintCG</a>.</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p><h3>UPDATE:</h3><p>CaseOh, being an absolute legend that he is, played another one of my games on his stream, this is snippet of the live where he plays this game, thanks CaseOh!</p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "DiggingHour", 700.0, 85000.0, "Atmospheric horror experience where you and your friend have to dig some bodies, but something is wrong.", "Released", null, "", "https://www.youtube.com/watch?v=tNoPejgMaB0", "Public" },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5809), "<p>a short&nbsp;<strong>vn style game</strong>&nbsp;made in rpgmaker in which you try to find out what happened to your missing friend.</p><p><strong>contains: mild blood, needles, a yandere, and a little bit of comedy</strong></p><p>this game's super short,&nbsp;<strong>5 endings</strong>, maybe around 10 to 15 minutes to complete?</p><p>sorry if there's errors and stuff, i made the entire thing in one night and im very sleep deprived&nbsp;</p><p>if there's any major errors or bugs lmk i'll try to get to fixing that asap okay dokay</p><p><strong>credits</strong></p><p>art and music: me</p><p>plugins: galv and that YEP message core thingy</p><p><strong>and btw.....!</strong></p><p>if you wanna follow along the development of the main game that this one is based off of, come&nbsp;<a href=\"https://discord.gg/MGzVp9JSsK\" target=\"_blank\" rel=\"nofollow noopener\">join my discord server!!</a></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Missing", 150.0, 60000.0, "Your friend's gone missing. You're out to find out what happened to them.", "Released", null, "", "", "Public" },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage.jpg", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5796), "<h3>Help Sheepy, an abandoned plushy brought to life, as he explores a forgotten and broken world. Sheepy: A Short Adventure is the first short game from MrSuicideSheep.</h3><h2>Independently Handcrafted</h2><p>A short, handcrafted, fully independent pixel art platformer, spanning several zones with unique skills to unlock. Discover an abandoned world full of secrets and lore influenced by themes driven by the music and community of MrSuicideSheep for more than 10 years.&nbsp;</p><h2>An Original Soundtrack</h2><p>Weaved into the world is an incredible original soundtrack created by Seeking Blue artists Tal Richards, Hahlweg and Yoe Mase availble to stream and purchase here.</p><h2>Mailing List</h2><p>Join the Mailing List and be the first to learn about future happenings with Sheepy!</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Sheepy", 500.0, 75000.0, "Help Sheepy, as he explores a forgotten an broken world.", "Released", null, "", "https://www.youtube.com/watch?v=RRs_AI96h-w", "Public" },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5910), "<p><strong>Security Booth is a VHS PSX Horror Game.&nbsp;</strong></p><p>Based in 1996, you are working for a company known as Nova Nexus, you play as a security guard.<br />Your job role is to make sure that only the right authorized personnel are getting into the facility.&nbsp;</p><p>The game has a total of&nbsp;<strong>2 endings.<br /></strong></p><p><strong>Average Game Time - 10 Minutes&nbsp;</strong></p><p><strong>Game Controls&nbsp;</strong></p><table><tbody><tr><td>Walk</td><td>Look Around</td><td>Interact</td><td>FlashLight</td></tr><tr><td>W,A,S,D</td><td>Mouse</td><td>E</td><td>F</td></tr></tbody></table><p><strong>Menu/UI Controls</strong></p><table><tbody><tr><td>Select Option</td><td>Go To Option Right/Next Page</td><td>Go To Option Left/Previous Page</td><td>Go To Option Up Or Down</td></tr><tr><td>E</td><td>D</td><td>A</td><td>W - UP<br />S - Down</td></tr></tbody></table><p>*The Mouse will never show up in game*</p><p>--------------------------------------------------------------------</p><p>Want more?<br />Security Booth:&nbsp;Director's Cut is OUT NOW!<br />Check out the Steam store or grab it here on Itch.io.</p><p>Follow my twitter for future games that I am making.<br /><a href=\"https://twitter.com/KyleHorwood\" rel=\"nofollow noopener\">https://twitter.com/KyleHorwood</a></p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "SecurityBooth", 200.0, 70000.0, "A Short VHS PSX Horror Game.", "Released", null, "", "https://www.youtube.com/watch?v=wYnJD9Pteis", "Public" },
                    { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.0, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5802), "<p><em>Donation is not necessary to play the game, but definitely much appreciated for me to keep making games.</em></p><p>---</p><h2><strong>DAUGHTER</strong></h2><p>Your daughter went to a sleepover birthday party at her friend's house, what could go wrong?</p><p>This is a short horror game about you trying to rescuing your daughter from a creepy house.</p><p>The story might feel incomplete as&nbsp;Daughter is a submission to the Lost Relic Games Game Jam 2022 and was made in a week. The theme is \"connection\" and I'm going for a more abstract route about the connection between the father and the daughter.</p><p>Your comments and feedbacks are very much appreciated as I might be updating this game after the Jam.</p><p>---</p><p><strong>BUGS</strong></p><ul><li>If you have a hard time reading the notes, close the flashlight before you interact with it.</li></ul><p>---</p><h2>BASIC CONTROLS</h2><p>Only support keyboard and mouse.</p><p>W,A,S,D - Walk</p><p>LEFT SHIFT - Sprint</p><p>F / E / LMB&nbsp;- Interact</p><p>G - Flashlight</p><p>Left CTRL - Crouch</p><p>---</p><p><strong>If you enjoy my game,&nbsp;you can follow my development on X:&nbsp;<a href=\"https://x.com/MikeTenDev\" rel=\"nofollow noopener\">https://x.com/MikeTenDev</a></strong></p><p>---</p><h2>CREDITS</h2><p><strong>TOOLS USED:&nbsp;</strong>Unreal Engine, Blender and Audacity</p><p><strong>ASSETS USED:</strong></p><p>Modular PSX Architecture Pack:&nbsp;<a href=\"https://comp3interactive.itch.io/modular-psx-architecture-kit\">https://comp3interactive.itch.io/modular-psx-architecture-kit</a></p><p>Retro PSX Style Tree Pack:&nbsp;<a href=\"https://elegantcrow.itch.io/psx-retro-style-tree-pack\">https://elegantcrow.itch.io/psx-retro-style-tree-pack</a></p><p>Retro House Pack: <a href=\"https://elegantcrow.itch.io/retro-house-pack\">https://elegantcrow.itch.io/retro-house-pack</a></p><p>Tiny Texture Pack 1:&nbsp;<a href=\"https://screamingbrainstudios.itch.io/tiny-texture-pack\">https://screamingbrainstudios.itch.io/tiny-texture-pack</a></p><p>Deceitful Castle in Dungeon Music Pack:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599</a></p><p>Fantasy Sound Bundle:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-193760\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-19376</a></p><p>Happy Birthday Whistle:&nbsp;<a href=\"https://freesound.org/people/gaiterjay/sounds/617576/\" rel=\"nofollow noopener\">https://freesound.org/people/gaiterjay/sounds/617576/</a></p><p>Requiem in d minor:&nbsp;<a href=\"https://musopen.org/music/43683-requiem-in-d-minor-k-626/\" rel=\"nofollow noopener\">https://musopen.org/music/43683-requiem-in-d-minor-k-626/</a></p><p>Biblical Goth Girl:&nbsp;<a href=\"https://crimsongcat.itch.io/biblical-goth-angel-girl\">https://crimsongcat.itch.io/biblical-goth-angel-girl</a></p><p>Brush Strokes:&nbsp;<a href=\"https://www.freepik.com/vectors/japanese-brush\" rel=\"nofollow noopener\">https://www.freepik.com/vectors/japanese-brush</a></p>", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", false, "Daughter", 200.0, 75000.0, "A short horror game", "Released", null, "", "", "Public" },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5882), "<h1>Evaluation</h1><p>A short PS1-inspired third person adventure game about growing up&nbsp;and finding your place in reality.<br />The game focuses on rewarding exploration, features NPCs and platforming elements, all supported by the narrative and a strong eerie atmosphere.</p><p>Evaluation is my first game&nbsp;project. It was a wild ride, way longer to finalize than I expected, but I learnt so much along the way, and hope to do more in the future!</p><h1>Controls</h1><p>WASD/Arrow keys - Move<br />MOUSE - Look around /&nbsp;click advances dialogue<br />SPACE - Jump<br />E - Talk/Interact<br />ESCAPE - Skip Cutscene<br />R - Respawn (if you get stuck)</p><h1>Credits</h1><p>I crafted as much as I could do from scratch, however the following external assets were of invaluable help on pulling off the game as I imagined it:<br /><a href=\"https://hutonggames.com/\" rel=\"nofollow noopener\">Playmaker - Huton Games</a><br /><a href=\"https://www.w3schools.com/\" rel=\"nofollow noopener\">PSX Effects - Triple Axis</a><br /><a href=\"https://assetstore.unity.com/packages/tools/physics/character-movement-fundamentals-144966\" rel=\"nofollow noopener\">Character Movement Fundamentals - Jan OTT</a><br /><a href=\"https://assetstore.unity.com/packages/3d/animations/basic-motions-free-154271\" rel=\"nofollow noopener\">Basic Motions - Kevin Iglesias</a></p><h1>More</h1><p>Find me on&nbsp;<a href=\"https://www.instagram.com/vivivivitotototo/\" rel=\"nofollow noopener\">Instagram</a>,&nbsp;<a href=\"https://twitter.com/vtrmrl\" rel=\"nofollow noopener\">Twitter</a>,&nbsp;<a href=\"https://soundcloud.com/zerocrossingpoint\" rel=\"nofollow noopener\">Soundcloud</a></p><p>Let me know if you find any bugs!</p><p><br /><br /></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Evaluation", 500.0, 90000.0, "A short PS1-inspired third person adventure & exploration game about growth", "Released", null, "", "", "Public" },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5771), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Moldwasher", 250.0, 120000.0, "", "Released", null, "", "https://www.youtube.com/watch?v=6KGgPoY7TbY", "Public" },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5928), "<p>Your mum is cooking dinner. Saddened by the amount of leftover and not wanting it to go to waste, she tasked you the job to give it all away to your neighbours.</p><p>You, who was just minding your own business watching cartoons. You who your mum have told many times to not talk to strangers. But yet, you have no right to deny the request.&nbsp;</p><p>Armed with limited skills of communication, meet all the quirky and creepy neighbours to finish the task before your mum finish you first...literally.</p><p>Created for SCREAM JAM 2021&nbsp;by:</p><ul><li>Realmpact - Programmer</li><li>Skekarin - Artist, Writer and Games Designer</li></ul><p><strong>Disclaimer</strong></p><p>The WebGL version of the game is meant for users who are not using a Windows machine. For the best experience, we would recommend downloading the Windows version instead.</p><p>FAQ</p><ul><li>Help! I cannot show the leftovers!<ul><li>Press Q during the prompt to show leftovers&nbsp;to continue the conversation as if you showed it.</li></ul></li></ul>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Leftovers", 100.0, 50000.0, "Don't talk to strangers, unless your mother needs you to.", "Released", null, "", "", "Public" },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.5, new Guid("5e1afbc9-31dd-417d-ae49-baa45d6d5797"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage.jpg", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5922), "<h4>\"Welcome to my game, buddy!\"</h4><p>Mr. TomatoS is glad to see you! He waited a long time for someone to visit him! Feel like at home and get ready for endless f̶u̶n̶ !</p><p>Mr. TomatoS needs YOUR help! looks like he had not eaten for ages! Of course not, he has no hands!</p><p>Feed Mr. Tomatos with big variety of food, combine it with blender, and use different items to help you with this task!</p><h4>\"But why should I do this?\"</h4><p>Glad you asked! By helping him you can earn a lot of points to spend them in the shop later! Everyone loves to earn points, right?</p><h4>\"Why am i always d̶y̶i̶n̶g̶ losing?\"</h4><p>Glad you asked, my dear friend! j̶u̶s̶t̶ d̶o̶n̶t̶ d̶o̶w̶n̶l̶o̶a̶d̶ i̶t̶ you need a strategy to finish the game! without a strategy, everything can go wrong.</p><p>Manage your resources correctly to s̶t̶a̶y̶ a̶l̶i̶v̶e̶ win!)</p><p>unless you want to make Mr. TomatoS angry.</p><p>This game is made in the style of old web flash games, what sets it apart from other new games!</p><p>Feel the atmosphere of old flash games!</p><p>You can complete the game only ONCE, that means that you won't have a second chance. And how you will complete YOUR game - depends only on YOU. Try your best. Good luck.</p><p>Main theme by:&nbsp;<strong>Cnupoc (</strong><span title=\"https://freesound.org/people/Cnupoc/\"><a href=\"https://freesound.org/people/Cnupoc/\" rel=\"nofollow noopener\">https://freesound.org/people/Cnupoc/</a></span><strong>)</strong></p><p>Game theme by:&nbsp;<strong>Sirkoto51 (</strong><span title=\"https://freesound.org/people/Sirkoto51/\"><a href=\"https://freesound.org/people/Sirkoto51/\" rel=\"nofollow noopener\">https://freesound.org/people/Sirkoto51/</a></span><strong>)</strong></p><p><strong>Sirkoto51 soundcloud :&nbsp;</strong>&nbsp;<span title=\"https://soundcloud.com/sirkoto51\"><a href=\"https://soundcloud.com/sirkoto51\" rel=\"nofollow noopener\">https://soundcloud.com/sirkoto51</a></span></p><p>Some sounds by:&nbsp;<strong>InspectorJ(</strong>Jonathan Shaw<strong>) (</strong><span title=\"https://freesound.org/people/InspectorJ/\"><a href=\"https://freesound.org/people/InspectorJ/\" rel=\"nofollow noopener\">https://freesound.org/people/InspectorJ/</a></span><strong>)</strong></p><p><strong>InspectorJ patreon:&nbsp;</strong><span title=\"https://www.patreon.com/JonathanShaw\"><a href=\"https://www.patreon.com/JonathanShaw\" rel=\"nofollow noopener\">https://www.patreon.com/JonathanShaw</a></span></p><h3>MrTomatoS</h3><p>- standard version of the game.</p><h3>MrTomatoS++</h3><h4>\" Oh oh, it looks like someone messed up the game code!&nbsp;\"</h4><p>- Now you can reset your game progress after completion to get more endings</p><p>- You can download this version even if you already played in standart version, and completed it</p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Tomato", 300.0, 75000.0, "Welcome to my game, buddy!", "Released", null, "", "", "Public" },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("bca8721b-c323-44a1-afcf-876e206ab035"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5889), "<p><strong>DOMINOID&nbsp;</strong>is an arcade-styled&nbsp;puzzle game about stacking dominids!&nbsp;<strong>CLEAR&nbsp;</strong>pieces by forming&nbsp;<strong>RINGS&nbsp;</strong>with matching tiles. Create huge&nbsp;<strong>COMBOS&nbsp;</strong>by stacking dominids effectively. Collect&nbsp;<strong>BADGES&nbsp;</strong>for major accomplishments.&nbsp;Earn&nbsp;<strong>EXP&nbsp;</strong>by clearing dominids to go towards a&nbsp;<strong>LEVEL UP</strong>. Can you get all the way to&nbsp;<strong>LEVEL 10</strong>?</p><p>The game features gamepad support as well as remappable controls for both keyboard and gamepad. There's support for custom music packs, sound effect packs, background sets, and pieces. Multiple sets of backgrounds and pieces come included with the game. The game also comes with an&nbsp;instruction book and wallpaper bundle.</p><p><img src=\"https://img.itch.zone/aW1nLzIxNDg1MzM4LnBuZw==/original/TVLouX.png\" alt=\"\" /></p><p>Additional art by : Julian</p><p>Audio by : Dim&nbsp;Widdy</p>", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", false, "Dominoid", 600.0, 95000.0, "An arcade-styled falling block puzzle game. Stack DOMINIDS, form RINGS, build COMBOS, & earn EXP to LEVEL UP!", "Released", null, "", "", "Public" },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage.png", new DateTime(2025, 7, 28, 2, 15, 3, 194, DateTimeKind.Local).AddTicks(5790), "<h3>Welcome to PAC-SIDE</h3><p>PAC-SIDE is a fast-paced pacman-based horror game, where you can meet your old yellow friend! Wait.. It looks like something bad&nbsp;happened with him..</p><h3>Controls</h3><table><tbody><tr><td><strong>W, A,&nbsp;S, D</strong></td><td>Movement</td></tr><tr><td><strong>Mouse</strong></td><td>Look Around</td></tr><tr><td><strong>Left Shift</strong></td><td>Run</td></tr></tbody></table><h3>Epilepsy Warning!</h3><p>This game contains flashing lights and images, which is&nbsp;<strong>NOT RECOMMENDED</strong>&nbsp;for sensitive people.</p><h3>Developer</h3><p>Game by&nbsp;<strong>SeriousDaniel</strong></p><p>Made with Unreal Engine</p><p><strong>This game is a fan-game and does NOT related to the original Pac-Man or its developers. All rights to the original characters, sounds and graphics&nbsp;belong to Bandai Namco.</strong></p><p>Follow me on X&nbsp;<a href=\"https://x.com/serious_voice\" rel=\"nofollow noopener\">https://x.com/serious_voice</a></p>", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", false, "Pacside", 400.0, 75000.0, "A pac-man horror game", "Released", null, "", "https://www.youtube.com/watch?v=yxt7w5VRQ_w", "Public" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "UserId", "Avatar", "BankAccount", "BankName", "Bio", "Birthday", "FacebookLink", "Fullname", "LastPingAt", "YoutubeChannelLink" },
                values: new object[,]
                {
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Player1", null, "" },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Developer1", null, "" },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Developer2", null, "" },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Moderator", null, "" },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Player3", null, "" },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Player2", null, "" },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Developer3", null, "" },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Admin", null, "" }
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
                values: new object[] { new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"), new DateOnly(2025, 8, 7), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), 10.0 });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("07e4bf0a-173b-4aff-93e8-542b8e689574"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("0a86cc5d-09df-4632-8e45-baf2f640c9e3"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("0d782718-e5ed-4035-bd3c-352bab5d06ca"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("12116013-72c1-46d7-825f-1163e44f9cc2"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("14f28e5e-0c88-4222-9120-fbec388f31ee"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("19b8ab7a-17fd-4b6d-a256-665610105c02"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("1d4f4239-aa0c-44fc-9af6-fd008a902ed2"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("1d8828b6-a78d-4380-9462-e9bec30f34e7"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("21beec72-53db-4161-a855-543cbbb8ab6e"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("2212b056-b7e1-4bd4-a258-aae3e24f9a87"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage1.png" },
                    { new Guid("271d2525-2643-4a9a-8b61-b5ca82cb0647"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("2dda2af6-e0cd-43f0-beea-0fd72b33a2d4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("2f7fb15e-7ebb-4236-80c8-dac54a45e918"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("30d586e3-8e6d-4546-a8cd-299fb3654494"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("33d19987-69aa-4bf7-a4f5-3ae00e244624"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("396cf491-b737-4983-a65e-42ecd36080d7"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage2.png" },
                    { new Guid("3e3724d5-c2cd-4f69-825c-02a52adb3a7a"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("4af46748-c350-4d7f-85bd-74b877197972"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("516d232d-42f7-4390-af05-9bad82dc2e20"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("51edc2ab-1622-4bdc-b319-d867d7337599"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("5a1fcd13-6cea-4c4b-ac82-fb6f632dce79"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("5b562af5-ec76-489a-a4a3-15ac28933b39"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("5c2b70cd-0bee-44e3-9bdc-6211cd5d84e5"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("62450290-0546-4ec2-9987-96d3cb5793e6"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("63bb9f37-adcd-4d88-bd72-47007b03ee70"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("6ba879dd-fd40-458a-bed2-6500bcb73aac"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("6bf37632-c9f2-45a7-b0f5-f02a1f75818d"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("72785c8c-8dba-478f-aee9-b7dbd1a5441a"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("7bec971b-9a41-42bd-a941-b1318ef262ba"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("7bf730ec-0947-4a4a-8652-8da78eaba06c"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("7fa98d4c-ae51-424e-82e4-a0e6fe2736f3"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("81738026-cd42-482c-a692-f080a6fe9240"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage4.png" },
                    { new Guid("836148c3-f21d-456d-9322-347b45a6a475"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("85f34486-8933-40d9-9024-c523c61ba9c7"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("88af137e-e887-467b-b50f-1563c12b97ef"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("8a0e24c3-1c23-4f05-b927-588e575a80bd"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("8b421630-a199-4fb2-a5c9-e8858da2a807"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("90f57ede-dc49-41f9-a002-8904376182a9"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("92d0933e-bd03-46e3-b010-95e9fec750fc"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("9345bfca-9b7e-4f99-95c3-44674b58c037"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("9e8d3a30-ee95-4591-b50a-34be844fb9fd"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("a0ddf991-d595-447b-8c5c-b57daca5833b"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("a56b4ce4-738a-4399-9e0f-877218290db4"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("a66ac83d-d1c4-47c6-a898-8ddbf81dc226"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("b95b0e14-9a09-4171-860f-fc5ca2fefb10"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("bbf6cfbc-4db8-40bd-b344-a0a897c5099d"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("bf6b9f30-fe8a-4bcc-851f-feb1f3732216"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("c1f34f0a-9202-421d-ac70-033a1afc03cb"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("c2862cd9-7e3d-489f-876b-c99ffec969cb"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("c4c1ef28-4708-4729-aa33-be18fa2df103"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("c84cee08-9bf2-4724-9b88-be18dd2d5686"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("c95a3814-ff3f-4443-851d-155bd56d1531"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("cb833a1e-8d3c-44be-adb5-a99b844bb032"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("d3e36747-a19a-41ff-b8a1-1c274e378dab"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage5.png" },
                    { new Guid("d6e86c0b-c184-4b16-98e6-27b185f72dab"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("dc5e81ec-24b6-4109-ba9f-e9de4ad9a855"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage3.png" },
                    { new Guid("df518d90-7870-4224-b1e9-02f991964cc5"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("e2c4b5af-0094-4849-b541-d5230bede178"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("e30e7a65-2369-405b-8f12-df20d2f430fa"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("e6f2b34d-75e6-42ec-b10e-bde05066c6f3"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("f48bf7bb-28fc-4e1e-94a1-d13ddc6c678d"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("f491e4ff-2564-43d5-81d6-fd74d16c2734"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("f4ad0d8e-b259-470a-99b2-9181aab90e31"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("f8c15145-b618-45f9-b678-b819d9962f95"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("f9cdbad5-fbaf-4eff-8ecb-c10a8bb53b5e"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("ff567793-606a-4a27-988c-4cfb351ce281"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("fff092ea-4abd-4494-9e99-895b6fd23cfe"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" }
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
                    { new Guid("02edb248-bff2-4a67-bdbd-2c4671f1a777"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("09f3dfe1-c1a5-4015-a749-432349be9077"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("35bd4f24-c039-4002-9a2a-22e8cfa07c56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("387cd17a-b406-469d-9037-623c886fed2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("39827d89-4c8e-4afd-968e-6d727ec52167"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("491e1c5c-e2a2-45db-91a2-1db2bcab5ac6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("4d58eee0-d225-468a-89cd-d4205672de77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("5dd12209-2df6-4f52-be7c-4209532f362f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("61c05d72-c393-4d32-9c26-609b487bc6fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("64c997f5-1988-42d5-ac48-e6f58350802d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("6aae7d96-ce83-47d5-9ba2-b9b7c322094e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("6deb758b-00e5-47ad-a085-5743ad18ed2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("70bef0a1-c6f3-4c32-92ce-633ea5c08d2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("7cf6505f-5fee-4e31-a357-360a1123ccd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("9421e019-e53c-4977-a11a-bcd4cc777e7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("9be891f4-63d7-4c85-b4cb-a56e0c98db5f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("a8333bd6-2fe7-46d6-93f2-cea1d4ca1555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("c81fbfbe-d948-49a1-99aa-f9438e00614c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("cde80f4d-163d-4bed-90e5-9c4d2ad11592"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("d75e5961-287b-4e8b-86fe-6547974e7616"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("da507fb0-58bd-40a4-8c72-cdf5fff131a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("f0615184-09a7-43e5-bbb0-65b203034221"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("fb40362e-6a33-4096-a611-910962662752"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("fc190397-6c71-43af-9ad9-e33c9bed13c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("fd0a2843-51c6-4705-9e16-9f97fe1421ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" }
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
                    { new Guid("22ba5ff3-f981-40b7-a866-5214f656d191"), "This game gives me a cozy vibe", new DateTime(2025, 7, 28, 2, 15, 3, 202, DateTimeKind.Local).AddTicks(6017), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("30c3fead-1b24-497d-a1bb-41602d654fdb"), "This game is good, but it has some bugs", new DateTime(2025, 7, 28, 2, 15, 3, 202, DateTimeKind.Local).AddTicks(6020), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("44eb3875-4501-49f9-af5d-caab5f760214"), "This is the best game I have ever seen", new DateTime(2025, 7, 28, 2, 15, 3, 202, DateTimeKind.Local).AddTicks(6011), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
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
                name: "IX_CommercialRegistration_CommercialPackageId",
                table: "CommercialRegistration",
                column: "CommercialPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CommercialRegistration_GameId",
                table: "CommercialRegistration",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_Code",
                table: "Coupons",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_UserId",
                table: "Coupons",
                column: "UserId");

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
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId",
                unique: true,
                filter: "[CouponId] IS NOT NULL");

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
                name: "CommercialRegistration");

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
                name: "Coupons");

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
