using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSecurityStampSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e296b74-89e4-45ed-819d-de2f2eed30d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAENk7BzLLBUvAx59XqY5mWdttXURPsIc3xTNG5ZwvA/YwRSuKuoOyWobZ1pYP5RQydQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0716dfc2-eb76-44a2-b73b-6492d112a615", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEOn2rReJqgazyqpKZTzZDDOh7mAaFyxia1NTYjl9pNr98KIkptxnp0yCRsBuMVObfg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c51e357-4785-4fb3-9f8b-505dfaf818fc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEMGVr1O6mmdTU3dvemM+fv6/VRt8WnFBTBEoRHWWfZEpxvk2utHZbPhV1sNBC7d4Hw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cb98a61-bacf-4067-bf37-b677fea9c750", new DateTime(2025, 5, 26, 21, 55, 55, 795, DateTimeKind.Local).AddTicks(7851), "AQAAAAIAAYagAAAAEFEbD6hyERhvS3aPm0FSp1AjlIBBpL4H6kcGfsnoEgO/TWr6GHrBRGAonunLqRCrgA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b32f2135-d6e9-47ea-99b0-b050b0eab33d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEL/Jv9lQ7+e2E1EHY+pLutFUtjH4dpaqg+xHuYQiC7G95/Uq3zLeNsmFQkWnNuH8aQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35cf0360-4c0e-4072-9375-1951a5d51a77", new DateTime(2025, 5, 26, 21, 55, 55, 735, DateTimeKind.Local).AddTicks(2834), "AQAAAAIAAYagAAAAEF9k917m0Fi+YMtPIxYuaiY+jHuyEfXHWQvv5LClJPM/rIQs4eD2MZZPaO/mTWflLw==", null });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 5), new DateOnly(2025, 5, 26) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 26, 21, 55, 55, 719, DateTimeKind.Local).AddTicks(585), new DateTime(2025, 5, 26, 21, 55, 55, 719, DateTimeKind.Local).AddTicks(592) });
        }
    }
}
