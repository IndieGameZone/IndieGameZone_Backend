using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFromGameInfoToGameImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameInfos_Games_GameId",
                table: "GameInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameInfos",
                table: "GameInfos");

            migrationBuilder.RenameTable(
                name: "GameInfos",
                newName: "GameImages");

            migrationBuilder.RenameIndex(
                name: "IX_GameInfos_GameId",
                table: "GameImages",
                newName: "IX_GameImages_GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameImages",
                table: "GameImages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2403de55-751c-4b1b-86da-47f8c3e14e66", new DateTime(2025, 5, 29, 14, 15, 59, 608, DateTimeKind.Local).AddTicks(8079), "AQAAAAIAAYagAAAAEHYMHo9PBcbpu6kS3B8RqC6J0VeLJUGI7O6zhmHZBUA/bSoPLzOAy6z06QCT1rryPg==", "afa3d5d3-eb15-44f3-9507-fada2cb3d46a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f140e30-97be-4db2-8b4e-7073dddc1d3a", new DateTime(2025, 5, 29, 14, 15, 59, 663, DateTimeKind.Local).AddTicks(2747), "AQAAAAIAAYagAAAAEM2XXvghrW4goQr2OuZ6Yb2mX3CYak2nTU+TUdTCImWfXv4Ehwx6Ny2OkCjooo3zYg==", "1129473b-f42c-468d-86ae-c19ef860519f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354dd748-5e9f-4071-82e0-fb207c2363eb", new DateTime(2025, 5, 29, 14, 15, 59, 728, DateTimeKind.Local).AddTicks(6898), "AQAAAAIAAYagAAAAEIMnGrbY0SG+W7mI/wkEYJKb79dnCCru23j5+YoPyxrHqhAZbX+MUc5PqlwRFojxEA==", "7ec1a8d3-3928-4046-bd49-a2f9c9cecb56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6075551-5805-43df-ab4e-e3ba1d1d27eb", new DateTime(2025, 5, 29, 14, 15, 59, 553, DateTimeKind.Local).AddTicks(7292), "AQAAAAIAAYagAAAAEJbF2mKswor0O0e/H8eJUEZutKQ6ubN0XchFdwCN9F4Ia1Os0YRC01sO3I2jUsVRDQ==", "6ef48d7b-d548-46ad-8b3a-a752dabc81de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b3bf7b-31b3-46ec-8dc1-6810b7376869", new DateTime(2025, 5, 29, 14, 15, 59, 789, DateTimeKind.Local).AddTicks(4863), "AQAAAAIAAYagAAAAEDQvD/OfEgp74hFPULony2hMe8o3Brk819xH0Bhl/XvoFyK38hvnM7H75yFO+Mebpw==", "48935f26-8c06-4e4c-a160-0206bba6eeca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058f9ec1-8185-4ead-82a0-edbc91ed7e37", new DateTime(2025, 5, 29, 14, 15, 59, 498, DateTimeKind.Local).AddTicks(1017), "AQAAAAIAAYagAAAAEA9iVGOiJHrbTCGcj5iova8fqJc2yDFI8qUaIqEaGYbrxHfcLvKsQXHhgMz5pb6Sxg==", "99728d77-eb4e-4f36-af92-980ef9dd38b1" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 8), new DateOnly(2025, 5, 29) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 5, 29, 14, 15, 59, 483, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.AddForeignKey(
                name: "FK_GameImages_Games_GameId",
                table: "GameImages",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameImages_Games_GameId",
                table: "GameImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameImages",
                table: "GameImages");

            migrationBuilder.RenameTable(
                name: "GameImages",
                newName: "GameInfos");

            migrationBuilder.RenameIndex(
                name: "IX_GameImages_GameId",
                table: "GameInfos",
                newName: "IX_GameInfos_GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameInfos",
                table: "GameInfos",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66603482-a9c1-4d3b-8b11-7af5647523d9", new DateTime(2025, 5, 28, 21, 42, 38, 898, DateTimeKind.Local).AddTicks(7856), "AQAAAAIAAYagAAAAEASwNrPvgFx8EPQQ9pNF3fJmIAvKnxgOOlf2rQqXNVFQMCo9MoA7rpxiwKk8Nd26lg==", "8b412446-0f4e-4db6-861c-1b0bbb16a131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f6c68f2-de9d-4bc3-afa7-1fd93ccf7eda", new DateTime(2025, 5, 28, 21, 42, 38, 963, DateTimeKind.Local).AddTicks(9112), "AQAAAAIAAYagAAAAEK2hKPy8sIdNYUxlrdEZWDa3256LGkUDvQOvxIpiilA/8NnJ+uuMUSRp5zG9KEsbpg==", "26dd4cb9-73eb-4070-a26b-409081f2bf69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c3c53af-6f9e-4b09-ba20-48ad1835aadc", new DateTime(2025, 5, 28, 21, 42, 39, 27, DateTimeKind.Local).AddTicks(9716), "AQAAAAIAAYagAAAAEEBSCkaITsokEF2N2Ct/wPv91Ejbfwjqbg0ZBjinCTvX/yL2g7EEhfAYpOBBHieq3Q==", "36eec191-83bf-4a8a-ab9d-917d5a6a543e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63fad390-42b5-42ec-9d66-cc9d9bbb39e0", new DateTime(2025, 5, 28, 21, 42, 38, 803, DateTimeKind.Local).AddTicks(7231), "AQAAAAIAAYagAAAAENZT+RjpA64eKInbQi7QL8EetBFqOXUMXgCk+l9elV8/AcHR9MEj4ySRjYDHx5AsSQ==", "07712a85-f256-4a69-8d9e-4f499ee8a4b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2caa0869-0a27-44ea-9b67-dbc5ee77f11e", new DateTime(2025, 5, 28, 21, 42, 39, 110, DateTimeKind.Local).AddTicks(935), "AQAAAAIAAYagAAAAEKT8gNj12ZOUeGxu0ctC7ZbR2r84xhhYRFliIx1RwsZW4VljjHSP4ro0Qr8ZHF31LQ==", "349aca66-a563-42bf-b1ee-42db3d952be1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38bef736-aee6-4a01-a991-ffbb0938cef6", new DateTime(2025, 5, 28, 21, 42, 38, 678, DateTimeKind.Local).AddTicks(5537), "AQAAAAIAAYagAAAAEMOloYxwY56KQYbQC8OCd68i6jNWOgWWdJX6q74IRxE6FfahXv27vK4qd6lXCAvEMA==", "e2729ca3-5f93-443b-a69e-f93b83c4ad21" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 7), new DateOnly(2025, 5, 28) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 5, 28, 21, 42, 38, 663, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.AddForeignKey(
                name: "FK_GameInfos_Games_GameId",
                table: "GameInfos",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
