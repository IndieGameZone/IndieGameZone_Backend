using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa9e849-4c01-42d7-bebe-f84c9907c576", new DateTime(2025, 5, 29, 10, 39, 12, 238, DateTimeKind.Utc).AddTicks(9982), true, "AQAAAAIAAYagAAAAEPlPlJSUB71DGpPepvBUE3iGMaS/DbD5HlaUkZMa4w+C7JlZz9z8HLogtCIZYalBUA==", "75737503-4cbc-470c-93a0-af2cad7fc507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92ee6b61-9336-4c90-bf4c-89817a23db8b", new DateTime(2025, 5, 29, 10, 39, 12, 286, DateTimeKind.Utc).AddTicks(7552), true, "AQAAAAIAAYagAAAAEAUhHzz8l7rHpN4ImBz/yfc5mpLTcpY/umAIEaqJNrA7xi+/RfgSQrloupapNeblwg==", "99b73599-4415-4e18-9f9f-08f04940e0fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f024f4fd-84fc-4e93-8c22-0867a8952fd5", new DateTime(2025, 5, 29, 10, 39, 12, 334, DateTimeKind.Utc).AddTicks(7960), true, "AQAAAAIAAYagAAAAEMIjqnh9PX7WlKu1ay7dRNhyrVOyf1N44sXIR0Ef81vq+bHGZ6SW8zBZx315cQIwAg==", "5fc03b31-612b-4c44-9d16-e9fa304e06b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6e2114-df13-468c-b1a6-4b8cabb35f98", new DateTime(2025, 5, 29, 10, 39, 12, 191, DateTimeKind.Utc).AddTicks(1959), true, "AQAAAAIAAYagAAAAEBvowa84i/TFJuD1WOmFjJ+2QTIN/I/iBM1rluckpTfRHpsJMX4ObUbhxBs6nhjgzw==", "d25c43aa-1cec-4e8a-94df-b9678e628ee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49cbb291-54b5-408f-b320-35bdb63f7368", new DateTime(2025, 5, 29, 10, 39, 12, 383, DateTimeKind.Utc).AddTicks(3043), true, "AQAAAAIAAYagAAAAEH4ScviFWk0tvcIJgPbp0F8bVinEQrdYzts9brzXnwPaUNAmvYfLxBGGTJRN0Cf9oQ==", "e6405f9d-878b-4e25-826a-4436ecef9d10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed11ad84-e984-4b60-a46e-6cb7ce245ee7", new DateTime(2025, 5, 29, 10, 39, 12, 142, DateTimeKind.Utc).AddTicks(2227), true, "AQAAAAIAAYagAAAAEFu+jhFhufuAe36DPBvTGlig8lh/A0MarjC8Lbe7Gju27Jv+0cDhMHtuvwv9Wh6PbA==", "c21786e1-3b45-4559-b509-2aa4dbe139b9" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 5, 29, 17, 39, 12, 128, DateTimeKind.Local).AddTicks(5557));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2403de55-751c-4b1b-86da-47f8c3e14e66", new DateTime(2025, 5, 29, 14, 15, 59, 608, DateTimeKind.Local).AddTicks(8079), false, "AQAAAAIAAYagAAAAEHYMHo9PBcbpu6kS3B8RqC6J0VeLJUGI7O6zhmHZBUA/bSoPLzOAy6z06QCT1rryPg==", "afa3d5d3-eb15-44f3-9507-fada2cb3d46a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f140e30-97be-4db2-8b4e-7073dddc1d3a", new DateTime(2025, 5, 29, 14, 15, 59, 663, DateTimeKind.Local).AddTicks(2747), false, "AQAAAAIAAYagAAAAEM2XXvghrW4goQr2OuZ6Yb2mX3CYak2nTU+TUdTCImWfXv4Ehwx6Ny2OkCjooo3zYg==", "1129473b-f42c-468d-86ae-c19ef860519f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354dd748-5e9f-4071-82e0-fb207c2363eb", new DateTime(2025, 5, 29, 14, 15, 59, 728, DateTimeKind.Local).AddTicks(6898), false, "AQAAAAIAAYagAAAAEIMnGrbY0SG+W7mI/wkEYJKb79dnCCru23j5+YoPyxrHqhAZbX+MUc5PqlwRFojxEA==", "7ec1a8d3-3928-4046-bd49-a2f9c9cecb56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6075551-5805-43df-ab4e-e3ba1d1d27eb", new DateTime(2025, 5, 29, 14, 15, 59, 553, DateTimeKind.Local).AddTicks(7292), false, "AQAAAAIAAYagAAAAEJbF2mKswor0O0e/H8eJUEZutKQ6ubN0XchFdwCN9F4Ia1Os0YRC01sO3I2jUsVRDQ==", "6ef48d7b-d548-46ad-8b3a-a752dabc81de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b3bf7b-31b3-46ec-8dc1-6810b7376869", new DateTime(2025, 5, 29, 14, 15, 59, 789, DateTimeKind.Local).AddTicks(4863), false, "AQAAAAIAAYagAAAAEDQvD/OfEgp74hFPULony2hMe8o3Brk819xH0Bhl/XvoFyK38hvnM7H75yFO+Mebpw==", "48935f26-8c06-4e4c-a160-0206bba6eeca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058f9ec1-8185-4ead-82a0-edbc91ed7e37", new DateTime(2025, 5, 29, 14, 15, 59, 498, DateTimeKind.Local).AddTicks(1017), false, "AQAAAAIAAYagAAAAEA9iVGOiJHrbTCGcj5iova8fqJc2yDFI8qUaIqEaGYbrxHfcLvKsQXHhgMz5pb6Sxg==", "99728d77-eb4e-4f36-af92-980ef9dd38b1" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 5, 29, 14, 15, 59, 483, DateTimeKind.Local).AddTicks(6322));
        }
    }
}
