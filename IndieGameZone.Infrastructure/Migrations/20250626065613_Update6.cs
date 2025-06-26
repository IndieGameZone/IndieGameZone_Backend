using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("042b01ff-4568-44bc-8565-2ba3f2d226dc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0d6fae8d-76ff-412c-a651-7461f8f1089a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("11035991-cb3d-46bb-a872-354ecd0aece0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("163e1e39-ec7b-45b4-ba05-bbe586027c27"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1962d524-19de-493e-9315-1e361d20dc79"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1aa73140-c594-4f1d-a7fd-ff0bb0e11760"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1b938cfe-5f13-4192-810c-588fceb7119c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1e65c3d8-2c5e-4cdb-8ed0-f064b6a563f1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2d83e782-372a-4a3d-8506-61a9c5b70800"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2f86490b-1ea5-43c5-979b-384042712687"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("32b39173-182f-481a-beb6-341a306362a1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("375c57a4-034b-47bf-b3da-5c1bd1f606e2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("391945f6-e335-415b-bbcd-c8bf7dc515ea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3abccad0-89d9-493c-9fde-45cd2f881589"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43e59bd9-d9ca-444d-b306-2879dbff108e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("45101340-35d8-4096-92cb-d06ebe60c2d0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4fd76fed-36b2-44b5-9c7b-69ceef67bb32"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("52d0ce3c-eaf3-49be-8f7a-364716d2bd33"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5d9d32b6-c91d-4fde-a69a-3fe63dfc0820"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("60138d5e-a68f-40d9-9e7b-ac5fe5ecc053"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6a4fb2d8-4974-48e7-a3ac-0b000f075dd5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6e8784a2-0b1a-4770-8b5f-a303095f6de0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("73e589da-99b1-45ea-a052-5faab29ed4ae"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7802eade-2bbc-4353-9892-a1faa2ebfa03"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("80823e37-ca17-406b-940a-837589ef8e7e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8748757d-c0f3-42a2-a9d0-2a03c04fd697"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8cca7185-b5ac-452a-bc70-90305572c5d7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("901fbdca-14f1-4fdd-8345-d4e819942bfd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90e2ad38-4263-4fa7-aafc-bef6bee57c10"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("94df4b0f-1ebe-40e3-a9c8-7ee2366b6862"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("95e3e2a4-7947-469e-9825-795e07352903"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("979951e1-2b53-40dd-b281-078af79f2eff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9826c8d0-cae1-4c2e-99fe-57824e06538e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9a65df50-22ce-4861-abc8-cb0928b78493"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9dd8ca61-c29e-4c6b-8ddb-c0f105eaa4f7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a09e8ca3-e172-4927-b9b4-88e6f7999118"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1e5c82a-cbe6-410f-b675-2c3fd6c98724"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a4635af7-21fb-43b8-bd9a-bb51fc17d573"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a5d4a564-8792-4d5f-b5f4-273ca04b5c95"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a8581414-e4f6-4cd5-bc4c-4e626cf64d34"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a8603f57-3de8-48a0-b8c2-65334e460151"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a8853219-b3dc-4b91-83f3-d089902bc102"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a8f268c1-aa28-4377-9dbf-60ee051bb51e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b192aba0-dcce-4f21-82bb-e8a052b8f1a4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b518c7f2-991e-4570-908a-916efeadd58b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b5dfad75-aaa3-4fba-93ba-385286078eb6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ba722973-9d06-4da0-b31c-0f9f6c965b7c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("baeb88f6-60f6-460a-977c-c5f1689990c2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("be040f5c-b9ff-422c-86af-814d3a80b8e5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c927cf1d-219f-4460-8209-5eb0b327929a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c9e6340d-fb17-4340-a1bc-cea842925ed5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cac1725a-c76a-4e27-a83b-029f096f7b01"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cbf27dcb-b26c-42f6-9854-f958f2ebe118"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d0648c73-52e2-4261-b454-aab7951e3b95"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d7b0d3bb-8344-4da5-b60a-3df7327d9eee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dbdcad30-075a-4f4e-94ff-0d8610c662b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("df259cef-765c-45b8-b1d9-3b6e5dab8802"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e3b54f52-b695-4800-bb97-66a2e05ae64c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e55eac15-c9b9-4006-b1c5-bc385f4aa04c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e62a8485-506c-4f5c-9266-f9566783e76f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eaf9d6ff-b7ea-4ec6-90ed-dcfde20cf0b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f9e5dcd9-ced0-495e-b143-88abd3ffc696"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0438344b-d781-465f-9f10-ab690362bd4c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("07a6b216-43c3-4920-b2db-f0aceb1946b8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1d48ec31-6329-46bd-9b06-2b88fcd11e77"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1fb95215-b620-4904-98e9-4220f1b6809b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("27705435-e444-46a3-9f4d-54d4d8152b9b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3080439b-3ee0-40c0-85d3-66abec84acd4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("39f38c87-20fd-427d-b767-53d828afc273"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3ecc27e7-77bb-4cc0-98a1-5b61e36f83ed"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("56f48c12-a857-4a55-ae70-63ba8a9b6693"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5d2402cb-22de-4b38-980c-b779f016c57d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("64c2af89-62ce-495d-be08-f07fad5afe1f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("70d89ea2-3c7e-4d62-b372-d14d7d851a8b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("78b83be5-94ef-4332-b4cc-b941f0452d5e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("80ce4654-d1b2-497d-8d44-fc199e9f322d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8dda3058-c994-469a-880b-f74dd58be2ff"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8ed16b77-0592-43c0-a678-991d2909d2af"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a6042c77-912a-492c-bf03-42dcc8a79e55"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ae3be902-55d9-4489-b3bc-c7a19e85223c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c99b7ecc-96ff-408e-a1d3-8864738dfc72"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d422332a-c207-4be2-8047-8942aa8da8ac"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dd4b366c-c1e0-44e0-bf3d-199d4d40bd0f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e384971b-31e1-49c3-92f3-061c5cbc6936"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f59af784-1d8f-417e-9ec5-ea23f634568b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f5bfb724-f4c8-445f-99f9-7d0e65a896b0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fc20acc3-3c96-4838-8254-669e30f4bfcf"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CensoredAt",
                table: "GameCensorLogs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "GameCensorLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18fd29b1-392d-42b6-8d49-f4db94730727", new DateTime(2025, 6, 26, 13, 56, 12, 43, DateTimeKind.Local).AddTicks(3507), "AQAAAAIAAYagAAAAEP48aqqx2J3g7gTIjpcfUuKVKWNsJHjqz/0m9pHgZS0+7g2V0+Np2HSWLl2Qywz1hg==", "19e6cc3e-7e09-4181-ab8c-27704e5fd524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eebbd905-bc6c-42b5-a902-2ac75f2da429", new DateTime(2025, 6, 26, 13, 56, 12, 218, DateTimeKind.Local).AddTicks(6020), "AQAAAAIAAYagAAAAEFTQu9JCxEJxazRUcKhls78vBtPmfuvlfiqJY/AmJ+zXGulotZr+Mw28RhP6Pl/ASg==", "8cfaf54b-0d64-4ac5-adcc-e3c121a77d9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af9589f-fe39-499f-9722-705d38e6d252", new DateTime(2025, 6, 26, 13, 56, 12, 277, DateTimeKind.Local).AddTicks(5915), "AQAAAAIAAYagAAAAEE8im/GMdTff4o8ML+xu/jeeyH3EaB/CvCVhlFbwuPf2mIBjES2OA0+S175noGb+gA==", "8d306de7-0b81-4fab-ac6f-3fd48da93134" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "071e373b-2cd9-45dd-91f3-462883555d00", new DateTime(2025, 6, 26, 13, 56, 11, 983, DateTimeKind.Local).AddTicks(1781), "AQAAAAIAAYagAAAAEPKKByyWqnK5tkVSsHp5+vojR6gyzxpXilZs7ZXHaqPVLOvhCDnAylbpSR4DbIP5zQ==", "597cad9d-f726-4f4f-b5a4-501532125234" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "056dfb6b-ef1f-4613-92bf-fecad9529733", new DateTime(2025, 6, 26, 13, 56, 12, 159, DateTimeKind.Local).AddTicks(8358), "AQAAAAIAAYagAAAAEPFvBnNqFw1XN4Mh6tjDDisFwboSsT/T/JBGoN7mGI0xKtT3nrYOBXqdDy0WBfsDuw==", "98a8b9c0-9ef0-4de2-9f6a-3409b7d75e65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd300b1a-80dd-4957-a927-2f6cab911899", new DateTime(2025, 6, 26, 13, 56, 12, 100, DateTimeKind.Local).AddTicks(5350), "AQAAAAIAAYagAAAAEOOl8bNksu1ObXLoRqdtuy79ErWQzAJvY6a0H09m3rXONwk0aJ4VsqcaMFsbYa1bAg==", "f39f5027-7cd3-4859-a13a-cc27ad568d93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd142b73-ccc9-4dc2-9f2d-d9c217bfed28", new DateTime(2025, 6, 26, 13, 56, 12, 335, DateTimeKind.Local).AddTicks(7660), "AQAAAAIAAYagAAAAEBcxuGh88JEiu5MhNJPG9hDjDUbT+tuKSAvDaAGe8qlMtoDK7og5ULCfwFvUqN6ACA==", "24eef7f0-c4bb-4e4d-ba7e-161aa68be831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "668571a3-dd91-4a99-abeb-63251167fdf1", new DateTime(2025, 6, 26, 13, 56, 11, 922, DateTimeKind.Local).AddTicks(2964), "AQAAAAIAAYagAAAAEMAzQDu+VDxNiXq+KTRZ7Lyf+MP2ieSAd0j8g+S4GjBooA6eCerfKioEYPgXBNSUjQ==", "b962d0e9-5652-499c-92ad-a487c25edfbb" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("03e031d6-e3ae-4f1d-a962-58f7bb477cf4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("0f30c065-5ef8-4ad7-9096-e7b7b0b52240"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("13af86bb-8168-4480-9f01-395307a6dc71"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("24ddb5af-fafb-4938-9dbd-1fc4debffb4a"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("2791fbdb-d2a6-429e-bce4-e63924cb0426"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("29c66fcc-931a-409a-8a16-97906085006b"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("2fb6001d-45a9-48ef-9b06-3f966916289e"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("455395a2-f2f6-4362-adcc-16f269c8d7c9"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("4de69701-b2cf-4a5a-a7e4-a7ac015620d0"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("4e42e848-32c4-47a7-99b9-dfe2eca9801f"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("56bb2ca0-adcb-4f42-8144-9bf830f72882"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("5a2047ad-661a-45e6-9272-09bf0a4dd786"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("5be98db3-a78c-428e-bbea-c061e8b9fc5e"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("5cdc3a9c-761e-4770-92f5-aa4009bf37fb"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("68975152-431b-4871-8814-ea3b1cb81fa9"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("69c3eab3-5a32-4c69-8eb7-82c08ec5c289"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("6e509a8e-6d0d-430b-bc62-80d9e8c5b1a7"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("714c0156-906c-468d-a9da-d29e40376c90"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("7c62bb57-223b-4918-a372-f33f180310b4"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("7cb08fa4-479e-4b48-9a19-8c0b484ed097"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("7d645815-cf44-4fbb-bb63-77b498eb0043"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("7dbbecff-2d9a-4f3d-94a8-d11afd144509"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("838a228a-2f18-4be4-9b96-c7bd3f4281b5"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("83f4c743-ee1f-4ed4-916d-849408b2d7ff"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("8544eeb5-6a7e-43c1-916f-c5188140b976"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("8564484f-c034-4b4a-9143-0ca539aefbab"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("85ab6c24-aac9-4208-bb05-e7171e95e93e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("87deee52-76d4-4262-95d8-3db0caa18b1d"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("90aa0e4d-adec-4060-a8ca-da6cc55d0cc7"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("92f14c1c-58b7-4172-b34e-b55f0318dd31"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("9b08be66-5364-4235-a082-bf77d5e4b9f5"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("9b19192c-e4fa-4e07-8fe2-5ccf1f549b30"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("9b9eefef-e133-4d56-a769-b834edb27bdc"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("9c163c3b-b884-4f45-89ea-9333d3f7600d"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("a1b0a19c-299d-4f10-9efa-f667073b78c5"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("a41bc8fa-1c11-45ee-a783-a58e02baa590"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("a57df769-77f9-417e-ad5b-1fdeb896d6e9"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("a8ae7abd-efc5-466e-b5a0-cd5cfbc6087b"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("ada67b3d-76bc-4085-81e3-b717fda67a0e"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("b1af566c-cf99-4948-a9e0-becc31b2e9ad"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("b20a2cfd-b0ca-4f1d-9026-f1964409823d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("b9ac88f3-0c1c-4295-ad97-b6a946b9574b"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("baaf21d6-dd42-426d-8096-f27798967265"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("bc2c47fd-8481-4742-8e2b-2bd0b2f2af32"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("bd85305a-0757-4f69-ad7a-43a1e8b6c098"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("bf11d7fd-c194-4e98-8dd8-ede803d67ea0"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("c18d323c-dcc5-4bab-86dc-e691526973d2"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("c495561f-6bd7-434d-bb10-9199527d27d3"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("c786094a-852f-4cde-be96-73b58ece84c5"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("cca9b971-6934-45c2-98ab-f1f982de320f"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("d033b81c-92cc-4656-9118-478b13730842"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("d611c7ae-030c-48b3-9f64-4775e19b035f"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("d8d65e2c-7f14-43f4-aaa5-a22b414abd8d"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("dded03be-f3aa-48a6-b747-4987fcf21fd6"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("de2c521a-cefd-4fc0-8e7a-02c74e67065a"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("e000a5de-f207-494f-b652-eb10196b1549"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("e4ec44f3-d4d8-400a-8740-b8fd0ef40c37"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("e815e146-ba2d-4800-9d6e-9f0245ef32ed"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("e8c21fe6-99ef-4e2a-8032-920e957ed38c"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("ee87bc25-eecd-456b-a31a-1224edd08fa8"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("eee06b31-3e42-4de4-b63f-924964105b20"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("ffa36c31-d363-4002-9250-789af2cd8751"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("048539c0-fb46-4f5f-a874-db15834a703d"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("12d534d3-56f7-47d2-97e0-a2b6063f903f"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("13cbdcd9-2a00-4afc-bac3-d1c8ece25fcc"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("22c4fbc1-8a8a-4675-b7bb-b7de168fdc71"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("253730fb-5262-4534-868b-67a9f46702a7"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("35ef243f-65c3-416c-9dd9-b08773a9c5f8"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("36dd13b4-24c3-455f-b50e-c817d9144992"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("3aa072db-9731-4045-b5cf-cfaa89aa45d6"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("477b0075-d5b8-404b-8271-869e059c826f"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("5035d3f0-9fa2-40fd-822e-759f189cb837"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("58c5e791-3f89-49a5-b887-b35d69348b69"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("7c2ffedd-2e3d-4c41-96e0-816b5b65d1c1"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("84a1611a-944f-463d-9fe4-53bd21a967f7"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("8f0840d9-dd67-4849-9429-9e104b19ee06"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("985e3262-c016-4369-b6be-2241a118acc0"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("a142b0c2-bd2a-4426-99eb-e41a4c50467f"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("ad58124e-d10d-4239-a005-0905e26160ce"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("ba4d637c-28df-4a3b-a70b-0a24c9b0f114"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("d31a48cb-0db0-4ed6-b671-759f101a681b"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("df62f177-b0e2-469a-923d-8cd3d9175615"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("e707d79e-ccfc-488b-b394-3d6e9a517431"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("e77c9ae3-3799-4254-b82f-b5c6d2a4dac8"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("eba1e9fd-84a6-4271-8bd4-87d3b6f05b57"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("f6fef759-d373-4553-9eaa-e61a301ab6eb"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("fbee6de1-6802-4261-b717-56fc9c7c0aa5"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 13, 56, 11, 901, DateTimeKind.Local).AddTicks(4604));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("03e031d6-e3ae-4f1d-a962-58f7bb477cf4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0f30c065-5ef8-4ad7-9096-e7b7b0b52240"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("13af86bb-8168-4480-9f01-395307a6dc71"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("24ddb5af-fafb-4938-9dbd-1fc4debffb4a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2791fbdb-d2a6-429e-bce4-e63924cb0426"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("29c66fcc-931a-409a-8a16-97906085006b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2fb6001d-45a9-48ef-9b06-3f966916289e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("455395a2-f2f6-4362-adcc-16f269c8d7c9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4de69701-b2cf-4a5a-a7e4-a7ac015620d0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4e42e848-32c4-47a7-99b9-dfe2eca9801f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("56bb2ca0-adcb-4f42-8144-9bf830f72882"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5a2047ad-661a-45e6-9272-09bf0a4dd786"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5be98db3-a78c-428e-bbea-c061e8b9fc5e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5cdc3a9c-761e-4770-92f5-aa4009bf37fb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("68975152-431b-4871-8814-ea3b1cb81fa9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("69c3eab3-5a32-4c69-8eb7-82c08ec5c289"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6e509a8e-6d0d-430b-bc62-80d9e8c5b1a7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("714c0156-906c-468d-a9da-d29e40376c90"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7c62bb57-223b-4918-a372-f33f180310b4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7cb08fa4-479e-4b48-9a19-8c0b484ed097"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7d645815-cf44-4fbb-bb63-77b498eb0043"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7dbbecff-2d9a-4f3d-94a8-d11afd144509"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("838a228a-2f18-4be4-9b96-c7bd3f4281b5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("83f4c743-ee1f-4ed4-916d-849408b2d7ff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8544eeb5-6a7e-43c1-916f-c5188140b976"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8564484f-c034-4b4a-9143-0ca539aefbab"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("85ab6c24-aac9-4208-bb05-e7171e95e93e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("87deee52-76d4-4262-95d8-3db0caa18b1d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90aa0e4d-adec-4060-a8ca-da6cc55d0cc7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("92f14c1c-58b7-4172-b34e-b55f0318dd31"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9b08be66-5364-4235-a082-bf77d5e4b9f5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9b19192c-e4fa-4e07-8fe2-5ccf1f549b30"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9b9eefef-e133-4d56-a769-b834edb27bdc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9c163c3b-b884-4f45-89ea-9333d3f7600d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1b0a19c-299d-4f10-9efa-f667073b78c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a41bc8fa-1c11-45ee-a783-a58e02baa590"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a57df769-77f9-417e-ad5b-1fdeb896d6e9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a8ae7abd-efc5-466e-b5a0-cd5cfbc6087b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ada67b3d-76bc-4085-81e3-b717fda67a0e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b1af566c-cf99-4948-a9e0-becc31b2e9ad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b20a2cfd-b0ca-4f1d-9026-f1964409823d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b9ac88f3-0c1c-4295-ad97-b6a946b9574b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("baaf21d6-dd42-426d-8096-f27798967265"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bc2c47fd-8481-4742-8e2b-2bd0b2f2af32"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bd85305a-0757-4f69-ad7a-43a1e8b6c098"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bf11d7fd-c194-4e98-8dd8-ede803d67ea0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c18d323c-dcc5-4bab-86dc-e691526973d2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c495561f-6bd7-434d-bb10-9199527d27d3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c786094a-852f-4cde-be96-73b58ece84c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cca9b971-6934-45c2-98ab-f1f982de320f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d033b81c-92cc-4656-9118-478b13730842"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d611c7ae-030c-48b3-9f64-4775e19b035f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d8d65e2c-7f14-43f4-aaa5-a22b414abd8d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dded03be-f3aa-48a6-b747-4987fcf21fd6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("de2c521a-cefd-4fc0-8e7a-02c74e67065a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e000a5de-f207-494f-b652-eb10196b1549"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e4ec44f3-d4d8-400a-8740-b8fd0ef40c37"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e815e146-ba2d-4800-9d6e-9f0245ef32ed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e8c21fe6-99ef-4e2a-8032-920e957ed38c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ee87bc25-eecd-456b-a31a-1224edd08fa8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eee06b31-3e42-4de4-b63f-924964105b20"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ffa36c31-d363-4002-9250-789af2cd8751"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("048539c0-fb46-4f5f-a874-db15834a703d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("12d534d3-56f7-47d2-97e0-a2b6063f903f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("13cbdcd9-2a00-4afc-bac3-d1c8ece25fcc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("22c4fbc1-8a8a-4675-b7bb-b7de168fdc71"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("253730fb-5262-4534-868b-67a9f46702a7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("35ef243f-65c3-416c-9dd9-b08773a9c5f8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("36dd13b4-24c3-455f-b50e-c817d9144992"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3aa072db-9731-4045-b5cf-cfaa89aa45d6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("477b0075-d5b8-404b-8271-869e059c826f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5035d3f0-9fa2-40fd-822e-759f189cb837"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("58c5e791-3f89-49a5-b887-b35d69348b69"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7c2ffedd-2e3d-4c41-96e0-816b5b65d1c1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("84a1611a-944f-463d-9fe4-53bd21a967f7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8f0840d9-dd67-4849-9429-9e104b19ee06"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("985e3262-c016-4369-b6be-2241a118acc0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a142b0c2-bd2a-4426-99eb-e41a4c50467f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ad58124e-d10d-4239-a005-0905e26160ce"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ba4d637c-28df-4a3b-a70b-0a24c9b0f114"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d31a48cb-0db0-4ed6-b671-759f101a681b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("df62f177-b0e2-469a-923d-8cd3d9175615"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e707d79e-ccfc-488b-b394-3d6e9a517431"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e77c9ae3-3799-4254-b82f-b5c6d2a4dac8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("eba1e9fd-84a6-4271-8bd4-87d3b6f05b57"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f6fef759-d373-4553-9eaa-e61a301ab6eb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fbee6de1-6802-4261-b717-56fc9c7c0aa5"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "GameCensorLogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CensoredAt",
                table: "GameCensorLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3a93bd-b3ff-4ee0-80ef-927344c89167", new DateTime(2025, 6, 26, 0, 52, 26, 339, DateTimeKind.Local).AddTicks(9090), "AQAAAAIAAYagAAAAENO/xvPcgaOrbGhAtOxu3K4ft8/roPswAWo5FNCwnvAMEBJVh4um8HFyU1ZzrMbAnQ==", "aa51ad8d-0e04-4801-aee3-de39df23ed7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82dbf95c-c07d-4b12-b79d-4161977d4edf", new DateTime(2025, 6, 26, 0, 52, 26, 509, DateTimeKind.Local).AddTicks(3917), "AQAAAAIAAYagAAAAENpRmmiYA2o4oyXgWK7T07El0gXHKVfJbE3cTB0pe2yC2lafLQSY6snblziB/GdYNQ==", "c6031b73-e682-42b1-8591-522b51ef391d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cb5fb09-a411-434c-bb28-0e0fec5c06cd", new DateTime(2025, 6, 26, 0, 52, 26, 573, DateTimeKind.Local).AddTicks(4048), "AQAAAAIAAYagAAAAEM30dw28ZH5wnd7Fsqk4yXnlYDCmeNJ+IVyW2FdBAe476BKS2eElTDRpYHJ1Ek5xmw==", "e65cbf30-7488-4c8e-b3fb-eb404b48cbea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ffa2910-ec8a-449a-9836-bfd43b0f6c1b", new DateTime(2025, 6, 26, 0, 52, 26, 282, DateTimeKind.Local).AddTicks(6666), "AQAAAAIAAYagAAAAEEYj5qxKNaBS6oAOneBZwl9LfWJzypK1PL+5F9FZ3G+++pBA/hm6oSrv2agX0/RpGw==", "ebe64ad4-1503-4adb-9627-92ff649432a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d25bdf-a885-4dc5-9727-fa0e52389868", new DateTime(2025, 6, 26, 0, 52, 26, 453, DateTimeKind.Local).AddTicks(7427), "AQAAAAIAAYagAAAAENUWkPuzbZIPQYAHxn7NBxz12QdGbmVeVsj3YcEQQxgzSjHxRuTWNwqNE9O2mWmMdQ==", "c383dfd9-fc83-4ce8-9c23-e58a7ea09242" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "106fe8fe-3099-4560-a8bd-a81ed6ecb134", new DateTime(2025, 6, 26, 0, 52, 26, 395, DateTimeKind.Local).AddTicks(9567), "AQAAAAIAAYagAAAAENxguPe92JcB8dTb+WZSwOS/mR3j0Jf+YLRAhqZ77feOXHLGjFN9v2twgb1I+EQQ+g==", "73953912-f6ab-4b51-b96d-8d20199015d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "561116c8-285e-44b3-9864-7e733e3681c2", new DateTime(2025, 6, 26, 0, 52, 26, 629, DateTimeKind.Local).AddTicks(5270), "AQAAAAIAAYagAAAAELKe5bmVm2NygvIrS5gdObl489A4x6slCU6FteHYLxs8QXEckDqqaeU26l8Yiv4P7A==", "f0cb0c15-375b-4127-8f97-a760215a2856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb1237c8-5d4e-42eb-bac5-806985e78b86", new DateTime(2025, 6, 26, 0, 52, 26, 226, DateTimeKind.Local).AddTicks(8970), "AQAAAAIAAYagAAAAEEGOjJsDWdK/dqm+pwcAF1P9gGmYCUzxqR9jcU/zN9WnaE1zhpY0SQjSr63/+/5XhA==", "a6222c01-8e0a-437a-83c8-6c22ee311590" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("042b01ff-4568-44bc-8565-2ba3f2d226dc"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("0d6fae8d-76ff-412c-a651-7461f8f1089a"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("11035991-cb3d-46bb-a872-354ecd0aece0"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("163e1e39-ec7b-45b4-ba05-bbe586027c27"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("1962d524-19de-493e-9315-1e361d20dc79"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("1aa73140-c594-4f1d-a7fd-ff0bb0e11760"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("1b938cfe-5f13-4192-810c-588fceb7119c"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("1e65c3d8-2c5e-4cdb-8ed0-f064b6a563f1"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("2d83e782-372a-4a3d-8506-61a9c5b70800"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("2f86490b-1ea5-43c5-979b-384042712687"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("32b39173-182f-481a-beb6-341a306362a1"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("375c57a4-034b-47bf-b3da-5c1bd1f606e2"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("391945f6-e335-415b-bbcd-c8bf7dc515ea"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("3abccad0-89d9-493c-9fde-45cd2f881589"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("43e59bd9-d9ca-444d-b306-2879dbff108e"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("45101340-35d8-4096-92cb-d06ebe60c2d0"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("4fd76fed-36b2-44b5-9c7b-69ceef67bb32"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("52d0ce3c-eaf3-49be-8f7a-364716d2bd33"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("5d9d32b6-c91d-4fde-a69a-3fe63dfc0820"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("60138d5e-a68f-40d9-9e7b-ac5fe5ecc053"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("6a4fb2d8-4974-48e7-a3ac-0b000f075dd5"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("6e8784a2-0b1a-4770-8b5f-a303095f6de0"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("73e589da-99b1-45ea-a052-5faab29ed4ae"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("7802eade-2bbc-4353-9892-a1faa2ebfa03"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("80823e37-ca17-406b-940a-837589ef8e7e"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("8748757d-c0f3-42a2-a9d0-2a03c04fd697"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("8cca7185-b5ac-452a-bc70-90305572c5d7"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("901fbdca-14f1-4fdd-8345-d4e819942bfd"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("90e2ad38-4263-4fa7-aafc-bef6bee57c10"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("94df4b0f-1ebe-40e3-a9c8-7ee2366b6862"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("95e3e2a4-7947-469e-9825-795e07352903"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("979951e1-2b53-40dd-b281-078af79f2eff"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("9826c8d0-cae1-4c2e-99fe-57824e06538e"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("9a65df50-22ce-4861-abc8-cb0928b78493"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("9dd8ca61-c29e-4c6b-8ddb-c0f105eaa4f7"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("a09e8ca3-e172-4927-b9b4-88e6f7999118"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("a1e5c82a-cbe6-410f-b675-2c3fd6c98724"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("a4635af7-21fb-43b8-bd9a-bb51fc17d573"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("a5d4a564-8792-4d5f-b5f4-273ca04b5c95"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("a8581414-e4f6-4cd5-bc4c-4e626cf64d34"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("a8603f57-3de8-48a0-b8c2-65334e460151"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("a8853219-b3dc-4b91-83f3-d089902bc102"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("a8f268c1-aa28-4377-9dbf-60ee051bb51e"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("b192aba0-dcce-4f21-82bb-e8a052b8f1a4"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("b518c7f2-991e-4570-908a-916efeadd58b"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("b5dfad75-aaa3-4fba-93ba-385286078eb6"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("ba722973-9d06-4da0-b31c-0f9f6c965b7c"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("baeb88f6-60f6-460a-977c-c5f1689990c2"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("be040f5c-b9ff-422c-86af-814d3a80b8e5"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("c927cf1d-219f-4460-8209-5eb0b327929a"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("c9e6340d-fb17-4340-a1bc-cea842925ed5"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("cac1725a-c76a-4e27-a83b-029f096f7b01"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("cbf27dcb-b26c-42f6-9854-f958f2ebe118"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("d0648c73-52e2-4261-b454-aab7951e3b95"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("d7b0d3bb-8344-4da5-b60a-3df7327d9eee"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("dbdcad30-075a-4f4e-94ff-0d8610c662b1"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("df259cef-765c-45b8-b1d9-3b6e5dab8802"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("e3b54f52-b695-4800-bb97-66a2e05ae64c"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("e55eac15-c9b9-4006-b1c5-bc385f4aa04c"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("e62a8485-506c-4f5c-9266-f9566783e76f"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("eaf9d6ff-b7ea-4ec6-90ed-dcfde20cf0b3"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("f9e5dcd9-ced0-495e-b143-88abd3ffc696"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("0438344b-d781-465f-9f10-ab690362bd4c"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("07a6b216-43c3-4920-b2db-f0aceb1946b8"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("1d48ec31-6329-46bd-9b06-2b88fcd11e77"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("1fb95215-b620-4904-98e9-4220f1b6809b"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("27705435-e444-46a3-9f4d-54d4d8152b9b"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("3080439b-3ee0-40c0-85d3-66abec84acd4"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("39f38c87-20fd-427d-b767-53d828afc273"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("3ecc27e7-77bb-4cc0-98a1-5b61e36f83ed"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("56f48c12-a857-4a55-ae70-63ba8a9b6693"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("5d2402cb-22de-4b38-980c-b779f016c57d"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("64c2af89-62ce-495d-be08-f07fad5afe1f"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("70d89ea2-3c7e-4d62-b372-d14d7d851a8b"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("78b83be5-94ef-4332-b4cc-b941f0452d5e"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("80ce4654-d1b2-497d-8d44-fc199e9f322d"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("8dda3058-c994-469a-880b-f74dd58be2ff"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("8ed16b77-0592-43c0-a678-991d2909d2af"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("a6042c77-912a-492c-bf03-42dcc8a79e55"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("ae3be902-55d9-4489-b3bc-c7a19e85223c"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("c99b7ecc-96ff-408e-a1d3-8864738dfc72"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("d422332a-c207-4be2-8047-8942aa8da8ac"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("dd4b366c-c1e0-44e0-bf3d-199d4d40bd0f"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("e384971b-31e1-49c3-92f3-061c5cbc6936"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("f59af784-1d8f-417e-9ec5-ea23f634568b"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("f5bfb724-f4c8-445f-99f9-7d0e65a896b0"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("fc20acc3-3c96-4838-8254-669e30f4bfcf"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 0, 52, 26, 214, DateTimeKind.Local).AddTicks(2922));
        }
    }
}
