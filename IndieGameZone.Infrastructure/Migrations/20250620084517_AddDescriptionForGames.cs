using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionForGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0c33b840-96ec-4429-9686-d839ed2e542a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0cc51e80-b68e-4aac-bc76-bddb00fdbdc8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1a53aabc-9fd3-4788-8cc2-e5b9c9e2f813"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1af494c7-fdb4-4825-9dee-4cab4b45b0b5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ff9e42b-6926-4339-87ce-183ec3b44a20"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("212642c2-cae8-4c11-b933-47ff67e6384a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("23bc9d9c-a27d-4cbe-bd06-b016a53ae044"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2a4a96ad-a20c-4ee3-89c8-a4ae7a5de428"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2b48a511-708d-4cdc-9b81-445aa0982cfc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2e491688-262b-4de0-bde7-ecc1adf58003"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("30b2fcf8-ab80-47b3-b1d8-acfda11717b0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("36a9b8af-c2db-4948-af77-f6d1c784e5f1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("42f9787a-f782-4d28-b91e-83d0c61a981c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("44425553-948a-49a8-b581-898febbd7c4d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4c73ef8b-3e3e-4c32-8fb3-59ad22a9c131"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("503e4434-0a06-4ed3-95a5-bdab614eacad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("52d06485-6b43-40c7-b10f-bbf216a2395f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("56115c5b-b418-4cae-a1ba-0ecdf8d00205"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("58490e1b-54b3-4244-8c66-18c560594798"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("58e6c4db-8019-49f2-ae9f-2ddc9ce8e2f1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5ad92a08-60ef-4a64-8bb7-c08886f03a54"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5c2a79e1-c91c-4ad9-8eaa-0b5f903323f9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6081d186-b63d-498b-b82d-f0cce35e7159"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("674b9f66-0ff5-4b5e-b642-c34be150188a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("720a3dd4-62f8-4a8b-bb58-70f20868085d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("74c012b5-6043-454c-bc38-411dc75b5f8a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("77684486-63de-4704-aad0-71b3fc75e5d2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7b6dec73-b9e4-4f24-82bb-190e58e843d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7cc64dcf-cd64-41b6-8876-fd70e3ea2d0f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("872b3d45-d5e9-42c3-a41c-58460e2a3295"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8812de48-8282-425a-b86f-067e363fe35c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8b34ae67-9e81-42cb-97ff-1b0fd687a776"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8c026dea-8d38-4456-8dee-b7baff6abd03"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("974b5cca-0f56-4c96-8200-3155288ed56f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("97f246b6-3ce6-4e56-95a2-531a5c564a75"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9d4d7d96-5e88-4e3f-acdf-9b1e59c416e5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a0a3975a-7b98-40e2-bd73-dc65c13668a0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1057a28-b15a-40ef-bd8e-45158e309b65"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ab011f3c-20de-486e-95f6-0b8271076696"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b2bd1387-4dbd-43b6-a2ff-1db2350fc484"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b6c34be7-8f01-4fdd-99f5-2e5f2c5f28a4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b71825ad-e1cf-45f5-a253-393e54fa8aed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b7e97a66-a197-44dd-af9c-b015c4a12485"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bc412cff-4c90-4de9-bb3e-1f72c9ed3f40"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bc610ea9-5241-49ee-b6f8-c6d65b6e96d7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c18f53ff-eda1-48e5-92e5-36a175a253bd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c3f5185b-0af4-45f3-afbb-fc4bcb34011b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c678fa48-8914-49ab-9835-de076f6af6d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d3d42f9a-bd2f-40c7-99ad-90a6a5baa6aa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dc098177-29ef-4ed0-a421-2c3b0203c328"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dc9a66c2-3f84-4bd5-9f5c-8ed7622c4995"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e0f5ce3e-3160-4da7-9a22-96b7e1428da1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e54d9cfd-edc3-43a8-aeea-fabea00326aa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e69c71dd-9f6a-4fe0-8ff8-6e07d2787297"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e7804d4c-4cb7-4aea-9a5e-769cda35652d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eb1fc14f-b7d6-4b49-a462-a3ab349e5b24"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ef145df5-963f-4827-ae62-2d45e444ae01"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f5e66f17-03cb-4298-8b59-1ae58d9cff51"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f647e38c-08d7-4f74-8c8b-be7299b68060"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f8e0457c-605e-4b1d-bc26-32a8038af105"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fbbb52e4-a0a8-4126-b37b-45d4674ed7e9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fbe67754-a88c-48bb-9b78-b0b50d26661f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0d87b841-dda7-42ae-927f-d53fefe6677b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("29e21cfc-222d-4190-afb9-6682c6eb048c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2a43f336-ec20-450f-b578-0ef3944180aa"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("327265ab-d951-4325-9250-562498cebc7d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("34e52c42-93c4-4b34-a6f1-42b6366af81d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3b95c6bc-88f0-4b70-a8d4-3d729d0b3487"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("49c8e7cd-3671-41da-9ae8-798f3552c189"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5038a4ad-1ac1-4ac3-8286-a06ac0e3e2e8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5b19f130-01a5-45d0-9544-45c3001446a0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6494837a-b101-4855-a4f6-b08f6f965a21"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6e20a0e3-b7d7-4181-9651-d3f89567d5c7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("76219ad7-87dc-4265-bf94-bf90db13f211"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7c4451d6-5f57-442a-81e7-06ac88fcd419"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7f17e58b-f17e-4803-8754-4ede3c9a2e44"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8c0b4bac-9f7e-49ea-a4e3-0e33cb532dce"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("963f945c-c5f9-473c-95c1-437d2b3bc440"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a4fe0f85-3cb0-4dd7-ad51-11e6c39484cd"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b292d756-bbd4-4b27-8033-b522eaaea666"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c670c5d8-1f1a-4131-b8cb-e0a42fc9d7e8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("caa390b7-b9aa-4165-9c3b-4d63054eaea0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ce6e5b1f-3f4c-42bd-a1e4-0cde2bdd4832"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d3a29e8a-c8b3-4f88-bf7c-94a36976024d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d9ffc2eb-7bb9-433e-9e4e-b53b55139c99"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dee057bb-e1b0-43ca-abba-b5b428413d86"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e88472af-f79b-404d-a8bd-a8723d0f4095"));

            migrationBuilder.AddColumn<bool>(
                name: "HasCommercial",
                table: "Games",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7211c17-4124-457f-9994-ef8d07e716d0", new DateTime(2025, 6, 20, 15, 45, 16, 396, DateTimeKind.Local).AddTicks(9813), "AQAAAAIAAYagAAAAEFHrYNezP4cpUYOB0TMfmoy1fZ2/yMXFw7glBhsIg84Qn4k1ZbENr60uFyMkhISDEg==", "8f7d2ff1-391b-4a15-85e5-441c6a91072f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae782652-6a9b-46e5-a6f7-b163d61ebf44", new DateTime(2025, 6, 20, 15, 45, 16, 584, DateTimeKind.Local).AddTicks(1729), "AQAAAAIAAYagAAAAEFFCNwR0cUbIkN2gh1YiQR3zfRAjZagEWqloely+ux/+ArsKdGxjgP3bW1DP6jeApQ==", "01e01c2c-cf3b-496e-982f-a1af195bd198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a243e34f-4e0e-491e-b00d-8a7d1a4f0863", new DateTime(2025, 6, 20, 15, 45, 16, 646, DateTimeKind.Local).AddTicks(4510), "AQAAAAIAAYagAAAAECxa8quJSWP4HcfUgFoJ43vYH4O40BeK2UDNaGIPz1ur6U9rY99UUHAMzYE45uvZpQ==", "dc45e0dc-caa1-40a6-9b2c-8c95f43eef70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34670b6d-2a15-40a1-b69f-b706dcbadd92", new DateTime(2025, 6, 20, 15, 45, 16, 327, DateTimeKind.Local).AddTicks(903), "AQAAAAIAAYagAAAAENl7p9DkDCtlnBa304ti0vWFggjwWDQlohrXjKZfSPPWFfpBibH5STz9eypBnYYkIQ==", "f40e84fc-7e6e-4f43-8a37-987313c6b96b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d68b57a-5714-417d-b9e6-6af12b2b7ee3", new DateTime(2025, 6, 20, 15, 45, 16, 521, DateTimeKind.Local).AddTicks(6007), "AQAAAAIAAYagAAAAEAFpzIFLCoZ9hqRZAHrS1QwReyz8SmbBmSmP2HqEHRIpH7FE/duQGl7/CNNE4doeNg==", "0ec5069d-e378-483a-aed3-39747142a5c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6985c87-6d2c-4cd1-bfe1-f098d01b6dd8", new DateTime(2025, 6, 20, 15, 45, 16, 458, DateTimeKind.Local).AddTicks(2227), "AQAAAAIAAYagAAAAEDT7xQN7O1snsVDE6oldXag++joHLv4Ao6xc0iQ+JQvhmDKoU+hOtfPEVQ5YIhR0eQ==", "0e11565b-2d5d-44c9-bbb1-0325625ba456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf67d608-271f-47dd-a4fb-9227270ac6a5", new DateTime(2025, 6, 20, 15, 45, 16, 711, DateTimeKind.Local).AddTicks(6871), "AQAAAAIAAYagAAAAEFSHz4cLP/Gyx+IEmgOkilgL9l2a2R1VYoncvVxMoUzRS1LnBhD6IA9w+yzLyNKIVw==", "f17db4ee-efc8-481f-a0e3-87fc6efa5738" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52b55649-2888-4fec-b80b-715f65dd622b", new DateTime(2025, 6, 20, 15, 45, 16, 264, DateTimeKind.Local).AddTicks(3725), "AQAAAAIAAYagAAAAEPzrpBJMtnqoFh2Yefu+nA8b6Be+2hCZ8MHE0g8xSPOCN55EzVGigVZd/uzw2UvEfg==", "ae924e3e-3484-4405-9a44-59485a546b71" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 30), new DateOnly(2025, 6, 20) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("03a46f76-fbb1-4425-9ad4-8b10cde8826c"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("04fe471a-4f38-4616-b2e9-2cdb7084ec0d"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("0f3e63f3-eef3-4ac7-936f-e9bfca338de2"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("0f71211a-9433-4a23-8067-59a2ef99a100"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("1445a46b-de85-43ed-966c-48d6686c8dd1"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("17f4faad-b25b-4d0d-aa0b-af628cfaa0bd"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("197a7dfe-1a22-48ef-8b0a-71219289ff94"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("1aaa2879-38e2-4ef1-aced-5955bfebb313"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("1e10cf86-1ade-4cde-8493-387efada08e1"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("20b664ae-4bb8-4369-8ca3-cacb359cdba2"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("28db1536-5921-4f83-bc2c-5e22d8639c42"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("2e310983-6c20-4300-8307-a38f75b4bdf2"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("31072f31-9386-46a6-9024-4e952355e8e3"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("31910fcc-4d44-416a-8aef-8ebf23dd9d84"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("31cbfe1f-0a17-486d-827b-8992b672fdd3"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("32c0110d-cf9a-4394-8993-eeeae6e10047"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("35acf833-d03e-4b29-9df7-140e756c9ac9"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("37672997-c10e-4786-9fba-9b1d9d67dd54"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("3bf7045b-bf02-4838-8c21-56a17c18144c"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("3cf683c3-2c8e-4941-99d2-e26060502da0"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("41595398-7810-4e57-b5fc-df92c30e5a0e"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("4195def0-1617-4dd8-840b-6b6380b2502d"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("4863a56d-5702-4f48-9c74-8ad5bbe11863"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("4b29eaa7-0e5d-499f-939e-9b2a76c01fc4"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("4c06187d-6e14-45a2-93f2-4d8d2d7a68b8"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("51fdd34f-9e20-44b3-ae33-08c5dd75d749"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("570e77b6-3efb-4906-a35b-6e1d94a4e111"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("58f425fd-3c74-45bc-8c7d-300dc60bc18a"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("5ec9c382-d23a-4416-b816-72fbe19badb8"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("5fe64339-fe59-4712-93c5-3dd079b2b0a5"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("62849584-b485-455f-af49-48d311bf644a"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("70cd2e80-5a3e-43c0-b71d-0263298e83b3"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("71844a7c-58ed-4285-a9cc-366571365584"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("7308c3c3-0cd9-4993-942a-78ba6a5ae8ff"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("75a152d3-4aa1-4bfd-8f28-031dbf8b415f"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("7d9f1818-b47d-4c31-b193-2d398ee24ada"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("8015a7c6-dd5c-4b8f-b2c0-709da8648b54"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("89402eb9-318b-47e7-8b10-7128ebeb0fce"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("8f95ae2a-b4e7-415f-a0ad-d13135dc3093"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("90799b47-0c93-4369-ba38-85fa1bce9ea8"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("9dbaa741-7c63-44c2-aec2-f96f4a2a51a8"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("a45d7679-ecb3-4aae-bb5e-d15d04a97dad"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("ac74fc24-1364-44d0-8fb6-ac2481d5f37d"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("af08cf6c-56ed-44fb-aebf-578872aca9d1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("b0df6409-1c77-4e38-ad21-7cd7be63805a"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("b5fb3e44-0e54-4405-9169-2b5157b289e6"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("b85b318a-fb21-4bb6-91d3-9316aefb7b76"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("c40e80cf-e272-4b35-a4f5-c41820dc945f"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("c6c1c4d0-fe49-4e0b-852c-dec5cc2255ab"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("cb9e029f-5778-40e9-acba-5fd776eb5b69"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("cf3bed6c-f400-4237-b8ed-3b875297b247"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("cfafd00c-f9ef-4b3b-850f-e114efb74668"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("d0a8fd8c-87b5-470c-ba77-dacc39059853"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("d3a724c3-c524-4130-8693-6d899a18bb03"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("d4342187-f0bc-46c8-be99-c479102a6c30"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("d8ff3345-a544-45c5-a335-fd2b6e90da17"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("db22cad1-37f5-42e9-804a-9ee7144c367a"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("dd22c3e6-f6e7-4666-9dcc-e17977434111"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("e3cfcec3-5172-4849-9b75-f5affeca59ff"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("e5e375cd-6af7-4625-9621-28d951313cdf"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("e9af4893-cfd9-42db-9e6c-e1d16e0ad373"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("feafa08d-9e0b-4d36-ba81-8997422bc1f3"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("08c7c9f1-3801-46f0-b64e-624a6f129dcb"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("1356b365-a9aa-4d35-a3b4-9d6b63820054"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("201fd2e9-aaf5-4e5d-b3b5-49e6d8c6e981"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("21d0550c-03ad-4534-8f4c-0da5629b7011"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("2b3b24ee-dfbd-42c5-b028-6d5a17a8ddd1"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("4282552a-18de-4c3e-8039-9480970b6c09"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("58da17b8-da12-45b9-8893-3710f7bc327f"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5921aaa4-0978-456f-bbe3-0b7b633716a2"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5ed67bca-7e37-427f-beaf-462db11b9cd5"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("613af596-f8a6-4432-bcb5-9034f5ad3dd4"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("70e2aaa8-c354-46b2-8e07-014b42422cdf"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("85334363-5ca6-4ddf-9f7c-ecc1d4341eaa"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("8de21811-4651-4010-92c0-7d0b69c837ab"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("8e8f6619-6951-4596-8d9d-957acf50c285"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("9a3e9679-0f36-4ac3-bf53-6f99f9c43487"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("a2c5cae2-2ec7-4b78-88a3-f9fecaac4b5f"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("aa6bdea8-bf24-47db-b643-76a13dc36327"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("c99b0dca-b3e7-4a66-866d-0fe9b150fc22"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("ccdc3e44-4ad6-4892-b7aa-3b85195eb9e7"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("d195257b-d8c6-4c2f-9482-b660f51336f2"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("deb79db1-c127-46c4-ad10-f9a500e229b9"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("e5fe1573-79de-4c0e-ac63-bba0abc6451a"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("e8cb55c6-4125-4734-a25b-94bd33b0db27"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("ed23eb65-9a8c-4c87-a224-ad095e7aab38"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("f5aa2c41-64aa-4746-afda-a527991c4ab8"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3373), "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!!&nbsp;<a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>", false, "Chill mold-cleaning arcade" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3525), "<h2>``ATLYSS``</h2><h4>SOLO DEVELOPMENT ACTION ORPG PROJECT</h4><p><em><strong>A work in progress / under development game made by Kiseff</strong></em><em><br /></em></p><h4>Core Game Info</h4><ul><li>\"ATLYSS\" is a (Single-player + Multi-player)&nbsp;<strong>A</strong>ction&nbsp;<strong>O</strong>nline&nbsp;<strong>R</strong>ole&nbsp;<strong>P</strong>laying&nbsp;<strong>G</strong>ame</li><li>Enriched, instanced maps to discover</li><li>Equipment, Trade Items and Consumables to collect</li><li>Many Character Customization options with&nbsp;<strong>5 races</strong>&nbsp;to choose from</li><li>3 Primary Classes to become at lv-10 (<strong>Fighter</strong>,&nbsp;<strong>Bandit</strong>,&nbsp;<strong>Mystic</strong>)</li><li>Skill load-out system for making builds to suit your game-play style</li><li>Character stat progression / leveling systems / attributes</li><li>7 Weapon types to use in combat (Katars, Heavy Melee, Scepters, and more)</li><li>Repeatable Questing / Single Quests to complete</li><li><strong>Aesthetics inspired by 6th Generation video games</strong></li></ul><h4>Media / Promotion</h4><p><a href=\"https://www.patreon.com/Kiseff?fan_landing=true\" target=\"_blank\" rel=\"nofollow noopener\"><strong>If you'd like to support my game-dev work and other assorted projects, you can do so via my Patreon!</strong></a></p><p>For more instant information / updates / development progress, you can:</p><p><a href=\"https://twitter.com/kis_soft\" target=\"_blank\" rel=\"nofollow noopener\"><strong>Follow @kis_soft on Twitter</strong></a><strong><br /></strong></p><p><strong><a href=\"https://discord.gg/vScP5yUbtk\" target=\"_blank\" rel=\"nofollow noopener\">Join the KisSoft Underground Server to receive progression updates and notes, including announcements first hand! Community links are provided in the Discord's promotional links channel.</a></strong></p>", false });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3513), "<h1><em>Dispatched!&nbsp;</em></h1><h3>\"The Hungry Hungry Hippos of late-stage capitalism.\"</h3><p>From the same idiots who made 'Plane Food Simulator':&nbsp;<a href=\"https://sheepandram.itch.io/pfs2021\">https://sheepandram.itch.io/pfs2021</a></p><p><strong>Platform =</strong>&nbsp;PC and Android App&nbsp;Store<br /><strong><br /></strong><strong>Full Description:</strong></p><p>In&nbsp;<em>Dispatched!</em>&nbsp;the aim of the game is to mail as many parcels as you can within the allocated time! Be careful you don't confuse the priority boxes, and make sure you bring an empty bottle.</p><p><strong>PC Controls:<br /></strong>Begin Game: Enter<br />Dispatch Parcel (Employee Left): Q<br />Dispatch Parcel (Employee Right): P<br /><strong><br /></strong><strong>Android/Phone Controls:</strong><br />Start Game = Tap Screen<br />Dispatch Parcel&nbsp;(Employee Left) = Tap Screen (Left hand side)<br />Dispatch Parcel (Employee Right) = Tap Screen (Right hand side)<br /><strong><br /></strong></p><p><strong>Executive Imagineer Enhancement Architect</strong><br />Chris Ramsden&nbsp;<a href=\"https://chris-ramsden.neocities.org/\" rel=\"nofollow noopener\">Neocities</a><br /><strong><br /></strong><strong>Executive Code Architect and Fulfilment Developer&nbsp;</strong><br />Sheps&nbsp;<a href=\"https://linktr.ee/thesheps\" rel=\"nofollow noopener\">https://linktr.ee/thesheps</a></p><p><strong>Executive Experience Enhancement Officer&nbsp;</strong><br />Max Blake</p><p><strong>Soundtrack Specialist</strong><br />The Gasman <a href=\"https://thegasman.bandcamp.com/music\" rel=\"nofollow noopener\">https://thegasman.bandcamp.com/music</a></p><p><strong>Special Thanks&nbsp;</strong>:&nbsp;<a href=\"https://freetousesounds.bandcamp.com/\" rel=\"nofollow noopener\">https://freetousesounds.bandcamp.com/</a></p><p><strong>All essential workers and distribution staff. Thanks for halting the societal collapse of 2020/21!</strong></p>", false, "The Hungry Hungry Hippos of late-stage capitalism." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3488), "<p><strong><em>On Friday night, just past midnight, the people of Thunderhead screamed in terror.</em></strong></p><p><strong><em>Their end began four days earlier, when a strange hill appeared at the edge of the cemetery.</em></strong></p><p><strong><em>Maybe it began even further back - but our story begins the next morning, when the first light touched a town stained by horror.</em></strong></p><p><strong><em>What happened in Thunderhead was first told by the man who delivers milk every Friday to towns too quiet to matter.</em></strong></p><h2>FEATURES</h2><ul><li><strong><em>A&nbsp;Milk-Delivery Western Horror!</em></strong></li><li><em><strong>Driving!&nbsp;</strong></em>Take the wheel of your rusty old van.</li><li><strong><em>Delivering!</em></strong>&nbsp;Bring milk and orange juice to a tiny, forgotten Western town.<em><br /></em></li><li><strong><em>Fixing!</em></strong>&nbsp;The van's temperamental&mdash;sometimes it needs a whack with a wrench.</li><li><strong><em>Mystery!&nbsp;</em></strong>The town is empty. Where did everyone go? Why are there crosses everywhere? Who left behind those torn clothes? What happened here?</li><li><strong><em>Spectacle!</em></strong>&nbsp;Phenomenal music by&nbsp;<a href=\"https://voltzsupreme.itch.io/\">Voltz Supreme</a>, immersive sound design and an epic, cinematic finale.</li><li><strong><em>Retro graphics!</em></strong>&nbsp;Soak in the PSX-style aesthetic - on the prairie!</li></ul><h2>SOUNDTRACK</h2><p><a href=\"https://open.spotify.com/playlist/4ZiuqrgseeMUVCzz7oZI1D?si=42f92c241bdb4c7f&amp;nd=1&amp;dlsi=acab8f98a54b45e5\" rel=\"nofollow noopener\">You can listen to the soundtrack here.</a></p><h2>FOUND A BUG?&nbsp;</h2><p>Please let me know in the comments.&nbsp;</p><h2>FOLLOW ME</h2><table><tbody><tr><td><a href=\"https://bsky.app/profile/roawrvideostore.bsky.social\" rel=\"nofollow noopener\">Bluesky</a></td><td><a href=\"https://www.instagram.com/roawrvideostore/\" rel=\"nofollow noopener\">Instagram</a></td><td><a href=\"https://www.threads.net/@roawrvideostore\" rel=\"nofollow noopener\">Threads</a></td></tr></tbody></table>", false, "A Milk-Delivery Western Horror." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3379), "<h3>ABOUT:</h3><p>A short,&nbsp;psychological horror experience where you, player, quickly age to see how's your family doing now.</p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"MouseMemoirs\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Crouch</td><td>Ctrl</td></tr><tr><td>Interaction</td><td>E</td></tr></tbody></table><h3>NOTE:</h3><p>Game has a bit of experimentation going on in it and I tried some new stuff, like moving away from retro graphics, experimenting with movement and colors etc. and I sincerely hope that you will like what you see!</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p>", false, "Short and strange psychological horror" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3353), "<p><strong>Announcement</strong>: Midnight Shift 1.2 has been released.</p><ul><li>Enhanced 4:3 VHS / found footage appearance.</li><li>The animation for the ending has been updated.</li><li>Increased field-of-view.</li><li>Updated main menu.</li></ul><p><strong>Synopsis</strong></p><p><em>Midnight Shift</em>&nbsp;puts players in the role as an ordinary security guard for a mannequin storage facility. At the end of a seemingly ordinary shift, strange things begin to happen in the facility. Leaving won't be easy as the keys required for the exit doors have been misplaced.</p><p><strong>Development</strong></p><p>This was my first Unity project I created during my time at Edmonton Digital Arts College. The project has eight weeks of development time with seldom game engine and coding experience.</p><p><strong>Developer's Note</strong></p><p>Thanks for 25,000+ Midnight Shift downloads! I appreciate all the support and your interest in my projects.</p>", false, "Escape a mannequin storage facility." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CensorStatus", "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { "Approved", new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3340), "<h4>Steam release features Hard Mode, as well as double the story!</h4><p>You are in the backseat of your parent's car during a long drive. As your parents begin fighting, your hand-held game is your only source of entertainment. But the game begins to mirror real life... Collect items on your hand-held game to send them to the backseat and use them to defend against the monstrosity that's trying to make its way into the backseat with you.</p><h4>SURVIVE THE NIGHT DRIVE</h4><p>Your drive home from grandma's is interrupted by an unexpected detour. Play a hand-held game in the backseat as your parent's drive.</p><h4>RETRO GAMING</h4><p>Your hand-held game is beginning to mirror reality... Supplies you collect in the game will be sent to the backseat.</p><h4>TRAPPED IN THE DEADSEAT</h4><p>A deadly monstrosity wants to join you in the backseat. Juggle your supplies and defend all sides. In this car, there&rsquo;s only onwards to drive, and nowhere to run.</p><h4>THE STORY</h4><p>Your parents can't get along, and you can&rsquo;t ignore it, no matter how deep you immerse yourself in your game. If only you could get away from it all and escape to somewhere better. And seemingly, the voice in your game says you can.</p>", false, "A short horror game where you play a hand-held game in the backseat during a long drive home." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3361), "<h2>THE STORY</h2><p>On your first day as an apprentice at the Nytheris Archive, you accidentally unleash an ancient force that was meant to stay sealed forever. Ooops!</p><p>Now, with the world teetering on the brink, it's up to you to piece together the remnants of a shattered relic and set things right.</p><p>Explore a world filled with strange characters, forgotten ruins, and puzzles. Follow the clues. Trust your instincts... and try not to make things worse.</p><p><em>Broken Relic</em>&nbsp;invites you to navigate a crumbling world, uncovering its secrets one strange step at a time. You may not be the hero it needs. But you're what it&rsquo;s got.</p><h2>What to expect:</h2><ul><li>Fully voiced dialogue with a world full of unusual people.</li><li>A handcrafted pixel art world filled with details and secrets.</li><li>Nonlinear exploration across connected regions.</li><li>No fail states, no pixel hunting, no filler.<br /><br /><br />If you enjoy the demo, please wishlist and follow the game on Steam, it really helps support the project!&nbsp;<br /><a href=\"https://store.steampowered.com/app/3384820/Broken_Relic/\" rel=\"nofollow noopener\">https://store.steampowered.com/app/3384820/Broken_Relic/<br /></a></li></ul><p>Also you can join the newsletter to hear about the big updates:&nbsp;<a href=\"https://broken-relic.kit.com/ea36291513\" rel=\"nofollow noopener\">https://www.brokenrelic.com/<br /></a>And dont forget to join our Discord!! <a href=\"https://discord.gg/zDBJUKwD\" rel=\"nofollow noopener\">https://discord.gg/zDBJUKwD</a></p>", false, "First day on the job. You broke a seal, unleashed a dark power, and may have doomed everyone." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3413), "<p><em>Warning: Contains blood, violence, strong language and disturbing imagery.</em></p><h1><em>Dated November 4th, 1988.</em></h1><h2>MASSACRE AT DAYTON COUNTY MALL! HUNDREDS DEAD, OVER 350 INJURED.</h2><h2>EXPERTS ARE STILL INVESTIGATING WHAT EXACTLY HAPPENED, BUT IT APPEARS A... DINOSAUR?... MATERIALISED IN THE MALL AND WENT FERAL...</h2><p><em>This is a breaking story - more information soon.</em></p><p><strong>Special thanks:</strong></p><ul><li>3D Art assistance - Anders Brynildsen</li></ul><p><strong>Voicing:</strong></p><ul><li>Han Davies</li><li>Ned Sanders</li><li>Will Aryitey</li><li>Figerox Studios</li></ul><p>This game was heavily inspired by the legend,&nbsp;Puppet Combo.</p>", false, "It came without warning. Put an end to the massacre, and hunt down the dinosaur." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3544), "<p>After a long day, you take the subway home. The train is late, but everything seems normal&mdash;until the doors close. Among the passengers, one man starts acting strange... There's nowhere to run.</p><h3>Features:</h3><p>Average playtime: 5&ndash;10 minutes</p><p>Four original endings + secret ending</p><p>PSX retro style</p><p>Original story</p><p><strong>Streamer-YouTuber friendly: non-copyright music</strong></p><p>Completely translated to Portuguese, Spanish, Turkish, Polish, Russian, German, Korean, Italian and French!</p><h3>Controls:</h3><p>Movement: WASD</p><p>Run: Shift</p><p>Interact: E</p><p>Next dialogue/Move objects: Left mouse button</p><p>Stand up: Space</p><h3>About:</h3><p>DISCLAIMER: This game displays your pc's name so if you don't want your real name to be displayed you should change your pc's name or just don't play the game on stream.</p><p>If you liked this game, you should check out:</p><p><a href=\"https://riversoftware.itch.io/on-my-way-home\">On My Way Home by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/neighbournextdoor\">Neighbour Next Door by RiverSoftware</a></p><p><a href=\"https://riversoftware.itch.io/tv-night\">TV Night by RiverSoftware</a></p><h3>Known Issues:</h3><p>Gameplay limited to 100fps due to a bug with player controller</p><p>Some lights may not work if you select the low graphics option</p>", false, "Just a typical subway ride..." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3506), "<h3>ABOUT:</h3><p>A short, atmospheric horror experience where you and a friend are tasked with digging up two bodies,&nbsp;<strong>but something isn&rsquo;t right.</strong></p><h3>MORE INFO:</h3><p>~10 minutes</p><p>In game font: \"November\"</p><h3>CONTROLS:</h3><table><tbody><tr><td>Movement</td><td>W, A,&nbsp;S, D</td></tr><tr><td>Sprint</td><td>Shift</td></tr><tr><td>Interaction</td><td>E</td></tr><tr><td>Attack</td><td>LMB</td></tr></tbody></table><h3>WARNING:</h3><p>The game features mild gore, loud sound effects and everything that comes with horror genre. Player discretion is advised.</p><h3>NOTE:</h3><p>Game has a bit of comedy in it and I hope that I did good job with implementing it!</p><p>Don't harass me over voice acting :D , Neither me, or my friend are native English speakers, but we gave it our best and had a lot of fun doing it!</p><p>Most of the&nbsp;<strong>models&nbsp;</strong>(4 that aren't are aptly credited),&nbsp;<strong>music&nbsp;</strong>and&nbsp;<strong>scripts</strong>&nbsp;in&nbsp;the game are made by me, textures are from&nbsp;<a href=\"https://ambientcg.com/\" target=\"_blank\" rel=\"nofollow noopener\">AmbeintCG</a>.</p><p>If you run into any bugs or issues, feel free to reach out in the comments, my&nbsp;<a href=\"https://www.youtube.com/@VukDobric\" target=\"_blank\" rel=\"nofollow noopener\">YouTube</a>&nbsp;channel or by e-mail at&nbsp;vukkdobric@gmail.com</p><h3>UPDATE:</h3><p>CaseOh, being an absolute legend that he is, played another one of my games on his stream, this is snippet of the live where he plays this game, thanks CaseOh!</p>", false, "Atmospheric horror experience where you and your friend have to dig some bodies, but something is wrong." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3407), "<p>a short&nbsp;<strong>vn style game</strong>&nbsp;made in rpgmaker in which you try to find out what happened to your missing friend.</p><p><strong>contains: mild blood, needles, a yandere, and a little bit of comedy</strong></p><p>this game's super short,&nbsp;<strong>5 endings</strong>, maybe around 10 to 15 minutes to complete?</p><p>sorry if there's errors and stuff, i made the entire thing in one night and im very sleep deprived&nbsp;</p><p>if there's any major errors or bugs lmk i'll try to get to fixing that asap okay dokay</p><p><strong>credits</strong></p><p>art and music: me</p><p>plugins: galv and that YEP message core thingy</p><p><strong>and btw.....!</strong></p><p>if you wanna follow along the development of the main game that this one is based off of, come&nbsp;<a href=\"https://discord.gg/MGzVp9JSsK\" target=\"_blank\" rel=\"nofollow noopener\">join my discord server!!</a></p>", false, "Your friend's gone missing. You're out to find out what happened to them." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3391), "<h3>Help Sheepy, an abandoned plushy brought to life, as he explores a forgotten and broken world. Sheepy: A Short Adventure is the first short game from MrSuicideSheep.</h3><h2>Independently Handcrafted</h2><p>A short, handcrafted, fully independent pixel art platformer, spanning several zones with unique skills to unlock. Discover an abandoned world full of secrets and lore influenced by themes driven by the music and community of MrSuicideSheep for more than 10 years.&nbsp;</p><h2>An Original Soundtrack</h2><p>Weaved into the world is an incredible original soundtrack created by Seeking Blue artists Tal Richards, Hahlweg and Yoe Mase availble to stream and purchase here.</p><h2>Mailing List</h2><p>Join the Mailing List and be the first to learn about future happenings with Sheepy!</p>", false, "Help Sheepy, as he explores a forgotten an broken world." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3519), "<p><strong>Security Booth is a VHS PSX Horror Game.&nbsp;</strong></p><p>Based in 1996, you are working for a company known as Nova Nexus, you play as a security guard.<br />Your job role is to make sure that only the right authorized personnel are getting into the facility.&nbsp;</p><p>The game has a total of&nbsp;<strong>2 endings.<br /></strong></p><p><strong>Average Game Time - 10 Minutes&nbsp;</strong></p><p><strong>Game Controls&nbsp;</strong></p><table><tbody><tr><td>Walk</td><td>Look Around</td><td>Interact</td><td>FlashLight</td></tr><tr><td>W,A,S,D</td><td>Mouse</td><td>E</td><td>F</td></tr></tbody></table><p><strong>Menu/UI Controls</strong></p><table><tbody><tr><td>Select Option</td><td>Go To Option Right/Next Page</td><td>Go To Option Left/Previous Page</td><td>Go To Option Up Or Down</td></tr><tr><td>E</td><td>D</td><td>A</td><td>W - UP<br />S - Down</td></tr></tbody></table><p>*The Mouse will never show up in game*</p><p>--------------------------------------------------------------------</p><p>Want more?<br />Security Booth:&nbsp;Director's Cut is OUT NOW!<br />Check out the Steam store or grab it here on Itch.io.</p><p>Follow my twitter for future games that I am making.<br /><a href=\"https://twitter.com/KyleHorwood\" rel=\"nofollow noopener\">https://twitter.com/KyleHorwood</a></p>", false, "A Short VHS PSX Horror Game." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3397), "<p><em>Donation is not necessary to play the game, but definitely much appreciated for me to keep making games.</em></p><p>---</p><h2><strong>DAUGHTER</strong></h2><p>Your daughter went to a sleepover birthday party at her friend's house, what could go wrong?</p><p>This is a short horror game about you trying to rescuing your daughter from a creepy house.</p><p>The story might feel incomplete as&nbsp;Daughter is a submission to the Lost Relic Games Game Jam 2022 and was made in a week. The theme is \"connection\" and I'm going for a more abstract route about the connection between the father and the daughter.</p><p>Your comments and feedbacks are very much appreciated as I might be updating this game after the Jam.</p><p>---</p><p><strong>BUGS</strong></p><ul><li>If you have a hard time reading the notes, close the flashlight before you interact with it.</li></ul><p>---</p><h2>BASIC CONTROLS</h2><p>Only support keyboard and mouse.</p><p>W,A,S,D - Walk</p><p>LEFT SHIFT - Sprint</p><p>F / E / LMB&nbsp;- Interact</p><p>G - Flashlight</p><p>Left CTRL - Crouch</p><p>---</p><p><strong>If you enjoy my game,&nbsp;you can follow my development on X:&nbsp;<a href=\"https://x.com/MikeTenDev\" rel=\"nofollow noopener\">https://x.com/MikeTenDev</a></strong></p><p>---</p><h2>CREDITS</h2><p><strong>TOOLS USED:&nbsp;</strong>Unreal Engine, Blender and Audacity</p><p><strong>ASSETS USED:</strong></p><p>Modular PSX Architecture Pack:&nbsp;<a href=\"https://comp3interactive.itch.io/modular-psx-architecture-kit\">https://comp3interactive.itch.io/modular-psx-architecture-kit</a></p><p>Retro PSX Style Tree Pack:&nbsp;<a href=\"https://elegantcrow.itch.io/psx-retro-style-tree-pack\">https://elegantcrow.itch.io/psx-retro-style-tree-pack</a></p><p>Retro House Pack: <a href=\"https://elegantcrow.itch.io/retro-house-pack\">https://elegantcrow.itch.io/retro-house-pack</a></p><p>Tiny Texture Pack 1:&nbsp;<a href=\"https://screamingbrainstudios.itch.io/tiny-texture-pack\">https://screamingbrainstudios.itch.io/tiny-texture-pack</a></p><p>Deceitful Castle in Dungeon Music Pack:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/music/dungeon-music-pack-20599</a></p><p>Fantasy Sound Bundle:&nbsp;<a href=\"https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-193760\" rel=\"nofollow noopener\">https://assetstore.unity.com/packages/audio/sound-fx/fantasy-sounds-bundle-19376</a></p><p>Happy Birthday Whistle:&nbsp;<a href=\"https://freesound.org/people/gaiterjay/sounds/617576/\" rel=\"nofollow noopener\">https://freesound.org/people/gaiterjay/sounds/617576/</a></p><p>Requiem in d minor:&nbsp;<a href=\"https://musopen.org/music/43683-requiem-in-d-minor-k-626/\" rel=\"nofollow noopener\">https://musopen.org/music/43683-requiem-in-d-minor-k-626/</a></p><p>Biblical Goth Girl:&nbsp;<a href=\"https://crimsongcat.itch.io/biblical-goth-angel-girl\">https://crimsongcat.itch.io/biblical-goth-angel-girl</a></p><p>Brush Strokes:&nbsp;<a href=\"https://www.freepik.com/vectors/japanese-brush\" rel=\"nofollow noopener\">https://www.freepik.com/vectors/japanese-brush</a></p>", false, "A short horror game" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3494), "<h1>Evaluation</h1><p>A short PS1-inspired third person adventure game about growing up&nbsp;and finding your place in reality.<br />The game focuses on rewarding exploration, features NPCs and platforming elements, all supported by the narrative and a strong eerie atmosphere.</p><p>Evaluation is my first game&nbsp;project. It was a wild ride, way longer to finalize than I expected, but I learnt so much along the way, and hope to do more in the future!</p><h1>Controls</h1><p>WASD/Arrow keys - Move<br />MOUSE - Look around /&nbsp;click advances dialogue<br />SPACE - Jump<br />E - Talk/Interact<br />ESCAPE - Skip Cutscene<br />R - Respawn (if you get stuck)</p><h1>Credits</h1><p>I crafted as much as I could do from scratch, however the following external assets were of invaluable help on pulling off the game as I imagined it:<br /><a href=\"https://hutonggames.com/\" rel=\"nofollow noopener\">Playmaker - Huton Games</a><br /><a href=\"https://www.w3schools.com/\" rel=\"nofollow noopener\">PSX Effects - Triple Axis</a><br /><a href=\"https://assetstore.unity.com/packages/tools/physics/character-movement-fundamentals-144966\" rel=\"nofollow noopener\">Character Movement Fundamentals - Jan OTT</a><br /><a href=\"https://assetstore.unity.com/packages/3d/animations/basic-motions-free-154271\" rel=\"nofollow noopener\">Basic Motions - Kevin Iglesias</a></p><h1>More</h1><p>Find me on&nbsp;<a href=\"https://www.instagram.com/vivivivitotototo/\" rel=\"nofollow noopener\">Instagram</a>,&nbsp;<a href=\"https://twitter.com/vtrmrl\" rel=\"nofollow noopener\">Twitter</a>,&nbsp;<a href=\"https://soundcloud.com/zerocrossingpoint\" rel=\"nofollow noopener\">Soundcloud</a></p><p>Let me know if you find any bugs!</p><p><br /><br /></p>", false, "A short PS1-inspired third person adventure & exploration game about growth" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "CreatedAt", "HasCommercial" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3367), false });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3538), "<p>Your mum is cooking dinner. Saddened by the amount of leftover and not wanting it to go to waste, she tasked you the job to give it all away to your neighbours.</p><p>You, who was just minding your own business watching cartoons. You who your mum have told many times to not talk to strangers. But yet, you have no right to deny the request.&nbsp;</p><p>Armed with limited skills of communication, meet all the quirky and creepy neighbours to finish the task before your mum finish you first...literally.</p><p>Created for SCREAM JAM 2021&nbsp;by:</p><ul><li>Realmpact - Programmer</li><li>Skekarin - Artist, Writer and Games Designer</li></ul><p><strong>Disclaimer</strong></p><p>The WebGL version of the game is meant for users who are not using a Windows machine. For the best experience, we would recommend downloading the Windows version instead.</p><p>FAQ</p><ul><li>Help! I cannot show the leftovers!<ul><li>Press Q during the prompt to show leftovers&nbsp;to continue the conversation as if you showed it.</li></ul></li></ul>", false, "Don't talk to strangers, unless your mother needs you to." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CoverImage", "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage.jpg", new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3531), "<h4>\"Welcome to my game, buddy!\"</h4><p>Mr. TomatoS is glad to see you! He waited a long time for someone to visit him! Feel like at home and get ready for endless f̶u̶n̶ !</p><p>Mr. TomatoS needs YOUR help! looks like he had not eaten for ages! Of course not, he has no hands!</p><p>Feed Mr. Tomatos with big variety of food, combine it with blender, and use different items to help you with this task!</p><h4>\"But why should I do this?\"</h4><p>Glad you asked! By helping him you can earn a lot of points to spend them in the shop later! Everyone loves to earn points, right?</p><h4>\"Why am i always d̶y̶i̶n̶g̶ losing?\"</h4><p>Glad you asked, my dear friend! j̶u̶s̶t̶ d̶o̶n̶t̶ d̶o̶w̶n̶l̶o̶a̶d̶ i̶t̶ you need a strategy to finish the game! without a strategy, everything can go wrong.</p><p>Manage your resources correctly to s̶t̶a̶y̶ a̶l̶i̶v̶e̶ win!)</p><p>unless you want to make Mr. TomatoS angry.</p><p>This game is made in the style of old web flash games, what sets it apart from other new games!</p><p>Feel the atmosphere of old flash games!</p><p>You can complete the game only ONCE, that means that you won't have a second chance. And how you will complete YOUR game - depends only on YOU. Try your best. Good luck.</p><p>Main theme by:&nbsp;<strong>Cnupoc (</strong><span title=\"https://freesound.org/people/Cnupoc/\"><a href=\"https://freesound.org/people/Cnupoc/\" rel=\"nofollow noopener\">https://freesound.org/people/Cnupoc/</a></span><strong>)</strong></p><p>Game theme by:&nbsp;<strong>Sirkoto51 (</strong><span title=\"https://freesound.org/people/Sirkoto51/\"><a href=\"https://freesound.org/people/Sirkoto51/\" rel=\"nofollow noopener\">https://freesound.org/people/Sirkoto51/</a></span><strong>)</strong></p><p><strong>Sirkoto51 soundcloud :&nbsp;</strong>&nbsp;<span title=\"https://soundcloud.com/sirkoto51\"><a href=\"https://soundcloud.com/sirkoto51\" rel=\"nofollow noopener\">https://soundcloud.com/sirkoto51</a></span></p><p>Some sounds by:&nbsp;<strong>InspectorJ(</strong>Jonathan Shaw<strong>) (</strong><span title=\"https://freesound.org/people/InspectorJ/\"><a href=\"https://freesound.org/people/InspectorJ/\" rel=\"nofollow noopener\">https://freesound.org/people/InspectorJ/</a></span><strong>)</strong></p><p><strong>InspectorJ patreon:&nbsp;</strong><span title=\"https://www.patreon.com/JonathanShaw\"><a href=\"https://www.patreon.com/JonathanShaw\" rel=\"nofollow noopener\">https://www.patreon.com/JonathanShaw</a></span></p><h3>MrTomatoS</h3><p>- standard version of the game.</p><h3>MrTomatoS++</h3><h4>\" Oh oh, it looks like someone messed up the game code!&nbsp;\"</h4><p>- Now you can reset your game progress after completion to get more endings</p><p>- You can download this version even if you already played in standart version, and completed it</p>", false, "Welcome to my game, buddy!" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3500), "<p><strong>DOMINOID&nbsp;</strong>is an arcade-styled&nbsp;puzzle game about stacking dominids!&nbsp;<strong>CLEAR&nbsp;</strong>pieces by forming&nbsp;<strong>RINGS&nbsp;</strong>with matching tiles. Create huge&nbsp;<strong>COMBOS&nbsp;</strong>by stacking dominids effectively. Collect&nbsp;<strong>BADGES&nbsp;</strong>for major accomplishments.&nbsp;Earn&nbsp;<strong>EXP&nbsp;</strong>by clearing dominids to go towards a&nbsp;<strong>LEVEL UP</strong>. Can you get all the way to&nbsp;<strong>LEVEL 10</strong>?</p><p>The game features gamepad support as well as remappable controls for both keyboard and gamepad. There's support for custom music packs, sound effect packs, background sets, and pieces. Multiple sets of backgrounds and pieces come included with the game. The game also comes with an&nbsp;instruction book and wallpaper bundle.</p><p><img src=\"https://img.itch.zone/aW1nLzIxNDg1MzM4LnBuZw==/original/TVLouX.png\" alt=\"\" /></p><p>Additional art by : Julian</p><p>Audio by : Dim&nbsp;Widdy</p>", false, "An arcade-styled falling block puzzle game. Stack DOMINIDS, form RINGS, build COMBOS, & earn EXP to LEVEL UP!" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CreatedAt", "Description", "HasCommercial", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 45, 16, 249, DateTimeKind.Local).AddTicks(3385), "<h3>Welcome to PAC-SIDE</h3><p>PAC-SIDE is a fast-paced pacman-based horror game, where you can meet your old yellow friend! Wait.. It looks like something bad&nbsp;happened with him..</p><h3>Controls</h3><table><tbody><tr><td><strong>W, A,&nbsp;S, D</strong></td><td>Movement</td></tr><tr><td><strong>Mouse</strong></td><td>Look Around</td></tr><tr><td><strong>Left Shift</strong></td><td>Run</td></tr></tbody></table><h3>Epilepsy Warning!</h3><p>This game contains flashing lights and images, which is&nbsp;<strong>NOT RECOMMENDED</strong>&nbsp;for sensitive people.</p><h3>Developer</h3><p>Game by&nbsp;<strong>SeriousDaniel</strong></p><p>Made with Unreal Engine</p><p><strong>This game is a fan-game and does NOT related to the original Pac-Man or its developers. All rights to the original characters, sounds and graphics&nbsp;belong to Bandai Namco.</strong></p><p>Follow me on X&nbsp;<a href=\"https://x.com/serious_voice\" rel=\"nofollow noopener\">https://x.com/serious_voice</a></p>", false, "A pac-man horror game" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("03a46f76-fbb1-4425-9ad4-8b10cde8826c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("04fe471a-4f38-4616-b2e9-2cdb7084ec0d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0f3e63f3-eef3-4ac7-936f-e9bfca338de2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0f71211a-9433-4a23-8067-59a2ef99a100"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1445a46b-de85-43ed-966c-48d6686c8dd1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("17f4faad-b25b-4d0d-aa0b-af628cfaa0bd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("197a7dfe-1a22-48ef-8b0a-71219289ff94"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1aaa2879-38e2-4ef1-aced-5955bfebb313"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1e10cf86-1ade-4cde-8493-387efada08e1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("20b664ae-4bb8-4369-8ca3-cacb359cdba2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("28db1536-5921-4f83-bc2c-5e22d8639c42"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2e310983-6c20-4300-8307-a38f75b4bdf2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("31072f31-9386-46a6-9024-4e952355e8e3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("31910fcc-4d44-416a-8aef-8ebf23dd9d84"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("31cbfe1f-0a17-486d-827b-8992b672fdd3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("32c0110d-cf9a-4394-8993-eeeae6e10047"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35acf833-d03e-4b29-9df7-140e756c9ac9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("37672997-c10e-4786-9fba-9b1d9d67dd54"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3bf7045b-bf02-4838-8c21-56a17c18144c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3cf683c3-2c8e-4941-99d2-e26060502da0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("41595398-7810-4e57-b5fc-df92c30e5a0e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4195def0-1617-4dd8-840b-6b6380b2502d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4863a56d-5702-4f48-9c74-8ad5bbe11863"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4b29eaa7-0e5d-499f-939e-9b2a76c01fc4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4c06187d-6e14-45a2-93f2-4d8d2d7a68b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("51fdd34f-9e20-44b3-ae33-08c5dd75d749"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("570e77b6-3efb-4906-a35b-6e1d94a4e111"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("58f425fd-3c74-45bc-8c7d-300dc60bc18a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5ec9c382-d23a-4416-b816-72fbe19badb8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5fe64339-fe59-4712-93c5-3dd079b2b0a5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("62849584-b485-455f-af49-48d311bf644a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("70cd2e80-5a3e-43c0-b71d-0263298e83b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("71844a7c-58ed-4285-a9cc-366571365584"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7308c3c3-0cd9-4993-942a-78ba6a5ae8ff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("75a152d3-4aa1-4bfd-8f28-031dbf8b415f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7d9f1818-b47d-4c31-b193-2d398ee24ada"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8015a7c6-dd5c-4b8f-b2c0-709da8648b54"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("89402eb9-318b-47e7-8b10-7128ebeb0fce"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8f95ae2a-b4e7-415f-a0ad-d13135dc3093"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90799b47-0c93-4369-ba38-85fa1bce9ea8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9dbaa741-7c63-44c2-aec2-f96f4a2a51a8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a45d7679-ecb3-4aae-bb5e-d15d04a97dad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ac74fc24-1364-44d0-8fb6-ac2481d5f37d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("af08cf6c-56ed-44fb-aebf-578872aca9d1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b0df6409-1c77-4e38-ad21-7cd7be63805a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b5fb3e44-0e54-4405-9169-2b5157b289e6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b85b318a-fb21-4bb6-91d3-9316aefb7b76"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c40e80cf-e272-4b35-a4f5-c41820dc945f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c6c1c4d0-fe49-4e0b-852c-dec5cc2255ab"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb9e029f-5778-40e9-acba-5fd776eb5b69"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cf3bed6c-f400-4237-b8ed-3b875297b247"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cfafd00c-f9ef-4b3b-850f-e114efb74668"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d0a8fd8c-87b5-470c-ba77-dacc39059853"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d3a724c3-c524-4130-8693-6d899a18bb03"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d4342187-f0bc-46c8-be99-c479102a6c30"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d8ff3345-a544-45c5-a335-fd2b6e90da17"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("db22cad1-37f5-42e9-804a-9ee7144c367a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dd22c3e6-f6e7-4666-9dcc-e17977434111"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e3cfcec3-5172-4849-9b75-f5affeca59ff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e5e375cd-6af7-4625-9621-28d951313cdf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e9af4893-cfd9-42db-9e6c-e1d16e0ad373"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("feafa08d-9e0b-4d36-ba81-8997422bc1f3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("08c7c9f1-3801-46f0-b64e-624a6f129dcb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1356b365-a9aa-4d35-a3b4-9d6b63820054"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("201fd2e9-aaf5-4e5d-b3b5-49e6d8c6e981"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("21d0550c-03ad-4534-8f4c-0da5629b7011"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2b3b24ee-dfbd-42c5-b028-6d5a17a8ddd1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4282552a-18de-4c3e-8039-9480970b6c09"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("58da17b8-da12-45b9-8893-3710f7bc327f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5921aaa4-0978-456f-bbe3-0b7b633716a2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5ed67bca-7e37-427f-beaf-462db11b9cd5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("613af596-f8a6-4432-bcb5-9034f5ad3dd4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("70e2aaa8-c354-46b2-8e07-014b42422cdf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("85334363-5ca6-4ddf-9f7c-ecc1d4341eaa"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8de21811-4651-4010-92c0-7d0b69c837ab"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8e8f6619-6951-4596-8d9d-957acf50c285"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9a3e9679-0f36-4ac3-bf53-6f99f9c43487"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a2c5cae2-2ec7-4b78-88a3-f9fecaac4b5f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("aa6bdea8-bf24-47db-b643-76a13dc36327"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c99b0dca-b3e7-4a66-866d-0fe9b150fc22"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ccdc3e44-4ad6-4892-b7aa-3b85195eb9e7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d195257b-d8c6-4c2f-9482-b660f51336f2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("deb79db1-c127-46c4-ad10-f9a500e229b9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e5fe1573-79de-4c0e-ac63-bba0abc6451a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e8cb55c6-4125-4734-a25b-94bd33b0db27"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ed23eb65-9a8c-4c87-a224-ad095e7aab38"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f5aa2c41-64aa-4746-afda-a527991c4ab8"));

            migrationBuilder.DropColumn(
                name: "HasCommercial",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bd3d315-71db-4b28-bfc8-c08a2dff7ee8", new DateTime(2025, 6, 19, 0, 36, 42, 982, DateTimeKind.Local).AddTicks(3073), "AQAAAAIAAYagAAAAEKdQiLx9eC9yc6TnU8CZvvqOb7c75A0nDadDE/X1rg9YUiLBkig1SDN9be4XyC+i9w==", "c497a791-6fdc-43f9-b530-ddfb4fe51839" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "884facf7-0630-41df-9387-30d23b2f9004", new DateTime(2025, 6, 19, 0, 36, 43, 151, DateTimeKind.Local).AddTicks(1391), "AQAAAAIAAYagAAAAENlJ9NR0pROk/wm85losNzUhNPK8WEcTLY2XRbmejWk7I2JFFE/bb0aFn826ghvg9g==", "3d723448-ae7f-437c-8585-067ed1508f8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79e511d4-0d59-4643-aee9-4fb2ef0577d8", new DateTime(2025, 6, 19, 0, 36, 43, 205, DateTimeKind.Local).AddTicks(6978), "AQAAAAIAAYagAAAAEIWWPfEWp03LdaCCS4dzM84bBkpaafmDp6NenV2m0RoI32MS3wLDsPelPIsK8OLGvA==", "06c10d90-59c1-490d-ae8c-b14cbafe9205" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f57adf00-82ff-4327-8e64-3b522cbb02c6", new DateTime(2025, 6, 19, 0, 36, 42, 915, DateTimeKind.Local).AddTicks(6463), "AQAAAAIAAYagAAAAEE1czk3rraZxKDEp4fj1Rp878jAbzxKUcrSXYCb4x8cyzSxKB3uJPCwhEZ++zrTYjA==", "8324dd37-ed30-4c8b-b666-89b5aab14675" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81e32bb0-fcf3-4fa2-b1cc-eb0aff0ae2c4", new DateTime(2025, 6, 19, 0, 36, 43, 96, DateTimeKind.Local).AddTicks(8745), "AQAAAAIAAYagAAAAEDz8EWbThCe2nH0Tz/RYRq7+MPoHY1w5XmekIw+6RUAMnkyTyxOv3OqR4khkmtRipQ==", "14ddf632-d596-421a-b8c5-d5df58016d5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f7f1b00-d728-4943-a676-063345c1fc65", new DateTime(2025, 6, 19, 0, 36, 43, 39, DateTimeKind.Local).AddTicks(2140), "AQAAAAIAAYagAAAAEPtoTAKKMM9XUQKYbvf8dIuAPV2EcB9+f8AMAS/cw5Szj9TCgPcypg+QzUvC1ZBz6w==", "8164e7e5-33ea-40f1-a38a-9cc097ebe4f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04241ed0-c312-4c21-a02b-5f83e20f6904", new DateTime(2025, 6, 19, 0, 36, 43, 260, DateTimeKind.Local).AddTicks(4537), "AQAAAAIAAYagAAAAECTeS/TaJ/d4vL1TSngei6aLtq2/QSxoiRtRFhtoJEuOyTe31QDJHcrQoEde4B0pvA==", "58ba0c70-e0fe-4476-94c2-d1e47a9084e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f55740e-e8ff-446a-b2f9-68610d8ddced", new DateTime(2025, 6, 19, 0, 36, 42, 856, DateTimeKind.Local).AddTicks(9313), "AQAAAAIAAYagAAAAEEfvmlQHDwsZa7VIfWaKuAuu1Vo+Rlq6FryGVcTd3sCdFTPPfIfIy99B81DVGL2a4A==", "7137a402-2819-44ce-b64d-bc8739564180" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 29), new DateOnly(2025, 6, 19) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0c33b840-96ec-4429-9686-d839ed2e542a"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("0cc51e80-b68e-4aac-bc76-bddb00fdbdc8"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("1a53aabc-9fd3-4788-8cc2-e5b9c9e2f813"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("1af494c7-fdb4-4825-9dee-4cab4b45b0b5"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("1ff9e42b-6926-4339-87ce-183ec3b44a20"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("212642c2-cae8-4c11-b933-47ff67e6384a"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("23bc9d9c-a27d-4cbe-bd06-b016a53ae044"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("2a4a96ad-a20c-4ee3-89c8-a4ae7a5de428"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("2b48a511-708d-4cdc-9b81-445aa0982cfc"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("2e491688-262b-4de0-bde7-ecc1adf58003"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("30b2fcf8-ab80-47b3-b1d8-acfda11717b0"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("36a9b8af-c2db-4948-af77-f6d1c784e5f1"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("42f9787a-f782-4d28-b91e-83d0c61a981c"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("44425553-948a-49a8-b581-898febbd7c4d"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("4c73ef8b-3e3e-4c32-8fb3-59ad22a9c131"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("503e4434-0a06-4ed3-95a5-bdab614eacad"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("52d06485-6b43-40c7-b10f-bbf216a2395f"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("56115c5b-b418-4cae-a1ba-0ecdf8d00205"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("58490e1b-54b3-4244-8c66-18c560594798"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("58e6c4db-8019-49f2-ae9f-2ddc9ce8e2f1"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("5ad92a08-60ef-4a64-8bb7-c08886f03a54"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("5c2a79e1-c91c-4ad9-8eaa-0b5f903323f9"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("6081d186-b63d-498b-b82d-f0cce35e7159"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("674b9f66-0ff5-4b5e-b642-c34be150188a"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("720a3dd4-62f8-4a8b-bb58-70f20868085d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("74c012b5-6043-454c-bc38-411dc75b5f8a"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("77684486-63de-4704-aad0-71b3fc75e5d2"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("7b6dec73-b9e4-4f24-82bb-190e58e843d8"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("7cc64dcf-cd64-41b6-8876-fd70e3ea2d0f"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("872b3d45-d5e9-42c3-a41c-58460e2a3295"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("8812de48-8282-425a-b86f-067e363fe35c"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("8b34ae67-9e81-42cb-97ff-1b0fd687a776"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("8c026dea-8d38-4456-8dee-b7baff6abd03"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("974b5cca-0f56-4c96-8200-3155288ed56f"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("97f246b6-3ce6-4e56-95a2-531a5c564a75"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("9d4d7d96-5e88-4e3f-acdf-9b1e59c416e5"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("a0a3975a-7b98-40e2-bd73-dc65c13668a0"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("a1057a28-b15a-40ef-bd8e-45158e309b65"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("ab011f3c-20de-486e-95f6-0b8271076696"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("b2bd1387-4dbd-43b6-a2ff-1db2350fc484"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("b6c34be7-8f01-4fdd-99f5-2e5f2c5f28a4"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("b71825ad-e1cf-45f5-a253-393e54fa8aed"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("b7e97a66-a197-44dd-af9c-b015c4a12485"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("bc412cff-4c90-4de9-bb3e-1f72c9ed3f40"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("bc610ea9-5241-49ee-b6f8-c6d65b6e96d7"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("c18f53ff-eda1-48e5-92e5-36a175a253bd"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("c3f5185b-0af4-45f3-afbb-fc4bcb34011b"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("c678fa48-8914-49ab-9835-de076f6af6d8"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("d3d42f9a-bd2f-40c7-99ad-90a6a5baa6aa"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("dc098177-29ef-4ed0-a421-2c3b0203c328"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("dc9a66c2-3f84-4bd5-9f5c-8ed7622c4995"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("e0f5ce3e-3160-4da7-9a22-96b7e1428da1"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("e54d9cfd-edc3-43a8-aeea-fabea00326aa"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("e69c71dd-9f6a-4fe0-8ff8-6e07d2787297"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("e7804d4c-4cb7-4aea-9a5e-769cda35652d"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("eb1fc14f-b7d6-4b49-a462-a3ab349e5b24"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("ef145df5-963f-4827-ae62-2d45e444ae01"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("f5e66f17-03cb-4298-8b59-1ae58d9cff51"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("f647e38c-08d7-4f74-8c8b-be7299b68060"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("f8e0457c-605e-4b1d-bc26-32a8038af105"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("fbbb52e4-a0a8-4126-b37b-45d4674ed7e9"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("fbe67754-a88c-48bb-9b78-b0b50d26661f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("0d87b841-dda7-42ae-927f-d53fefe6677b"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("29e21cfc-222d-4190-afb9-6682c6eb048c"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("2a43f336-ec20-450f-b578-0ef3944180aa"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("327265ab-d951-4325-9250-562498cebc7d"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("34e52c42-93c4-4b34-a6f1-42b6366af81d"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("3b95c6bc-88f0-4b70-a8d4-3d729d0b3487"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("49c8e7cd-3671-41da-9ae8-798f3552c189"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5038a4ad-1ac1-4ac3-8286-a06ac0e3e2e8"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5b19f130-01a5-45d0-9544-45c3001446a0"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("6494837a-b101-4855-a4f6-b08f6f965a21"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("6e20a0e3-b7d7-4181-9651-d3f89567d5c7"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("76219ad7-87dc-4265-bf94-bf90db13f211"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("7c4451d6-5f57-442a-81e7-06ac88fcd419"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("7f17e58b-f17e-4803-8754-4ede3c9a2e44"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("8c0b4bac-9f7e-49ea-a4e3-0e33cb532dce"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("963f945c-c5f9-473c-95c1-437d2b3bc440"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("a4fe0f85-3cb0-4dd7-ad51-11e6c39484cd"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("b292d756-bbd4-4b27-8033-b522eaaea666"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("c670c5d8-1f1a-4131-b8cb-e0a42fc9d7e8"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("caa390b7-b9aa-4165-9c3b-4d63054eaea0"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("ce6e5b1f-3f4c-42bd-a1e4-0cde2bdd4832"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("d3a29e8a-c8b3-4f88-bf7c-94a36976024d"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("d9ffc2eb-7bb9-433e-9e4e-b53b55139c99"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("dee057bb-e1b0-43ca-abba-b5b428413d86"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("e88472af-f79b-404d-a8bd-a8723d0f4095"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(406), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(505), "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(493), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(443), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(411), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(386), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CensorStatus", "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(327), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(393), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(438), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(521), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(488), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(432), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(421), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(498), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(427), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(477), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(516), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CoverImage", "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage.png", new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(510), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(483), "", "" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CreatedAt", "Description", "ShortDescription" },
                values: new object[] { new DateTime(2025, 6, 19, 0, 36, 42, 841, DateTimeKind.Local).AddTicks(416), "", "" });
        }
    }
}
