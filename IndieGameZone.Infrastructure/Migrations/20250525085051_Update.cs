using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AgeRestrictions_AgeRestrictionId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games");

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
                name: "FK_Games_AgeRestrictions_AgeRestrictionId",
                table: "Games",
                column: "AgeRestrictionId",
                principalTable: "AgeRestrictions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AgeRestrictions_AgeRestrictionId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6fbbd0d-fb64-48f5-ad9e-c32eebc5f1ea", "AQAAAAIAAYagAAAAEDROM3G/WOKatDc2kP6DtBjXR94nLgI7/6Aj12LThgXnfJyXmFftqP2FRkpO8aAoBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50b9d501-1d78-4b7d-b321-a584682e856b", "AQAAAAIAAYagAAAAEJdOeRsNHCYKpaKmn6KRvsbIwfief4NS5HdPYtU2M8npMrFT2IriW5iltCIah/i3eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "06ae0a28-0567-4e58-95ba-7925b475d745", new DateTime(2025, 5, 25, 13, 46, 32, 931, DateTimeKind.Local).AddTicks(7875), "AQAAAAIAAYagAAAAEDu/UUId8RG9v5oqilO+yEUnBCYPYCgRDWMd5QJHLh/8/IAb50sR9lamAtRtAXhXMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "f644e443-8573-4f60-a75b-dcc9d4c08311", new DateTime(2025, 5, 25, 13, 46, 32, 872, DateTimeKind.Local).AddTicks(4170), "AQAAAAIAAYagAAAAEONzGRVxB3pTscvGjS8hLkQMSDyJ7r4YguhzZ1k2siQ8ECMsZJS62ZDmPGdYT3rL8g==" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 25, 13, 46, 32, 855, DateTimeKind.Local).AddTicks(4771), new DateTime(2025, 5, 25, 13, 46, 32, 855, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AgeRestrictions_AgeRestrictionId",
                table: "Games",
                column: "AgeRestrictionId",
                principalTable: "AgeRestrictions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
