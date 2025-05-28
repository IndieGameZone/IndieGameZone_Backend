using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderCodeForpayOS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderCode",
                table: "Transactions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06da29b2-3b5b-4bbe-8a38-bc11254f7cda", new DateTime(2025, 5, 28, 13, 59, 17, 144, DateTimeKind.Local).AddTicks(9882), "AQAAAAIAAYagAAAAEOrebgjjWvc88wi6um5GKYaNaxzjLJwfjLoI2pFPnstmMuPhQHa9w0LOg+4eFAqOzQ==", "d0de3ab0-fb8a-4e2b-b89b-aedd1ac3b07c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "365a1555-29ea-424f-bc03-a6de482712fa", new DateTime(2025, 5, 28, 13, 59, 17, 207, DateTimeKind.Local).AddTicks(6008), "AQAAAAIAAYagAAAAEMV3UWy61ta6iDGuvQ3KX1FY0kp4QbDe58sIH0cvVwhEp44/sx1wx/f/exh8jL614w==", "942b4433-072b-4ad3-91ca-736927c2da38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb2411e-b95f-4115-ac15-f9a2f9d1c6e5", new DateTime(2025, 5, 28, 13, 59, 17, 268, DateTimeKind.Local).AddTicks(5215), "AQAAAAIAAYagAAAAEGuHQtaL6C79/svAY8wtG84EGo40oyJQfUfQ/D4xyZJV4IDDrxDyaeShT+z2FfhY7Q==", "044496cd-3485-4299-9873-1fe6d9a18f54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdfeb482-1961-4861-83c8-ac19eb6867da", new DateTime(2025, 5, 28, 13, 59, 17, 79, DateTimeKind.Local).AddTicks(7125), "AQAAAAIAAYagAAAAEBmZ49PmgGklyVJnZ1BN47wzfGDYWIBhULvwMqLrCijpVsF9Zb6Dg+akWEAofas8zw==", "c6c46a02-f6b6-4c7e-a251-fae9d7a7c9c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e3a128b-fba4-429e-ba84-a1163ad20926", new DateTime(2025, 5, 28, 13, 59, 17, 329, DateTimeKind.Local).AddTicks(9506), "AQAAAAIAAYagAAAAEBdmzl/tboStg692B24sSTg/HzEVY2F9BPXYytXqrqB926FUpU1zM02qqIV5BevAKA==", "cf371061-a7a4-42a2-9322-818500c06dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c44ddb0f-f2b0-4164-8746-dcc0ada8cb32", new DateTime(2025, 5, 28, 13, 59, 17, 21, DateTimeKind.Local).AddTicks(45), "AQAAAAIAAYagAAAAEPGjSik4uHYbFUtwI7fUwuA7I0PxpYFCk9OISHHiEzVkEbSu3Z1vAVFmnfY42WEw1g==", "20388689-789f-4dfa-9418-5135335ff712" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 28, 13, 59, 17, 3, DateTimeKind.Local).AddTicks(4133), new DateTime(2025, 5, 28, 13, 59, 17, 3, DateTimeKind.Local).AddTicks(4145) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d84a140-1e68-45ae-8f35-9c04fb61c686", new DateTime(2025, 5, 28, 13, 44, 30, 788, DateTimeKind.Local).AddTicks(3097), "AQAAAAIAAYagAAAAEA7eZltWEA6YkdxUVVHBH666fNDRu4KtCp6z/Wc4GnIAN8BK72JECUYPZpGMu8ulPw==", "203f08e6-66ab-480d-84e4-f9583b442495" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "491309ac-908d-4ff9-82f9-70fbe84896a0", new DateTime(2025, 5, 28, 13, 44, 30, 847, DateTimeKind.Local).AddTicks(3529), "AQAAAAIAAYagAAAAELtJq4HmSmjela6tZglXfdncgkuGvQBkLUaF6s6Zn+UvNcRCY882AyzeAL9fbbWQ3w==", "59df949c-86da-4db1-bc32-5ec0d34e3793" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e363e7c-04ab-4d78-bd4f-0d85c6969dfe", new DateTime(2025, 5, 28, 13, 44, 30, 904, DateTimeKind.Local).AddTicks(162), "AQAAAAIAAYagAAAAEEsYb5qKvC+9SSDkRSkYU9V4GpW7MHbwCiHFLSSuqVHr0POGnX/qjkvX1hNpv0rRJw==", "201cbfe6-f087-45e0-bf01-68bb3ba127e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccb83edf-9c49-4406-935a-dbed144fd032", new DateTime(2025, 5, 28, 13, 44, 30, 728, DateTimeKind.Local).AddTicks(8773), "AQAAAAIAAYagAAAAEHUl1+1A58/kKI0+KqmXaDf5rmJpE8sbDDolBj4VINT7CLHSgJrk+dGzKARUu/Nsrw==", "fd43e7d4-3476-4124-aa23-48bbc8edfbf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eecb6e9-31aa-4ccd-896c-1b990d3cd1b2", new DateTime(2025, 5, 28, 13, 44, 30, 959, DateTimeKind.Local).AddTicks(9407), "AQAAAAIAAYagAAAAEImIUKViS3DYRwPy3ZqL+rpAGrmGXzMX5d+H20DDUMv4KvnnU/0tuZKpcpBmWKxFCw==", "01f0dda7-8789-4dea-8bd4-1a4062ef81cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81afba36-fcf9-4d91-ad67-5c439facf374", new DateTime(2025, 5, 28, 13, 44, 30, 672, DateTimeKind.Local).AddTicks(8825), "AQAAAAIAAYagAAAAEHsqHATbKP9r+u3psuHTrVp+AddQA8XwZnxJwMi6YufKrlK5bERAGvXk3anMhPxooA==", "705ae7b4-1af6-49d9-9e7e-a9ab0cb3c8dd" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 28, 13, 44, 30, 659, DateTimeKind.Local).AddTicks(3356), new DateTime(2025, 5, 28, 13, 44, 30, 659, DateTimeKind.Local).AddTicks(3360) });
        }
    }
}
