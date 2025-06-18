using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    Duration = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BanHistories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
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
                    FollowingUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollows", x => new { x.FollowingUserId, x.FollowedUserId });
                    table.ForeignKey(
                        name: "FK_UserFollows_AspNetUsers_FollowedUserId",
                        column: x => x.FollowedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFollows_AspNetUsers_FollowingUserId",
                        column: x => x.FollowingUserId,
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
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallInstruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowDonation = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CensorStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    NumberOfDownloads = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CensoredAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AverageSession = table.Column<double>(type: "float", nullable: false),
                    AgeRestrictionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeveloperId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CensorReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_Games_AspNetUsers_ModeratorId",
                        column: x => x.ModeratorId,
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
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
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
                    DisplayName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false)
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
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CensoredAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderCode = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
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
                name: "WithdrawRequests",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageProof = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTransfered = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawRequests", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_WithdrawRequests_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
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
                    ReportingUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_ReportedUserId",
                        column: x => x.ReportedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_ReportingUserId",
                        column: x => x.ReportingUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d8f0c15-cdb8-4f99-a84e-d749474f9f98"), "Comment 500 Times" },
                    { new Guid("0f7b9b0f-f527-43cc-92f1-92fe4d03d09d"), "Omniscient (View every game page)" },
                    { new Guid("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"), "Like 50 Posts" },
                    { new Guid("187f58aa-ecc1-4e65-9b76-f3fe37213ae3"), "Wishlist 500 Games" },
                    { new Guid("1a7902b5-b931-4050-a0bc-4df6bbd0b2a1"), "Philanthropist (Gift 10 games)" },
                    { new Guid("1fc7e4c8-6a14-4b10-a54f-28c14a5bfae4"), "Early Adopter (Joined at launch)" },
                    { new Guid("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), "Comment 100 Times" },
                    { new Guid("24e0f221-e9a0-4c4d-a71d-1ed16ad6d36a"), "Wishlist 100 Games" },
                    { new Guid("2d3fcb09-5a7c-4268-9d86-248eb28a166d"), "Like 500 Posts" },
                    { new Guid("348ea355-5d52-4120-8794-b9022b4d3172"), "Wishlist 250 Games" },
                    { new Guid("45a6e417-48aa-4ad8-8b89-0bc72c4edb62"), "Ultimate Streak (365-day streak)" },
                    { new Guid("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"), "Post 100 Threads" },
                    { new Guid("5291fbd1-9926-4904-92bc-7f36c738c189"), "Post 50 Threads" },
                    { new Guid("52cb47a2-2d10-4662-a36d-4f3fefca498b"), "Complete Profile (Fill all fields)" },
                    { new Guid("56e5cd8d-2d46-45dc-9006-f71920beea40"), "Buy 10 Games" },
                    { new Guid("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), "Follow 100 Developers" },
                    { new Guid("61a86ea6-3db1-4a99-afe8-dbd178470cc2"), "Wishlist 50 Games" },
                    { new Guid("6a95c38c-e765-4a9b-9adf-d640eeedb214"), "Buy 500 Games" },
                    { new Guid("6b8a7ab1-bb17-4958-91c6-ff6d7a2ea880"), "Streak Master (30-day login streak)" },
                    { new Guid("6e1ea6cb-8d1d-4b4b-9316-195270d92c0f"), "Wishlist 1000 Games (Platinum)" },
                    { new Guid("6fc5791d-b726-41df-b524-d5286f316d69"), "Bug Hunter (Report 10 bugs)" },
                    { new Guid("70e2f6b1-b748-4ce7-8b71-84995c37cd3c"), "Like 250 Posts" },
                    { new Guid("72b6b5e2-bff5-49ec-9770-b7a0bfa452f8"), "Critic (Write 50 reviews)" },
                    { new Guid("79447ee2-7653-4b48-90db-8c4a607b9db9"), "Legendary Tastemaker (Get 1000 likes on a post)" },
                    { new Guid("8232bff1-9cc1-4b1d-aabd-03cf0b3b2448"), "Post 500 Threads" },
                    { new Guid("8d1c8d65-2d84-4c86-a5b1-16de0aee3a34"), "Follow 1000 Developers (Platinum)" },
                    { new Guid("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"), "Like 10 Posts" },
                    { new Guid("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"), "Buy 50 Games" },
                    { new Guid("9e9c76d3-8d24-4f14-aaf1-c85cbb20c29d"), "Reviewer (Write 10 reviews)" },
                    { new Guid("a67ae3f1-e9fd-47cd-bc80-9a51753f52f1"), "Wishlist 10 Games" },
                    { new Guid("a76b7914-3d28-4bb9-8a6e-96f3953447e3"), "Comment 250 Times" },
                    { new Guid("a94e99cb-9a99-4d4f-879b-4fa2f4b8a4c7"), "Buy 1000 Games (Platinum)" },
                    { new Guid("ae30b8aa-cf63-474d-b42c-9b8e4479b31b"), "Follow 500 Developers" },
                    { new Guid("b0ea7c96-6d5c-4199-9029-7f04e7502f66"), "Post 10 Threads" },
                    { new Guid("b186aeb1-033f-4937-a24c-d11b1989e7e2"), "Follow 50 Developers" },
                    { new Guid("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), "Follow 10 Developers" },
                    { new Guid("bbf75b11-92d5-4bcf-8c2e-bb0c6a9b50e5"), "Comment 1000 Times (Platinum)" },
                    { new Guid("bdde7288-0ec3-4726-9760-c802f4527c45"), "Like 1000 Posts (Platinum)" },
                    { new Guid("ccae8845-7497-4cb9-9a0c-cd5102ce08f2"), "Tastemaker (Get 100 likes on a post)" },
                    { new Guid("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"), "Like 100 Posts" },
                    { new Guid("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), "Comment 50 Times" },
                    { new Guid("de08b771-763c-4e33-a97f-c627a2e790df"), "Buy 100 Games" },
                    { new Guid("e1719829-fd9f-4a14-bfe4-6d524b01300b"), "Post 1000 Threads (Platinum)" },
                    { new Guid("e4a10952-4869-499e-90f2-743ef6ad2c0c"), "Explorer (Visit all categories)" },
                    { new Guid("ec14ae35-0147-470e-a927-03b999924b53"), "Follow 250 Developers" },
                    { new Guid("ee7743cf-fdb3-4abf-85b1-9fa84b33fd06"), "Top Fan (Like 100+ posts in a month)" },
                    { new Guid("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), "Comment 10 Times" },
                    { new Guid("f9d84647-6f77-4684-a39c-f5e671c181a1"), "Post 250 Threads" },
                    { new Guid("fbdc5b33-eef1-42aa-897f-e8f7de9f3179"), "Buy 250 Games" },
                    { new Guid("fef0c70d-cf7b-4c90-9865-383e660fda8a"), "First Purchase" }
                });

            migrationBuilder.InsertData(
                table: "AgeRestrictions",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { new Guid("32d6d768-d670-4ef5-acaa-fcfe4c8167d3"), "PEGI 12", "May contain violence of a more graphic nature towards fantasy characters, or mild bad language." },
                    { new Guid("3df25298-5f31-4639-a3a0-425ae4db72ca"), "PEGI 16", "More realistic violence, sexual activity, use of tobacco or alcohol, and stronger language." },
                    { new Guid("92ca7f1e-94c3-4c48-a468-61d3bab8f0b9"), "PEGI 18", "Depictions of gross violence, sexual violence, or content that glamorizes illegal drug use." },
                    { new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), "PEGI 7", "May contain some frightening scenes or sounds." },
                    { new Guid("c91901a1-1b27-4e42-9b6f-869c920b1b1c"), "PEGI 3", "Suitable for all age groups. No sounds or pictures likely to frighten young children." }
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
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), 0, "1bd3d315-71db-4b28-bfc8-c08a2dff7ee8", "player1@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 42, 982, DateTimeKind.Local).AddTicks(3073), null, null, true, null, "PLAYER1@GMAIL.COM", "PLAYER1", "AQAAAAIAAYagAAAAEKdQiLx9eC9yc6TnU8CZvvqOb7c75A0nDadDE/X1rg9YUiLBkig1SDN9be4XyC+i9w==", null, false, null, null, "c497a791-6fdc-43f9-b530-ddfb4fe51839", false, "player1" },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), 0, "884facf7-0630-41df-9387-30d23b2f9004", "developer1@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 43, 151, DateTimeKind.Local).AddTicks(1391), null, null, true, null, "DEVELOPER1@GMAIL.COM", "DEVELOPER1", "AQAAAAIAAYagAAAAENlJ9NR0pROk/wm85losNzUhNPK8WEcTLY2XRbmejWk7I2JFFE/bb0aFn826ghvg9g==", null, false, null, null, "3d723448-ae7f-437c-8585-067ed1508f8c", false, "developer1" },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), 0, "79e511d4-0d59-4643-aee9-4fb2ef0577d8", "developer2@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 43, 205, DateTimeKind.Local).AddTicks(6978), null, null, true, null, "DEVELOPER2@GMAIL.COM", "DEVELOPER2", "AQAAAAIAAYagAAAAEIWWPfEWp03LdaCCS4dzM84bBkpaafmDp6NenV2m0RoI32MS3wLDsPelPIsK8OLGvA==", null, false, null, null, "06c10d90-59c1-490d-ae8c-b14cbafe9205", false, "developer2" },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), 0, "f57adf00-82ff-4327-8e64-3b522cbb02c6", "moderator@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 42, 915, DateTimeKind.Local).AddTicks(6463), null, null, true, null, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAIAAYagAAAAEE1czk3rraZxKDEp4fj1Rp878jAbzxKUcrSXYCb4x8cyzSxKB3uJPCwhEZ++zrTYjA==", null, false, null, null, "8324dd37-ed30-4c8b-b666-89b5aab14675", false, "moderator" },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), 0, "81e32bb0-fcf3-4fa2-b1cc-eb0aff0ae2c4", "player3@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 43, 96, DateTimeKind.Local).AddTicks(8745), null, null, true, null, "PLAYER3@GMAIL.COM", "PLAYER3", "AQAAAAIAAYagAAAAEDz8EWbThCe2nH0Tz/RYRq7+MPoHY1w5XmekIw+6RUAMnkyTyxOv3OqR4khkmtRipQ==", null, false, null, null, "14ddf632-d596-421a-b8c5-d5df58016d5e", false, "player3" },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), 0, "9f7f1b00-d728-4943-a676-063345c1fc65", "player2@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 43, 39, DateTimeKind.Local).AddTicks(2140), null, null, true, null, "PLAYER2@GMAIL.COM", "PLAYER2", "AQAAAAIAAYagAAAAEPtoTAKKMM9XUQKYbvf8dIuAPV2EcB9+f8AMAS/cw5Szj9TCgPcypg+QzUvC1ZBz6w==", null, false, null, null, "8164e7e5-33ea-40f1-a38a-9cc097ebe4f9", false, "player2" },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), 0, "04241ed0-c312-4c21-a02b-5f83e20f6904", "developer3@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 43, 260, DateTimeKind.Local).AddTicks(4537), null, null, true, null, "DEVELOPER3@GMAIL.COM", "DEVELOPER3", "AQAAAAIAAYagAAAAECTeS/TaJ/d4vL1TSngei6aLtq2/QSxoiRtRFhtoJEuOyTe31QDJHcrQoEde4B0pvA==", null, false, null, null, "58ba0c70-e0fe-4476-94c2-d1e47a9084e2", false, "developer3" },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), 0, "8f55740e-e8ff-446a-b2f9-68610d8ddced", "admin@gmail.com", true, true, new DateTime(2025, 6, 19, 0, 36, 42, 856, DateTimeKind.Local).AddTicks(9313), null, null, true, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEEfvmlQHDwsZa7VIfWaKuAuu1Vo+Rlq6FryGVcTd3sCdFTPPfIfIy99B81DVGL2a4A==", null, false, null, null, "7137a402-2819-44ce-b64d-bc8739564180", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Simulation" },
                    { new Guid("3623f541-4b87-4174-bfce-dd2b027c7a33"), "Sports" },
                    { new Guid("39b71d75-ed24-461a-8dbf-e4fa9ae425fc"), "Platformer" },
                    { new Guid("4d84bb23-8644-4720-8344-d4a9d0433d35"), "Shooter" },
                    { new Guid("592e7334-c896-46f6-ad6c-a781a2ab7219"), "Card Game" },
                    { new Guid("5e1afbc9-31dd-417d-ae49-baa45d6d5797"), "Education" },
                    { new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), "Visual Novel" },
                    { new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Action" },
                    { new Guid("88fd3b90-179a-4c18-8c3a-5f3929992e0a"), "Racing" },
                    { new Guid("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"), "Role-Playing" },
                    { new Guid("929c6ef0-41e5-4bc5-9ef9-86f0703b9c20"), "Strategy" },
                    { new Guid("a5a8e1af-bbea-4029-99fe-42912e7c7ba2"), "Rhythm" },
                    { new Guid("ab34908d-20dc-43bd-b80d-eac5b59d6238"), "Survival" },
                    { new Guid("b277ba85-f89b-4617-a464-49cda6e8d387"), "Fighting" },
                    { new Guid("bca8721b-c323-44a1-afcf-876e206ab035"), "Puzzle" },
                    { new Guid("cd1fb8a2-c34e-4fc4-bbbd-9931a0c6ce0e"), "Interactive Fiction" },
                    { new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "CommercialPackages",
                columns: new[] { "Id", "Description", "Duration", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0efbfb71-599d-4233-a598-1595615810e1"), "Displays a banner on a category page for 7 days.", 7.0, "Category Banner - Weekly", 60000.0 },
                    { new Guid("4bfbc5f2-bef6-44ff-a5c4-baaff953f651"), "Displays a banner on the homepage for 7 days.", 7.0, "Homepage Banner - Weekly", 80000.0 },
                    { new Guid("854bb0e5-ecf6-4bc8-a5f7-1d9e27d27e73"), "Displays a banner on a category page for 1 day.", 1.0, "Category Banner - Daily", 10000.0 },
                    { new Guid("856314ae-b364-4d83-94ba-f11600c88cff"), "Displays a banner on the homepage for 1 day.", 1.0, "Homepage Banner - Daily", 20000.0 },
                    { new Guid("8f451273-fe64-4c67-80e9-84ee20733ddd"), "Displays a banner on the homepage for 30 days.", 30.0, "Homepage Banner - Monthly", 310000.0 },
                    { new Guid("a9758e65-b0d6-4dd1-8272-fe1f2cb4794e"), "Displays a banner on a category page for 30 days.", 30.0, "Category Banner - Monthly", 230000.0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04adfb56-cb77-4209-8fc3-a7b96b768784"), "Japanese" },
                    { new Guid("11a64feb-23f6-41ad-a55f-a9f487d04a85"), "Chinese" },
                    { new Guid("149615f6-6214-4e42-a016-1dba7d248c0f"), "Korean" },
                    { new Guid("2f98f2c8-2640-4cff-a8eb-ed61d9179dcb"), "Spanish" },
                    { new Guid("3ec80948-8c1a-46aa-9fd6-01feeb273c22"), "Russian" },
                    { new Guid("73b3d9d2-ecbf-4d91-95ad-e9a48b7e54cd"), "German" },
                    { new Guid("80e3581d-3836-4921-a838-b7d917b5e11f"), "Vietnamese" },
                    { new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527"), "English" },
                    { new Guid("ae4f3cfb-6dd6-473b-a1c6-695f9edce11e"), "French" },
                    { new Guid("ca29265a-4bab-4aa1-a819-9636878b50da"), "Portuguese" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("574cb883-e637-4f18-9518-269e4d22312c"), "MacOS" },
                    { new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "Windows" },
                    { new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), "Linux" }
                });

            migrationBuilder.InsertData(
                table: "ReportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c0d2f16-1f4a-4c5e-9c26-2e86e0cfa28f"), "Malicious Behavior" },
                    { new Guid("32992805-dcef-427a-afb8-239c79cb4de9"), "Offensive Language" },
                    { new Guid("3f36c22a-5f0d-4f02-ab65-b47a22ae81a7"), "Political or Religious Extremism" },
                    { new Guid("59eff953-9268-4488-9f2a-0ce3a5b80ac3"), "Scam or Fraud" },
                    { new Guid("77cf1c6b-bc98-4c98-8a7e-27f2c4b45377"), "Inappropriate Content" },
                    { new Guid("78e8165a-c263-4790-b0f4-21d2398c3d82"), "Performance Issues" },
                    { new Guid("7fb483f2-3499-4f56-a22f-af191fac0411"), "False Information" },
                    { new Guid("8b92d32e-0aa0-4f88-bc43-0e04c4121e0e"), "Copyright Infringement" },
                    { new Guid("a8eae5df-0705-4021-835c-75c12df9b2f2"), "Off-topic" },
                    { new Guid("b348e5d5-55ea-48ed-a5fe-b3cc56c8a7b1"), "Harassment" },
                    { new Guid("baf14634-874b-461b-b44d-3c5d261fbdc8"), "Other" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("048cbb0b-d39e-4f1d-b1d7-e28aeb6fc6e6"), "Grayscale" },
                    { new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3"), "First-Person" },
                    { new Guid("130d3ae5-7c92-4d37-9082-13226dd0d9af"), "Platformer" },
                    { new Guid("1c175c84-379e-43dc-a95a-aafd910d6a00"), "Action" },
                    { new Guid("229ef81c-f48f-49ae-a9a1-149f71d54d77"), "Showcase 🎨" },
                    { new Guid("22ad33b0-8358-4054-aa6b-59a2b5296842"), "Isometric" },
                    { new Guid("37223e27-41ad-44cb-9332-d985dbc9f708"), "Pixel Art" },
                    { new Guid("3d76f55a-a3c8-4f51-a959-6a36c90ba4bd"), "Sports" },
                    { new Guid("3e7412cc-2817-4d03-9dcf-7c3c7e619186"), "16-Bit" },
                    { new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f"), "3D" },
                    { new Guid("41c1f4f5-4cf0-411b-bb15-e59f15b04762"), "Fighting" },
                    { new Guid("46c0001e-beb3-4291-885a-f076e53f40fd"), "Survival" },
                    { new Guid("48239920-0a09-438e-8320-6b822e01f8bb"), "Two Colors" },
                    { new Guid("4d1a6086-ed27-4767-8fb6-4c4af12c384c"), "Role-Playing" },
                    { new Guid("510d85f4-c8dc-4228-93cb-311809751bed"), "Multiplayer" },
                    { new Guid("5452906a-03b1-45df-b4f0-a65398885171"), "Visual Novel" },
                    { new Guid("569a2ff2-5259-4467-9824-a3f2c5a595f7"), "1-Bit" },
                    { new Guid("611e1869-df31-4ec1-b063-7c9ae49bfb30"), "RPG Maker" },
                    { new Guid("621f12a7-89cb-4b97-83c0-cd3e84774dd4"), "Third-Person" },
                    { new Guid("62c2fe13-f1d2-4905-b3e1-166598e091fb"), "8x8" },
                    { new Guid("6cc4c52b-3b0e-4641-9997-8a1e6c29753b"), "Godot" },
                    { new Guid("71918e61-bb0b-4ca1-975a-616d869769bf"), "Puzzle" },
                    { new Guid("7cc2168e-4ad6-409f-9868-bd59df589d8c"), "Guide 📖" },
                    { new Guid("7d5d4e96-d0fa-440e-914f-1667b6ef54c1"), "Unreal Engine" },
                    { new Guid("7e3be5eb-bf83-4450-9ecb-70535267d3ea"), "Flat-Shading" },
                    { new Guid("85a1abde-9980-4cc7-976e-1d4135ffddff"), "Review ★" },
                    { new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac"), "Colorful" },
                    { new Guid("8c202501-893d-427e-9faf-47e2f1d6ba2d"), "Education" },
                    { new Guid("8db1d14f-c82c-4a06-bd60-456350a62594"), "Non-Eucledian" },
                    { new Guid("8fdfc2fc-b9ae-49a4-9aa5-e986cdf9f65a"), "Neon" },
                    { new Guid("9636813b-f393-4adb-b9a7-44f877f67ae5"), "8-Bit" },
                    { new Guid("9c685bd3-c75f-48df-8043-20c2fe181e7f"), "Watercolor" },
                    { new Guid("a0f1e28b-a439-4e72-aed8-0baddbb515c2"), "Rhythm" },
                    { new Guid("a137e663-30d5-4ed9-8aa3-b9b500f18de7"), "Card Game" },
                    { new Guid("aa580b0a-12c6-4d95-8d4f-c68fdd8cfbd9"), "32x32" },
                    { new Guid("aa592c96-400a-4c67-bf18-3b82823e9ef9"), "Racing" },
                    { new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769"), "Cartoon" },
                    { new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301"), "Singleplayer" },
                    { new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d"), "Horror" },
                    { new Guid("b6dd9e32-eaf5-4942-9c18-566421ca2e90"), "Top-Down" },
                    { new Guid("b9e9a223-25b3-491b-ba92-e185a74d82ab"), "Simulation" },
                    { new Guid("bc50196f-6aa1-49c2-9347-33f4ef15b8d6"), "Black and White" },
                    { new Guid("c04cba4a-a827-4a49-b61b-f02798ef17c9"), "Shooter" },
                    { new Guid("c7cee309-8f38-43fd-8512-e40e4d6f1ccd"), "Strategy" },
                    { new Guid("cd37e2fc-cb7e-45c3-90d6-87c690a2aaf3"), "Ren’Py" },
                    { new Guid("cd543d0f-1761-4874-945b-53863f00942b"), "Adventure" },
                    { new Guid("da2b3f32-20fc-4a62-a16f-f87fbe4696fb"), "Question ❓" },
                    { new Guid("e27b19a2-12d7-4a55-a8e4-7ff3487db712"), "Pastel" },
                    { new Guid("e4e35307-2071-4a75-88fc-579db0077703"), "Unity" },
                    { new Guid("e50d38ef-93f6-4f52-a55b-0dbf8188f91f"), "Discussion 💬" },
                    { new Guid("f3527a12-03c3-417d-9dd1-6130e7fcfe3e"), "16x16" },
                    { new Guid("f503a37e-dff0-45a8-8ae8-58ccefa4c9d3"), "Low-Poly" },
                    { new Guid("f57af0bf-7612-4b08-84f3-be98a842f932"), "Interactive Fiction" },
                    { new Guid("f8d13d4f-1a7b-406b-aa6e-4f37d8cebacf"), "Hand-Drawn" },
                    { new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b"), "2D" }
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
                columns: new[] { "Id", "AgeRestrictionId", "AllowDonation", "AverageSession", "CategoryId", "CensorReason", "CensorStatus", "CensoredAt", "CoverImage", "CreatedAt", "Description", "DeveloperId", "InstallInstruction", "ModeratorId", "Name", "NumberOfDownloads", "Price", "ShortDescription", "Status", "UpdatedAt", "VideoLink", "Visibility" },
                values: new object[,]
                {
                    { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(406), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", null, "Latestop", 300.0, 100000.0, "", "Released", null, "https://www.youtube.com/watch?v=WJKp2xT4QTs", "Public" },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(505), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", null, "Atlyss", 150.0, 60000.0, "", "Released", null, "https://www.youtube.com/watch?v=example", "Public" },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(493), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", null, "Dispatched", 100.0, 85000.0, "", "Released", null, "", "Public" },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(443), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", null, "Thunderhead", 400.0, 90000.0, "", "Released", null, "https://www.youtube.com/watch?v=c8JdCXw4l3k", "Public" },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(411), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", null, "QuietPlace", 300.0, 50000.0, "", "Released", null, "https://www.youtube.com/watch?v=gjV5Vdf04UY&t=1s", "Public" },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftCoverImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(386), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", null, "MidnightShift", 150.0, 150000.0, "", "Released", null, "https://www.youtube.com/watch?v=v1oeNEKiwTg", "Public" },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), null, "PendingAIReview", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatCoverImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(327), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", null, "The Deadseat", 100.0, 100000.0, "", "Released", null, "https://www.youtube.com/watch?v=Q4A2c8-BN78&t=2s", "Public" },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 3.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelicCoverImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(393), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", null, "Broken Relic", 200.0, 200000.0, "", "Released", null, "https://www.youtube.com/watch?v=ColSNi0XD6Q", "Public" },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 2.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(438), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", null, "Bloodmall", 350.0, 80000.0, "", "Released", null, "https://www.youtube.com/watch?v=1fYf3Rt7guw", "Public" },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(521), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", null, "TheStation", 200.0, 65000.0, "", "Released", null, "", "Public" },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(488), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", null, "DiggingHour", 700.0, 85000.0, "", "Released", null, "https://www.youtube.com/watch?v=tNoPejgMaB0", "Public" },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 0.5, new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(432), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", null, "Missing", 150.0, 60000.0, "", "Released", null, "", "Public" },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage.jpg", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(421), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", null, "Sheepy", 500.0, 75000.0, "", "Released", null, "https://www.youtube.com/watch?v=RRs_AI96h-w", "Public" },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(498), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", null, "SecurityBooth", 200.0, 70000.0, "", "Released", null, "https://www.youtube.com/watch?v=wYnJD9Pteis", "Public" },
                    { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.0, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(427), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "", null, "Daughter", 200.0, 75000.0, "", "Released", null, "", "Public" },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(477), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", null, "Evaluation", 500.0, 90000.0, "", "Released", null, "", "Public" },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(399), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", null, "Moldwasher", 250.0, 120000.0, "", "Released", null, "https://www.youtube.com/watch?v=6KGgPoY7TbY", "Public" },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(516), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", null, "Leftovers", 100.0, 50000.0, "", "Released", null, "", "Public" },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.5, new Guid("5e1afbc9-31dd-417d-ae49-baa45d6d5797"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(510), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", null, "Tomato", 300.0, 75000.0, "", "Released", null, "", "Public" },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("bca8721b-c323-44a1-afcf-876e206ab035"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(483), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "", null, "Dominoid", 600.0, 95000.0, "", "Released", null, "", "Public" },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), null, "Approved", null, "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(416), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "", null, "Pacside", 400.0, 75000.0, "", "Released", null, "https://www.youtube.com/watch?v=yxt7w5VRQ_w", "Public" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "UserId", "Avatar", "BankAccount", "BankName", "Bio", "Birthday", "FacebookLink", "Fullname", "YoutubeChannelLink" },
                values: new object[,]
                {
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Player1", "" },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Developer1", "" },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Developer2", "" },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Moderator", "" },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Player3", "" },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Player2", "" },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Developer3", "" },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Admin", "" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "UserId", "Balance" },
                values: new object[,]
                {
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), 0.0 },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), 0.0 },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), 0.0 },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), 0.0 },
                    { new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"), 0.0 },
                    { new Guid("91b106fa-7b95-480f-a12a-0e0303454332"), 0.0 },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), 0.0 },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "EndDate", "GameId", "Percentage", "StartDate" },
                values: new object[] { new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"), new DateOnly(2025, 6, 29), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), 10.0, new DateOnly(2025, 6, 19) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0c33b840-96ec-4429-9686-d839ed2e542a"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("0cc51e80-b68e-4aac-bc76-bddb00fdbdc8"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("1a53aabc-9fd3-4788-8cc2-e5b9c9e2f813"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("1af494c7-fdb4-4825-9dee-4cab4b45b0b5"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("1ff9e42b-6926-4339-87ce-183ec3b44a20"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("212642c2-cae8-4c11-b933-47ff67e6384a"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("2212b056-b7e1-4bd4-a258-aae3e24f9a87"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage1.png" },
                    { new Guid("23bc9d9c-a27d-4cbe-bd06-b016a53ae044"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("2a4a96ad-a20c-4ee3-89c8-a4ae7a5de428"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("2b48a511-708d-4cdc-9b81-445aa0982cfc"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("2e491688-262b-4de0-bde7-ecc1adf58003"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("30b2fcf8-ab80-47b3-b1d8-acfda11717b0"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("36a9b8af-c2db-4948-af77-f6d1c784e5f1"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("396cf491-b737-4983-a65e-42ecd36080d7"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage2.png" },
                    { new Guid("42f9787a-f782-4d28-b91e-83d0c61a981c"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("44425553-948a-49a8-b581-898febbd7c4d"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("4c73ef8b-3e3e-4c32-8fb3-59ad22a9c131"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("503e4434-0a06-4ed3-95a5-bdab614eacad"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("52d06485-6b43-40c7-b10f-bbf216a2395f"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("56115c5b-b418-4cae-a1ba-0ecdf8d00205"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("58490e1b-54b3-4244-8c66-18c560594798"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("58e6c4db-8019-49f2-ae9f-2ddc9ce8e2f1"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("5ad92a08-60ef-4a64-8bb7-c08886f03a54"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("5c2a79e1-c91c-4ad9-8eaa-0b5f903323f9"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("6081d186-b63d-498b-b82d-f0cce35e7159"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("674b9f66-0ff5-4b5e-b642-c34be150188a"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("720a3dd4-62f8-4a8b-bb58-70f20868085d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("74c012b5-6043-454c-bc38-411dc75b5f8a"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("77684486-63de-4704-aad0-71b3fc75e5d2"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("7b6dec73-b9e4-4f24-82bb-190e58e843d8"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("7cc64dcf-cd64-41b6-8876-fd70e3ea2d0f"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("81738026-cd42-482c-a692-f080a6fe9240"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage4.png" },
                    { new Guid("872b3d45-d5e9-42c3-a41c-58460e2a3295"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("8812de48-8282-425a-b86f-067e363fe35c"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("8b34ae67-9e81-42cb-97ff-1b0fd687a776"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("8c026dea-8d38-4456-8dee-b7baff6abd03"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("974b5cca-0f56-4c96-8200-3155288ed56f"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("97f246b6-3ce6-4e56-95a2-531a5c564a75"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("9d4d7d96-5e88-4e3f-acdf-9b1e59c416e5"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("a0a3975a-7b98-40e2-bd73-dc65c13668a0"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("a1057a28-b15a-40ef-bd8e-45158e309b65"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("ab011f3c-20de-486e-95f6-0b8271076696"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("b2bd1387-4dbd-43b6-a2ff-1db2350fc484"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("b6c34be7-8f01-4fdd-99f5-2e5f2c5f28a4"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("b71825ad-e1cf-45f5-a253-393e54fa8aed"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("b7e97a66-a197-44dd-af9c-b015c4a12485"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("bc412cff-4c90-4de9-bb3e-1f72c9ed3f40"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("bc610ea9-5241-49ee-b6f8-c6d65b6e96d7"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("c18f53ff-eda1-48e5-92e5-36a175a253bd"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("c3f5185b-0af4-45f3-afbb-fc4bcb34011b"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("c678fa48-8914-49ab-9835-de076f6af6d8"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("d3d42f9a-bd2f-40c7-99ad-90a6a5baa6aa"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("d3e36747-a19a-41ff-b8a1-1c274e378dab"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage5.png" },
                    { new Guid("dc098177-29ef-4ed0-a421-2c3b0203c328"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("dc5e81ec-24b6-4109-ba9f-e9de4ad9a855"), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage3.png" },
                    { new Guid("dc9a66c2-3f84-4bd5-9f5c-8ed7622c4995"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("e0f5ce3e-3160-4da7-9a22-96b7e1428da1"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("e54d9cfd-edc3-43a8-aeea-fabea00326aa"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("e69c71dd-9f6a-4fe0-8ff8-6e07d2787297"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("e7804d4c-4cb7-4aea-9a5e-769cda35652d"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("eb1fc14f-b7d6-4b49-a462-a3ab349e5b24"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("ef145df5-963f-4827-ae62-2d45e444ae01"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("f5e66f17-03cb-4298-8b59-1ae58d9cff51"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("f647e38c-08d7-4f74-8c8b-be7299b68060"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("f8e0457c-605e-4b1d-bc26-32a8038af105"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("fbbb52e4-a0a8-4126-b37b-45d4674ed7e9"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("fbe67754-a88c-48bb-9b78-b0b50d26661f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" }
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
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("0d87b841-dda7-42ae-927f-d53fefe6677b"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("29e21cfc-222d-4190-afb9-6682c6eb048c"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("2a43f336-ec20-450f-b578-0ef3944180aa"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("327265ab-d951-4325-9250-562498cebc7d"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("34e52c42-93c4-4b34-a6f1-42b6366af81d"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("3b95c6bc-88f0-4b70-a8d4-3d729d0b3487"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("49c8e7cd-3671-41da-9ae8-798f3552c189"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5038a4ad-1ac1-4ac3-8286-a06ac0e3e2e8"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5b19f130-01a5-45d0-9544-45c3001446a0"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("6494837a-b101-4855-a4f6-b08f6f965a21"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("6e20a0e3-b7d7-4181-9651-d3f89567d5c7"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("76219ad7-87dc-4265-bf94-bf90db13f211"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("7c4451d6-5f57-442a-81e7-06ac88fcd419"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("7f17e58b-f17e-4803-8754-4ede3c9a2e44"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("8c0b4bac-9f7e-49ea-a4e3-0e33cb532dce"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("963f945c-c5f9-473c-95c1-437d2b3bc440"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("a4fe0f85-3cb0-4dd7-ad51-11e6c39484cd"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("b292d756-bbd4-4b27-8033-b522eaaea666"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("c670c5d8-1f1a-4131-b8cb-e0a42fc9d7e8"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("caa390b7-b9aa-4165-9c3b-4d63054eaea0"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("ce6e5b1f-3f4c-42bd-a1e4-0cde2bdd4832"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("d3a29e8a-c8b3-4f88-bf7c-94a36976024d"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("d9ffc2eb-7bb9-433e-9e4e-b53b55139c99"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("dee057bb-e1b0-43ca-abba-b5b428413d86"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("e88472af-f79b-404d-a8bd-a8723d0f4095"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 }
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
                name: "IX_BanHistories_UserId",
                table: "BanHistories",
                column: "UserId");

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
                name: "IX_Games_ModeratorId",
                table: "Games",
                column: "ModeratorId");

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
                name: "IX_PostComments_PostId",
                table: "PostComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_UserId",
                table: "PostComments",
                column: "UserId");

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
                name: "IX_Reports_ReportedUserId",
                table: "Reports",
                column: "ReportedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportingUserId",
                table: "Reports",
                column: "ReportingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportReasonId",
                table: "Reports",
                column: "ReportReasonId");

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollows_FollowedUserId",
                table: "UserFollows",
                column: "FollowedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_UserId",
                table: "Wishlists",
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
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Discounts");

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
                name: "PostReactions");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Reviews");

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
                name: "CommercialPackages");

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
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Posts");

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
