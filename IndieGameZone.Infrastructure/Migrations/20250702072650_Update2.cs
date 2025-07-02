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
                name: "FK_Reports_AspNetUsers_ReportedUserId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0533d44c-9c56-4bc1-84e7-c968f0b510e6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("106e9947-0b13-4ba2-9792-d5f4d189fc9e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("15cfb7e5-d835-4696-adc5-8ef9bc21de0c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1e7396c8-9162-44bf-9c45-a3b8a4945fd1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2220c264-b122-4c7e-9d95-5ef69141a0e5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("23d96cc1-abc4-4949-980a-08dcb82b2dcc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2452fe54-efb8-48c1-ab92-1958edf01208"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2d11f196-320d-4e11-9932-a1439eee3fb6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3186f1b2-9bb0-466f-959a-90477b7dce2f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3437cea0-b3f9-4f02-b5cf-10a0e2c9fd2c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3ad16221-bf95-4b2a-9508-4b05d57848c9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3d443037-0881-4cbc-a881-5073a65dcb35"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43dc5b27-bb2d-4491-a3c6-5396f1e094c0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4684a355-4344-44cf-a2f3-a3b4f2a83b78"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4a22cf75-3ae7-46e2-8843-245c335debcf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4d8eabda-5c9b-45c0-8d8e-9f14e5ebddd4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("56a67c40-6559-47ce-b12f-0244a766dd64"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6b121295-3948-4c8a-8fcb-d9bc34ddacc8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6e9be909-e000-4b8e-8991-07ef908751d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("701458b4-1e0b-4a72-8ee1-5564fb25ea0b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("71d2170b-40c0-45ca-9bf8-ce506f02e0b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7526bc78-e298-4351-ac28-c53c3158d4cf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("77a71735-c5dd-4a21-949b-0b53c0376d6b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7d3bebe6-88e7-436a-a40a-209e2890bf74"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7db939bd-e4dd-48e6-b6f8-84bf042caabd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("80947ad0-6ca8-436a-95e8-8bda6bc637d5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8a0ac192-13fb-4e76-a545-b455442f53ec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8e110b36-4ef8-4092-994c-5724f131317b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8e6dab40-0e40-4895-98e0-a782a2b3cbb9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9cafbf82-5450-4c68-8488-875a55a73634"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a2a6a370-9653-4b7b-97ba-f1e01b444cf7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ae09a6f3-b92e-4ad7-beef-b3228aeb66eb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b056b5a0-0c8e-48ed-9c64-919c2d3d6de0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b088842e-a792-4170-9f08-1e5dfe146281"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b38fe607-dc39-4c7a-9aaa-2e8ab65c86bc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b3d77dff-4d33-44e0-834f-2fd3d8ee3cf3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b3ff8134-c96f-4c02-befc-cfd3fc28071a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b631afe7-7048-45b0-ac00-67501a8fa722"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b8674639-c0ba-4469-9da2-20cb440d807f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bd010bc8-cd8d-4397-be05-38a7d9aa964a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("be2c8ce1-f2d9-41ca-8c07-fd75d402bded"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c0bdc7cf-05e8-4485-8a97-d9748a0cfd96"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c0cf3173-28f4-4c50-8fec-29d9c44a005f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c6bd0fda-808c-41d2-a373-b898d0442665"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c908a86d-0471-448b-a7c1-2ae1d5436bf7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cf1ce3ec-5734-4c09-a994-6425a0c10106"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cf91c2a4-0db6-4458-a84d-3c8f914bbc68"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d30d5888-9a9a-4b22-8890-797286389ae2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d5c21d64-06b1-4efd-ae9a-7542783b6431"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d615ac4d-2262-4b52-9f23-988127ed6332"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("db14a96a-7421-425d-801e-6081fb514358"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dde05d7d-c792-44c8-a788-6ad977b36fff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e2e63d80-ab7a-4f3c-8b43-90559cb5c65f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e75ae701-0374-40c5-b9de-21f14d135d17"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e8b18534-ffe5-4d55-8b52-03c26436da75"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e9ed3909-0341-42b1-a56e-89cd4829c512"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ed76588d-699a-441e-b304-28b4d7174f8e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f4cbfb10-7929-4fe9-8452-6f774e711c28"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f6e27380-82ca-4a7d-a7a6-03381832c331"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f9f2ac33-8a86-46c8-97f7-58f6bed41079"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fa244609-327b-4987-8f03-f11481959f7d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd5dd781-801c-4d66-8b03-71ed0c78f843"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0f74216d-ebfb-48e2-862a-b5785256ea4d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("143e1533-d898-4fb7-a5e6-fe10a58c0fa0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("14b625b4-8725-4aca-840d-0a4c9d10db6f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2563f05c-5b43-4e80-bd3a-4c99fb318336"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("29a72729-cde2-44ca-934f-10b2060f7d67"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("322bf570-d8ab-4143-81e6-958209fb4f4c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("46e4f6a3-50df-4193-8c94-8161f51dc362"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("525d0f6e-b370-41b6-9f05-e86bc4458578"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6217aad3-b894-4646-b5da-0b76905f4852"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6aec24fb-3d1c-4ff2-87c0-d77b367efafb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6b179ae6-1fd2-4d2e-9bdd-4c6b708ad544"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6d66b98c-d0e3-40de-bc4d-16b38e70988d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6f9a886d-f8ea-4932-a063-1c12a9438ad4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("85d83732-e640-4b2b-8e32-625783af2b9f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("94c09a30-4896-4a7b-8f97-56a12e7c334d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("971fa8b1-b1b5-4a1b-a3ff-15081e2b004b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("985947f2-2d3e-4392-b98b-ee7930929904"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a04807a7-505b-4377-8126-a7a252614c2c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ab8457e1-c38e-4f68-ae63-de5cc7b474cc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ad79e679-eb70-4cad-a20c-0e3891c4e1a3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("cab07a1f-63c5-41b3-ba00-f5842a10db01"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("cd406175-f7d2-4c89-9efc-e2676974536c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d006ac31-bb99-435f-976b-fb39fdf2df4a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d2763a6f-ff17-4f5c-87a9-c6c82a36c71e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d62a4047-c00e-452a-9697-493ae4bc7a0b"));

            migrationBuilder.RenameColumn(
                name: "ReportedUserId",
                table: "Reports",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ReportedUserId",
                table: "Reports",
                newName: "IX_Reports_UsersId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31079c93-7367-40d4-8136-6f589d89f364", new DateTime(2025, 7, 2, 14, 26, 48, 984, DateTimeKind.Local).AddTicks(5289), "AQAAAAIAAYagAAAAEB+h8Xr3NJoRFPHOoJdyWaK56zRd34dDuvgU0NgAb71qP/y4t8KqlW/ijQE8MBteLw==", "8bb75656-fe99-48fc-b7f5-ed09e639dcd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8fe086d-e6c6-4371-a0e1-d97366eceb9d", new DateTime(2025, 7, 2, 14, 26, 49, 157, DateTimeKind.Local).AddTicks(8516), "AQAAAAIAAYagAAAAEKATcsROQXL0aE2fxW2Jz5uHTV6LhXup28A207Y8Bhe2IBNlCs9u2rVbB+fpkfNfLw==", "7fb950c1-93ed-46ed-85b0-e531d34c02a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8d5d6a-7451-45a8-9b74-fe8a70c542b9", new DateTime(2025, 7, 2, 14, 26, 49, 212, DateTimeKind.Local).AddTicks(4035), "AQAAAAIAAYagAAAAEAQ0KGjsyiqZr+C/1tDI9km6zsIXYGNYBeL4dQ6yTYKqcvG2szcPThqHZEgLwoR8eQ==", "836daaee-9a82-41e3-895c-c0682f5d8750" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cad403f-a08c-4a27-a5d4-e074eab630c1", new DateTime(2025, 7, 2, 14, 26, 48, 928, DateTimeKind.Local).AddTicks(6517), "AQAAAAIAAYagAAAAEJnP7+NUTNVFRa8FWkbGjpuRpj3nbikurZUX9mwd72gz4tbDR4+pEWSOyY66HvLxOQ==", "f489f89c-5d64-4c32-bd2f-adce8d77c9fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d743b27-417c-4ab1-8c18-96039a1aecae", new DateTime(2025, 7, 2, 14, 26, 49, 95, DateTimeKind.Local).AddTicks(9331), "AQAAAAIAAYagAAAAEJ+GiJH9n+cCXiXxtBS2P9VMf53r8cI6ssCxZa/mgWZyWlSrbqfJW1+5LU6WVo72GA==", "ceefadfe-e9a1-45ff-89da-59e1051110b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a453778-d0c6-4f73-bc90-35ff220b9070", new DateTime(2025, 7, 2, 14, 26, 49, 40, DateTimeKind.Local).AddTicks(2618), "AQAAAAIAAYagAAAAEPLXbP67vaFh/HnYOqnHMreY8Fe3G2VgBZW15m7rs0FcoGoai+MUho4T57SwPAZVXQ==", "2ca90cf2-5209-4010-bed9-ed1b8aadf34d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74e8304d-a1d1-4736-8baa-4734bf85c03d", new DateTime(2025, 7, 2, 14, 26, 49, 268, DateTimeKind.Local).AddTicks(7807), "AQAAAAIAAYagAAAAEDwlYH4inTWhZ5CerzfI9X0MX4LZX5qoXAYvX3CajQlcsqjtBT1sFe37FXIWUJyXBQ==", "f6f228e9-1d42-4e2e-ab3f-61e77178cc08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f500a109-911a-48bc-a4e8-c1d7274877d3", new DateTime(2025, 7, 2, 14, 26, 48, 870, DateTimeKind.Local).AddTicks(7774), "AQAAAAIAAYagAAAAEOZ1fxFO9Uzc9+sFvr7rcs0ovV/wHFMKdmUH9oqiMvuM5/9yAX43CrqUAl8t9vM5tw==", "a0ce42ee-e62a-4ed0-be40-0d227a44550e" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("00e9f7f5-668a-40a1-9b71-f12f34b0bf57"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("016e9bfd-df64-4cd4-9a62-ba0d28525343"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("04e417b2-fb0f-4341-b887-59f3cb494465"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("0a8933e4-0c25-49e0-8635-d291c7fd5ca6"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("154d7e6d-05bf-493c-82b4-eb5efe14a16b"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("1704f206-63c8-44bd-a28c-61f92583d564"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("18c1bef1-c82e-4e49-ae3a-7d46e06c82e1"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("1b5b2a11-f466-4752-96a3-f4243932cdea"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("1b649dc6-537f-4571-85df-953aeca0ba60"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("1ddf5c69-3f47-459f-8cdd-aa8f57bd92da"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("1f4255d6-f8c6-44a2-84fa-e74f778d6360"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("20eba0d3-a109-4967-9fb7-a5e49959d507"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("23bcd07b-9fd5-461c-8c7e-285c48dbf35f"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("23f5ede3-7fcf-46d1-b660-fe91f3410747"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("28b02ab2-91c1-474a-9b30-7da8c8e957d2"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("29e6a612-c490-4155-93cf-1248c4f85d67"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("2a5b9052-23bd-428a-92fb-902eaeaea502"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("2f2e96e0-6a30-47d2-8ba5-fcf775c35eec"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("34952ed1-822c-4be4-ab1b-58c5091e3f20"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("358eafba-9c05-4f49-b246-5ce6cb945717"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("3b78374b-6e46-4e77-a9fa-fe3a9ecaa2f5"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("3de05f8e-e7fd-4792-b29e-3eba99d78293"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("40b50d59-b71b-43b5-a434-c962ef6023bb"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("44ab0211-14c4-4e0f-b7a5-35166d503f0c"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("5214e408-0fb7-4acf-a5c7-6ec9393edaaa"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("52b48f4c-1ae8-4307-8b0d-74a25bf1cc39"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("5a348503-191a-40d4-b627-52ad15b7c46d"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("6fe90573-790a-4d7e-bc14-9bcd68e66ec4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("71fa7624-d729-429b-984f-98db906289eb"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("7268c8f4-010c-4842-a61e-62836ecb0391"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("748a23c4-a97a-4633-a8ea-d393d628c447"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("77691228-d69f-4403-9362-ba488a7d9919"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("7f8f52ea-6671-4afe-9e46-7842f34227e2"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("860d0bd9-93a5-495c-9d63-fda243b2d4d7"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("8aacaa72-9091-4662-830c-59df09242b71"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("941452d0-4918-42d1-a5bd-49fdc443eb99"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("96587455-27d4-4901-af3c-79c435a31a45"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("99529c35-32ec-4c5b-846d-c776ba5ca009"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("99b50df7-081b-4d02-9278-35f22c0434c6"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("9af38860-6851-4473-a342-e65866c8a4ef"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("9c793bb4-8718-466b-90ae-def010290fcd"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("9e7e3096-f0b1-4766-8d46-184dfbc90d60"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("a314dd20-b8bf-4fc7-a6b6-24c79d5d217e"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("af0bf33a-ccc2-4552-9480-6d2a2f811f9c"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("b5e252fc-ab9a-4ff2-a397-9a03f63051eb"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("bca85edf-c481-49dc-8324-e7184cd60307"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("be73a680-9402-423b-9410-f65c86029dbb"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("be96a6cc-f2f7-4d92-a065-2e13ed870add"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("bfe641b1-ff48-4036-84d9-14697e05dc00"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("c737c713-ef50-4ce5-ab7f-9f2ec95957db"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("cc1d9be9-d5e9-40ae-acd5-b82b1eb89e77"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("d06fbf0d-a566-449d-acc1-4b7097105d12"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("d16ba8ae-de59-46a2-ac75-1e7b49e69943"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("d231718e-e94c-43ac-bd94-68d7dbe5a88e"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("d315c267-8293-4ba9-9ccc-dab096823f9d"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("d3600181-614a-4637-bcab-b28c56cd4b38"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("d49813ca-f065-4848-9fd6-7b4ea6533e20"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("de2fb3f9-d249-44e2-8688-155031882d3e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("de6e47c9-f9e4-4bbe-9eb7-9c5152c9430f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("e4f1cb4f-5a5f-43fd-9729-a773f88b5ff0"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("e9382f92-322b-497b-a85d-f288046db166"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("e9f24efd-8643-44ac-9e43-76f8f16acf7b"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("21268004-51ad-42bb-a3d7-4987b605b093"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("24dda56c-3bf2-45b8-a524-0870fc6c6e2d"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("300c94be-89d4-4774-86dd-aa015cf62bc8"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("3ee3b584-499f-4464-a841-3805de1b968c"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("451f4680-50b3-4006-988e-bff1c9b737c5"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("49d3eb15-77b8-40a7-bae3-fb1814908f7b"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("5485df5b-00ee-41cf-bb21-003a2917daa1"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("63853f96-0656-446e-8ef6-6dd098247ef9"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("6ba3fa86-b99b-4640-ba6f-a65a8a257fe6"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("815d7a75-cae9-4452-8b32-46a8e6f905e8"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("83d8ee80-7a6b-438f-86c6-a4a6c5f4c517"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("905305dc-3db1-4cba-8164-4679fa8ba902"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("92076c74-7576-4201-91cf-9503acdfbf1a"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("97c24e58-1da1-4b42-b287-46e104653704"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("a3c1d29f-f651-436f-8886-6b51d43774d2"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("a6dc3576-9682-4b79-8de3-8d393b08f896"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("c5c3cdab-25f7-4dc3-b2c5-908753e78df1"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("c727f555-d56f-42b9-a184-ced09591082f"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("cecf4879-6c0e-4018-88b0-a67c23143101"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("e147e12d-1fba-48ab-960e-7116e50bfca3"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("ea75667a-3f0c-49fd-ac8e-7e5867137b79"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("ef9d5cf6-65b5-4218-b89c-2bda6ca848cf"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("f32ebb04-884a-4eed-8c53-522aca84f847"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("f42a2cea-e682-4d10-a99c-1af093e8067d"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("f4d4cbb3-f2ea-4404-bc89-5905613ef995"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 14, 26, 48, 856, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_UsersId",
                table: "Reports",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_UsersId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("00e9f7f5-668a-40a1-9b71-f12f34b0bf57"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("016e9bfd-df64-4cd4-9a62-ba0d28525343"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("04e417b2-fb0f-4341-b887-59f3cb494465"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a8933e4-0c25-49e0-8635-d291c7fd5ca6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("154d7e6d-05bf-493c-82b4-eb5efe14a16b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1704f206-63c8-44bd-a28c-61f92583d564"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("18c1bef1-c82e-4e49-ae3a-7d46e06c82e1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1b5b2a11-f466-4752-96a3-f4243932cdea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1b649dc6-537f-4571-85df-953aeca0ba60"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ddf5c69-3f47-459f-8cdd-aa8f57bd92da"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1f4255d6-f8c6-44a2-84fa-e74f778d6360"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("20eba0d3-a109-4967-9fb7-a5e49959d507"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("23bcd07b-9fd5-461c-8c7e-285c48dbf35f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("23f5ede3-7fcf-46d1-b660-fe91f3410747"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("28b02ab2-91c1-474a-9b30-7da8c8e957d2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("29e6a612-c490-4155-93cf-1248c4f85d67"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2a5b9052-23bd-428a-92fb-902eaeaea502"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2f2e96e0-6a30-47d2-8ba5-fcf775c35eec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("34952ed1-822c-4be4-ab1b-58c5091e3f20"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("358eafba-9c05-4f49-b246-5ce6cb945717"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3b78374b-6e46-4e77-a9fa-fe3a9ecaa2f5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3de05f8e-e7fd-4792-b29e-3eba99d78293"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("40b50d59-b71b-43b5-a434-c962ef6023bb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("44ab0211-14c4-4e0f-b7a5-35166d503f0c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5214e408-0fb7-4acf-a5c7-6ec9393edaaa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("52b48f4c-1ae8-4307-8b0d-74a25bf1cc39"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5a348503-191a-40d4-b627-52ad15b7c46d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6fe90573-790a-4d7e-bc14-9bcd68e66ec4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("71fa7624-d729-429b-984f-98db906289eb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7268c8f4-010c-4842-a61e-62836ecb0391"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("748a23c4-a97a-4633-a8ea-d393d628c447"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("77691228-d69f-4403-9362-ba488a7d9919"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7f8f52ea-6671-4afe-9e46-7842f34227e2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("860d0bd9-93a5-495c-9d63-fda243b2d4d7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8aacaa72-9091-4662-830c-59df09242b71"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("941452d0-4918-42d1-a5bd-49fdc443eb99"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("96587455-27d4-4901-af3c-79c435a31a45"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("99529c35-32ec-4c5b-846d-c776ba5ca009"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("99b50df7-081b-4d02-9278-35f22c0434c6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9af38860-6851-4473-a342-e65866c8a4ef"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9c793bb4-8718-466b-90ae-def010290fcd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9e7e3096-f0b1-4766-8d46-184dfbc90d60"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a314dd20-b8bf-4fc7-a6b6-24c79d5d217e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("af0bf33a-ccc2-4552-9480-6d2a2f811f9c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b5e252fc-ab9a-4ff2-a397-9a03f63051eb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bca85edf-c481-49dc-8324-e7184cd60307"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("be73a680-9402-423b-9410-f65c86029dbb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("be96a6cc-f2f7-4d92-a065-2e13ed870add"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bfe641b1-ff48-4036-84d9-14697e05dc00"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c737c713-ef50-4ce5-ab7f-9f2ec95957db"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cc1d9be9-d5e9-40ae-acd5-b82b1eb89e77"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d06fbf0d-a566-449d-acc1-4b7097105d12"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d16ba8ae-de59-46a2-ac75-1e7b49e69943"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d231718e-e94c-43ac-bd94-68d7dbe5a88e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d315c267-8293-4ba9-9ccc-dab096823f9d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d3600181-614a-4637-bcab-b28c56cd4b38"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d49813ca-f065-4848-9fd6-7b4ea6533e20"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("de2fb3f9-d249-44e2-8688-155031882d3e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("de6e47c9-f9e4-4bbe-9eb7-9c5152c9430f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e4f1cb4f-5a5f-43fd-9729-a773f88b5ff0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e9382f92-322b-497b-a85d-f288046db166"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e9f24efd-8643-44ac-9e43-76f8f16acf7b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("21268004-51ad-42bb-a3d7-4987b605b093"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("24dda56c-3bf2-45b8-a524-0870fc6c6e2d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("300c94be-89d4-4774-86dd-aa015cf62bc8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3ee3b584-499f-4464-a841-3805de1b968c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("451f4680-50b3-4006-988e-bff1c9b737c5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("49d3eb15-77b8-40a7-bae3-fb1814908f7b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5485df5b-00ee-41cf-bb21-003a2917daa1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("63853f96-0656-446e-8ef6-6dd098247ef9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6ba3fa86-b99b-4640-ba6f-a65a8a257fe6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("815d7a75-cae9-4452-8b32-46a8e6f905e8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("83d8ee80-7a6b-438f-86c6-a4a6c5f4c517"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("905305dc-3db1-4cba-8164-4679fa8ba902"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("92076c74-7576-4201-91cf-9503acdfbf1a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("97c24e58-1da1-4b42-b287-46e104653704"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a3c1d29f-f651-436f-8886-6b51d43774d2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a6dc3576-9682-4b79-8de3-8d393b08f896"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c5c3cdab-25f7-4dc3-b2c5-908753e78df1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c727f555-d56f-42b9-a184-ced09591082f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("cecf4879-6c0e-4018-88b0-a67c23143101"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e147e12d-1fba-48ab-960e-7116e50bfca3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ea75667a-3f0c-49fd-ac8e-7e5867137b79"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ef9d5cf6-65b5-4218-b89c-2bda6ca848cf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f32ebb04-884a-4eed-8c53-522aca84f847"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f42a2cea-e682-4d10-a99c-1af093e8067d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f4d4cbb3-f2ea-4404-bc89-5905613ef995"));

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Reports",
                newName: "ReportedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_UsersId",
                table: "Reports",
                newName: "IX_Reports_ReportedUserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad24663e-bcc7-477c-a734-a40773430be8", new DateTime(2025, 7, 2, 3, 9, 9, 868, DateTimeKind.Local).AddTicks(1574), "AQAAAAIAAYagAAAAEItlsbx1I+yOqOwNr5UncRu3Ip/P5XHf1ELF7LMXV5xEFL5WXXbWRZrkCD8/qqDh8g==", "1cb3cdfb-95e6-458b-b0cc-0098220eff50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "115ad3a3-852a-4b53-a8b0-260eb0e2e4b5", new DateTime(2025, 7, 2, 3, 9, 10, 22, DateTimeKind.Local).AddTicks(5643), "AQAAAAIAAYagAAAAEBjK5QaKEeAmbR1Jp1bjJYyXxFfN/9ixrYMRwcXTcAzOBfmkDCLI9JinGDohVEo2MQ==", "c402eeed-62e0-410c-b420-f830dcb17b69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4185ebe-859d-45f9-b181-fae2f1e94601", new DateTime(2025, 7, 2, 3, 9, 10, 73, DateTimeKind.Local).AddTicks(6352), "AQAAAAIAAYagAAAAEKxH6myNgXeykGcbbX3sNCIKj4b7HbR1Z0Oc9a+uEZ4xP//Z6A55SJymynmTiREufA==", "95d5f43f-a5cc-48a6-b7a6-2eac8d27cf59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c07967e4-0f08-4da7-b8d8-4a4f4e7318e6", new DateTime(2025, 7, 2, 3, 9, 9, 819, DateTimeKind.Local).AddTicks(1397), "AQAAAAIAAYagAAAAEAoFe7VnwSkZmJaAd66B4cWhC2fcfm6OP9HwzD3YqpcDvMW9o09/hk/Xrv5Z6WwXXg==", "49691511-81c1-4d20-8341-dc3227423327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "615b845e-cfe0-4fdd-9a61-9f9221ac6c32", new DateTime(2025, 7, 2, 3, 9, 9, 967, DateTimeKind.Local).AddTicks(2621), "AQAAAAIAAYagAAAAEKWQF1ydReVpxJ3uLE2pvMca6m5Gy7l3Z4TJnE231TSqqwS+Z6mlQ8kmAEu3jJnRpA==", "0d5fc7ee-4d29-4e92-b113-3eaf35e5ba87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c091bd4-4a9c-4b70-8fa9-45ea4ebf7467", new DateTime(2025, 7, 2, 3, 9, 9, 917, DateTimeKind.Local).AddTicks(7480), "AQAAAAIAAYagAAAAEOk6H1Ysybz06C34YQcGQAjMyYz+WOiQWdhbakipOitX+ac7bD82u4NK6rPVVypmvA==", "1242da42-5887-4a62-8df4-81a76adca765" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae5bf3a8-d874-49fd-9627-c845571ed92f", new DateTime(2025, 7, 2, 3, 9, 10, 125, DateTimeKind.Local).AddTicks(8613), "AQAAAAIAAYagAAAAELdk8dT9tip/vhl9PPJacY4tF3rlYtUU/MTtETG5ArsPzeoGOp3MG54hmbdRjodq0g==", "5df96f38-b190-4ed9-b3fd-3a7c3bf0639c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54f51834-1370-4333-a810-9df8ca331917", new DateTime(2025, 7, 2, 3, 9, 9, 770, DateTimeKind.Local).AddTicks(6842), "AQAAAAIAAYagAAAAEELOos/xgNTWp5/JdKS9CtLhO2ykTQYL7kw7fxe+VJXWpY1SySFr5kTjPsCGfqyVxg==", "e50d5334-97fd-4c0f-96fe-7d822a9a2028" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0533d44c-9c56-4bc1-84e7-c968f0b510e6"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("106e9947-0b13-4ba2-9792-d5f4d189fc9e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("15cfb7e5-d835-4696-adc5-8ef9bc21de0c"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("1e7396c8-9162-44bf-9c45-a3b8a4945fd1"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("2220c264-b122-4c7e-9d95-5ef69141a0e5"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("23d96cc1-abc4-4949-980a-08dcb82b2dcc"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("2452fe54-efb8-48c1-ab92-1958edf01208"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("2d11f196-320d-4e11-9932-a1439eee3fb6"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("3186f1b2-9bb0-466f-959a-90477b7dce2f"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("3437cea0-b3f9-4f02-b5cf-10a0e2c9fd2c"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("3ad16221-bf95-4b2a-9508-4b05d57848c9"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("3d443037-0881-4cbc-a881-5073a65dcb35"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("43dc5b27-bb2d-4491-a3c6-5396f1e094c0"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("4684a355-4344-44cf-a2f3-a3b4f2a83b78"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("4a22cf75-3ae7-46e2-8843-245c335debcf"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("4d8eabda-5c9b-45c0-8d8e-9f14e5ebddd4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("56a67c40-6559-47ce-b12f-0244a766dd64"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("6b121295-3948-4c8a-8fcb-d9bc34ddacc8"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("6e9be909-e000-4b8e-8991-07ef908751d4"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("701458b4-1e0b-4a72-8ee1-5564fb25ea0b"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("71d2170b-40c0-45ca-9bf8-ce506f02e0b3"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("7526bc78-e298-4351-ac28-c53c3158d4cf"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("77a71735-c5dd-4a21-949b-0b53c0376d6b"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("7d3bebe6-88e7-436a-a40a-209e2890bf74"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("7db939bd-e4dd-48e6-b6f8-84bf042caabd"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("80947ad0-6ca8-436a-95e8-8bda6bc637d5"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("8a0ac192-13fb-4e76-a545-b455442f53ec"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("8e110b36-4ef8-4092-994c-5724f131317b"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("8e6dab40-0e40-4895-98e0-a782a2b3cbb9"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("9cafbf82-5450-4c68-8488-875a55a73634"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("a2a6a370-9653-4b7b-97ba-f1e01b444cf7"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("ae09a6f3-b92e-4ad7-beef-b3228aeb66eb"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("b056b5a0-0c8e-48ed-9c64-919c2d3d6de0"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("b088842e-a792-4170-9f08-1e5dfe146281"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("b38fe607-dc39-4c7a-9aaa-2e8ab65c86bc"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("b3d77dff-4d33-44e0-834f-2fd3d8ee3cf3"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("b3ff8134-c96f-4c02-befc-cfd3fc28071a"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("b631afe7-7048-45b0-ac00-67501a8fa722"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("b8674639-c0ba-4469-9da2-20cb440d807f"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("bd010bc8-cd8d-4397-be05-38a7d9aa964a"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("be2c8ce1-f2d9-41ca-8c07-fd75d402bded"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("c0bdc7cf-05e8-4485-8a97-d9748a0cfd96"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("c0cf3173-28f4-4c50-8fec-29d9c44a005f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("c6bd0fda-808c-41d2-a373-b898d0442665"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("c908a86d-0471-448b-a7c1-2ae1d5436bf7"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("cf1ce3ec-5734-4c09-a994-6425a0c10106"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("cf91c2a4-0db6-4458-a84d-3c8f914bbc68"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("d30d5888-9a9a-4b22-8890-797286389ae2"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("d5c21d64-06b1-4efd-ae9a-7542783b6431"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("d615ac4d-2262-4b52-9f23-988127ed6332"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("db14a96a-7421-425d-801e-6081fb514358"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("dde05d7d-c792-44c8-a788-6ad977b36fff"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("e2e63d80-ab7a-4f3c-8b43-90559cb5c65f"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("e75ae701-0374-40c5-b9de-21f14d135d17"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("e8b18534-ffe5-4d55-8b52-03c26436da75"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("e9ed3909-0341-42b1-a56e-89cd4829c512"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("ed76588d-699a-441e-b304-28b4d7174f8e"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("f4cbfb10-7929-4fe9-8452-6f774e711c28"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("f6e27380-82ca-4a7d-a7a6-03381832c331"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("f9f2ac33-8a86-46c8-97f7-58f6bed41079"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("fa244609-327b-4987-8f03-f11481959f7d"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("fd5dd781-801c-4d66-8b03-71ed0c78f843"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("0f74216d-ebfb-48e2-862a-b5785256ea4d"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("143e1533-d898-4fb7-a5e6-fe10a58c0fa0"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("14b625b4-8725-4aca-840d-0a4c9d10db6f"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("2563f05c-5b43-4e80-bd3a-4c99fb318336"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("29a72729-cde2-44ca-934f-10b2060f7d67"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("322bf570-d8ab-4143-81e6-958209fb4f4c"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("46e4f6a3-50df-4193-8c94-8161f51dc362"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("525d0f6e-b370-41b6-9f05-e86bc4458578"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("6217aad3-b894-4646-b5da-0b76905f4852"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("6aec24fb-3d1c-4ff2-87c0-d77b367efafb"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("6b179ae6-1fd2-4d2e-9bdd-4c6b708ad544"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("6d66b98c-d0e3-40de-bc4d-16b38e70988d"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("6f9a886d-f8ea-4932-a063-1c12a9438ad4"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("85d83732-e640-4b2b-8e32-625783af2b9f"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("94c09a30-4896-4a7b-8f97-56a12e7c334d"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("971fa8b1-b1b5-4a1b-a3ff-15081e2b004b"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("985947f2-2d3e-4392-b98b-ee7930929904"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("a04807a7-505b-4377-8126-a7a252614c2c"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("ab8457e1-c38e-4f68-ae63-de5cc7b474cc"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("ad79e679-eb70-4cad-a20c-0e3891c4e1a3"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("cab07a1f-63c5-41b3-ba00-f5842a10db01"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("cd406175-f7d2-4c89-9efc-e2676974536c"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("d006ac31-bb99-435f-976b-fb39fdf2df4a"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("d2763a6f-ff17-4f5c-87a9-c6c82a36c71e"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("d62a4047-c00e-452a-9697-493ae4bc7a0b"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 2, 3, 9, 9, 756, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_ReportedUserId",
                table: "Reports",
                column: "ReportedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
