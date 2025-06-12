using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a7dcbbe-fc27-443e-a172-091183988faa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("10a94a17-92f8-4e0b-86fe-c38680e3ac24"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("127dc0ca-56d6-419b-b716-35452c9a81b6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("135fa281-cde1-425f-883e-f3384770963a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("14c1e3db-14a5-4ddb-ba66-82a8d8de2cee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1bea743e-b54c-4553-9510-52042262e4fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ecaf395-fa2f-439c-892d-c44a32ebcef0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("203cce6d-970c-4e1e-823a-b3f5a3d82efc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("25384ff7-49b9-4ed1-8936-ecb5d29efe89"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("27027f0f-50fa-4188-93a9-0d048198bcc3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("292b1674-a3c4-4d3a-bc34-962e0d33ed82"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2ec45adf-3fd2-49f9-ac41-ef96f51cb2fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2edee00e-a139-45f9-acd2-93a0934fc472"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2fff2a2d-062f-49b3-83d1-13d3aa0b0d29"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3666d4cf-40dd-4f27-8cdd-538ad4c96fea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("390612c1-52a6-4ba9-8b7a-b73b39464883"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3b9e85e6-185f-460c-ade7-a31900d8749b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3de68047-c097-4e4b-9d1b-5e0497f3633d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4518537e-f9e7-49e9-8cda-311d378f7d91"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("45bae5dd-6f8f-4068-942e-bdc54fabcebe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("475eb862-6b3a-4448-baea-9a5602198277"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("55e5dae0-2380-4571-91e7-86bc095ede75"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("59f7f183-1952-408a-a94c-1444a1a538b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("62e5b7ec-0c99-45aa-88db-98079b8198c4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6560011f-65a4-43b0-b5b2-d76bb73f57df"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6bdd3e5f-845e-4a0d-bf14-7595c4f5b19c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("73cadd1c-2734-414b-a371-037e9d94d71a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("80c573e1-9097-4dba-8182-e298540118f7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("852187fc-e4d6-400b-9c8a-3b692c176d0c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("87067b89-eebb-4903-9b67-a6079c169d9d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8ecc345f-18a6-422c-ace9-125c158904b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9024c54e-e6a4-4390-a16a-75402b8068ed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("91749d2d-872a-479d-9b00-002be7cf2388"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("947ba875-2190-4f89-a3f4-80b6ccda7077"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("97899cdb-7b35-4793-97c0-138f1eda59a5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9a0dfa64-c35b-48b1-87c8-2be734ecf5a7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9bee8e5a-fe4f-47e8-a691-943e6c4dcdfa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9f7ab01e-0df9-4540-97fb-2bdf974a236a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a016d07c-e3ee-4037-bc5c-879a97c574ba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a2eb1201-0e85-42a0-8e5e-c032f4c6f6ec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a32da0b5-f16e-44f4-8801-25de8308247e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a40408ce-0cc4-4df7-ba75-aed875df7a12"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a443f45f-6960-43a1-87f0-47a768469a2c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aa9b2348-99bc-4d37-8901-694cac8547ad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ac15aac6-41b2-4f19-8a5e-21c52ffd0b93"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("af48d2a1-2dd6-4246-9843-401dc42c79cc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b856d4af-e579-4424-81c5-88b879d165f6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b90197d9-323a-4019-b805-33a78db76367"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("be3eca21-bc99-46e6-a17f-8417c97b95c0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bfbe5be6-c4d3-4132-bec1-4c764536cee8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c72606f4-f239-40c6-8908-a35895658a39"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cc4ca223-025c-4868-9a89-abe694c98031"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d15a3e28-a1a5-49ca-bd51-70c50d44b34a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d42546da-24ba-4c00-84d5-99d5fa5d4b65"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d9936f1d-f1f5-4ce8-bfa3-3ce7eb10dfcd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("daac2a85-e8fa-46bf-bc33-ff24fd72b0f0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e041685f-ce3e-4fd2-a797-2acc7dc2c951"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ea9c9d3b-e630-49c1-8af2-e930bebea460"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f1193635-3044-4fe0-9756-7118e77601e9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f17c1f52-133d-418f-8bbd-5377edccdb64"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f3592e7d-063e-413b-92bf-74567232483f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ff37f69e-c146-4ae0-950c-bfab3e51f475"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ReportReasonId",
                table: "Reports",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NumberOfDownloads",
                table: "Games",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUsernameChangedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LastUsernameChangedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a55bd26-8354-43fc-bbf4-4ec590b69733", new DateTime(2025, 6, 12, 14, 33, 34, 501, DateTimeKind.Local).AddTicks(174), null, "AQAAAAIAAYagAAAAED3B2lSfwWcZK8tFyUV7MIDHM6v3YyE7ZaNL/s8sLIto9rbzEmhFnnSWXGSpfXevAA==", "1a6d41ae-ec28-4e20-bd79-164bb194fb67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LastUsernameChangedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "251ac0c1-a33d-4b13-ae5d-9135a5a3f123", new DateTime(2025, 6, 12, 14, 33, 34, 556, DateTimeKind.Local).AddTicks(4296), null, "AQAAAAIAAYagAAAAELpykaLdE7GHL0Ghi/VkPrIYi9gANRsgk4bcVJG6LFGtTf48QGy3/WSkng3n2sAV8g==", "65173a7b-1063-484b-b41f-0f073761e7df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LastUsernameChangedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "566a948c-bbcc-433d-8a0d-ebe72bce3ae6", new DateTime(2025, 6, 12, 14, 33, 34, 630, DateTimeKind.Local).AddTicks(5511), null, "AQAAAAIAAYagAAAAEB8z/VyyWIiF929IxdLtZwbWw8nmYwWTiNaJTZ/NtVg7/Qucaj2Fcn23A6dGokOjUw==", "60844680-2c08-4f82-b0ca-6d00ba2f530d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LastUsernameChangedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58d369a6-ed9b-4279-8050-7330693c7072", new DateTime(2025, 6, 12, 14, 33, 34, 445, DateTimeKind.Local).AddTicks(4653), null, "AQAAAAIAAYagAAAAEEJ6jj9lT1cRumCqSChw6fjG8EKhe5XIRGp/6+Q1HDv+CbqjHFn6vU81cZG6SWLckA==", "fd192b83-129e-4e7b-804d-ff991e52e5bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LastUsernameChangedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4569424-d781-47f1-82b1-1d778e5c0920", new DateTime(2025, 6, 12, 14, 33, 34, 685, DateTimeKind.Local).AddTicks(9205), null, "AQAAAAIAAYagAAAAEJX6+xUzXh2T738U1WewUnbmCFN/Xl3qbawVClKUw7007dq4Oj8GyPrfQfOzC3WvMQ==", "0c98838c-7fca-4898-879e-78f5cafea166" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "LastUsernameChangedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1bc9f03-2d08-42f8-a91b-608e52f11fc6", new DateTime(2025, 6, 12, 14, 33, 34, 389, DateTimeKind.Local).AddTicks(9048), null, "AQAAAAIAAYagAAAAEMEjH+e6Mv0ZzEyk5CQnwQqjn8m8gSl/4cK4q4u/s0228ddDYwhs33oCvsX4Ml83jA==", "6943d937-1180-4757-8630-ba626fd2687c" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 22), new DateOnly(2025, 6, 12) });

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

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8572), 300.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8767), 150.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8757), 100.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8613), 400.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8578), 300.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8552), 150.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8383), 100.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8562), 200.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8608), 350.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8783), 200.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8752), 700.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8602), 150.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8590), 500.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8762), 200.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8597), 200.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8740), 500.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8567), 250.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8778), 100.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8773), 300.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8747), 600.0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CreatedAt", "NumberOfDownloads" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 33, 34, 372, DateTimeKind.Local).AddTicks(8583), 400.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_Code",
                table: "Coupons",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Coupons_Code",
                table: "Coupons");

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

            migrationBuilder.DropColumn(
                name: "NumberOfDownloads",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "LastUsernameChangedDate",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReportReasonId",
                table: "Reports",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "658982db-c0ef-4174-b0c7-a94e488782b6", new DateTime(2025, 6, 8, 15, 42, 57, 23, DateTimeKind.Local).AddTicks(3537), "AQAAAAIAAYagAAAAEB9dDDHv/V7hkakkLgf5bzR0gfF8e6YYZCNqwTWb2xFEDR/mayE+ULqsr6W1hSDDEA==", "075feff8-c97e-411c-bcd2-9973e0af581e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49605481-70dd-4b19-944c-47cd57414b75", new DateTime(2025, 6, 8, 15, 42, 57, 82, DateTimeKind.Local).AddTicks(48), "AQAAAAIAAYagAAAAEFfcUzvyXG2GcmNvsjkz6oxk+0m8aNUKrg/LOOlaKUf9IS6htfPDSTFX/xNcVKgUKw==", "f833a55f-1995-4693-bc84-f4d5be5accd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9a98414-d234-4d41-bc74-1084ce3c0d73", new DateTime(2025, 6, 8, 15, 42, 57, 139, DateTimeKind.Local).AddTicks(9716), "AQAAAAIAAYagAAAAEFGArxKM5r79AlyKq4h8NkT9iiJtMkCeqwFNBFABIA8yYrUOBY9Lf2Zm6ntLyiee9w==", "597928d2-7b1a-4a0c-849a-a662f3e2a96c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06ff68bc-e4c0-48b3-aa12-35a34e8b63f5", new DateTime(2025, 6, 8, 15, 42, 56, 938, DateTimeKind.Local).AddTicks(9393), "AQAAAAIAAYagAAAAEOujDUWIe8Cff/LTiQtVXKd7v1RzreoB8zZ847hXuDDeUBF7Sd8g3xpr2aAufe2eZA==", "5391fa71-631e-498f-aae1-917c65c4516c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff7c255-1490-4da3-bcbc-830431a47a27", new DateTime(2025, 6, 8, 15, 42, 57, 199, DateTimeKind.Local).AddTicks(3344), "AQAAAAIAAYagAAAAEFZX3nun6w3DifIc2c4xaTKKxiivAioLS1cfVUY3GAKud5xcsZirubJpSiAFuXw1EQ==", "3d66ad7a-4521-4bbf-93c9-aaedd9cf4f45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28bd57e5-32be-49c1-ac28-7c97d460d7f7", new DateTime(2025, 6, 8, 15, 42, 56, 878, DateTimeKind.Local).AddTicks(7558), "AQAAAAIAAYagAAAAECJVKHSsDuIWzbtoar4gJAVWSR5PW5wTLuP1Uh82nebNjTEV9ecMzkNP+KeYWa98WQ==", "2db38833-11dc-4eba-a111-762b24cb8d4b" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 18), new DateOnly(2025, 6, 8) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0a7dcbbe-fc27-443e-a172-091183988faa"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("10a94a17-92f8-4e0b-86fe-c38680e3ac24"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("127dc0ca-56d6-419b-b716-35452c9a81b6"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("135fa281-cde1-425f-883e-f3384770963a"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("14c1e3db-14a5-4ddb-ba66-82a8d8de2cee"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("1bea743e-b54c-4553-9510-52042262e4fd"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("1ecaf395-fa2f-439c-892d-c44a32ebcef0"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("203cce6d-970c-4e1e-823a-b3f5a3d82efc"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("25384ff7-49b9-4ed1-8936-ecb5d29efe89"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("27027f0f-50fa-4188-93a9-0d048198bcc3"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("292b1674-a3c4-4d3a-bc34-962e0d33ed82"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("2ec45adf-3fd2-49f9-ac41-ef96f51cb2fd"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("2edee00e-a139-45f9-acd2-93a0934fc472"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("2fff2a2d-062f-49b3-83d1-13d3aa0b0d29"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("3666d4cf-40dd-4f27-8cdd-538ad4c96fea"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("390612c1-52a6-4ba9-8b7a-b73b39464883"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("3b9e85e6-185f-460c-ade7-a31900d8749b"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("3de68047-c097-4e4b-9d1b-5e0497f3633d"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("4518537e-f9e7-49e9-8cda-311d378f7d91"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("45bae5dd-6f8f-4068-942e-bdc54fabcebe"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("475eb862-6b3a-4448-baea-9a5602198277"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("55e5dae0-2380-4571-91e7-86bc095ede75"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("59f7f183-1952-408a-a94c-1444a1a538b1"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("62e5b7ec-0c99-45aa-88db-98079b8198c4"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("6560011f-65a4-43b0-b5b2-d76bb73f57df"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("6bdd3e5f-845e-4a0d-bf14-7595c4f5b19c"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("73cadd1c-2734-414b-a371-037e9d94d71a"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("80c573e1-9097-4dba-8182-e298540118f7"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("852187fc-e4d6-400b-9c8a-3b692c176d0c"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("87067b89-eebb-4903-9b67-a6079c169d9d"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("8ecc345f-18a6-422c-ace9-125c158904b1"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("9024c54e-e6a4-4390-a16a-75402b8068ed"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("91749d2d-872a-479d-9b00-002be7cf2388"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("947ba875-2190-4f89-a3f4-80b6ccda7077"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("97899cdb-7b35-4793-97c0-138f1eda59a5"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("9a0dfa64-c35b-48b1-87c8-2be734ecf5a7"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("9bee8e5a-fe4f-47e8-a691-943e6c4dcdfa"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("9f7ab01e-0df9-4540-97fb-2bdf974a236a"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("a016d07c-e3ee-4037-bc5c-879a97c574ba"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("a2eb1201-0e85-42a0-8e5e-c032f4c6f6ec"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("a32da0b5-f16e-44f4-8801-25de8308247e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("a40408ce-0cc4-4df7-ba75-aed875df7a12"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("a443f45f-6960-43a1-87f0-47a768469a2c"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("aa9b2348-99bc-4d37-8901-694cac8547ad"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("ac15aac6-41b2-4f19-8a5e-21c52ffd0b93"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("af48d2a1-2dd6-4246-9843-401dc42c79cc"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("b856d4af-e579-4424-81c5-88b879d165f6"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("b90197d9-323a-4019-b805-33a78db76367"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("be3eca21-bc99-46e6-a17f-8417c97b95c0"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("bfbe5be6-c4d3-4132-bec1-4c764536cee8"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("c72606f4-f239-40c6-8908-a35895658a39"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("cc4ca223-025c-4868-9a89-abe694c98031"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("d15a3e28-a1a5-49ca-bd51-70c50d44b34a"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("d42546da-24ba-4c00-84d5-99d5fa5d4b65"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("d9936f1d-f1f5-4ce8-bfa3-3ce7eb10dfcd"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("daac2a85-e8fa-46bf-bc33-ff24fd72b0f0"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("e041685f-ce3e-4fd2-a797-2acc7dc2c951"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("ea9c9d3b-e630-49c1-8af2-e930bebea460"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("f1193635-3044-4fe0-9756-7118e77601e9"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("f17c1f52-133d-418f-8bbd-5377edccdb64"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("f3592e7d-063e-413b-92bf-74567232483f"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("ff37f69e-c146-4ae0-950c-bfab3e51f475"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 8, 15, 42, 56, 863, DateTimeKind.Local).AddTicks(4859));
        }
    }
}
