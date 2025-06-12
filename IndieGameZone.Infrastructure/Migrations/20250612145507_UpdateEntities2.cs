using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntities2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0663810d-f38f-4803-ab3a-f3676666abf9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("07247e6b-0dbc-4da0-8f19-36e14a8d5ee3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0baf2efe-a586-4da5-a1c1-639eb61399ea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("18341c37-111b-464f-849b-8b54a965b6fe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ade38a5-b92e-42d8-a25c-57401915a3e2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1af1a3d4-0ffe-4b64-aa0f-1b87796fdf84"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1cab8925-6bbf-4a7d-9af9-6f36f57ec532"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1cc9350b-e10a-4ce5-96e6-bb43c826f574"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1fb4665e-1a34-41c3-b9da-91d5942b2b24"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ff85e76-8d90-455a-bbe3-187ff43983bd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2517e187-495c-4829-a830-ac5a3a3ac2f1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2cb655b7-663a-41b6-9d7a-27985c742609"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2ffdbbe5-22d6-4085-b904-ef8f6b1dcfc0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("39a8981b-52fd-41e3-a1c7-0fd9249eb836"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e6470df-3462-4a62-8afb-77d52667e9d6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("40c7f884-447d-4c29-b80d-89de1d8ae89d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("49953d9f-80e9-4d39-908f-52b155f67644"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("49fd46f9-980d-4ab3-9ff7-c9678a2bc04c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4a5a5c7c-e1c1-4862-9cc8-a58b99694362"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4c8c26c6-f401-49f5-9318-33bb75a25de2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4d0c6a61-a47e-4466-9ab4-482c7140fcc6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("54992df4-fb55-4d6b-8cb4-1e92cef7c52f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("590304fa-4e6a-4b57-926a-0dbf2bbbaaf6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5d7a0017-b37b-4764-adb2-804c338a8818"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5decae63-12ad-41a9-9231-45ffbb1cc1b9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6a6a6929-edc4-4cf4-8c29-66bd53fa73f5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6db69f6c-acc6-47f0-a717-2fdbc6362354"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("798e88de-98ca-4ef3-a6aa-80fed25e2a51"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("79b05fb3-08b2-43d0-a9ea-85eefe65738b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7b1694ba-dce9-4a81-8fc5-4450136180c9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7b3fff30-d176-4bda-86d5-53bc714d9efa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7eaed463-4793-4f8b-adc1-66f384bc6e97"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8198aee8-9bcb-45c1-afbb-08c94ad044ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("870c7be8-2651-4cfd-8da8-7ae099da2d05"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8b00cf68-94ba-4ff4-9648-2e47101b60e8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("953c729f-1cea-4f6d-91a2-3339237f436f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9644e6be-b1d1-4212-a76e-186ba4dd5039"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("97ee91e3-9694-411b-9b5c-7c77c9de6a5f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("99d09ada-e9af-41e4-8211-26f014d4986a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a165e3e5-6272-4993-a49b-60293c3e3278"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ac94abed-4ad0-4bff-a5b9-8392f01c5431"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b50dc051-a6d4-4420-8cce-214389f1ac78"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b51eba91-13d5-4eb8-b7db-03d7d014415d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bb55a715-7171-4109-8613-5d5452399aca"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bc22f2a3-f3c2-4586-a768-d765df17ad84"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bd120a0d-76ed-4b92-b814-1ffbf10bc607"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c41e8229-5bf5-4b64-a798-f51c5504c575"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c8115960-0b39-4457-a035-535bc5ff2a42"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ca2e2424-bf22-44df-9df1-9a7df477d415"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb883264-8eb4-4a26-967d-dbd5b941a63f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d1955a89-f408-4b64-ab1d-689583b0db3e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d8812575-5c73-48bf-9e6c-7d467f2628d5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("deb5b2fd-cf33-41ad-aecb-c26a95a3031d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("df21aeca-001c-4785-a547-664beb142fe6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e4984d63-e61d-4c97-907b-4318463af6aa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e49eadfa-b697-45d5-a90a-81897dbc859c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e6bd59c7-5a4d-4ba7-80e8-f1f603b6eace"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eb8e7eea-7f22-4c37-bad2-f2a6b4ce98ac"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ee0634aa-f2ed-4af2-afb9-415235da89d5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fc1f7614-bd03-4f97-8ca6-28689233ffef"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ff400c73-6387-4cf2-b94f-3e312649044d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ffa36ebf-3796-4fbd-a4ad-dac02f35586e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.AddColumn<string>(
                name: "CensorStatus",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "GamePlatforms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "GamePlatforms",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48dc990c-c997-4617-8438-454d26ef7664", new DateTime(2025, 6, 12, 21, 55, 6, 413, DateTimeKind.Local).AddTicks(8794), "AQAAAAIAAYagAAAAEGJZQ/Mljfd7BZwYl8PBLLa8HLVHICM7hnunJepNzZIWQUHGx9GiT/owieZUN9aokw==", "649e47fd-aa35-4309-a882-28b663023a16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d29bf022-b075-486e-9a44-abc768332499", new DateTime(2025, 6, 12, 21, 55, 6, 470, DateTimeKind.Local).AddTicks(2652), "AQAAAAIAAYagAAAAEOC210EG7+enctrxY/UXPREjNnsGpbZC4D17wn8dxlDwsBLS5vuoOoBX+cbjLgm2pg==", "30a532cc-4ca1-44a7-b0eb-6102a6bb3244" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "660deebe-5f13-4f07-a7cc-2c8702df3d1a", new DateTime(2025, 6, 12, 21, 55, 6, 527, DateTimeKind.Local).AddTicks(7715), "AQAAAAIAAYagAAAAEIRMlkiIWrDqYFI28waXHYn1TYwQ7RZgNHZrvP5R1f0Hyi/ovHArRtE5HKw/alGC2g==", "f6c89a95-1140-47a9-9bdb-5f95df1c9a7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "315077f9-6ea0-42b5-bcdc-c765aab4a491", new DateTime(2025, 6, 12, 21, 55, 6, 355, DateTimeKind.Local).AddTicks(9399), "AQAAAAIAAYagAAAAEEys7lwGS9uqsZTLMrSWA1kJA3Hl+wRDJ9zaGhmBTdkY/W3PLMY1pXcfddVsN8M6fg==", "9d8b3e1f-bbb8-4eb4-8eb0-bfb55dd3ca5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8abd0973-d888-48d8-87b8-5f60a6215720", new DateTime(2025, 6, 12, 21, 55, 6, 587, DateTimeKind.Local).AddTicks(2429), "AQAAAAIAAYagAAAAEG8JeO5siu1+zq5RsXGoXd43HQLugzjhfOK9/c3Z5H6uOmz4gtpGvbR9jARHolAdEw==", "d4d322b5-91ee-4727-b095-d3beb2d67ffe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c537ee4d-26e6-462c-a37a-2f7f627db1f6", new DateTime(2025, 6, 12, 21, 55, 6, 298, DateTimeKind.Local).AddTicks(3090), "AQAAAAIAAYagAAAAEDnIxS1Fpi7AB+G6BFELaUjqbbGYvY+5aQbJRYSqB6toDeCA946XrcbDqMMzYcc0Aw==", "0aeae883-4721-4527-8102-6ea832eb83cf" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0116f13b-5fe1-459a-83ea-80377ebe080a"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("062b3005-9c72-4139-8ee1-f7f276cc942e"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("0b289610-8db9-4b2b-bb02-5fc22b5426b8"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("106e4e64-4dd7-42bb-a779-20b9e0e0601a"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("1ad1cfac-62a5-4a4e-9322-915ab7075458"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("229eb2a2-06ba-48be-9e68-c8b5cd4386ee"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("24d13f8b-f3b0-43f9-aa46-2a677707f9c4"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("2523c9fa-9804-401b-bf26-738ba232c476"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("2766c33d-4b3a-47a6-8664-cfe7b33a5efe"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("2a1b974f-a9bb-4134-94f9-89ac3a83639e"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("2beea911-52e2-4959-9fdd-0b2dcb9510f3"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("2e83e783-ea81-4509-b14c-364af810d8d1"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("37401cb3-1546-4474-ba6d-188afed56795"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("3c91dfec-3f6d-4487-ae57-8b81475bef0d"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("3cbc708d-3551-4664-a3e8-fba207efabb7"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("4068ff6f-bdf0-47e5-986d-3599c5640fdb"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("55f42f52-9b79-445e-a2e0-725871361ebd"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("566874f7-c58c-4f09-a528-580bd15328a6"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("7057921e-69f6-4f01-8c4f-914bf530e913"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("7c32e3bc-2890-4215-a155-3ba7bd4bd7c7"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("808a1338-8371-4194-9e2d-0ba650d092d4"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("8914ff6a-2363-4b4a-8d18-60358fbff8e7"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("8ececb48-feb7-40fe-9a25-3e0e11f18e0d"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("8f0329e6-a3e3-4a0d-ab1d-16bb4aeb740c"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("91f5db12-0c1a-4ec7-983b-f3eec4b765f4"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("93b7072b-bc1c-4339-b18b-5a40dedc6006"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("949f0bc5-b362-4ddb-a667-9c901e0091dd"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("9947bcc8-6282-4055-8bec-7496fee989ed"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("9df3aa21-031b-4ad8-82ae-90ed2a085c13"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("9e056492-b9a5-4c6f-b824-bb2807ae97df"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("a06647c8-3b84-488d-9a5d-8d3f401149fd"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("a148a03e-52e3-4b6e-a5a1-dd7365e4ef27"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("a479818b-5353-4893-9d95-df4b05e1c4b9"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("a5c2034a-fe13-4efd-beba-135c54eb384c"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("aa667a73-3e53-43e7-93af-99a530e4f7d9"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("b32fe9d8-27a7-45dc-a19e-3543d9decb31"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("b552cbce-b96c-46de-a0e6-9fe75ee027f0"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("b6a36486-836e-41f7-b3d5-ad557dfb8555"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("b73750dc-3e12-48e8-bb61-8057e614c2ca"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("b7d4c75c-70c9-41ea-8ad4-ba84772349fd"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("b8be9256-df8a-41f3-981c-55eaf49d717a"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("b9a8a470-c718-4527-b9b5-cfd4c096f941"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("ba59e83d-8c3d-47af-a7b6-a2c71d61df0c"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("c47dc897-c4ac-4c35-8204-9054be5a3374"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("ca37b56f-d221-4ce5-8a74-01f0f828ca3e"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("ca7d86d7-b8a3-47a4-a60a-aeeeab0d8302"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("cb6957da-834a-411c-bb66-4d23ab8f1bf6"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("cdb3de98-1a5b-48a7-b3ec-7dc3e4ca82d8"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("d1648b87-0eb0-4eb6-a3c2-ae3143e09ddf"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("d30d3cfd-75f7-49b1-b97a-04a59b680e92"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("d54ee7ad-a209-4a98-a8f8-d486f1582adc"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("d7bcd2af-8bb1-4fa0-9fc4-7435741779b9"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("dfdba4cc-1dc5-4ecb-8e86-986655485fb0"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("e2f5388d-feec-466e-aa8f-e35fad1ea3ef"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("eb6b1c39-f7ac-4aa4-952f-99d3854178d8"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("eb98de3d-1f34-424a-8ed1-e59a945d1dc7"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("ee7992c0-b5a4-4dc7-a5e1-c612c689c6fe"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("f1df713e-04d3-41d2-a1b3-63e1d15aba9d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("fa7d0a8a-8721-457a-a932-ba1fdf947254"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("faa1724c-ede8-42dc-a865-ca1ba9e18510"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("fbcb7030-da4f-4e66-9be2-6d747387945a"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("ffcee535-24d9-46dc-a5be-7a5f034ea8b2"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("15d5e63b-a663-46cd-b964-fd8f0b5ca388"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("164e0d1f-790b-4d38-8ca5-509566bf78d2"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("211aa6c0-88e0-4e69-9483-f25f1bdd1531"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("25ec8ee0-31e2-4518-a594-d5382cd834de"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("2cc14a81-adf9-4805-8ba9-6b867e8a969e"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("2e17425e-9c17-420a-887e-6c08be480513"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5485bb32-c837-4364-ada0-f4d10b8c9058"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("569a3f8a-23b6-4543-9eba-106bdedb82ad"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("5f5afa47-d7ad-4e09-8c0b-b2e6eabe0030"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("63da7f9b-f80b-4b4c-8c26-efad8185ea10"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("67d0e585-6172-4501-bf29-21bec0990fda"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("7fb5ece8-9ada-4da1-b7c9-6559c21b0fa2"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("856f7ac0-65fc-4998-a9ea-7e57181deca1"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("8e64e02c-1b73-4d1d-90f2-620a3aef6c4a"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("8febc506-eb9a-4583-9f56-50e76e906aac"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("9c4a6bf1-2fda-43d9-be83-60e3fb226399"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("b54d7b2f-e1a0-4a78-b8d6-7a855d1825e4"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("c1704610-51fb-437f-aec9-5df8758038e2"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("e1e107ca-a867-4dc8-bdfc-51a6ba6fe79a"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("ea0500bd-2fd7-46a7-8e9d-3b2e7e1b32d9"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 0.0 },
                    { new Guid("eb9f08e0-4486-4d07-a52b-6e7e34ca27dc"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("eff860c7-ac47-41ea-b58c-7c3cd667ae00"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 0.0 },
                    { new Guid("f03ee920-776b-4d1a-9026-f89e9490d0f8"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("f5ab9a0a-3220-4a1c-abd7-63f8d80dada0"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 },
                    { new Guid("f953aa34-e051-4b97-8726-146d6eed4945"), "", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 0.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CensorStatus", "CreatedAt" },
                values: new object[] { "PendingAIReview", new DateTime(2025, 6, 12, 21, 55, 6, 283, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_GameId",
                table: "GamePlatforms",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms");

            migrationBuilder.DropIndex(
                name: "IX_GamePlatforms_GameId",
                table: "GamePlatforms");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0116f13b-5fe1-459a-83ea-80377ebe080a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("062b3005-9c72-4139-8ee1-f7f276cc942e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0b289610-8db9-4b2b-bb02-5fc22b5426b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("106e4e64-4dd7-42bb-a779-20b9e0e0601a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ad1cfac-62a5-4a4e-9322-915ab7075458"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("229eb2a2-06ba-48be-9e68-c8b5cd4386ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("24d13f8b-f3b0-43f9-aa46-2a677707f9c4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2523c9fa-9804-401b-bf26-738ba232c476"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2766c33d-4b3a-47a6-8664-cfe7b33a5efe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2a1b974f-a9bb-4134-94f9-89ac3a83639e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2beea911-52e2-4959-9fdd-0b2dcb9510f3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2e83e783-ea81-4509-b14c-364af810d8d1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("37401cb3-1546-4474-ba6d-188afed56795"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3c91dfec-3f6d-4487-ae57-8b81475bef0d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3cbc708d-3551-4664-a3e8-fba207efabb7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4068ff6f-bdf0-47e5-986d-3599c5640fdb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("55f42f52-9b79-445e-a2e0-725871361ebd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("566874f7-c58c-4f09-a528-580bd15328a6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7057921e-69f6-4f01-8c4f-914bf530e913"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7c32e3bc-2890-4215-a155-3ba7bd4bd7c7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("808a1338-8371-4194-9e2d-0ba650d092d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8914ff6a-2363-4b4a-8d18-60358fbff8e7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8ececb48-feb7-40fe-9a25-3e0e11f18e0d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8f0329e6-a3e3-4a0d-ab1d-16bb4aeb740c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("91f5db12-0c1a-4ec7-983b-f3eec4b765f4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("93b7072b-bc1c-4339-b18b-5a40dedc6006"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("949f0bc5-b362-4ddb-a667-9c901e0091dd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9947bcc8-6282-4055-8bec-7496fee989ed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9df3aa21-031b-4ad8-82ae-90ed2a085c13"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9e056492-b9a5-4c6f-b824-bb2807ae97df"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a06647c8-3b84-488d-9a5d-8d3f401149fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a148a03e-52e3-4b6e-a5a1-dd7365e4ef27"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a479818b-5353-4893-9d95-df4b05e1c4b9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a5c2034a-fe13-4efd-beba-135c54eb384c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aa667a73-3e53-43e7-93af-99a530e4f7d9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b32fe9d8-27a7-45dc-a19e-3543d9decb31"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b552cbce-b96c-46de-a0e6-9fe75ee027f0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b6a36486-836e-41f7-b3d5-ad557dfb8555"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b73750dc-3e12-48e8-bb61-8057e614c2ca"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b7d4c75c-70c9-41ea-8ad4-ba84772349fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b8be9256-df8a-41f3-981c-55eaf49d717a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b9a8a470-c718-4527-b9b5-cfd4c096f941"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ba59e83d-8c3d-47af-a7b6-a2c71d61df0c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c47dc897-c4ac-4c35-8204-9054be5a3374"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ca37b56f-d221-4ce5-8a74-01f0f828ca3e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ca7d86d7-b8a3-47a4-a60a-aeeeab0d8302"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb6957da-834a-411c-bb66-4d23ab8f1bf6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cdb3de98-1a5b-48a7-b3ec-7dc3e4ca82d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d1648b87-0eb0-4eb6-a3c2-ae3143e09ddf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d30d3cfd-75f7-49b1-b97a-04a59b680e92"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d54ee7ad-a209-4a98-a8f8-d486f1582adc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d7bcd2af-8bb1-4fa0-9fc4-7435741779b9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dfdba4cc-1dc5-4ecb-8e86-986655485fb0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e2f5388d-feec-466e-aa8f-e35fad1ea3ef"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eb6b1c39-f7ac-4aa4-952f-99d3854178d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eb98de3d-1f34-424a-8ed1-e59a945d1dc7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ee7992c0-b5a4-4dc7-a5e1-c612c689c6fe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f1df713e-04d3-41d2-a1b3-63e1d15aba9d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fa7d0a8a-8721-457a-a932-ba1fdf947254"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("faa1724c-ede8-42dc-a865-ca1ba9e18510"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fbcb7030-da4f-4e66-9be2-6d747387945a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ffcee535-24d9-46dc-a5be-7a5f034ea8b2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("15d5e63b-a663-46cd-b964-fd8f0b5ca388"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("164e0d1f-790b-4d38-8ca5-509566bf78d2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("211aa6c0-88e0-4e69-9483-f25f1bdd1531"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("25ec8ee0-31e2-4518-a594-d5382cd834de"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("2cc14a81-adf9-4805-8ba9-6b867e8a969e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("2e17425e-9c17-420a-887e-6c08be480513"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("5485bb32-c837-4364-ada0-f4d10b8c9058"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("569a3f8a-23b6-4543-9eba-106bdedb82ad"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("5f5afa47-d7ad-4e09-8c0b-b2e6eabe0030"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("63da7f9b-f80b-4b4c-8c26-efad8185ea10"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("67d0e585-6172-4501-bf29-21bec0990fda"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("7fb5ece8-9ada-4da1-b7c9-6559c21b0fa2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("856f7ac0-65fc-4998-a9ea-7e57181deca1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("8e64e02c-1b73-4d1d-90f2-620a3aef6c4a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("8febc506-eb9a-4583-9f56-50e76e906aac"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("9c4a6bf1-2fda-43d9-be83-60e3fb226399"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("b54d7b2f-e1a0-4a78-b8d6-7a855d1825e4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("c1704610-51fb-437f-aec9-5df8758038e2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("e1e107ca-a867-4dc8-bdfc-51a6ba6fe79a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("ea0500bd-2fd7-46a7-8e9d-3b2e7e1b32d9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("eb9f08e0-4486-4d07-a52b-6e7e34ca27dc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("eff860c7-ac47-41ea-b58c-7c3cd667ae00"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("f03ee920-776b-4d1a-9026-f89e9490d0f8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("f5ab9a0a-3220-4a1c-abd7-63f8d80dada0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("f953aa34-e051-4b97-8726-146d6eed4945"));

            migrationBuilder.DropColumn(
                name: "CensorStatus",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GamePlatforms");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "GamePlatforms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a55bd26-8354-43fc-bbf4-4ec590b69733", new DateTime(2025, 6, 12, 14, 33, 34, 501, DateTimeKind.Local).AddTicks(174), "AQAAAAIAAYagAAAAED3B2lSfwWcZK8tFyUV7MIDHM6v3YyE7ZaNL/s8sLIto9rbzEmhFnnSWXGSpfXevAA==", "1a6d41ae-ec28-4e20-bd79-164bb194fb67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "251ac0c1-a33d-4b13-ae5d-9135a5a3f123", new DateTime(2025, 6, 12, 14, 33, 34, 556, DateTimeKind.Local).AddTicks(4296), "AQAAAAIAAYagAAAAELpykaLdE7GHL0Ghi/VkPrIYi9gANRsgk4bcVJG6LFGtTf48QGy3/WSkng3n2sAV8g==", "65173a7b-1063-484b-b41f-0f073761e7df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "566a948c-bbcc-433d-8a0d-ebe72bce3ae6", new DateTime(2025, 6, 12, 14, 33, 34, 630, DateTimeKind.Local).AddTicks(5511), "AQAAAAIAAYagAAAAEB8z/VyyWIiF929IxdLtZwbWw8nmYwWTiNaJTZ/NtVg7/Qucaj2Fcn23A6dGokOjUw==", "60844680-2c08-4f82-b0ca-6d00ba2f530d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58d369a6-ed9b-4279-8050-7330693c7072", new DateTime(2025, 6, 12, 14, 33, 34, 445, DateTimeKind.Local).AddTicks(4653), "AQAAAAIAAYagAAAAEEJ6jj9lT1cRumCqSChw6fjG8EKhe5XIRGp/6+Q1HDv+CbqjHFn6vU81cZG6SWLckA==", "fd192b83-129e-4e7b-804d-ff991e52e5bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4569424-d781-47f1-82b1-1d778e5c0920", new DateTime(2025, 6, 12, 14, 33, 34, 685, DateTimeKind.Local).AddTicks(9205), "AQAAAAIAAYagAAAAEJX6+xUzXh2T738U1WewUnbmCFN/Xl3qbawVClKUw7007dq4Oj8GyPrfQfOzC3WvMQ==", "0c98838c-7fca-4898-879e-78f5cafea166" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1bc9f03-2d08-42f8-a91b-608e52f11fc6", new DateTime(2025, 6, 12, 14, 33, 34, 389, DateTimeKind.Local).AddTicks(9048), "AQAAAAIAAYagAAAAEMEjH+e6Mv0ZzEyk5CQnwQqjn8m8gSl/4cK4q4u/s0228ddDYwhs33oCvsX4Ml83jA==", "6943d937-1180-4757-8630-ba626fd2687c" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0663810d-f38f-4803-ab3a-f3676666abf9"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("07247e6b-0dbc-4da0-8f19-36e14a8d5ee3"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("0baf2efe-a586-4da5-a1c1-639eb61399ea"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("18341c37-111b-464f-849b-8b54a965b6fe"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("1ade38a5-b92e-42d8-a25c-57401915a3e2"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("1af1a3d4-0ffe-4b64-aa0f-1b87796fdf84"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("1cab8925-6bbf-4a7d-9af9-6f36f57ec532"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("1cc9350b-e10a-4ce5-96e6-bb43c826f574"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("1fb4665e-1a34-41c3-b9da-91d5942b2b24"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("1ff85e76-8d90-455a-bbe3-187ff43983bd"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("2517e187-495c-4829-a830-ac5a3a3ac2f1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("2cb655b7-663a-41b6-9d7a-27985c742609"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("2ffdbbe5-22d6-4085-b904-ef8f6b1dcfc0"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("39a8981b-52fd-41e3-a1c7-0fd9249eb836"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("3e6470df-3462-4a62-8afb-77d52667e9d6"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("40c7f884-447d-4c29-b80d-89de1d8ae89d"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("49953d9f-80e9-4d39-908f-52b155f67644"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("49fd46f9-980d-4ab3-9ff7-c9678a2bc04c"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("4a5a5c7c-e1c1-4862-9cc8-a58b99694362"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("4c8c26c6-f401-49f5-9318-33bb75a25de2"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("4d0c6a61-a47e-4466-9ab4-482c7140fcc6"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("54992df4-fb55-4d6b-8cb4-1e92cef7c52f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("590304fa-4e6a-4b57-926a-0dbf2bbbaaf6"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("5d7a0017-b37b-4764-adb2-804c338a8818"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("5decae63-12ad-41a9-9231-45ffbb1cc1b9"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("6a6a6929-edc4-4cf4-8c29-66bd53fa73f5"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("6db69f6c-acc6-47f0-a717-2fdbc6362354"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("798e88de-98ca-4ef3-a6aa-80fed25e2a51"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("79b05fb3-08b2-43d0-a9ea-85eefe65738b"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("7b1694ba-dce9-4a81-8fc5-4450136180c9"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("7b3fff30-d176-4bda-86d5-53bc714d9efa"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("7eaed463-4793-4f8b-adc1-66f384bc6e97"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("8198aee8-9bcb-45c1-afbb-08c94ad044ee"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("870c7be8-2651-4cfd-8da8-7ae099da2d05"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("8b00cf68-94ba-4ff4-9648-2e47101b60e8"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("953c729f-1cea-4f6d-91a2-3339237f436f"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("9644e6be-b1d1-4212-a76e-186ba4dd5039"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("97ee91e3-9694-411b-9b5c-7c77c9de6a5f"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("99d09ada-e9af-41e4-8211-26f014d4986a"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("a165e3e5-6272-4993-a49b-60293c3e3278"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("ac94abed-4ad0-4bff-a5b9-8392f01c5431"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("b50dc051-a6d4-4420-8cce-214389f1ac78"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("b51eba91-13d5-4eb8-b7db-03d7d014415d"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("bb55a715-7171-4109-8613-5d5452399aca"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("bc22f2a3-f3c2-4586-a768-d765df17ad84"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("bd120a0d-76ed-4b92-b814-1ffbf10bc607"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("c41e8229-5bf5-4b64-a798-f51c5504c575"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("c8115960-0b39-4457-a035-535bc5ff2a42"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("ca2e2424-bf22-44df-9df1-9a7df477d415"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("cb883264-8eb4-4a26-967d-dbd5b941a63f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("d1955a89-f408-4b64-ab1d-689583b0db3e"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("d8812575-5c73-48bf-9e6c-7d467f2628d5"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("deb5b2fd-cf33-41ad-aecb-c26a95a3031d"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("df21aeca-001c-4785-a547-664beb142fe6"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("e4984d63-e61d-4c97-907b-4318463af6aa"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("e49eadfa-b697-45d5-a90a-81897dbc859c"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("e6bd59c7-5a4d-4ba7-80e8-f1f603b6eace"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("eb8e7eea-7f22-4c37-bad2-f2a6b4ce98ac"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("ee0634aa-f2ed-4af2-afb9-415235da89d5"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("fc1f7614-bd03-4f97-8ca6-28689233ffef"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("ff400c73-6387-4cf2-b94f-3e312649044d"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("ffa36ebf-3796-4fbd-a4ad-dac02f35586e"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId", "File", "Size" },
                values: new object[,]
                {
                    { new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", 0.0 },
                    { new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", 0.0 },
                    { new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", 0.0 },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", 0.0 },
                    { new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", 0.0 },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", 0.0 },
                    { new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", 0.0 },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", 0.0 },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", 0.0 },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", 0.0 },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", 0.0 },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", 0.0 },
                    { new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", 0.0 },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", 0.0 },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", 0.0 },
                    { new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", 0.0 },
                    { new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", 0.0 },
                    { new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", 0.0 },
                    { new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", 0.0 },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", 0.0 },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", 0.0 },
                    { new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", 0.0 },
                    { new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", 0.0 },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", 0.0 },
                    { new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", 0.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8583));
        }
    }
}
