using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGameEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("006313d2-0bc1-4d69-af4b-1962e1895a0a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0786a1c0-384f-4017-a37e-9f2bf84dd0af"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a0a28e9-1cc0-4c29-ba77-8cfa4ee6da19"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("19d5446c-ce0d-4b42-8863-79a245486699"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1c426b7d-037d-4c99-9bca-ffe906d6c053"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("20b01879-fbf1-43f3-8281-022f6434cc09"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("346f4346-66a4-4489-bc7a-83b20d03563d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3952476f-e711-4bb6-8e19-f9aaaf5e6551"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43001e16-a7b1-4189-8f8a-9032a9f64209"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("47122048-b6a0-4c48-b918-ca1c8786346d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("49c52b0a-3fa3-4c34-a399-744908e8aa04"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4a2d19d5-32de-4138-ba31-f24e9134be51"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("523e2431-3d66-4d29-8cdb-1d4b9abecf2c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5715abb8-b760-4246-98d7-82210ea157a4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5bf517b0-e25c-4f01-9419-7e8f844ca1a3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5c8e7c70-008c-4416-acfc-91a9163650bc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5ccd5149-fc28-4c9e-8438-898a70a6759c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5df26676-1ca9-4ec9-b134-eaa35948fa5f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("673c7cd7-9df8-4cce-b296-aecdd178dfa5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6a2d57ba-f947-42a6-a028-9a9a28cb61b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6a68ef75-d58a-4094-adec-a025f7f8af2d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6e438653-d4c2-4532-bfc7-3350e48ef75b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("74bf1368-0abc-4cd9-853c-cd83f09b9261"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("76786bb2-07f8-4fe3-985d-83aa4174e36a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7926fa6f-cfcb-4e30-a900-28133adb4658"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7c1b54ec-cc42-41ee-afa5-6fe20b40ef81"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7d21784e-4901-451c-8382-c849be32b45d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("837742e4-0030-4c97-ba01-67bf1a52f4ef"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("839011f3-8c5b-4d1d-8a78-7c1d6661c3fa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("83a0b457-7909-4e1c-9812-22a141381f46"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("86f262c2-f1a6-4590-afec-f186b23163fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("88396cd6-34b2-4926-b9ee-bf6293550b5f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8b279fc1-2f0c-4f3f-9c7d-25ab34a0d25f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("904fb7eb-bd00-489d-9911-2786fabbbb63"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90673dd8-eaa9-4048-ab9f-baccb285b9ca"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("999d691e-038e-4174-94f8-5ac27bb6c64c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9c4822a1-a735-4ae7-ac6f-9c83e198fabe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9f742859-1b29-437d-9d2c-7797976549dc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a126b4a2-e771-4306-91be-c7f0040954d5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a289c122-94ae-47e9-9aae-f17f208af630"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a39c7672-a7d2-4b6e-bf10-367ee51c44e7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a877ba76-7b93-4b19-8cf0-8285bd8251ce"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ba2f5cdf-a9eb-4807-9247-47797733ed5b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("baa70e5b-4d16-4b1d-9a09-22aef0698ca4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bb42b782-73a1-472b-bb3d-78e606373dc3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bebde767-0f9e-4e2b-9f49-70e9da175991"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bf267b72-22bd-4e14-bcf1-6c29d729bd65"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ca93f91c-8782-4efb-afeb-1f710ba242a3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("caa422ab-b78f-44cb-b56c-a688103051c9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cd9c5b53-ff1b-4031-b1be-5a0ce4411876"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d6862569-ad19-4cd8-a767-ef122d7bddea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dd5fd0e7-f539-4724-bf78-3ca62a4cc5b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e45c22f8-dfb7-4f5b-b8b8-f7e0d07110af"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e7302c39-cee0-49a7-9f40-448c73040112"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e7ef1e17-3236-4b05-b617-e9a39fc963e6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("efa31c03-ebbe-4ebb-83fa-ec0e96d1f55e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f07a1f37-d920-4a01-a406-8f33dcde3a26"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f0ffa2dc-fdcb-468d-90a1-ca31597e4508"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f4421d3b-116f-44e8-b379-46ecd55e0052"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f8b0c1e1-7869-49f1-88ae-e94320207933"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fa85c4f1-f420-4858-8bbc-1b8ac8d338ea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ff729b10-3455-42a5-b2eb-373c940c22df"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Visibility",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68c847fd-1ddb-4816-a4dc-3b4852b24387", new DateTime(2025, 6, 6, 16, 2, 5, 267, DateTimeKind.Local).AddTicks(8654), "AQAAAAIAAYagAAAAEPhobgim0T9kCQ96vAj7S61ep2BrYAvItJOju61knyaDTtcT1drldMOcGVVvEciV5w==", "245d4cf1-95d7-4eb7-bd37-3117132100bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "202e30f3-1e38-4064-9cfd-7b5a81286717", new DateTime(2025, 6, 6, 16, 2, 5, 328, DateTimeKind.Local).AddTicks(4874), "AQAAAAIAAYagAAAAEJz+f7RvoySBVaPNFF8K6vUT9Ntk/884poujAMIY5VVjCmHJmhWBXvDolapmvWa9Yw==", "27b5b668-46a1-4085-9f58-3169775fdc26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dd686c8-c1d4-4446-9693-5be58255f7b3", new DateTime(2025, 6, 6, 16, 2, 5, 384, DateTimeKind.Local).AddTicks(3103), "AQAAAAIAAYagAAAAEKZFEJiOK7eXpVX+0sv8h4ULCLOqvn0OlJhHTPTEosrV+RyBOAG+Kh3sqT2+sN1m4w==", "5a5147ed-7caa-479c-aa32-5372550d2c1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a23e7022-8aae-4d4b-a8d6-4b78b316bcbb", new DateTime(2025, 6, 6, 16, 2, 5, 208, DateTimeKind.Local).AddTicks(1913), "AQAAAAIAAYagAAAAEDYO8hmDEgvN5WtgnQktn+45IlZxEMM4eUJYXtiD43Gn3bTd7DRkk1wc7akze8rKeA==", "2075bf8b-8356-43ea-99c1-50bfe0f849d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14e99c32-9ef4-4c76-b21b-4af792d90393", new DateTime(2025, 6, 6, 16, 2, 5, 442, DateTimeKind.Local).AddTicks(2374), "AQAAAAIAAYagAAAAEGaVbMr3m6MfDVRAefiURgqOyG2vdxPZRF+edAACvRZuucF0xDXHnfHm5MCAizC9WA==", "d96d1ad6-05bc-4009-9373-8135e7d9063f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93fa7580-5dca-4348-b24b-656667895176", new DateTime(2025, 6, 6, 16, 2, 5, 150, DateTimeKind.Local).AddTicks(2012), "AQAAAAIAAYagAAAAEDxfC+yEO6Qc3PyukfVp54hR8yWx+Gap9gEkvk6KHQKdagtlP7IbBwmlp+6k4kkWLg==", "35052559-3fcd-4388-ba60-2f7d5d2ea0e3" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 16), new DateOnly(2025, 6, 6) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("00857d2e-4d0d-42e1-8c04-17e02ad0f15c"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("025a7f61-b404-4fbb-b2c5-76a5ddea5978"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("0416b62c-5dd5-4ae3-9d5c-290e46a87920"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("073578c0-cf6a-4be2-b792-fae8e9ee3bea"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("096a7cc7-df5c-4550-a1f2-0cb711b4d7b4"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("097376fb-71e0-492f-886e-5bd220e6bd5d"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("0df3eee8-1d8e-4aae-82f1-45059ee48242"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("0e033a07-b853-47e1-92ea-a640ab475605"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("1804de18-298e-4170-bca8-39eff107fca8"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("18b29f74-369c-42ed-9639-cf62dcdb6c62"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("1cc1a70a-f340-457c-bd57-c64dc53b6ab2"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("1dd34a0e-4af5-4aaa-80e2-82acfbaeb0c8"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("1e5b887a-a89a-48f2-8bf1-23f9fdc7b5e0"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("1e85a16e-c402-4648-8235-68b97f2de4c6"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("21c03e2f-53cc-45fc-806c-08587249f732"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("225e6304-4b8f-49ce-9d10-3f1f8afa52d8"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("2af21421-f494-4da7-983f-2b1ec525088b"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("350976c6-9e29-46e0-ac6a-6c1a6547f94d"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("408411c7-f99d-454f-b78e-3a18b36c8445"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("4851d087-820b-457f-872c-dd901654b705"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("4a92a5e6-08b1-4ebe-a450-afc33cb5f27a"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("4d32b884-4dce-4f83-8fb3-580eda56d46d"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("4d483e54-987a-4694-8d15-262688b9aa54"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("4e77bb09-87e8-43d1-93a5-57f89a54adc7"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("514bfbf0-97d4-46a5-9da4-6a0722be2c53"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("546d038b-4db2-4a13-8c03-fdc77c977b83"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("57ef5e28-c5e5-4782-959c-b030b9bfc3c1"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("5e54e419-d643-4352-9920-b2f9596a134e"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("5ef496ee-8cdb-4513-a3de-7a035db66a85"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("612b2c29-bced-4133-900d-1a9a6a9cab8b"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("6bcc3683-92f3-4a56-9ec3-45d05b909957"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("7b5b72a7-114c-491e-99ea-1d21373a2bed"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("97434090-d7d7-4ed0-98cb-660f56868ad5"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("9b1908e6-6311-4a68-8f16-1757a2825ccb"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("a0a9d028-2374-4488-97dc-7adb874a95e0"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("a988a3ef-4af1-475f-a5be-4b8bff93c93d"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("aa079519-fca9-43b2-90cc-f7543a0a48b3"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("ad719199-a3cc-4eda-818d-6a25183b78c0"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("afa95998-b4f0-4ad6-90a5-99882ba6bdc3"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("b0139299-0587-477e-b9c5-5cc811d137e2"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("b42523c5-e56b-44b5-9809-7bb8c0ef5ac2"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("b70bba65-4e66-4c45-9a03-3ce61c74aa66"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("c111c357-f420-4763-b009-d61db3bdae3c"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("c2a1e02f-116c-48d3-a733-7d6efe400e6a"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("c5c57c5a-addc-4b68-a67f-888a90d04b9c"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("c9ffe699-c1c1-4ddf-9641-b97ad4bcd22e"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("d4cd56be-d664-4a7a-b81a-93677e49ba2e"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("d8660501-d406-42db-a4f2-39c72039f609"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("da1dcaad-c413-469c-bdc4-9d9341e8531d"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("db031970-5c31-4876-b657-fd5832770a8f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("db2daba1-ffc5-4a93-a5a8-0363d3ab84a6"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("dd798dc1-ace6-4dea-8b3c-2aa8799777bd"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("e2d3b7bb-fd71-48bb-b038-ec27ec6136f3"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("e643d9e0-0a9a-4b40-9479-f2248eb7ca2f"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("e76612fb-6efc-45d3-9a4f-53ed6dfb7aa0"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("e7973e73-2ab1-4566-b270-167fb5db0fa2"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("ed458707-ba6e-4715-b3ec-bedb33b17413"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("ed5c1704-6433-4c7a-8674-dbb5faf27346"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("f02b876e-4a2c-452d-86d1-053c02bbcea5"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("f2a5d17e-9081-4bff-a876-c91bf7ae13cc"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("f3c04803-b597-4e9d-85bc-aca3d1324f99"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("f3df3c8a-a9aa-4ada-b715-d3507310619c"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2961), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3078), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3068), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2995), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2965), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2908), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2893), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2947), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2990), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3093), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3063), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2986), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2975), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3073), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2980), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3001), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2955), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3088), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3083), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(3056), "Released", "Public" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CreatedAt", "Status", "Visibility" },
                values: new object[] { new DateTime(2025, 6, 6, 16, 2, 5, 135, DateTimeKind.Local).AddTicks(2970), "Released", "Public" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("00857d2e-4d0d-42e1-8c04-17e02ad0f15c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("025a7f61-b404-4fbb-b2c5-76a5ddea5978"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0416b62c-5dd5-4ae3-9d5c-290e46a87920"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("073578c0-cf6a-4be2-b792-fae8e9ee3bea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("096a7cc7-df5c-4550-a1f2-0cb711b4d7b4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("097376fb-71e0-492f-886e-5bd220e6bd5d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0df3eee8-1d8e-4aae-82f1-45059ee48242"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0e033a07-b853-47e1-92ea-a640ab475605"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1804de18-298e-4170-bca8-39eff107fca8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("18b29f74-369c-42ed-9639-cf62dcdb6c62"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1cc1a70a-f340-457c-bd57-c64dc53b6ab2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1dd34a0e-4af5-4aaa-80e2-82acfbaeb0c8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1e5b887a-a89a-48f2-8bf1-23f9fdc7b5e0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1e85a16e-c402-4648-8235-68b97f2de4c6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("21c03e2f-53cc-45fc-806c-08587249f732"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("225e6304-4b8f-49ce-9d10-3f1f8afa52d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2af21421-f494-4da7-983f-2b1ec525088b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("350976c6-9e29-46e0-ac6a-6c1a6547f94d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("408411c7-f99d-454f-b78e-3a18b36c8445"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4851d087-820b-457f-872c-dd901654b705"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4a92a5e6-08b1-4ebe-a450-afc33cb5f27a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4d32b884-4dce-4f83-8fb3-580eda56d46d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4d483e54-987a-4694-8d15-262688b9aa54"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4e77bb09-87e8-43d1-93a5-57f89a54adc7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("514bfbf0-97d4-46a5-9da4-6a0722be2c53"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("546d038b-4db2-4a13-8c03-fdc77c977b83"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("57ef5e28-c5e5-4782-959c-b030b9bfc3c1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5e54e419-d643-4352-9920-b2f9596a134e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5ef496ee-8cdb-4513-a3de-7a035db66a85"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("612b2c29-bced-4133-900d-1a9a6a9cab8b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6bcc3683-92f3-4a56-9ec3-45d05b909957"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7b5b72a7-114c-491e-99ea-1d21373a2bed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("97434090-d7d7-4ed0-98cb-660f56868ad5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9b1908e6-6311-4a68-8f16-1757a2825ccb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a0a9d028-2374-4488-97dc-7adb874a95e0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a988a3ef-4af1-475f-a5be-4b8bff93c93d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aa079519-fca9-43b2-90cc-f7543a0a48b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ad719199-a3cc-4eda-818d-6a25183b78c0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("afa95998-b4f0-4ad6-90a5-99882ba6bdc3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b0139299-0587-477e-b9c5-5cc811d137e2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b42523c5-e56b-44b5-9809-7bb8c0ef5ac2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b70bba65-4e66-4c45-9a03-3ce61c74aa66"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c111c357-f420-4763-b009-d61db3bdae3c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c2a1e02f-116c-48d3-a733-7d6efe400e6a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c5c57c5a-addc-4b68-a67f-888a90d04b9c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c9ffe699-c1c1-4ddf-9641-b97ad4bcd22e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d4cd56be-d664-4a7a-b81a-93677e49ba2e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d8660501-d406-42db-a4f2-39c72039f609"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("da1dcaad-c413-469c-bdc4-9d9341e8531d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("db031970-5c31-4876-b657-fd5832770a8f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("db2daba1-ffc5-4a93-a5a8-0363d3ab84a6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dd798dc1-ace6-4dea-8b3c-2aa8799777bd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e2d3b7bb-fd71-48bb-b038-ec27ec6136f3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e643d9e0-0a9a-4b40-9479-f2248eb7ca2f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e76612fb-6efc-45d3-9a4f-53ed6dfb7aa0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e7973e73-2ab1-4566-b270-167fb5db0fa2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ed458707-ba6e-4715-b3ec-bedb33b17413"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ed5c1704-6433-4c7a-8674-dbb5faf27346"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f02b876e-4a2c-452d-86d1-053c02bbcea5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f2a5d17e-9081-4bff-a876-c91bf7ae13cc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f3c04803-b597-4e9d-85bc-aca3d1324f99"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f3df3c8a-a9aa-4ada-b715-d3507310619c"));

            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8ef210a-b1f4-4d2b-9e4c-87e9f7ce6f2c", new DateTime(2025, 6, 5, 13, 59, 26, 545, DateTimeKind.Local).AddTicks(5022), "AQAAAAIAAYagAAAAEMnjO5iy1KU3SX477nlHwILxYYyozA7wtIpr9vTtERovXOjoEZ+a6I1NcL0yeQ1fLw==", "6c05d6d1-8452-46b4-81aa-c2003ec08985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ddbb190-f71e-44a8-a96c-0c5c6d692225", new DateTime(2025, 6, 5, 13, 59, 26, 604, DateTimeKind.Local).AddTicks(945), "AQAAAAIAAYagAAAAEC9A3NPfOYTwY3DMmsAYIVPPmQK+OYVWQs7O3s+fgdHRM9M/bBPCTNJKv3gIOT7RDg==", "f8431aac-0e32-4117-9b7d-f10b41eb4b07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "566604a8-b8ae-4ea7-840e-e14be4988fc7", new DateTime(2025, 6, 5, 13, 59, 26, 659, DateTimeKind.Local).AddTicks(8987), "AQAAAAIAAYagAAAAEM6EnHlw+D17KV7Yh5fyRuNoot69KeQKwkGJ/KMGTHeWgjfCDnBro+ySvLRW+B6BqA==", "cd3489d5-484d-47e7-a732-dcbda226e2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7d2a2e9-76da-46a1-80c7-8cac5e167b50", new DateTime(2025, 6, 5, 13, 59, 26, 486, DateTimeKind.Local).AddTicks(1196), "AQAAAAIAAYagAAAAEOMz4L6sP8LJNHB5SmD/omd/bxSpCn1FwOxC4Ew86p0hIKEqAjSKZn5TQWNO+1cbAQ==", "e90a8616-6894-4eb6-bec4-a56c338e59a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "747562dd-d333-49d4-a2e8-bd3fd8dc3c5f", new DateTime(2025, 6, 5, 13, 59, 26, 716, DateTimeKind.Local).AddTicks(1170), "AQAAAAIAAYagAAAAEAWykFIUENHhyqvONdojpsiN1zSYyYZ24XaLcB3WoFy7OAJ7zYfLrkfIOcpy17rd/w==", "e7f0bd8f-b67d-4c48-b00b-81493f1d5875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3e7fc42-fa70-454e-a48f-05c35e9c0419", new DateTime(2025, 6, 5, 13, 59, 26, 426, DateTimeKind.Local).AddTicks(900), "AQAAAAIAAYagAAAAEERv5eIIl+j1rCJ4ovqN9Ui99x5VJlVPy4Aum/fBVXPSudgl6o/DsAwtsnTRzXsDhw==", "9b30b605-88e8-46b8-94e3-db54dcddf0c8" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 15), new DateOnly(2025, 6, 5) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("006313d2-0bc1-4d69-af4b-1962e1895a0a"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("0786a1c0-384f-4017-a37e-9f2bf84dd0af"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("0a0a28e9-1cc0-4c29-ba77-8cfa4ee6da19"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("19d5446c-ce0d-4b42-8863-79a245486699"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("1c426b7d-037d-4c99-9bca-ffe906d6c053"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("20b01879-fbf1-43f3-8281-022f6434cc09"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("346f4346-66a4-4489-bc7a-83b20d03563d"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("3952476f-e711-4bb6-8e19-f9aaaf5e6551"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("43001e16-a7b1-4189-8f8a-9032a9f64209"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("47122048-b6a0-4c48-b918-ca1c8786346d"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("49c52b0a-3fa3-4c34-a399-744908e8aa04"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("4a2d19d5-32de-4138-ba31-f24e9134be51"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("523e2431-3d66-4d29-8cdb-1d4b9abecf2c"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("5715abb8-b760-4246-98d7-82210ea157a4"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("5bf517b0-e25c-4f01-9419-7e8f844ca1a3"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("5c8e7c70-008c-4416-acfc-91a9163650bc"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("5ccd5149-fc28-4c9e-8438-898a70a6759c"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("5df26676-1ca9-4ec9-b134-eaa35948fa5f"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("673c7cd7-9df8-4cce-b296-aecdd178dfa5"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("6a2d57ba-f947-42a6-a028-9a9a28cb61b1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("6a68ef75-d58a-4094-adec-a025f7f8af2d"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("6e438653-d4c2-4532-bfc7-3350e48ef75b"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("74bf1368-0abc-4cd9-853c-cd83f09b9261"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("76786bb2-07f8-4fe3-985d-83aa4174e36a"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("7926fa6f-cfcb-4e30-a900-28133adb4658"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("7c1b54ec-cc42-41ee-afa5-6fe20b40ef81"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("7d21784e-4901-451c-8382-c849be32b45d"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("837742e4-0030-4c97-ba01-67bf1a52f4ef"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("839011f3-8c5b-4d1d-8a78-7c1d6661c3fa"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("83a0b457-7909-4e1c-9812-22a141381f46"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("86f262c2-f1a6-4590-afec-f186b23163fd"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("88396cd6-34b2-4926-b9ee-bf6293550b5f"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("8b279fc1-2f0c-4f3f-9c7d-25ab34a0d25f"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("904fb7eb-bd00-489d-9911-2786fabbbb63"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("90673dd8-eaa9-4048-ab9f-baccb285b9ca"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("999d691e-038e-4174-94f8-5ac27bb6c64c"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("9c4822a1-a735-4ae7-ac6f-9c83e198fabe"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("9f742859-1b29-437d-9d2c-7797976549dc"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("a126b4a2-e771-4306-91be-c7f0040954d5"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("a289c122-94ae-47e9-9aae-f17f208af630"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("a39c7672-a7d2-4b6e-bf10-367ee51c44e7"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("a877ba76-7b93-4b19-8cf0-8285bd8251ce"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("ba2f5cdf-a9eb-4807-9247-47797733ed5b"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("baa70e5b-4d16-4b1d-9a09-22aef0698ca4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("bb42b782-73a1-472b-bb3d-78e606373dc3"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("bebde767-0f9e-4e2b-9f49-70e9da175991"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("bf267b72-22bd-4e14-bcf1-6c29d729bd65"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("ca93f91c-8782-4efb-afeb-1f710ba242a3"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("caa422ab-b78f-44cb-b56c-a688103051c9"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("cd9c5b53-ff1b-4031-b1be-5a0ce4411876"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("d6862569-ad19-4cd8-a767-ef122d7bddea"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("dd5fd0e7-f539-4724-bf78-3ca62a4cc5b1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("e45c22f8-dfb7-4f5b-b8b8-f7e0d07110af"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("e7302c39-cee0-49a7-9f40-448c73040112"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("e7ef1e17-3236-4b05-b617-e9a39fc963e6"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("efa31c03-ebbe-4ebb-83fa-ec0e96d1f55e"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("f07a1f37-d920-4a01-a406-8f33dcde3a26"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("f0ffa2dc-fdcb-468d-90a1-ca31597e4508"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("f4421d3b-116f-44e8-b379-46ecd55e0052"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("f8b0c1e1-7869-49f1-88ae-e94320207933"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("fa85c4f1-f420-4858-8bbc-1b8ac8d338ea"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("ff729b10-3455-42a5-b2eb-373c940c22df"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7615), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7745), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7734), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7710), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7620), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7593), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7575), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7603), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7704), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7794), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7729), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7698), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7632), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7740), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7691), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7718), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7609), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7758), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7751), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7723), 1 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 59, 26, 411, DateTimeKind.Local).AddTicks(7626), 1 });
        }
    }
}
