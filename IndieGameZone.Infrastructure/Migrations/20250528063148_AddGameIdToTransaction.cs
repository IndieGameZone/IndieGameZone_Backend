using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGameIdToTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GameId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4920f660-1484-4d03-89df-4d861a55122e", new DateTime(2025, 5, 28, 13, 31, 47, 353, DateTimeKind.Local).AddTicks(133), "AQAAAAIAAYagAAAAEPjZIHZEyLYCKllf0tmKRKJx4P6Iifu4QrQg0cwEmgDKSIo3AhSba+ExwU5mqFO9vg==", "c085f371-7a59-4a53-ab1b-4f2517d3e74f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f73a484-2d94-4b0e-a220-4b1cdb3fd2fe", new DateTime(2025, 5, 28, 13, 31, 47, 408, DateTimeKind.Local).AddTicks(6515), "AQAAAAIAAYagAAAAEDhf7KstaTycOn5CBXFGRp4J41tB4/pluJpvPOna3UCLM6zIU/Q74OT7l14+m5KaWQ==", "c36a29db-3db1-4c38-bf60-7f9a65b5f50c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a89e245-3152-4888-900f-292ee69fb961", new DateTime(2025, 5, 28, 13, 31, 47, 466, DateTimeKind.Local).AddTicks(6588), "AQAAAAIAAYagAAAAEHz+mW9BVgjd2rUNitzbuBLyhVYUpxE3QjX6lH3eOg96dUyZKf6ZCS5OfOhsPGrAuA==", "9fcce848-5078-4d79-918f-d6b884297795" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aac82110-3ce6-4796-a864-0318acd19d02", new DateTime(2025, 5, 28, 13, 31, 47, 295, DateTimeKind.Local).AddTicks(8101), "AQAAAAIAAYagAAAAEGRt/oDNhT3pRTN8IkbXvg9/K6GsxRU6rtg7J23GF/3CTUzIBSZAj6NjoLNQEq/JNQ==", "08584619-cb2c-4a6f-94aa-37c980580f03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46adf07e-ab7f-4521-a3e4-79440ed9071d", new DateTime(2025, 5, 28, 13, 31, 47, 531, DateTimeKind.Local).AddTicks(6192), "AQAAAAIAAYagAAAAEDz3SltmebMF1h7YPmoWv5r6MPrGS0MgNa1224au3CnFWskMJ54EHmpvlX7pt7DuZA==", "f37865f6-c3c6-4f5b-be00-6e9960266e4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "594a9bc8-6d20-45d5-ab26-e330115bcad2", new DateTime(2025, 5, 28, 13, 31, 47, 238, DateTimeKind.Local).AddTicks(3216), "AQAAAAIAAYagAAAAEIDT6cKv6X3rjGElUPyAkKhSO17neilzygVdFRcqwHVaasTPvWvsnEciP6sl7XKKLA==", "d51da64d-c98d-4e32-844a-570cdcb67afb" });

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
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 28, 13, 31, 47, 222, DateTimeKind.Local).AddTicks(4543), new DateTime(2025, 5, 28, 13, 31, 47, 222, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_GameId",
                table: "Transactions",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Games_GameId",
                table: "Transactions",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Games_GameId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_GameId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead321ea-eb9b-4bf8-911b-548ee4aa147b", new DateTime(2025, 5, 27, 23, 12, 41, 729, DateTimeKind.Local).AddTicks(1349), "AQAAAAIAAYagAAAAEAJPwQLkPJNRBF+LXrw3iDWk0b3DJpdJ5XwgGdDPG/Ym9CofzsfRbGt+IT5elnYhhQ==", "135b2042-eff5-4cdc-be80-5581d7b94552" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "634cf349-92b6-45af-9783-a04d081b3e1b", new DateTime(2025, 5, 27, 23, 12, 41, 785, DateTimeKind.Local).AddTicks(3826), "AQAAAAIAAYagAAAAEFI24b/BeVPhDPqVIXG9f2qWNEHZNq4k3sdJP66M8bxHbO1UFqHJ97FeGAGuslPedg==", "90f0f435-4a4b-4b2a-84f4-80d0384e2ab0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "833e7655-3de4-4e79-8a45-da4302f16b95", new DateTime(2025, 5, 27, 23, 12, 41, 841, DateTimeKind.Local).AddTicks(7248), "AQAAAAIAAYagAAAAEOmwb+ywJQfOlfiWxvL0Fs8ObQ259HRehHsYC8qBquOQW12Vq7SNnmhv/NIsVsCarA==", "e1654332-63ed-464e-a7df-6b295bad5b87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a8ce17-6eba-430c-9d63-58e65276cd1e", new DateTime(2025, 5, 27, 23, 12, 41, 671, DateTimeKind.Local).AddTicks(1311), "AQAAAAIAAYagAAAAEKmBCB3wbWQRO+O8zORomtRbkRGmT5j5AJkz+PH95g5/SZ91IbCN6kT4XvgAt1w1pg==", "40ece0f4-ab68-4f87-91c2-ff5933debec5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41378f98-9a38-419e-8b20-df9e550cd946", new DateTime(2025, 5, 27, 23, 12, 41, 898, DateTimeKind.Local).AddTicks(3414), "AQAAAAIAAYagAAAAEErXvFd4eNB/vARAOVaRtpToJOqaVcGe12lhRtfUAjM3gzVghH9lXaYS1xCR2WxY3g==", "d20942ff-052c-43cd-8358-ddf3250ee31a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a732c05d-b2e1-4e81-82e3-635b7e6c1782", new DateTime(2025, 5, 27, 23, 12, 41, 603, DateTimeKind.Local).AddTicks(4308), "AQAAAAIAAYagAAAAEJUFYe6RVY1CMkdcZ2ls2D671/4brh7Vetr54lBaKDiO+pSdonsLWHnxpNKviPc5tA==", "0257c570-51b4-471f-84c6-f00c167c135c" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 6), new DateOnly(2025, 5, 27) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 27, 23, 12, 41, 588, DateTimeKind.Local).AddTicks(6933), new DateTime(2025, 5, 27, 23, 12, 41, 588, DateTimeKind.Local).AddTicks(6945) });
        }
    }
}
