using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixDataInGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "617ed98c-63fe-464d-9b80-289997b340d5", "AQAAAAIAAYagAAAAEBomYz0Wa7elCQ9LtjseWIlHLLDbCxnwwZGZivBqtO0CWl7AoVKzfm1YJnMfcDDJXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d435b5f6-cf6e-4063-8f97-093ad15d2614", "AQAAAAIAAYagAAAAEPw4Y7WqBmMydGQJnCH80LcjuxQX0U4dFQ31jJcT1nPmH/Jbx0/ohU7fHUT4mLrGGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "892235a3-dbad-424b-b9de-f0a3417fd941", new DateTime(2025, 5, 22, 22, 7, 36, 782, DateTimeKind.Local).AddTicks(7054), "AQAAAAIAAYagAAAAEHrNRqc8v4EExgrDQoArBnfDm7HWLUp2ua/vHS+SE7ub9B20Zd06g5uS+2hzXmjeFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "1e5ce9d4-1f2b-4232-a0ea-a56049d8898a", new DateTime(2025, 5, 22, 22, 7, 36, 726, DateTimeKind.Local).AddTicks(9140), "AQAAAAIAAYagAAAAEAk3Brpc1ZB4LDDjkIQ2ZocBhxLzEQJA4sWQqRe3N26uC+3/xeqrWNWHlP/8GDlBqQ==" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CoverImage", "ReleasedDate", "UpdatedAt" },
                values: new object[] { "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseatCoverImage.png", new DateTime(2025, 5, 22, 22, 7, 36, 711, DateTimeKind.Local).AddTicks(3234), new DateTime(2025, 5, 22, 22, 7, 36, 711, DateTimeKind.Local).AddTicks(3256) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcdfd22a-beff-49fa-addd-dee47dc4cc34", "AQAAAAIAAYagAAAAED0Hu5DXfEG5TpEE6hIRWcJI/qKm1ZvASJyGRZjnYF4eOcrlRHk/retNv1vD44kNwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06737d96-e83a-498f-a838-240df0924cba", "AQAAAAIAAYagAAAAEJ9wKx5xvtAJIhtWpoLF6NeghKQZg6VzLy7LDTGShl+Xy5QsuDOqzK4zdefiXcofBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "3326f960-a6db-4480-923a-a223639115a5", new DateTime(2025, 5, 22, 21, 58, 19, 574, DateTimeKind.Local).AddTicks(5375), "AQAAAAIAAYagAAAAECwbQRcLMgAn8sAKKJXhTZKm56uGREP3unD6c2vKhp0rR2Q0mxYhUZhtmDJUeA14BQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "8fc72df9-cc6e-4ee3-91e9-0bc0f7aa59ac", new DateTime(2025, 5, 22, 21, 58, 19, 517, DateTimeKind.Local).AddTicks(1230), "AQAAAAIAAYagAAAAEFPa19t9e/Ai0M7i/tAcQVp/yWEntvqlLS2o5hC4t8IGz/MZhbQqnu4ZBbEIQU8mJA==" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CoverImage", "ReleasedDate", "UpdatedAt" },
                values: new object[] { "https://cdn.cloudflare.steamstatic.com/steam/apps/2380880/header.jpg?t=1698238821", new DateTime(2025, 5, 22, 21, 58, 19, 502, DateTimeKind.Local).AddTicks(227), new DateTime(2025, 5, 22, 21, 58, 19, 502, DateTimeKind.Local).AddTicks(239) });
        }
    }
}
