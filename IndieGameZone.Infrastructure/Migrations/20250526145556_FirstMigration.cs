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
                name: "GameStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStatuses", x => x.Id);
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
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AverageSession = table.Column<double>(type: "float", nullable: false),
                    AgeRestrictionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeveloperId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Games_GameStatuses_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawRequests",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageProof = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "GameInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameInfos_Games_GameId",
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
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatforms", x => new { x.GameId, x.PlatformId });
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportingUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Reports_ReportTypes_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "JoinedDate", "LastLogin", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("23879117-e09e-40f1-b78f-1493d81baf49"), 0, "6e296b74-89e4-45ed-819d-de2f2eed30d4", "player@gmail.com", true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "PLAYER@GMAIL.COM", null, "AQAAAAIAAYagAAAAENk7BzLLBUvAx59XqY5mWdttXURPsIc3xTNG5ZwvA/YwRSuKuoOyWobZ1pYP5RQydQ==", null, false, null, null, null, false, null },
                    { new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), 0, "0716dfc2-eb76-44a2-b73b-6492d112a615", "developer1@gmail.com", true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "DEVELOPER1@GMAIL.COM", null, "AQAAAAIAAYagAAAAEOn2rReJqgazyqpKZTzZDDOh7mAaFyxia1NTYjl9pNr98KIkptxnp0yCRsBuMVObfg==", null, false, null, null, null, false, null },
                    { new Guid("34670beb-a794-4419-adf8-0465eea22a78"), 0, "2c51e357-4785-4fb3-9f8b-505dfaf818fc", "developer2@gmail.com", true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "DEVELOPER2@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMGVr1O6mmdTU3dvemM+fv6/VRt8WnFBTBEoRHWWfZEpxvk2utHZbPhV1sNBC7d4Hw==", null, false, null, null, null, false, null },
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), 0, "1cb98a61-bacf-4067-bf37-b677fea9c750", "moderator@gmail.com", true, true, new DateTime(2025, 5, 26, 21, 55, 55, 795, DateTimeKind.Local).AddTicks(7851), null, false, null, "MODERATOR@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFEbD6hyERhvS3aPm0FSp1AjlIBBpL4H6kcGfsnoEgO/TWr6GHrBRGAonunLqRCrgA==", null, false, null, null, null, false, null },
                    { new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), 0, "b32f2135-d6e9-47ea-99b0-b050b0eab33d", "developer3@gmail.com", true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "DEVELOPER3@GMAIL.COM", null, "AQAAAAIAAYagAAAAEL/Jv9lQ7+e2E1EHY+pLutFUtjH4dpaqg+xHuYQiC7G95/Uq3zLeNsmFQkWnNuH8aQ==", null, false, null, null, null, false, null },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), 0, "35cf0360-4c0e-4072-9375-1951a5d51a77", "admin@gmail.com", true, true, new DateTime(2025, 5, 26, 21, 55, 55, 735, DateTimeKind.Local).AddTicks(2834), null, false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEF9k917m0Fi+YMtPIxYuaiY+jHuyEfXHWQvv5LClJPM/rIQs4eD2MZZPaO/mTWflLw==", null, false, null, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), "Simulation" },
                    { new Guid("3623f541-4b87-4174-bfce-dd2b027c7a33"), "Sports" },
                    { new Guid("3ef51667-ff8d-4873-979b-a3b9a5dbe1b1"), "Horror" },
                    { new Guid("4d84bb23-8644-4720-8344-d4a9d0433d35"), "Shooter" },
                    { new Guid("592e7334-c896-46f6-ad6c-a781a2ab7219"), "BoardGame" },
                    { new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "Action" },
                    { new Guid("88fd3b90-179a-4c18-8c3a-5f3929992e0a"), "Racing" },
                    { new Guid("89a4e6d2-2cfe-4474-9b96-6d3595ad4705"), "Role-Playing" },
                    { new Guid("929c6ef0-41e5-4bc5-9ef9-86f0703b9c20"), "Strategy" },
                    { new Guid("ab34908d-20dc-43bd-b80d-eac5b59d6238"), "Survival" },
                    { new Guid("b277ba85-f89b-4617-a464-49cda6e8d387"), "Fighting" },
                    { new Guid("bca8721b-c323-44a1-afcf-876e206ab035"), "Puzzle" },
                    { new Guid("dcf41a71-dd69-43db-af34-a8ca8592b079"), "Open World" },
                    { new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), "Adventure" },
                    { new Guid("fcb43570-6859-41f4-8d72-ce59a31f5858"), "Stealth" }
                });

            migrationBuilder.InsertData(
                table: "GameStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5fde9b6a-ddda-4833-a744-7fbb4d8efb3f"), "Free" },
                    { new Guid("5fef12e9-ad13-4707-ae74-7ecc23a43d5b"), "Demo" },
                    { new Guid("8097fd8b-f4ad-4fb9-93f3-6f8598cf6a4f"), "Alpha" },
                    { new Guid("92f9b646-d1db-4bd1-93ed-e5dc73ccd37e"), "Paid" }
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
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c175c84-379e-43dc-a95a-aafd910d6a00"), "Action" },
                    { new Guid("37223e27-41ad-44cb-9332-d985dbc9f708"), "Pixel Art" },
                    { new Guid("3d76f55a-a3c8-4f51-a959-6a36c90ba4bd"), "Sports" },
                    { new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f"), "3D" },
                    { new Guid("41c1f4f5-4cf0-411b-bb15-e59f15b04762"), "Fighting" },
                    { new Guid("46c0001e-beb3-4291-885a-f076e53f40fd"), "Survival" },
                    { new Guid("4d1a6086-ed27-4767-8fb6-4c4af12c384c"), "Role-Playing" },
                    { new Guid("510d85f4-c8dc-4228-93cb-311809751bed"), "Multiplayer" },
                    { new Guid("71918e61-bb0b-4ca1-975a-616d869769bf"), "Puzzle" },
                    { new Guid("72229e67-bba2-41ae-9fee-84c97d01d1fb"), "MacOS Game" },
                    { new Guid("78530cfe-1488-49ab-befb-0ee332cfe7a1"), "Open World" },
                    { new Guid("83f90ed3-38f1-40a9-88e5-8ce4a728a4a4"), "Kungfu" },
                    { new Guid("9f3617ec-c56d-4423-ad07-43c904ef6542"), "Stealth" },
                    { new Guid("a137e663-30d5-4ed9-8aa3-b9b500f18de7"), "BoardGame" },
                    { new Guid("a39f8614-3936-48cf-bb4a-01c590486bdc"), "Indie" },
                    { new Guid("aa592c96-400a-4c67-bf18-3b82823e9ef9"), "Racing" },
                    { new Guid("b92d60b0-0447-4ef2-9233-088b4d91cce5"), "Horror" },
                    { new Guid("b9e9a223-25b3-491b-ba92-e185a74d82ab"), "Simulation" },
                    { new Guid("c04cba4a-a827-4a49-b61b-f02798ef17c9"), "Shooter" },
                    { new Guid("c620e06f-49b2-4cc7-8be5-19d63e8d915a"), "Linux Game" },
                    { new Guid("c7cee309-8f38-43fd-8512-e40e4d6f1ccd"), "Strategy" },
                    { new Guid("cb631ff7-d19b-40a5-b948-a3b138703e19"), "Windows Game" },
                    { new Guid("cd543d0f-1761-4874-945b-53863f00942b"), "Adventure" },
                    { new Guid("e4cc8cbe-9b71-416d-967c-b88ad852be45"), "Singleplayer" },
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
                columns: new[] { "Id", "AgeRestrictionId", "AverageSession", "CategoryId", "CoverImage", "DeveloperId", "GameStatusId", "IsActive", "Name", "Price", "ReleasedDate", "UpdatedAt", "VideoLink" },
                values: new object[] { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), 0.5, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatCoverImage.png", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), new Guid("92f9b646-d1db-4bd1-93ed-e5dc73ccd37e"), true, "The Deadseat", 100000.0, new DateTime(2025, 5, 26, 21, 55, 55, 719, DateTimeKind.Local).AddTicks(585), new DateTime(2025, 5, 26, 21, 55, 55, 719, DateTimeKind.Local).AddTicks(592), "https://www.youtube.com/watch?v=Q4A2c8-BN78&t=2s" });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "UserId", "Avatar", "BankAccount", "BankName", "Bio", "Birthday", "FacebookLink", "Fullname" },
                values: new object[,]
                {
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Moderator" },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), "https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=6&m=1223671392&s=170667a&w=0&h=zP3l7WJinOFaGb2i1F4g8IS2ylw0FlIaa6x3tP9sebU=", "", "", "", new DateOnly(2002, 1, 23), "", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "UserId", "Balance" },
                values: new object[,]
                {
                    { new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"), 0.0 },
                    { new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"), 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "EndDate", "GameId", "Percentage", "StartDate" },
                values: new object[] { new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"), new DateOnly(2025, 6, 5), new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), 10.0, new DateOnly(2025, 5, 26) });

            migrationBuilder.InsertData(
                table: "GameInfos",
                columns: new[] { "Id", "Description", "GameId", "Image", "Title" },
                values: new object[,]
                {
                    { new Guid("2212b056-b7e1-4bd4-a258-aae3e24f9a87"), "You are in the backseat of your parent's car during a long drive. As your parents begin fighting, your hand-held game is your only source of entertainment. But the game begins to mirror real life... Collect items on your hand-held game to send them to the backseat and use them to defend against the monstrosity that's trying to make its way into the backseat with you.", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage1.png", "Steam release features Hard Mode, as well as double the story!" },
                    { new Guid("396cf491-b737-4983-a65e-42ecd36080d7"), "Your drive home from grandma's is interrupted by an unexpected detour. Play a hand-held game in the backseat as your parent's drive.", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage2.png", "SURVIVE THE NIGHT DRIVE" },
                    { new Guid("81738026-cd42-482c-a692-f080a6fe9240"), "A deadly monstrosity wants to join you in the backseat. Juggle your supplies and defend all sides. In this car, there’s only onwards to drive, and nowhere to run.", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage4.png", "TRAPPED IN THE DEADSEAT" },
                    { new Guid("d3e36747-a19a-41ff-b8a1-1c274e378dab"), "Your parents can't get along, and you can’t ignore it, no matter how deep you immerse yourself in your game. If only you could get away from it all and escape to somewhere better. And seemingly, the voice in your game says you can.", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage5.png", "THE STORY" },
                    { new Guid("dc5e81ec-24b6-4109-ba9f-e9de4ad9a855"), "Your hand-held game is beginning to mirror reality... Supplies you collect in the game will be sent to the backseat.", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatImage3.png", "RETRO GAMING" }
                });

            migrationBuilder.InsertData(
                table: "GameLanguages",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[] { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId", "File" },
                values: new object[] { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip" });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "GameId", "TagId" },
                values: new object[,]
                {
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("1c175c84-379e-43dc-a95a-aafd910d6a00") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") }
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
                name: "IX_Coupons_UserId",
                table: "Coupons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_GameId",
                table: "Discounts",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameInfos_GameId",
                table: "GameInfos",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguages_LanguageId",
                table: "GameLanguages",
                column: "LanguageId");

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
                name: "IX_Games_GameStatusId",
                table: "Games",
                column: "GameStatusId");

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
                name: "IX_Reports_ReportTypeId",
                table: "Reports",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

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
                name: "GameInfos");

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

            migrationBuilder.DropTable(
                name: "GameStatuses");
        }
    }
}
