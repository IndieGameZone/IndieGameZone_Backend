using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommercialRegistration_Transactions_TransactionId",
                table: "CommercialRegistration");

            migrationBuilder.DropIndex(
                name: "IX_CommercialRegistration_TransactionId",
                table: "CommercialRegistration");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0e3c9034-202f-40ac-8e88-b5f59266ad6a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0ff5b7d7-72f5-4fbd-bb99-6e72f827cf3d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("10242cac-5eea-4747-b869-8ac78b252195"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("13ab2f4c-1f98-4896-8695-9476996c6214"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1a59bd54-47bd-4777-a711-ed4a89d01285"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("245be98d-bb8a-4b89-b444-4fea6f41665f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("277f4c1e-96e6-48f9-b815-fbddf8a188a1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("28c87053-0d12-4542-8643-926d77df5e26"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2e8ca8b5-e74a-4e85-9b9c-b8c6cb590154"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2fe533e3-d9ea-41bc-b32a-00725b449aff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("32473707-25f2-4a91-8d0a-ef2dfcd8ebd1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35923690-e947-48c7-85e3-2d0281863e2c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3a39156d-058f-4659-a407-44eba3a30244"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3c527d98-da2a-4c71-8c96-4b7e04a14a4f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3ed98af1-31e6-416d-bb09-40b8ea95a803"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4d45f235-5cd3-4079-8606-225d2e86c6a4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("59a7ec8d-382f-42d9-b34c-ee9e62f6090c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5d48cfc1-0717-4eb5-812c-f93c10fce09d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5e50ed57-e1bc-4597-83c4-ae3b867b5c70"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5ff1dc9d-3d9f-4a00-a13f-1d80f45a3819"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("663b07c0-cb6c-4c0f-88b5-24e2991a25bb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("73ee290c-5367-4065-a7bd-47ed111c5db0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("77ada7ea-1125-4b40-8848-3ea844151549"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8035aed2-057a-4f7d-a97c-e5f3d7231575"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8134155f-814e-4a38-8c68-ac72419a482a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("837dbce1-3a40-4b8c-9f97-dd46efae65fe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("844b59c4-eceb-4446-8e17-bc02a6901882"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("84a5eabb-f40d-4bea-81d3-7037c3f010b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("85c8cf1d-30e4-4fe5-ad5f-697c08738c25"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("88be0043-c91f-45a0-bd23-e351e8563e82"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8be4372e-3c15-443a-813b-ec42a9913b9a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("905985b4-9821-40c2-aa4c-e09a1e4e92f0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9233442c-0d0b-477b-b806-131775d4824a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a02313b1-a7bc-4a2b-8af9-f1e0d0c91417"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a21e4beb-4a50-49f1-8757-d79691ad1154"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a4b532bf-22ce-449b-9741-ba8713b2ce45"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a5980ba5-e759-43ee-aaca-3f5d3a02f758"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a5a4d09f-d9b9-4373-b1d2-75f5b0cef19b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a667941e-c9b1-4989-8b2e-9bd7d78239e2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("af2f5ff6-ee64-43c0-ab74-3fa1bf254cd6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b11244f3-6d23-4f9a-be90-1bf1fc2e9bde"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b466bd33-67d3-4142-9df3-46f0dfc18b33"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b7dfe269-b622-40ae-9625-3d15215e95fa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b879d1a1-7528-42db-91e6-3498cf723938"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bffa4b28-5e61-43a1-8fdc-488b36c34f60"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c3697118-f0cb-4e3d-8384-d996e472c087"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c8286e36-da49-4357-9ae7-7b8674218a5f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cdb04cc0-b96b-4381-860d-24d28ac8e9f3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d255e45b-4451-43ae-8636-5d620fd6d78d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d48aaae9-9232-4f7b-aa74-284e917c9022"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d48e27b9-5df6-449f-9207-40eecf8daf88"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e3d84b66-c217-46c7-b49d-703c08e40e3c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ecacc488-efe4-4519-a9c9-59d30026d4de"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f15409a0-82f4-4902-b10c-0652a2111e2c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f2469f03-e06b-47cd-838b-385433290159"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f2a0d025-8c0a-4a60-8be2-532d287c6cd8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f3860285-72c4-496b-9861-982cedee6010"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f9eab3b9-dc61-4cef-8e13-82a17c46177f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f9f3fd90-c6c1-4575-848f-ab5676d9b6b7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fb03fa22-7485-4fb3-b384-73998bed60aa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fc7a14a2-955e-4921-a54e-f613cfb81dda"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fce9aa0b-8b34-40bb-a0ee-cc6538652fa1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("010e019c-19dc-413d-92c0-e203cd61bda6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0f7fbc86-d2bb-4aaf-8ccc-73114dfc8192"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1756076a-8c6a-4137-b811-d3842dc5ced1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1895cbc2-2d9e-419b-b16c-38a45483b120"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1b40d829-57ce-4448-9f75-390c89f7ddd6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("232b0447-0189-4bd8-89f2-d45d5235a907"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("345ba905-9ee7-437b-ae5a-cedf492ee637"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3b7cc6df-79f5-423a-8cf4-ea487772c909"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3bfff600-3c54-42f4-bcf1-42af15995bad"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4d25f538-a4f5-4c2a-acf4-dd722059c629"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5b1277c9-c609-4eb4-94c4-f3a0de064285"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6eb063d0-af11-4d6f-ae28-5d7187856572"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("851767ec-24fd-42f4-97a8-a919079324e9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("886cf87d-35f2-4f22-8177-759ed58b568d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("897805ec-9727-4b3e-9e40-53f33c9153a1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9da40c06-440f-4295-955e-417053b53f5a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b2ad394a-feb5-429a-a901-67161ee88b3c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bb5145eb-7f21-4570-871a-7536dacefe96"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c0063bc8-f23f-4025-8681-1278fb74c94a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c1a12345-b9d7-401a-b7fb-6fb8ea8b69e1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d654b5e4-1e55-4c02-8766-c0f39146e767"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dd221855-636c-4d0d-9667-887661aea2d7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e417680e-122e-4d03-ac6e-99e19255ab98"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f73f4640-8a88-4238-8527-dd364ba03155"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fd73ce8b-6962-49b9-a5c2-cf618a87b875"));

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "CommercialRegistration");

            migrationBuilder.AddColumn<Guid>(
                name: "CommercialRegistrationId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52f896f3-8f09-4d3c-b78c-b1739c53a6b7", new DateTime(2025, 6, 29, 21, 49, 7, 88, DateTimeKind.Local).AddTicks(3634), "AQAAAAIAAYagAAAAEEQsvDbhWxJbrwLZyUz6cnd5VLxQ0QUOOmz8W0JStFPLxC1hlOhaYI9FS0sw0z+MMQ==", "8cde29c0-29e8-4ecd-95e8-334e0c624454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3486b7-69c9-40e2-b058-9532ad2310a6", new DateTime(2025, 6, 29, 21, 49, 7, 253, DateTimeKind.Local).AddTicks(564), "AQAAAAIAAYagAAAAEDh7GmMqqKDx7rQxcw+AvccEIFTEtQrUF3wvUY8AILkT/MTIv72APi5TGnqkYjvL9A==", "df1f7882-a262-42d0-b058-a2d8ae04a5bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1441774-8b14-4669-96d2-6638f4934c93", new DateTime(2025, 6, 29, 21, 49, 7, 320, DateTimeKind.Local).AddTicks(4043), "AQAAAAIAAYagAAAAEIl0HEGpYoxbIqGLbYKt4vV21py5RaNzpeMXqPzGsBosaWySqMRlcTg/bSs6b/y4EQ==", "d6b69825-3eef-45b2-952b-a43576ceba31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b98076c-9528-4315-841d-7a5d3fb2677f", new DateTime(2025, 6, 29, 21, 49, 7, 34, DateTimeKind.Local).AddTicks(1922), "AQAAAAIAAYagAAAAEIf9yTWXbdMaOefHhQhjDmNXGr2uKqvex8dlOZlj2xqEHa07I+0b/ZkFo6o/FoF22A==", "54efd6ae-61a6-4199-bac7-bb159e12fb26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f46a2c-0206-4545-9777-2bedd349ee0d", new DateTime(2025, 6, 29, 21, 49, 7, 197, DateTimeKind.Local).AddTicks(9296), "AQAAAAIAAYagAAAAEHv4PTEcHOh3TNnNmtSLwdi4DaK5INsywdLFQ8iaEdp+I+5SYYG8DUt5y1e437/Awg==", "31021da6-a8fc-4b98-9659-be54543b5deb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd8f6d5c-295a-4cbd-8dc8-5ec81e79a92d", new DateTime(2025, 6, 29, 21, 49, 7, 142, DateTimeKind.Local).AddTicks(8411), "AQAAAAIAAYagAAAAEN8uoIYZTicQ0p+kMHDlfOdCRBADojpcnaM7+y8sibWnslDiGVTHkMt3duIvvTpxww==", "522579a5-9f71-47c3-a0e6-7822f1a812db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a00f0c9-8076-4b4d-bdde-57b36e123cf9", new DateTime(2025, 6, 29, 21, 49, 7, 374, DateTimeKind.Local).AddTicks(8505), "AQAAAAIAAYagAAAAEOKrvpV8yW93EW/SyG/Xm8cxnNLei6+Dig/2WJrAa/EShdNEtEBUo4Y0A5d8/gfC3Q==", "89b112ed-b475-4b23-8e4d-1354a2e84f60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d07df6e-3fa5-41fe-b3c5-75aab3fa3fe7", new DateTime(2025, 6, 29, 21, 49, 6, 976, DateTimeKind.Local).AddTicks(3422), "AQAAAAIAAYagAAAAEOM7JdQob/Ppnn+DTM3v+UQzoBh2IbYIpnjonBwCTI9OG0WZRQcvEvBY8KviSmgf8g==", "5dbc2ba1-6225-48b8-b869-217c593630ba" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("00eae056-7fd4-49db-af9c-ba09aad92e93"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("0aac489e-4e36-4c2c-a337-956e6a071468"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("133d4160-9ade-4e68-a555-a7c4141327d4"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("16b29194-f4db-4451-b007-45a349f8ec5d"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("1a2303a4-593e-4ed0-921d-3bb2c951e3f6"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("1bc78086-fe4f-4011-a279-7e25ae3d16c4"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("22839a3a-baa5-468d-8269-a68b0564ef0c"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("33e6d8fa-7a0b-4f2c-b507-1195025ba05c"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("367b57eb-6e96-4dc7-bc37-ac12337a84de"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("3841a35e-f81a-4d9a-8e34-04bcf2864314"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("3c0d734b-24be-437c-a324-0696561c8175"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("3ccc2079-eb7f-402d-ab14-193af6b659a4"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("42d7f51b-04e1-4860-b4f9-cf982b3be383"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("447d1497-15f0-4afb-829b-1481ba800136"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("4f2ab366-811e-4271-8387-4c3e5e2a236a"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("5b284028-95b4-428e-b2a3-d631b88b14ae"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("5c0454a6-12a1-4824-b620-478a35ccc06c"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("5fa59f04-2a0d-4deb-8703-7213755142dc"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("6114f9a0-4f8d-4773-8ecb-42558d929fb4"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("6421cdc2-7a4a-41f2-be16-335b5ff3c3d9"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("685c877e-d83e-440b-afc2-8439c04d4705"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("6d5f92a5-3a63-455e-9e4b-2d35e5950dc6"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("71fb5542-35e7-453a-9f22-465dd53bd9e7"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("77a0da92-556f-46a5-a069-2081ad666903"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("78bd270c-e34c-4b46-b24f-ee3dee835ddd"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("7ec0f4ca-b6d8-42a7-bbab-25eca43d6101"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("820f4af6-5719-4fce-8a32-ae628e68d5c8"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("87f136d7-19fa-46aa-9bda-def2871231e3"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("8d0ebc33-0596-440b-b999-4afa5fbe53fd"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("8e378885-b446-45c6-b793-93d7e1626e19"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("98b80f85-4994-45e2-91c4-2ed4cf0b203c"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("a4d39102-a5fe-4cf4-b9cd-008d726bec41"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("a578c484-cb2a-4a8c-a9fe-6eeb85ad9bcc"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("a98e120d-fba6-41ff-a523-073f35c621ff"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("aaee4283-5e17-40db-937e-ba5c89c89a4b"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("ab8db91f-c715-49a9-83a1-bb19c059fdff"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("ae0e73ad-c3bc-4d6a-ab98-fed2b9bdbb1f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("af2fdab6-0a65-4ded-a967-6b59637de979"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("b090abe7-eb75-4e94-b357-56f984b4611b"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("babeadb3-a8fc-4bce-9b62-9defc27979c5"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("bf0d0aa7-23f7-4b4a-92b8-36caaa494ded"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("bfbdbef6-aee0-4449-a65b-69f589250641"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("cb4150f6-b650-4dc8-8d9a-f7ce465e4d3c"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("cc41b41b-2ea2-4b91-8bdd-c5c05481924f"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("cdf7ac48-003f-418d-8800-15805f0b4be0"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("d217d560-4ca8-41d8-ac5a-b53c8a98d49c"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("d67ed3f7-dba5-47e0-8742-0e801df82578"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("dd3ad639-a075-4a8e-bd2c-b070441c8c3e"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("e1a0c6ba-bd7d-4b9f-a2c3-edcd258a880e"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("e31ba883-a4bc-46c8-94cb-4ead8c6c8fe3"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("e5bf9712-b557-4b12-93fa-7ef2e6f408b5"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("e8271b22-e945-4aca-a5ac-917ef72e08f7"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("e84a0807-8af8-4669-bb7a-ac3d9ce4e807"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("eb372bb2-e537-4e2f-b199-d35152b05cbf"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("eb6a9512-ad73-4b47-b974-686d6ad48b81"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("f41e90e1-588c-4ebc-b352-374aa58deb5a"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("f5bdea2c-61d1-4cc8-8218-65db9ec20374"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("f81c8c29-66ac-4a31-9979-8e9f5b3f3ad7"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("fd6035b5-4600-495d-b39f-e4566418cd4c"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("fd91b8ba-89ba-4160-9882-7ce5eb2ed713"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("ff56eecb-5370-45f3-a17a-04d73c898a4a"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("ffbec661-44ab-4a25-9db5-a5fb9f582388"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("03768628-94ec-4106-acb9-638b7c8d3629"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("096597e2-003f-4a21-8bc3-b10e5fab97dc"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("2a549d7c-ddfe-4018-9b58-9b065880de39"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("2d671467-37b2-4e25-8f95-b825f7baf2d6"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("31c34279-06c6-4abe-a596-c21a78c98a80"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("37084656-4914-40d2-b52b-b84be3ea84eb"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("3fba8e77-c17e-4a1a-8fb5-c5426aec0ab2"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("4a4a9d44-267f-4941-aafe-ce89a0db8c0d"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("4d19dd3d-838a-4935-a770-f8bc83662337"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("51c6a648-0565-4079-8ba8-0ae5580bec16"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("59e54167-01e4-4d2f-a032-1a2a7572c816"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("60f6f331-9c92-4f58-80c8-64e587e63b26"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("67a48ac7-8115-45f5-82b9-835a09322bc5"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("69b0517c-9ed8-4c22-825f-58f9c534f632"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("76524dea-c200-46a1-a4e1-88c3bae2b1a0"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("83c2cacf-5fa4-458d-8dd0-649fe67c9157"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("99b348e8-49c5-4cc9-b6e9-775fcfdb3cbe"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("99cc55cf-cf17-4e74-a6cf-e27af3f8f00c"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("a5592cf2-0bd9-40c8-bd1a-2b2d56b81dc2"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("ac9c5765-43bc-4773-a942-9660c0fc8d23"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("b06825e1-1a39-4e65-a70a-f136e1dd56f9"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("ba792084-aa43-43e0-aa87-163ea5de8186"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("d96d7e2c-74d2-4aef-a4bc-d571e82986d8"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("dbf2b916-a959-40fb-802a-11a6783d0059"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("f658d3c4-946d-4f86-8fea-82041c249b10"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 21, 49, 6, 961, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CommercialRegistrationId",
                table: "Transactions",
                column: "CommercialRegistrationId",
                unique: true,
                filter: "[CommercialRegistrationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_CommercialRegistration_CommercialRegistrationId",
                table: "Transactions",
                column: "CommercialRegistrationId",
                principalTable: "CommercialRegistration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_CommercialRegistration_CommercialRegistrationId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CommercialRegistrationId",
                table: "Transactions");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("00eae056-7fd4-49db-af9c-ba09aad92e93"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0aac489e-4e36-4c2c-a337-956e6a071468"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("133d4160-9ade-4e68-a555-a7c4141327d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("16b29194-f4db-4451-b007-45a349f8ec5d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1a2303a4-593e-4ed0-921d-3bb2c951e3f6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1bc78086-fe4f-4011-a279-7e25ae3d16c4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("22839a3a-baa5-468d-8269-a68b0564ef0c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("33e6d8fa-7a0b-4f2c-b507-1195025ba05c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("367b57eb-6e96-4dc7-bc37-ac12337a84de"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3841a35e-f81a-4d9a-8e34-04bcf2864314"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3c0d734b-24be-437c-a324-0696561c8175"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3ccc2079-eb7f-402d-ab14-193af6b659a4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("42d7f51b-04e1-4860-b4f9-cf982b3be383"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("447d1497-15f0-4afb-829b-1481ba800136"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4f2ab366-811e-4271-8387-4c3e5e2a236a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5b284028-95b4-428e-b2a3-d631b88b14ae"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5c0454a6-12a1-4824-b620-478a35ccc06c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5fa59f04-2a0d-4deb-8703-7213755142dc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6114f9a0-4f8d-4773-8ecb-42558d929fb4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6421cdc2-7a4a-41f2-be16-335b5ff3c3d9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("685c877e-d83e-440b-afc2-8439c04d4705"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6d5f92a5-3a63-455e-9e4b-2d35e5950dc6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("71fb5542-35e7-453a-9f22-465dd53bd9e7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("77a0da92-556f-46a5-a069-2081ad666903"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("78bd270c-e34c-4b46-b24f-ee3dee835ddd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7ec0f4ca-b6d8-42a7-bbab-25eca43d6101"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("820f4af6-5719-4fce-8a32-ae628e68d5c8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("87f136d7-19fa-46aa-9bda-def2871231e3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8d0ebc33-0596-440b-b999-4afa5fbe53fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8e378885-b446-45c6-b793-93d7e1626e19"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("98b80f85-4994-45e2-91c4-2ed4cf0b203c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a4d39102-a5fe-4cf4-b9cd-008d726bec41"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a578c484-cb2a-4a8c-a9fe-6eeb85ad9bcc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a98e120d-fba6-41ff-a523-073f35c621ff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aaee4283-5e17-40db-937e-ba5c89c89a4b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ab8db91f-c715-49a9-83a1-bb19c059fdff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ae0e73ad-c3bc-4d6a-ab98-fed2b9bdbb1f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("af2fdab6-0a65-4ded-a967-6b59637de979"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b090abe7-eb75-4e94-b357-56f984b4611b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("babeadb3-a8fc-4bce-9b62-9defc27979c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bf0d0aa7-23f7-4b4a-92b8-36caaa494ded"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bfbdbef6-aee0-4449-a65b-69f589250641"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb4150f6-b650-4dc8-8d9a-f7ce465e4d3c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cc41b41b-2ea2-4b91-8bdd-c5c05481924f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cdf7ac48-003f-418d-8800-15805f0b4be0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d217d560-4ca8-41d8-ac5a-b53c8a98d49c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d67ed3f7-dba5-47e0-8742-0e801df82578"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dd3ad639-a075-4a8e-bd2c-b070441c8c3e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e1a0c6ba-bd7d-4b9f-a2c3-edcd258a880e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e31ba883-a4bc-46c8-94cb-4ead8c6c8fe3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e5bf9712-b557-4b12-93fa-7ef2e6f408b5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e8271b22-e945-4aca-a5ac-917ef72e08f7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e84a0807-8af8-4669-bb7a-ac3d9ce4e807"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eb372bb2-e537-4e2f-b199-d35152b05cbf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eb6a9512-ad73-4b47-b974-686d6ad48b81"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f41e90e1-588c-4ebc-b352-374aa58deb5a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f5bdea2c-61d1-4cc8-8218-65db9ec20374"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f81c8c29-66ac-4a31-9979-8e9f5b3f3ad7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd6035b5-4600-495d-b39f-e4566418cd4c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd91b8ba-89ba-4160-9882-7ce5eb2ed713"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ff56eecb-5370-45f3-a17a-04d73c898a4a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ffbec661-44ab-4a25-9db5-a5fb9f582388"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("03768628-94ec-4106-acb9-638b7c8d3629"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("096597e2-003f-4a21-8bc3-b10e5fab97dc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2a549d7c-ddfe-4018-9b58-9b065880de39"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2d671467-37b2-4e25-8f95-b825f7baf2d6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("31c34279-06c6-4abe-a596-c21a78c98a80"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("37084656-4914-40d2-b52b-b84be3ea84eb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3fba8e77-c17e-4a1a-8fb5-c5426aec0ab2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4a4a9d44-267f-4941-aafe-ce89a0db8c0d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4d19dd3d-838a-4935-a770-f8bc83662337"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("51c6a648-0565-4079-8ba8-0ae5580bec16"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("59e54167-01e4-4d2f-a032-1a2a7572c816"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("60f6f331-9c92-4f58-80c8-64e587e63b26"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("67a48ac7-8115-45f5-82b9-835a09322bc5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("69b0517c-9ed8-4c22-825f-58f9c534f632"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("76524dea-c200-46a1-a4e1-88c3bae2b1a0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("83c2cacf-5fa4-458d-8dd0-649fe67c9157"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("99b348e8-49c5-4cc9-b6e9-775fcfdb3cbe"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("99cc55cf-cf17-4e74-a6cf-e27af3f8f00c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a5592cf2-0bd9-40c8-bd1a-2b2d56b81dc2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ac9c5765-43bc-4773-a942-9660c0fc8d23"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b06825e1-1a39-4e65-a70a-f136e1dd56f9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ba792084-aa43-43e0-aa87-163ea5de8186"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d96d7e2c-74d2-4aef-a4bc-d571e82986d8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dbf2b916-a959-40fb-802a-11a6783d0059"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f658d3c4-946d-4f86-8fea-82041c249b10"));

            migrationBuilder.DropColumn(
                name: "CommercialRegistrationId",
                table: "Transactions");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionId",
                table: "CommercialRegistration",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03802d72-5106-4665-91fa-ab36be6943c4", new DateTime(2025, 6, 29, 18, 56, 6, 251, DateTimeKind.Local).AddTicks(8343), "AQAAAAIAAYagAAAAEK4vFSBShvDmjD0o4qcZU69JN46tTby+fKquc0ti3GAo+bYtegbtTdNtiRRUUl0tWw==", "a5cd4dde-ef7b-443e-b62a-447689ab4591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8362c69-ebc8-4a8c-b594-87949158baa4", new DateTime(2025, 6, 29, 18, 56, 6, 420, DateTimeKind.Local).AddTicks(9730), "AQAAAAIAAYagAAAAEDfLQVZj/Y0z1m54OpQkOHos8v/DBpBw1TjwBJV92Z5BuGN3IwPmWsqKX6J9sMN5GQ==", "d812a6a9-51c4-478c-bd49-201d6ba6df4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ddc0a2d-c52e-4265-a0a9-f988e691b68e", new DateTime(2025, 6, 29, 18, 56, 6, 477, DateTimeKind.Local).AddTicks(1575), "AQAAAAIAAYagAAAAEA0SXv6Bz4wg6bUOEgVqOj+KCe6sZO/AA2vE+lLrdQc+RRebt9FuvkqBt/Vib9AX5A==", "32c8f0d5-c400-48cd-b264-f81084eadb93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c45bd5a4-8e4c-49f3-a0ae-7ee09529cc6a", new DateTime(2025, 6, 29, 18, 56, 6, 196, DateTimeKind.Local).AddTicks(5482), "AQAAAAIAAYagAAAAEAZ7gq2IySNsqvkLEWRXAeYLEdX07/OD52c9+nAG2DR8k9PbmgGieCTiEiiuX1AT0Q==", "207e8a9c-8979-488c-9147-3f7a1536f289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b677d874-c8ca-4c59-afe6-830eb56c8407", new DateTime(2025, 6, 29, 18, 56, 6, 364, DateTimeKind.Local).AddTicks(2265), "AQAAAAIAAYagAAAAEPhR/wAewFJwv0PZHH0XVpl4Z3x+hNIUWWmZxumQim9SaOTTysEl3v0E1wldLgvQfw==", "b2cedf7e-bec6-4821-8ae0-06edee4d5f93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fee8891-d6cd-497b-8210-7c4769415fd5", new DateTime(2025, 6, 29, 18, 56, 6, 308, DateTimeKind.Local).AddTicks(5195), "AQAAAAIAAYagAAAAELiBjNYFOt0BnYw9+Irg/+P8NiGkFUmNXfNaTbPLUlxEdnuD0NG2NphI699bSrqhcQ==", "234f15c7-4c8c-4f8e-b135-615a932c0733" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5235e76-f36a-42cb-8f5d-b40d82aff0ca", new DateTime(2025, 6, 29, 18, 56, 6, 536, DateTimeKind.Local).AddTicks(7535), "AQAAAAIAAYagAAAAEBJDNoCfWbt1xvqxudg2aLv6VY2jclPtpPskMAHanMw/zNk7+xRRZlSoawi9UL4NEg==", "5dfb5b96-89c7-4b35-93f1-88fa57f8bd3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25d9137e-f62d-4f04-ad2d-3b5f63e0a4bb", new DateTime(2025, 6, 29, 18, 56, 6, 134, DateTimeKind.Local).AddTicks(6753), "AQAAAAIAAYagAAAAEJYmX9S02gkmM4zYVRG6PpnNLPKiMo+H462RwKZ+K2S0SLRo/6XyHKKnXphg1FhZzA==", "121b23c4-9f48-40d9-bec4-a11d916b8a0c" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0e3c9034-202f-40ac-8e88-b5f59266ad6a"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("0ff5b7d7-72f5-4fbd-bb99-6e72f827cf3d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("10242cac-5eea-4747-b869-8ac78b252195"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("13ab2f4c-1f98-4896-8695-9476996c6214"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("1a59bd54-47bd-4777-a711-ed4a89d01285"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("245be98d-bb8a-4b89-b444-4fea6f41665f"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("277f4c1e-96e6-48f9-b815-fbddf8a188a1"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("28c87053-0d12-4542-8643-926d77df5e26"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("2e8ca8b5-e74a-4e85-9b9c-b8c6cb590154"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("2fe533e3-d9ea-41bc-b32a-00725b449aff"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("32473707-25f2-4a91-8d0a-ef2dfcd8ebd1"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("35923690-e947-48c7-85e3-2d0281863e2c"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("3a39156d-058f-4659-a407-44eba3a30244"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("3c527d98-da2a-4c71-8c96-4b7e04a14a4f"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("3ed98af1-31e6-416d-bb09-40b8ea95a803"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("4d45f235-5cd3-4079-8606-225d2e86c6a4"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("59a7ec8d-382f-42d9-b34c-ee9e62f6090c"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("5d48cfc1-0717-4eb5-812c-f93c10fce09d"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("5e50ed57-e1bc-4597-83c4-ae3b867b5c70"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("5ff1dc9d-3d9f-4a00-a13f-1d80f45a3819"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("663b07c0-cb6c-4c0f-88b5-24e2991a25bb"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("73ee290c-5367-4065-a7bd-47ed111c5db0"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("77ada7ea-1125-4b40-8848-3ea844151549"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("8035aed2-057a-4f7d-a97c-e5f3d7231575"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("8134155f-814e-4a38-8c68-ac72419a482a"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("837dbce1-3a40-4b8c-9f97-dd46efae65fe"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("844b59c4-eceb-4446-8e17-bc02a6901882"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("84a5eabb-f40d-4bea-81d3-7037c3f010b8"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("85c8cf1d-30e4-4fe5-ad5f-697c08738c25"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("88be0043-c91f-45a0-bd23-e351e8563e82"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("8be4372e-3c15-443a-813b-ec42a9913b9a"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("905985b4-9821-40c2-aa4c-e09a1e4e92f0"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("9233442c-0d0b-477b-b806-131775d4824a"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("a02313b1-a7bc-4a2b-8af9-f1e0d0c91417"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("a21e4beb-4a50-49f1-8757-d79691ad1154"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("a4b532bf-22ce-449b-9741-ba8713b2ce45"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("a5980ba5-e759-43ee-aaca-3f5d3a02f758"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("a5a4d09f-d9b9-4373-b1d2-75f5b0cef19b"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("a667941e-c9b1-4989-8b2e-9bd7d78239e2"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("af2f5ff6-ee64-43c0-ab74-3fa1bf254cd6"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("b11244f3-6d23-4f9a-be90-1bf1fc2e9bde"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("b466bd33-67d3-4142-9df3-46f0dfc18b33"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("b7dfe269-b622-40ae-9625-3d15215e95fa"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("b879d1a1-7528-42db-91e6-3498cf723938"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("bffa4b28-5e61-43a1-8fdc-488b36c34f60"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("c3697118-f0cb-4e3d-8384-d996e472c087"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("c8286e36-da49-4357-9ae7-7b8674218a5f"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("cdb04cc0-b96b-4381-860d-24d28ac8e9f3"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("d255e45b-4451-43ae-8636-5d620fd6d78d"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("d48aaae9-9232-4f7b-aa74-284e917c9022"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("d48e27b9-5df6-449f-9207-40eecf8daf88"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("e3d84b66-c217-46c7-b49d-703c08e40e3c"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("ecacc488-efe4-4519-a9c9-59d30026d4de"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("f15409a0-82f4-4902-b10c-0652a2111e2c"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("f2469f03-e06b-47cd-838b-385433290159"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("f2a0d025-8c0a-4a60-8be2-532d287c6cd8"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("f3860285-72c4-496b-9861-982cedee6010"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("f9eab3b9-dc61-4cef-8e13-82a17c46177f"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("f9f3fd90-c6c1-4575-848f-ab5676d9b6b7"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("fb03fa22-7485-4fb3-b384-73998bed60aa"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("fc7a14a2-955e-4921-a54e-f613cfb81dda"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("fce9aa0b-8b34-40bb-a0ee-cc6538652fa1"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("010e019c-19dc-413d-92c0-e203cd61bda6"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("0f7fbc86-d2bb-4aaf-8ccc-73114dfc8192"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("1756076a-8c6a-4137-b811-d3842dc5ced1"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("1895cbc2-2d9e-419b-b16c-38a45483b120"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("1b40d829-57ce-4448-9f75-390c89f7ddd6"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("232b0447-0189-4bd8-89f2-d45d5235a907"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("345ba905-9ee7-437b-ae5a-cedf492ee637"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("3b7cc6df-79f5-423a-8cf4-ea487772c909"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("3bfff600-3c54-42f4-bcf1-42af15995bad"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("4d25f538-a4f5-4c2a-acf4-dd722059c629"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("5b1277c9-c609-4eb4-94c4-f3a0de064285"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("6eb063d0-af11-4d6f-ae28-5d7187856572"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("851767ec-24fd-42f4-97a8-a919079324e9"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("886cf87d-35f2-4f22-8177-759ed58b568d"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("897805ec-9727-4b3e-9e40-53f33c9153a1"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("9da40c06-440f-4295-955e-417053b53f5a"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("b2ad394a-feb5-429a-a901-67161ee88b3c"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("bb5145eb-7f21-4570-871a-7536dacefe96"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("c0063bc8-f23f-4025-8681-1278fb74c94a"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("c1a12345-b9d7-401a-b7fb-6fb8ea8b69e1"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("d654b5e4-1e55-4c02-8766-c0f39146e767"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("dd221855-636c-4d0d-9667-887661aea2d7"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("e417680e-122e-4d03-ac6e-99e19255ab98"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("f73f4640-8a88-4238-8527-dd364ba03155"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("fd73ce8b-6962-49b9-a5c2-cf618a87b875"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 56, 6, 116, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.CreateIndex(
                name: "IX_CommercialRegistration_TransactionId",
                table: "CommercialRegistration",
                column: "TransactionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CommercialRegistration_Transactions_TransactionId",
                table: "CommercialRegistration",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
