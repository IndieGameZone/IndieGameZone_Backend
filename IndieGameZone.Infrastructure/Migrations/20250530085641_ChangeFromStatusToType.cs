using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeFromStatusToType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameStatuses_GameStatusId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "GameStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5fef12e9-ad13-4707-ae74-7ecc23a43d5b"));

            migrationBuilder.DeleteData(
                table: "GameStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8097fd8b-f4ad-4fb9-93f3-6f8598cf6a4f"));

            migrationBuilder.RenameColumn(
                name: "GameStatusId",
                table: "Games",
                newName: "GameTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_GameStatusId",
                table: "Games",
                newName: "IX_Games_GameTypeId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e803c425-b514-463e-bbd7-3684dd00890b", new DateTime(2025, 5, 30, 8, 56, 40, 904, DateTimeKind.Utc).AddTicks(9720), "AQAAAAIAAYagAAAAEMsMmbjjrOgljjoPgvJZTCS/Pj6Fz2+Jkyw3Z+W+S6C9HgyQkdvie+VP90FFl8vrZw==", "e01c7a63-c96a-4485-9fbe-02769d3e63e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b011ad71-87ae-4c95-82e3-dcf5c20f2c8b", new DateTime(2025, 5, 30, 8, 56, 40, 958, DateTimeKind.Utc).AddTicks(6444), "AQAAAAIAAYagAAAAEMU8lU0fcU3UvQwswzarUf8IrJEIPhOkSZYgXcb6vFl+j/Z3qL7J5FfK6uDCxJx/lA==", "2692ff23-b07f-4cd9-8cf3-2b3ed4f76273" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1867cf5-a777-4221-9540-641bb46083a2", new DateTime(2025, 5, 30, 8, 56, 41, 12, DateTimeKind.Utc).AddTicks(4277), "AQAAAAIAAYagAAAAEF4iSkWVnb43ZQO0VSfKaAgrPlk2kSGeAKTj0ziHIG5SMOEgt/Z8GvVbJU4aef07gA==", "04dcbe5c-9211-49d7-9a88-6afbdb484d8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a9ce1cd-91a5-4b93-8d83-70addc30fd82", new DateTime(2025, 5, 30, 8, 56, 40, 848, DateTimeKind.Utc).AddTicks(7957), "AQAAAAIAAYagAAAAEErf8Ucp3WqL1Ci4WN8aEdgIK30mLNTKTdsTbBeG3k7Lxz2E6c+OGxrY58gjPgEVKw==", "1c5a75d3-70f1-443a-97e6-1983c6c5c4f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32d08b57-a38b-4322-9de3-97353a1e0865", new DateTime(2025, 5, 30, 8, 56, 41, 66, DateTimeKind.Utc).AddTicks(4988), "AQAAAAIAAYagAAAAEMAcQ8KOG26/yKWct1SCWYZ6cGrJJk3OHpPsGBaKU8Q1vMFfnsacs+qM8ppAsOxFUA==", "490606b5-a954-45f1-b4e5-f922fc5488f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d79d140-46dd-484a-b86e-1da83c474075", new DateTime(2025, 5, 30, 8, 56, 40, 786, DateTimeKind.Utc).AddTicks(9173), "AQAAAAIAAYagAAAAEK6ft1D0oSzhMBSQ+fJkwbmFh3vKLUGWa/ur1f71DrXGqb/TJ/zu3aBspm6fXmoKrA==", "b0568da9-9b62-4767-bcf8-40894a18e524" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 9), new DateOnly(2025, 5, 30) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 5, 30, 15, 56, 40, 767, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameStatuses_GameTypeId",
                table: "Games",
                column: "GameTypeId",
                principalTable: "GameStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameStatuses_GameTypeId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "GameTypeId",
                table: "Games",
                newName: "GameStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_GameTypeId",
                table: "Games",
                newName: "IX_Games_GameStatusId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa9e849-4c01-42d7-bebe-f84c9907c576", new DateTime(2025, 5, 29, 10, 39, 12, 238, DateTimeKind.Utc).AddTicks(9982), "AQAAAAIAAYagAAAAEPlPlJSUB71DGpPepvBUE3iGMaS/DbD5HlaUkZMa4w+C7JlZz9z8HLogtCIZYalBUA==", "75737503-4cbc-470c-93a0-af2cad7fc507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92ee6b61-9336-4c90-bf4c-89817a23db8b", new DateTime(2025, 5, 29, 10, 39, 12, 286, DateTimeKind.Utc).AddTicks(7552), "AQAAAAIAAYagAAAAEAUhHzz8l7rHpN4ImBz/yfc5mpLTcpY/umAIEaqJNrA7xi+/RfgSQrloupapNeblwg==", "99b73599-4415-4e18-9f9f-08f04940e0fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f024f4fd-84fc-4e93-8c22-0867a8952fd5", new DateTime(2025, 5, 29, 10, 39, 12, 334, DateTimeKind.Utc).AddTicks(7960), "AQAAAAIAAYagAAAAEMIjqnh9PX7WlKu1ay7dRNhyrVOyf1N44sXIR0Ef81vq+bHGZ6SW8zBZx315cQIwAg==", "5fc03b31-612b-4c44-9d16-e9fa304e06b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6e2114-df13-468c-b1a6-4b8cabb35f98", new DateTime(2025, 5, 29, 10, 39, 12, 191, DateTimeKind.Utc).AddTicks(1959), "AQAAAAIAAYagAAAAEBvowa84i/TFJuD1WOmFjJ+2QTIN/I/iBM1rluckpTfRHpsJMX4ObUbhxBs6nhjgzw==", "d25c43aa-1cec-4e8a-94df-b9678e628ee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49cbb291-54b5-408f-b320-35bdb63f7368", new DateTime(2025, 5, 29, 10, 39, 12, 383, DateTimeKind.Utc).AddTicks(3043), "AQAAAAIAAYagAAAAEH4ScviFWk0tvcIJgPbp0F8bVinEQrdYzts9brzXnwPaUNAmvYfLxBGGTJRN0Cf9oQ==", "e6405f9d-878b-4e25-826a-4436ecef9d10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed11ad84-e984-4b60-a46e-6cb7ce245ee7", new DateTime(2025, 5, 29, 10, 39, 12, 142, DateTimeKind.Utc).AddTicks(2227), "AQAAAAIAAYagAAAAEFu+jhFhufuAe36DPBvTGlig8lh/A0MarjC8Lbe7Gju27Jv+0cDhMHtuvwv9Wh6PbA==", "c21786e1-3b45-4559-b509-2aa4dbe139b9" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 8), new DateOnly(2025, 5, 29) });

            migrationBuilder.InsertData(
                table: "GameStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5fef12e9-ad13-4707-ae74-7ecc23a43d5b"), "Demo" },
                    { new Guid("8097fd8b-f4ad-4fb9-93f3-6f8598cf6a4f"), "Alpha" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 5, 29, 17, 39, 12, 128, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameStatuses_GameStatusId",
                table: "Games",
                column: "GameStatusId",
                principalTable: "GameStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
