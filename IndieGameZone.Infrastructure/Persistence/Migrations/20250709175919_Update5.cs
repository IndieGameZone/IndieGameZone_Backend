using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BanHistories_AspNetUsers_UserId",
                table: "BanHistories");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("014c644c-f1ae-43c8-950f-44729c12e55a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("01dcca9f-95c7-48a0-bb7e-023d62f1c1f3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("07e8af7b-a04b-4345-b21f-60120e3f51a7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a7258f2-8bb6-4711-a7ba-e432d5c63d1c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("10341468-0fcb-43cf-a268-9109db203ab1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("104a01bc-d844-4f05-90cd-49bb55cba8d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("116f3884-8d9a-462a-b101-ef8589770f8d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1187e5e9-9e6f-4b02-ae0e-24b2e391171a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("122d0f65-43a4-4af3-beb5-1b99ea91b0c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("124048f0-62ed-4500-8f25-a88ca349d5ed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("12afa924-27fb-4181-80eb-b5b067623dbb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("16e77a6c-8211-4e7a-87bf-607cbcbf8c43"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1cd089de-4df4-4825-b2ac-2ccc8d6be9ce"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1def30ad-d190-4a36-a5a6-d918c2154bd1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ef0009a-0076-4d5f-847a-54e8393f3333"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1f2855a0-fcbc-4cae-86c1-1995646d199b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("21009a1a-28e7-448f-a6fa-e7c6137df3e3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("28d91691-9245-452c-8834-cce75698b9c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("29bbe263-1607-438e-a0cc-00b70ec997c8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2aa6b605-461e-4a34-8039-b64d9b5e71c2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("37e1a86b-2a50-4e2a-8154-00e4bd2fbfd3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("40a2b38f-6707-485e-a8ce-58815090eb45"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4628cb3c-ee58-4b01-8fcd-6e2ba50d4e3c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4c0b852b-16db-423b-a864-65c57bc2d95f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5377df91-de23-4803-83ad-7c82c4a40e5b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("585a5cbd-9bab-46cc-8cb1-7b19408b145a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5a787dd2-18bd-4c56-a424-d0a24dfafe44"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("64e16a1e-d701-4cba-b171-c36b16c12e26"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("65971f24-8a72-4568-b34c-e4e95f6fa4f7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("65b8627f-dad9-43d9-a2b7-d04a9f6c3814"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("69c8ffc5-7c93-4e0e-a4f7-e32c5d05df5b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6eafd88d-d990-475e-b4e4-e8be4bfa3f92"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("75c7b550-91e5-4530-97bb-63bbf13f31c2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8214cef3-0918-46d4-a325-964ec1103cfc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("84b5125c-2eda-4058-8fc2-7efa5eddc674"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("876848ae-e5c6-4ced-803e-5cb2e26216f8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("87b010f2-801a-4d8f-9142-8b03a86b6e97"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("94cfa7f4-f7b8-43cd-94d6-462a0cf19943"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9d30e5b2-4e7c-49c9-819f-da2c69e1ecb6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a7b26ea0-b29d-4369-a0e1-1075d6678dcc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a969b7e7-d873-4218-8ad7-506d853d410d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b70b8e0a-467c-4192-a006-3ee098e85800"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bd0ffd0d-421a-4174-a555-f6a364fa7582"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c2189570-f434-4ec6-b42b-047944c57b94"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c7eb835a-2181-4cea-b07e-f3dd7d685250"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cf84831c-1084-4167-af96-8eb76149b028"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cfffa239-8817-4c16-8541-d429dc81ff65"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d1368be3-62fc-416e-a4e2-e73d5ec8fe38"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d32b1fe6-f361-4b1a-8be9-edc9a44c5048"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d9032bba-9fd0-485b-930c-06c3048b8ad2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e3667c18-c4ac-44d6-be05-b08f89ddf738"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e54f0470-1a09-4c3e-8c9d-e1d160f6089e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e67eedc1-facd-4461-974e-3625b63ffd14"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e6f6930c-b1ab-4a7e-8d6a-46b6cd9156c3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ebe6d448-082c-4d02-b1ce-744d3313f82f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f49ed69c-095f-419c-922f-0274e7f056aa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f7904b6e-f37e-4aa4-957d-74fd29a1c761"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f870f834-7344-4d60-8476-30d6ff34f24b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("facabd5d-c3e3-44d6-9175-fd88c3536a85"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fb4d412c-0275-4669-99fb-18995a78de6c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd0b6e35-3956-43fb-bb14-f515d4e8aa64"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fdbe2bcf-00ab-48ad-940a-875be7de110c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("229b987f-9655-4aff-b0c0-ab69b447b6a0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("29827caa-c6c9-4a0d-af25-8ffb02e76ba9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3a68a4e7-a6a8-4496-9e3a-d71147303732"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("43b8f5f0-6f55-4c9c-afa7-0fc204d2c543"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("440d489a-7563-4c4d-8570-2635a748e95f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("44aee6a2-2342-4519-8292-83b5dbaddf6e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("46f627b1-2930-46ed-b922-a7b09ac666d5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("496f293b-0420-4408-a88c-a49337206dc0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4c8e3a49-0d18-4055-b653-85bbc66c037d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5d952e27-3ef6-4e1c-b21c-b86ac32f0bf3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("66c21ae7-e9b2-42f1-af8c-4d3a419f6322"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7166ca20-afed-4093-8d9c-38e7ed82b14d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("72f2d457-7606-4117-9f56-fd529de5c3b0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("86be6f22-7772-4b1e-8fc6-801b0c8443a0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9ec7818f-8dde-409e-815f-ba0a19eb2a17"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b4aeedb0-ff7e-433d-8dea-00d94a4c306a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b4b9de09-ffe3-49f8-b8c1-14c7fc6a1b42"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b4f0b493-d952-4a99-aca9-5487f812de1c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b50c57b2-45fc-459e-a6cf-93c02719989a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ba6a2450-e9bf-454e-8fbe-9ce9d806242b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d4c152ff-a2cd-4a37-9566-2eb79c7700a0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("da63e54b-0c94-4ab0-9caf-acd6ec948295"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e37bff2e-dd6b-4395-8658-078526b967f5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f828c7ef-b818-4092-89e0-b0b59aaeb5f6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fe9f288d-8322-4cf7-a718-0a7d359760f6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1f876251-3a6d-4f63-b65e-836ffd62610a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("9bdc960e-3696-4591-a462-5b93f8d7d093"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a7e8591e-f67e-4242-88d4-51e9d0a9b011"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BanHistories",
                newName: "BannedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BanHistories_UserId",
                table: "BanHistories",
                newName: "IX_BanHistories_BannedUserId");

            migrationBuilder.AddColumn<Guid>(
                name: "BannedByUserId",
                table: "BanHistories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f6d2058-339c-44d4-9c52-172b48e68bc5", new DateTime(2025, 7, 10, 0, 59, 18, 63, DateTimeKind.Local).AddTicks(2848), "AQAAAAIAAYagAAAAEMI4hq2lmIHH5iZpHnKhQoejX01kaGWFMcJAaP2+5iPyycESIcQRuUULUkdgr9vduw==", "dad2d6c8-73ce-47fe-bc42-be0fcaacc879" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f7681a8-8a2d-420d-97da-304e4807cf87", new DateTime(2025, 7, 10, 0, 59, 18, 234, DateTimeKind.Local).AddTicks(2422), "AQAAAAIAAYagAAAAEN/i61LeUUng1aQx+/75iO2bQfA4bSwyDh7X4jys/qMxomB5EX8s3In7Z77bbprD+g==", "e63de5d8-0879-46c1-bb54-de815c78b232" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fbcaf7b-2f2c-43e0-a9b6-2524c31b7d83", new DateTime(2025, 7, 10, 0, 59, 18, 286, DateTimeKind.Local).AddTicks(1368), "AQAAAAIAAYagAAAAEPtrpRiB8z/dsn7Zl4yFHhsu93LpJiBDqq02xd1OfVqb0/0N/o13ZrMNLlKizeo2Rw==", "642dddca-ed50-4dac-9f8c-39529a1985fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71587425-8165-4e54-b3cf-8e6e4bc39030", new DateTime(2025, 7, 10, 0, 59, 18, 14, DateTimeKind.Local).AddTicks(1228), "AQAAAAIAAYagAAAAEAwsbw0d+AS0sUT+InL9RX4JDcmdWlJmQzB+aC+5rgWpoVmv9mXr0e1wl4+Qn8ZCGg==", "87dea695-0eaf-4012-b86f-cde6855922b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b18e18e7-6cfc-4e3d-a8a3-41a893335677", new DateTime(2025, 7, 10, 0, 59, 18, 171, DateTimeKind.Local).AddTicks(2942), "AQAAAAIAAYagAAAAEJzJEBiD6vwJMWSu7gE3iRFtFNNK8F/5FNtTTJ2iKy1eE7JMNJs9f4LYesfRqvwemw==", "a2be5ca3-2c2a-41f3-acf9-6a50adb58ae0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cccc268-8fdc-473d-a369-54abfd9862de", new DateTime(2025, 7, 10, 0, 59, 18, 114, DateTimeKind.Local).AddTicks(856), "AQAAAAIAAYagAAAAEGWWeOYGEtNDnHEFhzVY1ewxQb9lttONrzs9nF9UQE2Y0Q1HkXfRja2hv1e+Uk9mlw==", "6b475ed2-09ef-48a6-9fed-0cf70973dca8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eea7b59-8b0f-47ff-8843-889f3deb6d0e", new DateTime(2025, 7, 10, 0, 59, 18, 334, DateTimeKind.Local).AddTicks(1670), "AQAAAAIAAYagAAAAEI5+8dvzwoiwrJSLRdL76Tqjqo7pD+lWmBgIvIksl123gJ7pt/bxGRW4oUFzhL2Gxw==", "65cba8c2-770e-42ce-a067-4046729ca7f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15283a4f-0403-42ed-973a-958623d0a39b", new DateTime(2025, 7, 10, 0, 59, 17, 961, DateTimeKind.Local).AddTicks(4059), "AQAAAAIAAYagAAAAEPa6Wk+vRfZPUkVN0GJV2QCANGW2VHFkUgE/mNgGbNJjG9YuJGbll3ouaFS3GTzdzw==", "9c18b4bc-053c-44f2-b68f-e9461b130f4d" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                column: "EndDate",
                value: new DateOnly(2025, 7, 20));

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0589f66f-9331-443c-993d-35f03f7f268a"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("06478adb-0899-4d8d-a018-3e83b60569d2"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("0a0662e9-d6ac-4723-8779-f69a09347eee"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("0f059f8d-487d-41ca-9176-dbd70824b51d"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("12ab9a44-e691-4fa1-b74d-5f13d6c2561c"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("12d52b47-8f22-4e0b-b882-a9685640eab6"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("17111d45-dea8-49b2-9d13-96bdf68f4277"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("1cdeb584-2432-4900-9c40-849aafe2ac13"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("2093747b-ecf9-4930-a84a-9e3be2c7a951"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("22443e7a-41cd-41b8-a656-64f3f9e3f7cc"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("251b29b7-d7d4-4cd5-b79b-175c272d1239"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("28dd32d8-cbc5-4d2d-8347-8740923257ad"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("304e2f82-7993-423d-b8df-53ef2c4c1dbe"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("31d5465c-ff87-4563-8846-3458e5c30758"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("35712738-ac8a-4aba-a426-54d2fcdf8393"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("39411380-cfdd-4258-8a1b-e61677b1635e"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("399db0cd-b9a4-4266-bbd8-ca6d53ab8e39"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("3ab6f7b2-6a12-4ef6-afee-80124c4744f6"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("3bfaee19-4aa2-4328-ba15-7abe5a78f28d"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("3d2184d9-59a5-47ec-bed2-25b85b5c6e82"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("3dbdcd49-e085-406c-be94-bc8c3de9d1b5"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("4328ec46-544c-4d22-97d2-4318a3ac4ff7"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("43b32948-51ac-4337-bc04-3277e5c03d20"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("45c8f81f-d982-4a61-9567-28e05e4b79c7"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("4b7194d2-27d6-4a1b-89ad-fb49fb9651b3"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("50572fe4-30ff-4295-9582-b30bf598fbb8"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("5080b5e4-c8fa-4886-bd46-b09ff7318589"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("52839338-f098-4309-82d3-589ab1b3d530"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("5f3cfe68-ab43-4bff-9a70-f1e09206bd19"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("623aaaf8-9bcf-43ef-8061-43de2e1ef50c"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("69b215c0-c4ad-4cdb-a33b-8b38af559359"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("6b1ce330-40c4-4aff-b66f-62aa08d55132"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("6d911c0f-055e-4d93-a524-a43e2847fbf5"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("74bc1e1e-c43c-4308-8d84-ef90a497efc4"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("761f2f97-5c2d-4763-ae1a-b94025c0e311"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("7efe8f64-21a1-4727-b0e8-e72b7dddb85c"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("8507c9e7-23c0-4dc0-b443-a08ea93d5777"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("8a7d6383-74cb-49a4-a93e-44de8641fd06"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("8fbd20fa-30ad-40d5-adee-e4fa8d13852a"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("931bc40f-a435-4f91-a3d6-28449b989bdf"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("95d85788-7480-4e1e-9f59-123854268b47"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("990a6379-c53a-47e9-b44b-6ff2c20affbc"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("992051f0-74f1-42d8-8b06-8e8e324aa412"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("a14bb1d0-6d69-463c-b4ba-538ffd34c395"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("a1b77b6f-bd98-48e0-b4ce-9390494fe849"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("a4e5565b-613b-479a-b621-d8ad8e49aca0"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("a70dbd48-7b21-4285-ac6e-7141752daedb"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("c3b780fd-f8ee-4697-b6a1-8a5f537d5841"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("c75e2cdf-bbd8-4cbd-b57a-efec5cb2a944"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("ccb644f1-104f-4c57-92ce-de50f08af4e9"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("cec06178-919a-4305-b663-9bfc781942b3"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("d34c63a7-24ae-4be8-996f-e246666435ad"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("d7114499-d7ab-4a7f-818f-0972c79721bf"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("d7edfa38-a002-45a9-944e-4c040ed3dae4"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("dc2b33a1-b875-4a32-89e2-7b4290ff397b"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("df482687-377a-4f75-8f35-b15e89cc0969"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("e78b1a24-2912-4c54-80be-e0df9d54523a"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("e950e96a-1591-4262-9685-ad8bce0365ca"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("ed8be620-4149-428b-848f-e79b38b1cdea"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("f1b665de-d837-484b-b620-2b41d219d908"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("f7b29a17-cbd0-4122-9ef6-9b6ca86ba13b"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("fbda9d82-15d0-44cc-be47-a5783cfa5c06"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("15c48e46-37a7-45ee-8e2a-f61aa9183184"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("1d2b26f9-a1da-449c-9f65-dc4470a083d8"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("1d5476ea-5b81-4bb4-962b-95a83a74c810"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("393bae49-6345-4549-9a94-6e9552d162a1"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("46050673-f779-4af1-b2b8-d9d1ad9f23d8"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("4b4861f3-8a78-4c02-837d-db3a9841cd78"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("50a9669f-c904-4fe4-b2a9-a04271ec93eb"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("69c221f9-8c56-4901-bd8c-d7077c381c60"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("76d6b48e-f416-4bc7-8c0e-6a4e9b137f54"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("77775685-3997-4dcd-9bfc-79c993297141"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("7f4df32a-0b50-4693-84e0-969d918cc7bf"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("81739dca-f626-4abf-8474-5d20d500e57f"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("83e2e05b-b9fd-44e3-95a8-456a20e1d249"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("93e98bf4-06b8-46a1-a050-b5a812676d5d"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("a3b96c16-ff23-40ba-919a-78f16ee3a6c0"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("a7c194de-9472-4dea-a89a-cee1fbb422ce"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("aab7f395-e7ba-40e2-847b-ac1404d5f505"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("ba0326f2-374b-45cf-8f1c-df163d2a9ac5"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("bfcdf56e-dd73-48df-881b-d0fc652e2ae5"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("d2721ced-a4d3-4e98-b6fa-5a2937bc7678"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("dd92d8bc-f350-472e-81bb-abac424e418d"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("df766d91-c0ba-4aca-860e-dd89d9a33951"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("e50f2830-6791-4bad-9c70-7c712b04a54c"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("f8fffe4c-d230-495c-9a88-af75968b8b4f"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("fb2bd80f-f0eb-4466-94ec-8bd15c7593ae"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 10, 0, 59, 17, 943, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("6a9f0b08-c168-499a-89de-c90638115677"), "This game gives me a cozy vibe", new DateTime(2025, 7, 10, 0, 59, 17, 951, DateTimeKind.Local).AddTicks(4596), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("941f8afb-ee8a-4449-aeb2-52f249b6105b"), "This is the best game I have ever seen", new DateTime(2025, 7, 10, 0, 59, 17, 951, DateTimeKind.Local).AddTicks(4588), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") },
                    { new Guid("e37e9b03-2cfc-48ec-a10d-e704f0ef53cf"), "This game is good, but it has some bugs", new DateTime(2025, 7, 10, 0, 59, 17, 951, DateTimeKind.Local).AddTicks(4600), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanHistories_BannedByUserId",
                table: "BanHistories",
                column: "BannedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BanHistories_AspNetUsers_BannedByUserId",
                table: "BanHistories",
                column: "BannedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BanHistories_AspNetUsers_BannedUserId",
                table: "BanHistories",
                column: "BannedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BanHistories_AspNetUsers_BannedByUserId",
                table: "BanHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_BanHistories_AspNetUsers_BannedUserId",
                table: "BanHistories");

            migrationBuilder.DropIndex(
                name: "IX_BanHistories_BannedByUserId",
                table: "BanHistories");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0589f66f-9331-443c-993d-35f03f7f268a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("06478adb-0899-4d8d-a018-3e83b60569d2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a0662e9-d6ac-4723-8779-f69a09347eee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0f059f8d-487d-41ca-9176-dbd70824b51d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("12ab9a44-e691-4fa1-b74d-5f13d6c2561c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("12d52b47-8f22-4e0b-b882-a9685640eab6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("17111d45-dea8-49b2-9d13-96bdf68f4277"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1cdeb584-2432-4900-9c40-849aafe2ac13"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2093747b-ecf9-4930-a84a-9e3be2c7a951"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("22443e7a-41cd-41b8-a656-64f3f9e3f7cc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("251b29b7-d7d4-4cd5-b79b-175c272d1239"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("28dd32d8-cbc5-4d2d-8347-8740923257ad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("304e2f82-7993-423d-b8df-53ef2c4c1dbe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("31d5465c-ff87-4563-8846-3458e5c30758"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35712738-ac8a-4aba-a426-54d2fcdf8393"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("39411380-cfdd-4258-8a1b-e61677b1635e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("399db0cd-b9a4-4266-bbd8-ca6d53ab8e39"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3ab6f7b2-6a12-4ef6-afee-80124c4744f6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3bfaee19-4aa2-4328-ba15-7abe5a78f28d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3d2184d9-59a5-47ec-bed2-25b85b5c6e82"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3dbdcd49-e085-406c-be94-bc8c3de9d1b5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4328ec46-544c-4d22-97d2-4318a3ac4ff7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43b32948-51ac-4337-bc04-3277e5c03d20"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("45c8f81f-d982-4a61-9567-28e05e4b79c7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4b7194d2-27d6-4a1b-89ad-fb49fb9651b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("50572fe4-30ff-4295-9582-b30bf598fbb8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5080b5e4-c8fa-4886-bd46-b09ff7318589"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("52839338-f098-4309-82d3-589ab1b3d530"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5f3cfe68-ab43-4bff-9a70-f1e09206bd19"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("623aaaf8-9bcf-43ef-8061-43de2e1ef50c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("69b215c0-c4ad-4cdb-a33b-8b38af559359"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6b1ce330-40c4-4aff-b66f-62aa08d55132"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6d911c0f-055e-4d93-a524-a43e2847fbf5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("74bc1e1e-c43c-4308-8d84-ef90a497efc4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("761f2f97-5c2d-4763-ae1a-b94025c0e311"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7efe8f64-21a1-4727-b0e8-e72b7dddb85c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8507c9e7-23c0-4dc0-b443-a08ea93d5777"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8a7d6383-74cb-49a4-a93e-44de8641fd06"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8fbd20fa-30ad-40d5-adee-e4fa8d13852a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("931bc40f-a435-4f91-a3d6-28449b989bdf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("95d85788-7480-4e1e-9f59-123854268b47"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("990a6379-c53a-47e9-b44b-6ff2c20affbc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("992051f0-74f1-42d8-8b06-8e8e324aa412"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a14bb1d0-6d69-463c-b4ba-538ffd34c395"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1b77b6f-bd98-48e0-b4ce-9390494fe849"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a4e5565b-613b-479a-b621-d8ad8e49aca0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a70dbd48-7b21-4285-ac6e-7141752daedb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c3b780fd-f8ee-4697-b6a1-8a5f537d5841"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c75e2cdf-bbd8-4cbd-b57a-efec5cb2a944"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ccb644f1-104f-4c57-92ce-de50f08af4e9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cec06178-919a-4305-b663-9bfc781942b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d34c63a7-24ae-4be8-996f-e246666435ad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d7114499-d7ab-4a7f-818f-0972c79721bf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d7edfa38-a002-45a9-944e-4c040ed3dae4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dc2b33a1-b875-4a32-89e2-7b4290ff397b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("df482687-377a-4f75-8f35-b15e89cc0969"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e78b1a24-2912-4c54-80be-e0df9d54523a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e950e96a-1591-4262-9685-ad8bce0365ca"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ed8be620-4149-428b-848f-e79b38b1cdea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f1b665de-d837-484b-b620-2b41d219d908"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f7b29a17-cbd0-4122-9ef6-9b6ca86ba13b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fbda9d82-15d0-44cc-be47-a5783cfa5c06"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("15c48e46-37a7-45ee-8e2a-f61aa9183184"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1d2b26f9-a1da-449c-9f65-dc4470a083d8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1d5476ea-5b81-4bb4-962b-95a83a74c810"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("393bae49-6345-4549-9a94-6e9552d162a1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("46050673-f779-4af1-b2b8-d9d1ad9f23d8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4b4861f3-8a78-4c02-837d-db3a9841cd78"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("50a9669f-c904-4fe4-b2a9-a04271ec93eb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("69c221f9-8c56-4901-bd8c-d7077c381c60"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("76d6b48e-f416-4bc7-8c0e-6a4e9b137f54"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("77775685-3997-4dcd-9bfc-79c993297141"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7f4df32a-0b50-4693-84e0-969d918cc7bf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("81739dca-f626-4abf-8474-5d20d500e57f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("83e2e05b-b9fd-44e3-95a8-456a20e1d249"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("93e98bf4-06b8-46a1-a050-b5a812676d5d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a3b96c16-ff23-40ba-919a-78f16ee3a6c0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a7c194de-9472-4dea-a89a-cee1fbb422ce"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("aab7f395-e7ba-40e2-847b-ac1404d5f505"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ba0326f2-374b-45cf-8f1c-df163d2a9ac5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bfcdf56e-dd73-48df-881b-d0fc652e2ae5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d2721ced-a4d3-4e98-b6fa-5a2937bc7678"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dd92d8bc-f350-472e-81bb-abac424e418d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("df766d91-c0ba-4aca-860e-dd89d9a33951"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e50f2830-6791-4bad-9c70-7c712b04a54c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f8fffe4c-d230-495c-9a88-af75968b8b4f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fb2bd80f-f0eb-4466-94ec-8bd15c7593ae"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6a9f0b08-c168-499a-89de-c90638115677"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("941f8afb-ee8a-4449-aeb2-52f249b6105b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e37e9b03-2cfc-48ec-a10d-e704f0ef53cf"));

            migrationBuilder.DropColumn(
                name: "BannedByUserId",
                table: "BanHistories");

            migrationBuilder.RenameColumn(
                name: "BannedUserId",
                table: "BanHistories",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BanHistories_BannedUserId",
                table: "BanHistories",
                newName: "IX_BanHistories_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60cf8841-20d1-4f38-acb4-fa0aa755d1b9", new DateTime(2025, 7, 9, 22, 27, 55, 906, DateTimeKind.Local).AddTicks(4384), "AQAAAAIAAYagAAAAENkBIaZa2wOM7YciS0TCeWyoUxIHz1Pi9DLib04y0HNU5eUs2QXVGSO6XcWAcGlwgQ==", "801611e0-4657-4a63-948d-c48648ebb672" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "087ad84a-29f3-43f6-acc3-5ad5e61984ba", new DateTime(2025, 7, 9, 22, 27, 56, 80, DateTimeKind.Local).AddTicks(2976), "AQAAAAIAAYagAAAAEGteWTq8GiDgdUFjMklhZnqRzR3ZyJL63YnLASGXoz+Ksn8X5cV4jxwoM3yAAzPZoA==", "16f14b92-c06a-4632-bcfe-ad0271d8cfb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c9d27a-03e0-476d-9732-18459ad5fd89", new DateTime(2025, 7, 9, 22, 27, 56, 146, DateTimeKind.Local).AddTicks(1198), "AQAAAAIAAYagAAAAEN34hoyiwNOkgtPWtOYIOUvEnvip4ApEsQtbOaUoPzuCUn5yLgRvbqkq8hcGcC+BuA==", "71d41ae7-9e10-40ad-a631-0e3eab8d3f81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2251b96-f0cd-41cd-b243-dff74b89ce91", new DateTime(2025, 7, 9, 22, 27, 55, 845, DateTimeKind.Local).AddTicks(3254), "AQAAAAIAAYagAAAAEJ/7hGTmC4ngbl9DnGHHi9Md/PILZtsIRMe5v1KFjjcnAX0/kk7Qe9daVkGj8XGcAw==", "6dcd0634-51e5-44de-a4ba-0cc6caf909b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5649f54f-5509-4fb3-a85e-d42bdd1dd42b", new DateTime(2025, 7, 9, 22, 27, 56, 22, DateTimeKind.Local).AddTicks(1804), "AQAAAAIAAYagAAAAENoLYErX74qRCUNO0M5PvbGaiL5bZQk/WdPUEntjZDTp6q9CdiLqyd6fJITzUg873Q==", "1cd7fd95-eb3c-4d9f-a250-2494ff69a789" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0831504e-9223-48a3-a2ab-9e826f0bc21b", new DateTime(2025, 7, 9, 22, 27, 55, 964, DateTimeKind.Local).AddTicks(5359), "AQAAAAIAAYagAAAAEEeZhgcfuVTYkmxMPIxatNnbuLH5exE3EPQTil5qXhob1VZLCAxdM5wUo6w0KZRZQg==", "511aedf2-d3de-4a39-9f6f-9ab9b725acc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "632aef85-171e-4c41-87f0-7e886f124dec", new DateTime(2025, 7, 9, 22, 27, 56, 204, DateTimeKind.Local).AddTicks(88), "AQAAAAIAAYagAAAAED8m6I3Wh8wPFRXag92MZAWJ+oEQMoAO6hJfJ7cuUmwgMMerVzgI/pEoHYUrlIi7RA==", "a2d95307-f3db-41cf-83e5-0fe1fc348f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35e88886-c00b-4e88-bdeb-09928875fe06", new DateTime(2025, 7, 9, 22, 27, 55, 788, DateTimeKind.Local).AddTicks(7512), "AQAAAAIAAYagAAAAEA4VC9C4pnSuBCyGKMto9VfvmPUyhNZMFon6Mpxeo4FasRNX7TRXxSCG46gbnmLKfA==", "df4309ab-2ba4-42b7-8a66-24dab90ae015" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                column: "EndDate",
                value: new DateOnly(2025, 7, 19));

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("014c644c-f1ae-43c8-950f-44729c12e55a"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("01dcca9f-95c7-48a0-bb7e-023d62f1c1f3"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("07e8af7b-a04b-4345-b21f-60120e3f51a7"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("0a7258f2-8bb6-4711-a7ba-e432d5c63d1c"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("10341468-0fcb-43cf-a268-9109db203ab1"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("104a01bc-d844-4f05-90cd-49bb55cba8d8"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("116f3884-8d9a-462a-b101-ef8589770f8d"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("1187e5e9-9e6f-4b02-ae0e-24b2e391171a"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("122d0f65-43a4-4af3-beb5-1b99ea91b0c5"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("124048f0-62ed-4500-8f25-a88ca349d5ed"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("12afa924-27fb-4181-80eb-b5b067623dbb"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("16e77a6c-8211-4e7a-87bf-607cbcbf8c43"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("1cd089de-4df4-4825-b2ac-2ccc8d6be9ce"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("1def30ad-d190-4a36-a5a6-d918c2154bd1"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("1ef0009a-0076-4d5f-847a-54e8393f3333"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("1f2855a0-fcbc-4cae-86c1-1995646d199b"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("21009a1a-28e7-448f-a6fa-e7c6137df3e3"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("28d91691-9245-452c-8834-cce75698b9c5"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("29bbe263-1607-438e-a0cc-00b70ec997c8"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("2aa6b605-461e-4a34-8039-b64d9b5e71c2"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("37e1a86b-2a50-4e2a-8154-00e4bd2fbfd3"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("40a2b38f-6707-485e-a8ce-58815090eb45"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("4628cb3c-ee58-4b01-8fcd-6e2ba50d4e3c"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("4c0b852b-16db-423b-a864-65c57bc2d95f"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("5377df91-de23-4803-83ad-7c82c4a40e5b"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("585a5cbd-9bab-46cc-8cb1-7b19408b145a"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("5a787dd2-18bd-4c56-a424-d0a24dfafe44"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("64e16a1e-d701-4cba-b171-c36b16c12e26"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("65971f24-8a72-4568-b34c-e4e95f6fa4f7"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("65b8627f-dad9-43d9-a2b7-d04a9f6c3814"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("69c8ffc5-7c93-4e0e-a4f7-e32c5d05df5b"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("6eafd88d-d990-475e-b4e4-e8be4bfa3f92"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("75c7b550-91e5-4530-97bb-63bbf13f31c2"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("8214cef3-0918-46d4-a325-964ec1103cfc"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("84b5125c-2eda-4058-8fc2-7efa5eddc674"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("876848ae-e5c6-4ced-803e-5cb2e26216f8"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("87b010f2-801a-4d8f-9142-8b03a86b6e97"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("94cfa7f4-f7b8-43cd-94d6-462a0cf19943"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("9d30e5b2-4e7c-49c9-819f-da2c69e1ecb6"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("a7b26ea0-b29d-4369-a0e1-1075d6678dcc"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("a969b7e7-d873-4218-8ad7-506d853d410d"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("b70b8e0a-467c-4192-a006-3ee098e85800"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("bd0ffd0d-421a-4174-a555-f6a364fa7582"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("c2189570-f434-4ec6-b42b-047944c57b94"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("c7eb835a-2181-4cea-b07e-f3dd7d685250"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("cf84831c-1084-4167-af96-8eb76149b028"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("cfffa239-8817-4c16-8541-d429dc81ff65"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("d1368be3-62fc-416e-a4e2-e73d5ec8fe38"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("d32b1fe6-f361-4b1a-8be9-edc9a44c5048"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("d9032bba-9fd0-485b-930c-06c3048b8ad2"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("e3667c18-c4ac-44d6-be05-b08f89ddf738"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("e54f0470-1a09-4c3e-8c9d-e1d160f6089e"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("e67eedc1-facd-4461-974e-3625b63ffd14"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("e6f6930c-b1ab-4a7e-8d6a-46b6cd9156c3"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("ebe6d448-082c-4d02-b1ce-744d3313f82f"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("f49ed69c-095f-419c-922f-0274e7f056aa"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("f7904b6e-f37e-4aa4-957d-74fd29a1c761"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("f870f834-7344-4d60-8476-30d6ff34f24b"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("facabd5d-c3e3-44d6-9175-fd88c3536a85"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("fb4d412c-0275-4669-99fb-18995a78de6c"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("fd0b6e35-3956-43fb-bb14-f515d4e8aa64"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("fdbe2bcf-00ab-48ad-940a-875be7de110c"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("229b987f-9655-4aff-b0c0-ab69b447b6a0"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("29827caa-c6c9-4a0d-af25-8ffb02e76ba9"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("3a68a4e7-a6a8-4496-9e3a-d71147303732"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("43b8f5f0-6f55-4c9c-afa7-0fc204d2c543"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("440d489a-7563-4c4d-8570-2635a748e95f"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("44aee6a2-2342-4519-8292-83b5dbaddf6e"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("46f627b1-2930-46ed-b922-a7b09ac666d5"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("496f293b-0420-4408-a88c-a49337206dc0"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("4c8e3a49-0d18-4055-b653-85bbc66c037d"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("5d952e27-3ef6-4e1c-b21c-b86ac32f0bf3"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("66c21ae7-e9b2-42f1-af8c-4d3a419f6322"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("7166ca20-afed-4093-8d9c-38e7ed82b14d"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("72f2d457-7606-4117-9f56-fd529de5c3b0"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("86be6f22-7772-4b1e-8fc6-801b0c8443a0"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("9ec7818f-8dde-409e-815f-ba0a19eb2a17"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("b4aeedb0-ff7e-433d-8dea-00d94a4c306a"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("b4b9de09-ffe3-49f8-b8c1-14c7fc6a1b42"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("b4f0b493-d952-4a99-aca9-5487f812de1c"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("b50c57b2-45fc-459e-a6cf-93c02719989a"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("ba6a2450-e9bf-454e-8fbe-9ce9d806242b"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("d4c152ff-a2cd-4a37-9566-2eb79c7700a0"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("da63e54b-0c94-4ab0-9caf-acd6ec948295"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("e37bff2e-dd6b-4395-8658-078526b967f5"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("f828c7ef-b818-4092-89e0-b0b59aaeb5f6"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("fe9f288d-8322-4cf7-a718-0a7d359760f6"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 22, 27, 55, 765, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f876251-3a6d-4f63-b65e-836ffd62610a"), "This is the best game I have ever seen", new DateTime(2025, 7, 9, 22, 27, 55, 774, DateTimeKind.Local).AddTicks(9551), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") },
                    { new Guid("9bdc960e-3696-4591-a462-5b93f8d7d093"), "This game gives me a cozy vibe", new DateTime(2025, 7, 9, 22, 27, 55, 774, DateTimeKind.Local).AddTicks(9563), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("a7e8591e-f67e-4242-88d4-51e9d0a9b011"), "This game is good, but it has some bugs", new DateTime(2025, 7, 9, 22, 27, 55, 774, DateTimeKind.Local).AddTicks(9566), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BanHistories_AspNetUsers_UserId",
                table: "BanHistories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
