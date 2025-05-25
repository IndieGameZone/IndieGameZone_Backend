using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameInfos_Games_GameId",
                table: "GameInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguages_Games_GameId",
                table: "GameLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatforms_Games_GameId",
                table: "GamePlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTags_Games_GameId",
                table: "GameTags");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c062f75-7d54-469f-a427-e614209358bf", "AQAAAAIAAYagAAAAEHHUiSkzRznkuZ/6fP5epzLNPVBSnbswB3WLxaY+kRfEbxvHFW7ktCVVTUStqkuVcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f00ea67e-6b8e-4fe9-81ea-db3425bbd001", "AQAAAAIAAYagAAAAEDV9vQiJhNVSOdZYDYcw/YvEakDBLeo7GXhOQFM6am9jvLxHv12xPVzjupW9VakPow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "c5968285-ba3d-4658-a890-01301b0337f7", new DateTime(2025, 5, 25, 15, 54, 52, 672, DateTimeKind.Local).AddTicks(7490), "AQAAAAIAAYagAAAAEKmIJaMO6SL93hiqqGVsxYnOQlW0qbr0F0zCz7ogC3+tGf8XnlnZ1hiXtSKnW27foQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "d158855c-f1e8-4a70-9cf3-834d9183a93f", new DateTime(2025, 5, 25, 15, 54, 52, 611, DateTimeKind.Local).AddTicks(2291), "AQAAAAIAAYagAAAAEA9nozeDQXQBMsjdyfYjh4jQ2kEvb+YQLsBxDbJh+xJFp7MFIVwVjxrs3yIPoaW+ng==" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 25, 15, 54, 52, 596, DateTimeKind.Local).AddTicks(9084), new DateTime(2025, 5, 25, 15, 54, 52, 596, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.AddForeignKey(
                name: "FK_GameInfos_Games_GameId",
                table: "GameInfos",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguages_Games_GameId",
                table: "GameLanguages",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatforms_Games_GameId",
                table: "GamePlatforms",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTags_Games_GameId",
                table: "GameTags",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameInfos_Games_GameId",
                table: "GameInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguages_Games_GameId",
                table: "GameLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatforms_Games_GameId",
                table: "GamePlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTags_Games_GameId",
                table: "GameTags");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0424f3b-5ed7-40bb-bd8c-c6f1b1c80333", "AQAAAAIAAYagAAAAEF2EwesYBrs4rPZqAZ27hkkU/SRfhNyHRgRkXQblvD9eWnUlKehdqUT+9xaGkG1xEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f6c1cf1-3377-40bd-ab02-e323628bbd52", "AQAAAAIAAYagAAAAEPkcPeFcwcq27/3d2Uqw5dTRMexD4799PoDUYDf05k6BrpHc3cXGDjBVEmG1elMdYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "fa64c6be-00b8-4d57-bb79-0239b39d7167", new DateTime(2025, 5, 25, 15, 50, 50, 563, DateTimeKind.Local).AddTicks(31), "AQAAAAIAAYagAAAAEKyk+rTJXqobSxv/ij+PrXJAWYCpRn7+wEskvd5G2epiSH8f//WuIFYJcFt9Y7ldow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "4d3ea10a-e66a-4097-9509-820e3c9dae1c", new DateTime(2025, 5, 25, 15, 50, 50, 505, DateTimeKind.Local).AddTicks(8600), "AQAAAAIAAYagAAAAEOpx9qFh9qviEXrBxF+2lCkK/TB7yaMCod2ihbhWdnuFmutDJmYwnP2A0/1KFZYgWg==" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 25, 15, 50, 50, 493, DateTimeKind.Local).AddTicks(1416), new DateTime(2025, 5, 25, 15, 50, 50, 493, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.AddForeignKey(
                name: "FK_GameInfos_Games_GameId",
                table: "GameInfos",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguages_Games_GameId",
                table: "GameLanguages",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatforms_Games_GameId",
                table: "GamePlatforms",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTags_Games_GameId",
                table: "GameTags",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
