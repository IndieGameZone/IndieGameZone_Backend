using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWithdrawRequestEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTransfered",
                table: "WithdrawRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbb699ef-6d1d-474e-8cb9-2bc0b204752c", new DateTime(2025, 6, 1, 6, 39, 56, 435, DateTimeKind.Utc).AddTicks(6077), "AQAAAAIAAYagAAAAECE6TefTrRhlCrbPMQS+c1VqrsNJKstmKmybiB/NvUxQRgG4d98TNCNVPklAzbhP2Q==", "8ddf582b-e6fd-42af-9cfe-d5f5ad6b7ebd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f59fc06-06b3-49ce-bb01-794561f05ae4", new DateTime(2025, 6, 1, 6, 39, 56, 500, DateTimeKind.Utc).AddTicks(5263), "AQAAAAIAAYagAAAAEMyijlNLCeF/jWWHOyAOwpU8+SMsGb8XFsjF9EEC3muNfiWVfP17Hs2ANkM54ywYzw==", "d152ad4a-59ab-4c94-ad82-3f89db963f74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79f13687-5d4e-4cbe-bba2-faff4c26d356", new DateTime(2025, 6, 1, 6, 39, 56, 562, DateTimeKind.Utc).AddTicks(8119), "AQAAAAIAAYagAAAAEByuTDVIBI2vWp+f/1jNg4fzW11l+EPUvJ3JPEsAYh/uhyj3prpPUxPm5WepRcynOg==", "34da28e3-ad5a-4e2f-bbd6-a943581fad25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b9d0353-06c2-487f-800a-a75e36eb7d95", new DateTime(2025, 6, 1, 6, 39, 56, 364, DateTimeKind.Utc).AddTicks(7838), "AQAAAAIAAYagAAAAEGBfaPM47SB0wI6ua5TeCawPKaD6knwzj7/OjitFrN3vwvhAcemFcEiyiXhhpaWwXA==", "c9e43128-2ef5-4b95-a1f2-e692f3478043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f791fd4b-6af5-4f2d-9b7b-f6bc6cbf9e0c", new DateTime(2025, 6, 1, 6, 39, 56, 627, DateTimeKind.Utc).AddTicks(609), "AQAAAAIAAYagAAAAEMjEVhwtYOesQiRMgIxlcBtK0lR4QUOqtteb9dqi1np9lm1+ujq7ABwY+8zclIr+3w==", "b617c689-9c49-4891-9a03-51c197482a16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5d24a1b-63ef-44ac-b814-ab5fcb0ce214", new DateTime(2025, 6, 1, 6, 39, 55, 856, DateTimeKind.Utc).AddTicks(188), "AQAAAAIAAYagAAAAEPYgqnc93KwDPnhRMLRG3RxpuuaLHE5fN+RJYkk3S2Cls8z8MPcH13xyPQnyLgj20A==", "128d060d-928b-455d-80ce-798246d96b42" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 13, 39, 55, 839, DateTimeKind.Local).AddTicks(440));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTransfered",
                table: "WithdrawRequests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b18f50e-1548-479f-958e-054ea10880a7", new DateTime(2025, 6, 1, 0, 17, 32, 110, DateTimeKind.Utc).AddTicks(7792), "AQAAAAIAAYagAAAAEB7CnYoBVRnUG7dWI3uatei1IrTt6WMm94gR70/f1XSz8tgPrK7F4/Dn+7SIIJ8dYQ==", "ffc6134f-09b9-450e-987c-060d02c81253" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa8c3c03-5052-4e4c-af72-be339743dbd9", new DateTime(2025, 6, 1, 0, 17, 32, 159, DateTimeKind.Utc).AddTicks(6024), "AQAAAAIAAYagAAAAEKGSC3jmQ+GHHFjLd5xV+Z0lpnV1aGWWCLT0iy7InDQqt53tB7AP4r2WkplDoMhtiw==", "713ef8e0-6955-4bcb-bcd8-c5720422ca79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42b76f03-de47-4bd2-96c3-7d82ab3e7143", new DateTime(2025, 6, 1, 0, 17, 32, 209, DateTimeKind.Utc).AddTicks(6477), "AQAAAAIAAYagAAAAEKJt9wPkrDwwTzBVxLn0ACresBbczo6sg4tpKv5Q50k5EB7zwo/KrJk50e+cO1OBHw==", "64d280fa-773b-49dc-afdf-222e4bd3c0dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66626e74-832b-40b5-be54-fe6a5f03fc05", new DateTime(2025, 6, 1, 0, 17, 32, 62, DateTimeKind.Utc).AddTicks(2589), "AQAAAAIAAYagAAAAECAsFlgYn6v38GUdE0D86YidhdhCRuZVdUyHZSzi/J8u2j73wDVbpsMhrQLjv6fw/Q==", "9e1c21e8-9502-407c-9494-2862ea00a4f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d6a1b04-c033-4128-a9ca-ad39a4a9beaf", new DateTime(2025, 6, 1, 0, 17, 32, 261, DateTimeKind.Utc).AddTicks(3179), "AQAAAAIAAYagAAAAEAJl0LjZxpM4L4a3omZtBwkY7oG5VGBbJdg8iVsJEM9Zq50iiJsfTxZdeQKJLLxR/Q==", "9b07d113-c84c-44c1-9728-9ee86007467c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e2f980-c9a0-4a5a-ab81-7dcb927386a1", new DateTime(2025, 6, 1, 0, 17, 32, 11, DateTimeKind.Utc).AddTicks(5916), "AQAAAAIAAYagAAAAELyaTVrXx4W62Ron5mA5Kq6Q2FMGeYZkE7+DeIbGFfd+d9DLARWF8l4Hi4EDaXkJfQ==", "c61958af-d955-4190-b66a-b15520281c06" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 7, 17, 31, 998, DateTimeKind.Local).AddTicks(36));
        }
    }
}
