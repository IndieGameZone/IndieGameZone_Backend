using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("040ce18c-c0ab-4251-8750-e6ac8d4c9b83"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("04dbbe37-a38b-4965-909d-a6f6e63e6806"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0734f190-39f5-428d-902a-9aee908c19ba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1379b38a-f9b1-4ec3-8aef-4bd74cef8242"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1749dfd9-10ab-4fda-ab34-b89ed6f82dd1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("195ca1a2-b4e3-4c57-b83f-fa1da59685dd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1d68497e-7aa6-4819-99fa-68bcb128f060"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ec1bc4b-9536-4b75-b5c7-3d2f2c8bb65a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("26af7063-e1d1-4525-b195-799fa6135e33"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("27308ed5-92e5-4d48-bcb1-18b3d05d4edb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2f460914-5e3a-402c-8ad2-91be13f6fad7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2fd5e2dc-427e-429b-b576-9543f3f23944"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35a6687b-7b3f-4f51-b25f-f5969337cea6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("370839c3-adfc-41c1-af3a-b8d50e2fa6a9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3ac97289-bc6b-421f-a90f-c12e339bd15d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("41249fcc-93e3-4af4-b7bb-7e6b7c34ee92"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43025af8-7541-4e1e-886e-c4b702310dd9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("463d13f8-9182-402a-8d89-f445083cc427"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("48a87bed-e068-4ff6-8fef-9e29d7c46d01"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("49620800-6e34-4bef-b809-0a23a4808fec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4ad30fbf-d27c-4d75-a5b4-adb848134b2e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("50373e13-a1aa-46f8-a102-48a5f096c701"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("536c9ecc-a33e-4b72-b90e-4852be65278c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("54cdb8c6-ea36-484e-bb02-647293c70ea1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("56ee355f-4174-4968-97b8-64022be420b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5db0c397-81eb-4fe3-a460-91ee3f89589a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("67ca8879-48a2-4d0e-bc41-8f98145e9c6d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("69ecc5e2-1c47-4296-ab62-d42b3d949c06"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6f230622-bba3-4d78-af65-0e4d2d48bd70"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("74b4a04e-4080-4665-883d-196484d91c36"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("788acb45-8837-41b9-a678-c1f73407adec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7995bdcc-4c82-4e6f-86fa-e85933fbf490"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("82c1cf99-793a-4b6c-b009-c60ebf54cb9a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8592fecb-7ef8-423f-8825-1ba5656833c9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("877008de-abea-41a5-9230-7cb0016a97f8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("929feaa4-10fa-473b-b10e-b7a467ab2246"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("93b8aba4-8f54-4145-85f5-2c2195ff3749"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("94638b30-c639-4330-b4a8-a42252c1d6c3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("95437814-12f0-443c-9cf4-7e38b3c2b36f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("98febee5-086b-4391-8438-1bd6d4e09f6f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9ba9e966-87dc-49fe-ba89-4a6f75fe8478"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9f5acaca-c7b9-4cf2-abc1-c8d99a8b5f9b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9fba60b2-5f48-431c-9f7f-832a4dbd505c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ae64e56b-78f6-4545-a34b-2c9689e3a9c3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b9bcf1a4-e3a9-47e1-b3a7-fe4bcb4759a5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c24130ab-9893-467e-a102-e82258a43eed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c5ea80db-cb31-494c-92ee-70444b7cfc64"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c802286e-9e03-44fb-a6e5-3079d0423349"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c9b5984c-0dbd-4bcc-8fe0-b017e1c045fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d0eb3fdf-9f0f-48f8-8db7-e1d158ce5824"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("db3fa7c8-3684-4ac0-aa77-4ab867ddf833"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("de4adfea-9137-40f6-8b4f-ef10a0eca645"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e17f0323-3d8b-4a81-a2a3-7e7be70de8f9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e3faf47a-81c2-4ce0-abe4-6468d602424f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e5d70348-a045-40b9-97ca-c3d04c4ad0df"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e91fc23d-13d4-440a-9f74-3ed14552b40d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ead2b2ef-5bcf-46f1-b338-8c66ab5355ba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ee87076a-d877-4d94-b247-edb78e81a00e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eea6cfcd-33d9-4841-8d26-733513662fe6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ef872298-19b0-4de0-b9ec-5dfbc36e0c73"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("efa16796-ebd3-4192-999f-7ad3fdd15a32"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f93dc750-f5b3-41d9-bbff-59ddcbf66f18"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1199a2ad-60c9-4ab6-b2d6-ec1f99038f4f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("14a080a6-2fe3-41e2-8e20-a97cd81760de"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2ae8b2ea-d85b-44db-b057-10037c1c857b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2d27d4ab-a2dd-4fb4-b2bc-936fd53d2f0b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("303a1cbf-c67c-4498-bc2d-d80c489f0927"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("31ccb741-61a2-41ed-a476-20fd53ee7226"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("34ec69ba-0c5e-42a1-a589-300e0e27bb9a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("49c3d937-cd3b-4124-b294-88b9eaab783c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("55f684c1-6483-4b7c-9ac0-7a056f57265d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("77dbb07c-eefb-4024-b620-42712ad2eec9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7a5650b1-afb2-4237-80dd-f30d1896bef8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("90c52422-1d4e-4e78-8898-e9883823f1ad"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("910f760d-9c75-4e8b-ad06-6b9d6a076130"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9c7dbf26-af5c-434c-816b-7b49af99a79d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a142fdab-5958-4dd0-a7a7-5e867b6f12c3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("aa957a79-2b7f-40d3-a397-3a18af81acf3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b0d42deb-c395-4abb-a41b-47db4088cd7e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c46ccc42-158e-41c9-94f1-9fd357e1831e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ce976814-1a07-46fd-91a0-3d316117d4d3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d022e72a-5235-449e-967b-84dcb27c7047"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d0684fc2-9e73-40a4-aba6-c5dc65e7d315"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d07b07d7-d69c-49c1-af2d-98c9cc2cfca9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("efd210cd-f3a5-4595-9b7c-ab3d8ccff53c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f4ad562e-355c-4e17-bb19-281c0271c768"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fac06f72-970c-482a-a414-f1319ba885e6"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6165b266-0711-4994-b7e7-c9332a365609", new DateTime(2025, 6, 29, 14, 20, 3, 341, DateTimeKind.Local).AddTicks(6020), "AQAAAAIAAYagAAAAEC9gRDSWkS284QDx0iTjKJdO/aDPQveCHaDO/PDpWOigWyDpTmfdT7DGglmzInTVtA==", "69188c5f-5d6c-43aa-a39a-5a8058e7c1f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26c6b19c-42c3-4943-b821-5fb59a1000d9", new DateTime(2025, 6, 29, 14, 20, 3, 588, DateTimeKind.Local).AddTicks(5823), "AQAAAAIAAYagAAAAEMwKG2aUnqbOa+gbqRGad7ZxjkvzoilmkTd06eQjk0ilXCzQRwvTtHxRCtgeIvrOFw==", "b1d3e6c6-3f31-4752-bae3-31ed4721c295" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c9386fd-8b43-47b0-8a06-d8cce8e6e162", new DateTime(2025, 6, 29, 14, 20, 3, 648, DateTimeKind.Local).AddTicks(992), "AQAAAAIAAYagAAAAEAkVE3OGkJ4vRYjmUR5xBk364girdZ92Fzn4jMrBGkTkUmFfw//NcJlqCUqIZ5+l5Q==", "316986e5-aa5a-437f-a075-f2a8d72c9958" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24286bcb-82ff-4bbb-b50f-91f010fd311d", new DateTime(2025, 6, 29, 14, 20, 3, 286, DateTimeKind.Local).AddTicks(2401), "AQAAAAIAAYagAAAAEM0nSpGnp4AomM9A10nIwKz12taowvgpZSpD7JtHYe8u4+EqdtTt23QZoO69cX4v/A==", "67e6f748-3372-4a6b-b3aa-dee844383864" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "625d74ed-e9ca-4bad-96ac-23745a0d1b16", new DateTime(2025, 6, 29, 14, 20, 3, 532, DateTimeKind.Local).AddTicks(9576), "AQAAAAIAAYagAAAAEHeNaoUgfQfeHYEn30kV6x49QJbuXd3oA+GH3bEe0Tm5mZ4uCjKcI6QnfnjgBhN45Q==", "48c509a7-ad48-4d7d-8d72-fd9ed5e94f9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81ef593a-3251-4505-b65e-349e3cf350f8", new DateTime(2025, 6, 29, 14, 20, 3, 466, DateTimeKind.Local).AddTicks(9658), "AQAAAAIAAYagAAAAENm3ML33QtQb8ZIdw3/XfoRzzlLu5jsvcCYFGwCy9dTtTV8o9ru1ScOkDicsIvCb/A==", "d89efb08-5144-400e-8ab6-72aa429b92e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc5faf77-417b-4918-b6e7-0bc1a56e8a9e", new DateTime(2025, 6, 29, 14, 20, 3, 707, DateTimeKind.Local).AddTicks(234), "AQAAAAIAAYagAAAAEExWWJB7mLUWpMsyuqNv3ZGW0ancC424/+W8eYMDfZ2XAbxnVydafUBY0zJwaAgm1Q==", "495ce215-591e-42aa-a7ed-cd1a5c2673ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45dd8c9e-c548-4f0d-b32f-6d35e869a839", new DateTime(2025, 6, 29, 14, 20, 3, 229, DateTimeKind.Local).AddTicks(5504), "AQAAAAIAAYagAAAAEB+GfIXycmRwHNctQJBYwPmpo1bZkyAsuOyco8e5T4Oi2aYPvim+tilv16gvA5dGHA==", "4e7c03e9-7de4-4e0d-b0a4-4a2be129c00a" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("040ce18c-c0ab-4251-8750-e6ac8d4c9b83"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("04dbbe37-a38b-4965-909d-a6f6e63e6806"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("0734f190-39f5-428d-902a-9aee908c19ba"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("1379b38a-f9b1-4ec3-8aef-4bd74cef8242"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("1749dfd9-10ab-4fda-ab34-b89ed6f82dd1"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("195ca1a2-b4e3-4c57-b83f-fa1da59685dd"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("1d68497e-7aa6-4819-99fa-68bcb128f060"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("1ec1bc4b-9536-4b75-b5c7-3d2f2c8bb65a"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("26af7063-e1d1-4525-b195-799fa6135e33"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("27308ed5-92e5-4d48-bcb1-18b3d05d4edb"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("2f460914-5e3a-402c-8ad2-91be13f6fad7"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("2fd5e2dc-427e-429b-b576-9543f3f23944"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("35a6687b-7b3f-4f51-b25f-f5969337cea6"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("370839c3-adfc-41c1-af3a-b8d50e2fa6a9"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("3ac97289-bc6b-421f-a90f-c12e339bd15d"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("41249fcc-93e3-4af4-b7bb-7e6b7c34ee92"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("43025af8-7541-4e1e-886e-c4b702310dd9"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("463d13f8-9182-402a-8d89-f445083cc427"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("48a87bed-e068-4ff6-8fef-9e29d7c46d01"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("49620800-6e34-4bef-b809-0a23a4808fec"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("4ad30fbf-d27c-4d75-a5b4-adb848134b2e"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("50373e13-a1aa-46f8-a102-48a5f096c701"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("536c9ecc-a33e-4b72-b90e-4852be65278c"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("54cdb8c6-ea36-484e-bb02-647293c70ea1"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("56ee355f-4174-4968-97b8-64022be420b8"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("5db0c397-81eb-4fe3-a460-91ee3f89589a"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("67ca8879-48a2-4d0e-bc41-8f98145e9c6d"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("69ecc5e2-1c47-4296-ab62-d42b3d949c06"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("6f230622-bba3-4d78-af65-0e4d2d48bd70"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("74b4a04e-4080-4665-883d-196484d91c36"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("788acb45-8837-41b9-a678-c1f73407adec"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("7995bdcc-4c82-4e6f-86fa-e85933fbf490"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("82c1cf99-793a-4b6c-b009-c60ebf54cb9a"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("8592fecb-7ef8-423f-8825-1ba5656833c9"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("877008de-abea-41a5-9230-7cb0016a97f8"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("929feaa4-10fa-473b-b10e-b7a467ab2246"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("93b8aba4-8f54-4145-85f5-2c2195ff3749"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("94638b30-c639-4330-b4a8-a42252c1d6c3"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("95437814-12f0-443c-9cf4-7e38b3c2b36f"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("98febee5-086b-4391-8438-1bd6d4e09f6f"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("9ba9e966-87dc-49fe-ba89-4a6f75fe8478"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("9f5acaca-c7b9-4cf2-abc1-c8d99a8b5f9b"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("9fba60b2-5f48-431c-9f7f-832a4dbd505c"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("ae64e56b-78f6-4545-a34b-2c9689e3a9c3"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("b9bcf1a4-e3a9-47e1-b3a7-fe4bcb4759a5"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("c24130ab-9893-467e-a102-e82258a43eed"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("c5ea80db-cb31-494c-92ee-70444b7cfc64"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("c802286e-9e03-44fb-a6e5-3079d0423349"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("c9b5984c-0dbd-4bcc-8fe0-b017e1c045fd"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("d0eb3fdf-9f0f-48f8-8db7-e1d158ce5824"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("db3fa7c8-3684-4ac0-aa77-4ab867ddf833"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("de4adfea-9137-40f6-8b4f-ef10a0eca645"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("e17f0323-3d8b-4a81-a2a3-7e7be70de8f9"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("e3faf47a-81c2-4ce0-abe4-6468d602424f"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("e5d70348-a045-40b9-97ca-c3d04c4ad0df"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("e91fc23d-13d4-440a-9f74-3ed14552b40d"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("ead2b2ef-5bcf-46f1-b338-8c66ab5355ba"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("ee87076a-d877-4d94-b247-edb78e81a00e"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("eea6cfcd-33d9-4841-8d26-733513662fe6"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("ef872298-19b0-4de0-b9ec-5dfbc36e0c73"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("efa16796-ebd3-4192-999f-7ad3fdd15a32"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("f93dc750-f5b3-41d9-bbff-59ddcbf66f18"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("1199a2ad-60c9-4ab6-b2d6-ec1f99038f4f"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("14a080a6-2fe3-41e2-8e20-a97cd81760de"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("2ae8b2ea-d85b-44db-b057-10037c1c857b"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("2d27d4ab-a2dd-4fb4-b2bc-936fd53d2f0b"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("303a1cbf-c67c-4498-bc2d-d80c489f0927"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("31ccb741-61a2-41ed-a476-20fd53ee7226"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("34ec69ba-0c5e-42a1-a589-300e0e27bb9a"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("49c3d937-cd3b-4124-b294-88b9eaab783c"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("55f684c1-6483-4b7c-9ac0-7a056f57265d"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("77dbb07c-eefb-4024-b620-42712ad2eec9"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("7a5650b1-afb2-4237-80dd-f30d1896bef8"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("90c52422-1d4e-4e78-8898-e9883823f1ad"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("910f760d-9c75-4e8b-ad06-6b9d6a076130"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("9c7dbf26-af5c-434c-816b-7b49af99a79d"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("a142fdab-5958-4dd0-a7a7-5e867b6f12c3"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("aa957a79-2b7f-40d3-a397-3a18af81acf3"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("b0d42deb-c395-4abb-a41b-47db4088cd7e"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("c46ccc42-158e-41c9-94f1-9fd357e1831e"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("ce976814-1a07-46fd-91a0-3d316117d4d3"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("d022e72a-5235-449e-967b-84dcb27c7047"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("d0684fc2-9e73-40a4-aba6-c5dc65e7d315"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("d07b07d7-d69c-49c1-af2d-98c9cc2cfca9"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("efd210cd-f3a5-4595-9b7c-ab3d8ccff53c"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("f4ad562e-355c-4e17-bb19-281c0271c768"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("fac06f72-970c-482a-a414-f1319ba885e6"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 14, 20, 3, 213, DateTimeKind.Local).AddTicks(3071));

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
    }
}
