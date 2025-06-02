using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUsersSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a689c0d-a5db-4a12-b266-8e077c5c0670", new DateTime(2025, 6, 2, 9, 25, 52, 60, DateTimeKind.Local).AddTicks(2316), "AQAAAAIAAYagAAAAEPHkGDSVrJpN2D3zAuff5Btj8+D8u0DQsJj9BtmOmOhEKOtTxmGbc0HaCZZwhQg4fg==", "97570f3e-11ed-4317-8793-c968aa71c518" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc66032-616e-4fe3-be46-d8cc31fc14e0", new DateTime(2025, 6, 2, 9, 25, 52, 111, DateTimeKind.Local).AddTicks(1073), "AQAAAAIAAYagAAAAELEkhdr33ZDmW54/3eULnNe1XXwF56GOt+xoOlp2ibN1Xc7VazeQUqrbHP8ypa0jHg==", "b1d4ff72-7f02-4820-85b1-4fe95bfe2b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54cc1816-6dd1-486d-87db-184974f67c9c", new DateTime(2025, 6, 2, 9, 25, 52, 160, DateTimeKind.Local).AddTicks(9188), "AQAAAAIAAYagAAAAEBJvmUWRp3NTErRWTiqFX6so11KSbLgUCL4Plpnca2zvy058ulHJWgsM2LxTZFb+cA==", "2158a4c9-a6ff-44e4-a3c0-d288c636272a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "088726f7-c6a2-4283-b9c5-d62e4149b76a", new DateTime(2025, 6, 2, 9, 25, 52, 9, DateTimeKind.Local).AddTicks(9567), "AQAAAAIAAYagAAAAEJOoIHTwvikAvftvF/dcLVOy5RomYgOk6fg42qXRiwkbOEBWdg4EdVpe1pBiMsVpXg==", "16039620-1ff5-4576-bff2-9786adb27e3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "525f44f7-ad99-4596-86f8-d54da17c1977", new DateTime(2025, 6, 2, 9, 25, 52, 216, DateTimeKind.Local).AddTicks(8473), "AQAAAAIAAYagAAAAEAKYYQoeDAFoW62T+oLzLbgdHWDthTHjkCM2ZhoaCiGZOqBUJjXSoRWm8MT8XKCAqg==", "23b6762c-a9fe-43d1-8a98-b4eed1f5194b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc2307c-b0e2-484a-84c5-20624ed0cca2", new DateTime(2025, 6, 2, 9, 25, 51, 960, DateTimeKind.Local).AddTicks(366), "AQAAAAIAAYagAAAAEEDQ9lDw2sqg8CxscO3P3TxsGVx/65+PGRtbe+stjv56vwLvEmgn/YiUGGRjvMxJ/A==", "67a35ffd-bfe3-485a-ac7b-974ff8865cf6" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 12), new DateOnly(2025, 6, 2) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 2, 9, 25, 51, 946, DateTimeKind.Local).AddTicks(7158));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 11), new DateOnly(2025, 6, 1) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 13, 39, 55, 839, DateTimeKind.Local).AddTicks(440));
        }
    }
}
