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
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_Orders_OrderId",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_OrderId",
                table: "Discounts");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0005fdc9-9efb-43c9-8bec-e3768346fffe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0154b24e-8688-471e-9284-be322d93c6e0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("04546941-3203-4529-8a46-7e76d14ab8ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("05af2755-47dc-4d02-9bd2-1022162f472a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("06d49c8a-0bdc-4fa7-9c00-ba912934f19a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("08216fe9-7629-427c-acc7-f4bf404f2742"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("09150869-7941-4903-ba40-57ce9751ecd0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0f5c4147-2452-4598-aa15-7dc479be69e1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("126150fd-fdeb-4ae8-aae2-f5e16e4a5b0b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("149e671b-6d84-474d-9144-90bd405d58a1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1c7ed7e3-9f7f-41c1-b803-eff843039fd7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("248247ed-5384-4c46-bd5b-8ce8b3a6e265"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("262fe8c3-efe7-406b-a064-028969abf2f3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2c22d81b-e331-47f4-b817-b8684d7b803a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2c578188-3a05-447e-ad98-9d0b229b7717"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("357c4e48-0725-43bd-91a7-21de237792d6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3678dc64-fd23-41dd-a36f-5e0ae3f56cb0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("396b2098-2e31-4dfd-a2e6-a14555c29dc3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3b1982f5-031f-429f-9e72-abf19ae1a20c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3b604c18-b9c5-416f-87bc-dbb616fbc45f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3ccaa16f-6f57-489d-907c-abbcd9856908"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43183153-2ef7-45de-8707-6719a4b293e8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("466b08c0-9384-4d12-a7c8-e764928bf114"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4c5fee14-bba2-4d4a-b1ee-ba25a8ecd19b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4cb49bca-fec8-4523-976b-996207353fb0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4d759603-f70a-49dd-a650-c9a6cdd12b86"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("54eb9e7e-cc88-4b74-929a-aafb7e762e87"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5a775ebd-b63c-40cf-acb2-5d262e71294e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5d90402c-8064-46d9-80b3-f83a2b1ac68b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5db82f24-04f2-4adc-9591-802928cd2ba3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("60803b42-6732-4925-9258-5d7e2b1ce981"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("61718c9a-72d3-4a14-8a70-59514e2c190b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("62c2f70d-2abb-415b-974f-f518ecf46ae0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6992acf4-a907-4bc2-99a4-806eba7badf4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6b94a4de-5a68-4524-a198-726a2c35a383"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("794bcc3a-aea9-46d8-9bec-5b7c64082fd9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7ed04581-5981-4ab9-a911-63b25576dbbb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("88c9624b-ff6e-405b-bf3b-361ba47877c6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("91efc038-8cf4-46da-9910-823dd360c534"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("96b495c0-ede7-4e09-abfd-73a1940b051d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("96f6e004-a77a-4d46-abb1-ef062e5e2a06"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("97130583-edf8-464a-9d50-cd14c862fd67"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9c0da57e-e9b2-41a3-83a0-42ea3e9556bb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9f6ea512-9c5d-41c6-9353-ccb89ed1f071"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9fb188b0-c62b-4809-9338-89d281fbe4ff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a05db195-9554-401d-9118-934d78a24549"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a3933f41-8fdb-4ae2-9075-9f95d08abb6a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a5f6ce14-2b01-40ce-9d31-7617c8aecde0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b760c09e-19fa-446d-a7bd-4f4843b0033f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bafca5e1-90f4-4920-9db8-fef65334a6e5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bf1e8d33-7fc6-434b-9c50-03207fb768de"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cc57f6e8-8c2e-443e-9059-b504c2f544b4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cca31620-28df-4958-bbaa-935ab4a655d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d8e47b63-ec5e-4d89-a61e-7df11b37c2ef"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("de1ce27f-127d-4c54-8919-3bac99f204f5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e175d2d1-f5dc-4150-b572-e53b104a8fd9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("edd1504d-effb-4015-a542-f77e71b3b544"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f1a667c2-5510-4703-9333-d71a3b8cce67"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f1d1223c-f829-468d-951e-56ba12703ec4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f32a5eb2-f1ce-48f4-99c8-b9ffe668ac29"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f33b9161-566b-4f7e-895d-ac684df04746"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fc27e703-7ad7-4581-a179-865573fb9025"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("11e14503-7dee-4823-ab62-cbbcb57f8515"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("318583ef-1665-4cab-98e2-ed3dc5093617"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("35ea932b-471a-4a3b-8d3b-98326d26183d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("390b347a-f92d-4f0e-b072-490ec87e4e55"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3fedf816-734a-4461-82cb-9ba2ce7d1e8b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("404d56dd-0d31-4bef-99f2-ee162539c84f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4ae29746-55a3-468c-9799-c36c559ff6f2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5a652573-865b-4cde-a81a-db3aec54d879"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6c122ddd-d9c5-45f4-8d2d-d3ea1a1f3d99"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7ab75336-49e0-4b8c-8736-773b5cd4a58a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8368c1bd-cdf4-49ee-966c-6107704a5f16"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("90fc9275-824a-45ab-a6d6-946ee7239ca1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9936c155-d306-49e3-bd40-fd2bed62003a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9aa5b8a3-92fa-4cb7-83b1-ae9ac2d6f5f0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ad79bf35-07af-46dc-9724-32bb6fdb7eb1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b01389f6-378b-4644-95d9-42a230a366da"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b0c80427-d9b7-4768-90f8-3a413fe90ea5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bb2cf2b1-6c43-4994-b7cb-e3b74101f8ed"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c7b2062a-aed5-4715-88df-2df1ddf031b5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d6304374-d840-47b4-b536-b2f812da6061"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("da141549-cad8-4c68-b750-f4c5af6bd4a0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("efbb83e2-6711-48a7-8273-5c64bb4aadac"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f721b07d-f1a8-48db-9d8f-439e315aec9a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f77b86cf-6bf9-49d4-bc3a-269a2c0cab6e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f7857906-76e3-4f1b-ba9d-c0ebe7f1a5ed"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("8aded8b9-5ee1-49fb-8185-badba6a388fb"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a81839a0-8d6f-44dc-ae6f-c48b76d47efc"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("edd8080b-3c22-41df-ac77-2fb4c7052319"));

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "DiscountAward",
                table: "Achievements");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Achievements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/10likes.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/50comments.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/50posts.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5291fbd1-9926-4904-92bc-7f36c738c189"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/10posts.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("56e5cd8d-2d46-45dc-9006-f71920beea40"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/10games.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/50dev.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/firstlike.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/50games.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b0ea7c96-6d5c-4199-9029-7f04e7502f66"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/firstposts.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b186aeb1-033f-4937-a24c-d11b1989e7e2"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/10dev.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/5dev.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/50likes.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/10comments.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/firstcomment.png");

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fef0c70d-cf7b-4c90-9865-383e660fda8a"),
                column: "Image",
                value: "https://indiegamezone.blob.core.windows.net/indiegamezone/firstgame.png");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab1b47c0-1854-4013-8b0c-e602e004c2f3", new DateTime(2025, 8, 14, 0, 5, 33, 1, DateTimeKind.Local).AddTicks(4840), "AQAAAAIAAYagAAAAEDpM7mjZYbVCCEqP3cyOLE+gJE9uIk34n2EV6aGGiU5DldjZYPngCDYJtENhrv2C2w==", "261efcab-0448-47fb-b400-024ab375b8b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f9a4739-fd6b-40b2-86bc-4a2ce492abaf", new DateTime(2025, 8, 14, 0, 5, 33, 202, DateTimeKind.Local).AddTicks(5690), "AQAAAAIAAYagAAAAEP4fIAHvKLkeoCdoKCI8Zp0ZrTc6ekMw4hVlgZCSiToxAyx5xWJsTzYsTjm6k33CcA==", "d42517ca-5a8f-47ab-bdac-9fddada5005a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36e975b3-fc8e-4ca1-a2ec-41b66583bacd", new DateTime(2025, 8, 14, 0, 5, 33, 267, DateTimeKind.Local).AddTicks(838), "AQAAAAIAAYagAAAAEMJ3Q0ZELqeKSStA1fyOhV/9MiFAF/B63xxDmx6+OgW5Pe+AxYRpY5smTQG44RjKYA==", "57d60e58-7f06-4bbb-9f91-9364bf3a25b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f70ce7c5-1c25-4ff2-a18e-b90e7ea6d56d", new DateTime(2025, 8, 14, 0, 5, 32, 932, DateTimeKind.Local).AddTicks(7613), "AQAAAAIAAYagAAAAEK9hLaJwvkTpsw3NkGuNx3f0nE4GhFgfKF4mKdreilC0ruPpF+iHml720MEvjca/og==", "0faf22e5-bc41-4f16-9b91-3f540eeac868" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4137aad3-37af-46f1-8275-b9b219f19056", new DateTime(2025, 8, 14, 0, 5, 33, 134, DateTimeKind.Local).AddTicks(7007), "AQAAAAIAAYagAAAAENCc7q78izeTiJsiQUfwH+vZX+CseqNvxTQlLj162w3T3kzZn/fcq+3Ywij97pXKiQ==", "df014ae5-55c5-4d5b-818b-1d4aef15aa33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43bf81bb-f699-41bd-879b-d2bd973ec15f", new DateTime(2025, 8, 14, 0, 5, 33, 63, DateTimeKind.Local).AddTicks(2309), "AQAAAAIAAYagAAAAEPPJf9Vu88KPCmhrfSBE+ZysS/tHHwoSBH+0WYAGmASBy7JwjvG3IF3RgNXHbDlEUg==", "09b902b8-2c40-4a68-b1fe-5f80c42a0e67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b190096-be0b-4e73-92e5-3405b82aa4d6", new DateTime(2025, 8, 14, 0, 5, 33, 329, DateTimeKind.Local).AddTicks(9000), "AQAAAAIAAYagAAAAEENL1SBIAWJaVUtNq1Xx8UORjzjZzj4xA+R4wAYvnpShl1stKsevkrWnzRf/Vjj9Ng==", "ba89632a-159d-4c2b-a868-ef96f06f6c09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df423b5b-3348-4342-a36d-92dcc0e8ce24", new DateTime(2025, 8, 14, 0, 5, 32, 861, DateTimeKind.Local).AddTicks(8390), "AQAAAAIAAYagAAAAEAKYohwn3jn1eeQyMmbbm7jiP4Xv4Pc/T23NhFalQKi1cVUcQzcHVfZkNPnnPzjzcw==", "d52a4403-7943-49e4-bb70-c7da89e76b4c" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                column: "EndDate",
                value: new DateOnly(2025, 8, 24));

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0296f201-0f6b-4d1f-aa06-2b5a04977543"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("0571a790-6547-4de8-b269-e5b4118585a2"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("0bd001f8-88c1-44fe-af43-56fafa5f0882"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("0ce2d8ad-4df6-4459-8b92-ce422fb599f6"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("0e04ec4d-11af-4ebb-9298-957e1b3e0612"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("11c6aefd-fc06-4f2a-94fb-cdebaa54ab82"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("13cac629-bcb7-46a6-ac5d-0c715e09fcfd"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("149f18f1-0219-41dc-9b99-4356b814ac6c"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("16216b0e-3738-4741-b91a-aa8ea45aa116"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("1a7c5df5-f964-4d12-9b12-6ff74ef9c09b"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("2b5cb2aa-38ab-406c-8fa1-18cac7caf7c6"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("341c4839-15d3-401c-aeae-1ff67a784517"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("41ac5123-3f28-44e9-98ef-8fd2382b29d4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("44c3f8d2-37ea-410c-9e8b-5b1cc49463a1"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("4f587532-92e8-46b6-b7ff-d78ee8395739"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("522eb4da-749c-4918-9ba2-b7075d37af85"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("5983af7b-f013-43d9-b14b-0178f35868b7"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("5a55e042-f445-4df5-b064-ae8009ca796c"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("5cab3c85-db02-429b-bcc9-d74b6c548c2a"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("5e747af6-758a-4668-9415-2b6b27e2c8d3"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("5f26712b-e5d0-4f22-8200-967b6cb3bcb5"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("60de38d0-871e-40e2-9a96-84948fb285ee"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("65c490f4-8299-491d-a484-ae3fd9540b15"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("6737ba3d-e1bd-4f9c-a45a-4d3226a0f5b1"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("6c2ba23e-19f1-4bf1-82f2-fe28c9628df6"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("7425f946-10ce-449f-8692-e438d507e67c"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("749bcaeb-2045-4d95-8f95-7556df6bb775"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("7a4d13c0-eacd-47c2-a682-0216f9206dd9"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("94e2c043-8910-42f7-818d-c32675cdf2db"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("960d863e-fc38-4872-8a35-27a75cd4dedd"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("9830546e-12a2-4747-a53d-8047ed6146da"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("99618945-26af-435c-ad5e-19a64a13862b"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("9b38cd26-b98f-4346-ab26-d1086911fe2a"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("9da0de54-cd42-44cc-83c6-a941241a224f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("a0a64d89-dd9d-4cee-9d2d-522441a1aaec"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("a14f9af0-065b-4e1f-ae2d-c63cce4f08fc"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("a7db2f83-a8e1-4113-824a-c3953f75e169"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("a89bafcf-c0d2-4a61-b3cc-e718834d1879"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("aa0a8960-1be1-46ce-9845-967a2bc325fb"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("ad50dfce-b521-4100-a457-7c0bfc25865f"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("b3750d3d-02ff-4167-bf69-4b94783d1d93"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("b81fab84-17f0-40ac-9f2c-62d8af0c038c"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("beded4f5-dd6b-4f2e-af40-c807b7d000e8"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("c19f2e68-5941-46b3-8ab3-a23f2c6a255b"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("c1d314eb-0b0c-42f7-8004-92a9503df9c0"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("c20c7655-5462-4979-90ed-e637ebedef9b"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("c4c41852-f1bd-4a7d-beff-1d7053c9115b"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("c51c3156-8983-442a-8950-55167270f077"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("c56ab577-02e6-4da0-ace4-074c95538d82"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("ce0e9443-9223-45fe-9a60-8d468c02f0a2"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("ce8e8d91-9849-46e6-8bdd-f6176644d7c8"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("cf71e129-0881-49c4-8b51-48c7ae14b25b"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("d1c3847e-24b7-495a-be39-e216e2333a3e"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("d3029381-960d-4a30-894a-52a902c17878"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("dd550869-3770-4346-983c-14117435df91"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("de00eee4-3c8a-4dd2-b3bb-55967615b5a7"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("e34f08f7-a151-4c96-9cde-b91a0dc08d7c"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("e6c1bffc-7b00-4432-91a6-72a06287b97c"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("f237b684-57c6-4667-9951-158881333ec5"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("f6a2b3cc-4e4b-4c9c-8e6a-a390cf4e698e"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("f7e17770-e26b-4139-bc11-dd8dac6f3520"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("fad09355-1947-4421-a872-dc161c73115f"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("08f17315-3be8-4a86-a34b-11c04ec09eb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("17a8ae55-47ec-41b7-b2f1-abd79c87877c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("2367f0e2-44b7-4639-b135-98f705cb8507"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("254ab8b5-c84e-4fe3-8b59-599fbb264924"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("2c0f4483-d3d5-4288-a6da-8b3098244846"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("36b30faa-2a90-4ff9-a2c1-9be02db6428c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("3d6579c1-5d14-4ae6-9d2b-c764ca3b30ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("46629632-d852-4468-928f-7df15605bc0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("48dfcf7f-f6af-4397-bd40-6919d16cd088"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("55d11172-1202-49f2-a580-f148855d1f4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("57aa2dce-5232-4f08-a3dc-df2cdc411daa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("5c0a84c4-5a92-4a4b-a08e-025fa8ed9bd4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("60c0a84e-6cac-407a-b709-3bc9691428bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("818d410c-c310-432e-8737-c69be6b153d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("94e3af92-d20d-40c2-93b2-7894c2c299bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("9aa1c239-1e66-416b-b013-3a37d1a8a190"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("abb0292a-bf40-4dc2-b441-2352c7cd0a06"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("b0d84691-0187-44bd-a4af-98ea399e2cc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("bfb3d661-5a50-4785-8aa8-500521ad1198"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("cc4e3348-4b14-4e8e-9cb5-fe4e5b9ce17e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("d39ad971-85d5-4334-9dbb-58257e85cca9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("d3ff2423-1708-41c7-90a4-7c0cc454960d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("e0a8b87b-43ac-42e3-ac58-6eae20e380af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("eb775b58-a60b-4d96-be68-b7ab026aff38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("f020e94a-b6cd-472a-b301-40dfe71b4387"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 14, 0, 5, 32, 836, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d55a762-8595-4ff1-b6e5-e5760fd6077e"), "This game gives me a cozy vibe", new DateTime(2025, 8, 14, 0, 5, 32, 847, DateTimeKind.Local).AddTicks(1111), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("a13218e8-50e4-4191-8b14-40c529195c21"), "This game is good, but it has some bugs", new DateTime(2025, 8, 14, 0, 5, 32, 847, DateTimeKind.Local).AddTicks(1121), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("e6c707c7-bfba-4c09-b256-379a8aa53195"), "This is the best game I have ever seen", new DateTime(2025, 8, 14, 0, 5, 32, 847, DateTimeKind.Local).AddTicks(1097), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0296f201-0f6b-4d1f-aa06-2b5a04977543"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0571a790-6547-4de8-b269-e5b4118585a2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0bd001f8-88c1-44fe-af43-56fafa5f0882"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0ce2d8ad-4df6-4459-8b92-ce422fb599f6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0e04ec4d-11af-4ebb-9298-957e1b3e0612"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("11c6aefd-fc06-4f2a-94fb-cdebaa54ab82"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("13cac629-bcb7-46a6-ac5d-0c715e09fcfd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("149f18f1-0219-41dc-9b99-4356b814ac6c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("16216b0e-3738-4741-b91a-aa8ea45aa116"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1a7c5df5-f964-4d12-9b12-6ff74ef9c09b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2b5cb2aa-38ab-406c-8fa1-18cac7caf7c6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("341c4839-15d3-401c-aeae-1ff67a784517"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("41ac5123-3f28-44e9-98ef-8fd2382b29d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("44c3f8d2-37ea-410c-9e8b-5b1cc49463a1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4f587532-92e8-46b6-b7ff-d78ee8395739"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("522eb4da-749c-4918-9ba2-b7075d37af85"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5983af7b-f013-43d9-b14b-0178f35868b7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5a55e042-f445-4df5-b064-ae8009ca796c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5cab3c85-db02-429b-bcc9-d74b6c548c2a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5e747af6-758a-4668-9415-2b6b27e2c8d3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5f26712b-e5d0-4f22-8200-967b6cb3bcb5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("60de38d0-871e-40e2-9a96-84948fb285ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("65c490f4-8299-491d-a484-ae3fd9540b15"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6737ba3d-e1bd-4f9c-a45a-4d3226a0f5b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6c2ba23e-19f1-4bf1-82f2-fe28c9628df6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7425f946-10ce-449f-8692-e438d507e67c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("749bcaeb-2045-4d95-8f95-7556df6bb775"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7a4d13c0-eacd-47c2-a682-0216f9206dd9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("94e2c043-8910-42f7-818d-c32675cdf2db"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("960d863e-fc38-4872-8a35-27a75cd4dedd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9830546e-12a2-4747-a53d-8047ed6146da"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("99618945-26af-435c-ad5e-19a64a13862b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9b38cd26-b98f-4346-ab26-d1086911fe2a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9da0de54-cd42-44cc-83c6-a941241a224f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a0a64d89-dd9d-4cee-9d2d-522441a1aaec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a14f9af0-065b-4e1f-ae2d-c63cce4f08fc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a7db2f83-a8e1-4113-824a-c3953f75e169"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a89bafcf-c0d2-4a61-b3cc-e718834d1879"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aa0a8960-1be1-46ce-9845-967a2bc325fb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ad50dfce-b521-4100-a457-7c0bfc25865f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b3750d3d-02ff-4167-bf69-4b94783d1d93"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b81fab84-17f0-40ac-9f2c-62d8af0c038c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("beded4f5-dd6b-4f2e-af40-c807b7d000e8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c19f2e68-5941-46b3-8ab3-a23f2c6a255b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c1d314eb-0b0c-42f7-8004-92a9503df9c0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c20c7655-5462-4979-90ed-e637ebedef9b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c4c41852-f1bd-4a7d-beff-1d7053c9115b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c51c3156-8983-442a-8950-55167270f077"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c56ab577-02e6-4da0-ace4-074c95538d82"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ce0e9443-9223-45fe-9a60-8d468c02f0a2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ce8e8d91-9849-46e6-8bdd-f6176644d7c8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cf71e129-0881-49c4-8b51-48c7ae14b25b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d1c3847e-24b7-495a-be39-e216e2333a3e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d3029381-960d-4a30-894a-52a902c17878"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dd550869-3770-4346-983c-14117435df91"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("de00eee4-3c8a-4dd2-b3bb-55967615b5a7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e34f08f7-a151-4c96-9cde-b91a0dc08d7c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e6c1bffc-7b00-4432-91a6-72a06287b97c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f237b684-57c6-4667-9951-158881333ec5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f6a2b3cc-4e4b-4c9c-8e6a-a390cf4e698e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f7e17770-e26b-4139-bc11-dd8dac6f3520"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fad09355-1947-4421-a872-dc161c73115f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("08f17315-3be8-4a86-a34b-11c04ec09eb5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("17a8ae55-47ec-41b7-b2f1-abd79c87877c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2367f0e2-44b7-4639-b135-98f705cb8507"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("254ab8b5-c84e-4fe3-8b59-599fbb264924"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2c0f4483-d3d5-4288-a6da-8b3098244846"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("36b30faa-2a90-4ff9-a2c1-9be02db6428c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3d6579c1-5d14-4ae6-9d2b-c764ca3b30ad"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("46629632-d852-4468-928f-7df15605bc0e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("48dfcf7f-f6af-4397-bd40-6919d16cd088"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("55d11172-1202-49f2-a580-f148855d1f4e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("57aa2dce-5232-4f08-a3dc-df2cdc411daa"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5c0a84c4-5a92-4a4b-a08e-025fa8ed9bd4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("60c0a84e-6cac-407a-b709-3bc9691428bc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("818d410c-c310-432e-8737-c69be6b153d4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("94e3af92-d20d-40c2-93b2-7894c2c299bf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9aa1c239-1e66-416b-b013-3a37d1a8a190"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("abb0292a-bf40-4dc2-b441-2352c7cd0a06"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b0d84691-0187-44bd-a4af-98ea399e2cc0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bfb3d661-5a50-4785-8aa8-500521ad1198"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("cc4e3348-4b14-4e8e-9cb5-fe4e5b9ce17e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d39ad971-85d5-4334-9dbb-58257e85cca9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d3ff2423-1708-41c7-90a4-7c0cc454960d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e0a8b87b-43ac-42e3-ac58-6eae20e380af"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("eb775b58-a60b-4d96-be68-b7ab026aff38"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f020e94a-b6cd-472a-b301-40dfe71b4387"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1d55a762-8595-4ff1-b6e5-e5760fd6077e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a13218e8-50e4-4191-8b14-40c529195c21"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e6c707c7-bfba-4c09-b256-379a8aa53195"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Achievements");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Discounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DiscountAward",
                table: "Achievements",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"),
                column: "DiscountAward",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"),
                column: "DiscountAward",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"),
                column: "DiscountAward",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5291fbd1-9926-4904-92bc-7f36c738c189"),
                column: "DiscountAward",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("56e5cd8d-2d46-45dc-9006-f71920beea40"),
                column: "DiscountAward",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"),
                column: "DiscountAward",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"),
                column: "DiscountAward",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"),
                column: "DiscountAward",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b0ea7c96-6d5c-4199-9029-7f04e7502f66"),
                column: "DiscountAward",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b186aeb1-033f-4937-a24c-d11b1989e7e2"),
                column: "DiscountAward",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"),
                column: "DiscountAward",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"),
                column: "DiscountAward",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"),
                column: "DiscountAward",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"),
                column: "DiscountAward",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fef0c70d-cf7b-4c90-9865-383e660fda8a"),
                column: "DiscountAward",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0713cb1e-c3ab-49b0-a465-0406ba690f55", new DateTime(2025, 8, 8, 1, 33, 6, 199, DateTimeKind.Local).AddTicks(9595), "AQAAAAIAAYagAAAAECeK09a30UP1nhuXwrKdgnT9ri2NpKvLfWToPwvYzRIW2tLml08HoNkTpOSEy6GL8g==", "0968b6aa-4540-46ca-81f5-b54b35f5ee09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23024ac6-e619-4c8a-8a9a-125146cf1265", new DateTime(2025, 8, 8, 1, 33, 6, 381, DateTimeKind.Local).AddTicks(885), "AQAAAAIAAYagAAAAEEDPSBzmdVHv6yuQ3ijwbLp+nW9nLTV1VvchzHeoVJ7JlT5XUcTXVeQSuHkE3gzwFQ==", "d2018121-52a6-445f-a02a-b61d72ab5191" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70059a27-c598-4d80-8ff9-2b87eec07418", new DateTime(2025, 8, 8, 1, 33, 6, 437, DateTimeKind.Local).AddTicks(6630), "AQAAAAIAAYagAAAAEAQi3NrGrw8qUmlsK9EmEjfI2uf/9QDdfNlbzDvdeMimj6+TbB79Qn72XOa25HLzHA==", "33ab544e-993f-4a40-a6d3-d6841822b737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02c65527-64e5-4622-91fe-99e98db6b220", new DateTime(2025, 8, 8, 1, 33, 6, 141, DateTimeKind.Local).AddTicks(6210), "AQAAAAIAAYagAAAAEIxCH7bbkqjM69rKSeZ7Imh/6GCuc9PneUBRJoGsg6SXbWqX5x3LYXB3x9M5PZx4Zw==", "822724b8-160e-4f29-859a-bcf70bc429f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a90ce08b-efdd-4909-b14a-35b425c01849", new DateTime(2025, 8, 8, 1, 33, 6, 314, DateTimeKind.Local).AddTicks(2569), "AQAAAAIAAYagAAAAEDuIa8FyTu4oikFnSK6uedW79ManGhOtvZizXPUWABtVpY15eEGB7ZHi3bYPzZg6EA==", "0daf1328-de1a-4904-b871-6435e69a6fee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c45f4d3-aacc-482b-aabc-5c8ce0b664be", new DateTime(2025, 8, 8, 1, 33, 6, 255, DateTimeKind.Local).AddTicks(214), "AQAAAAIAAYagAAAAEFoQmsuJrqRtyigs0m6i1EJLajMdpdRaMw35DBG3+ptzv8O+oj0xRkRZ98p6sfYSLw==", "be3fe362-d94d-49a9-9921-eef458832b41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecd3512b-64be-49e8-892c-9a3dc9bd80bf", new DateTime(2025, 8, 8, 1, 33, 6, 492, DateTimeKind.Local).AddTicks(9573), "AQAAAAIAAYagAAAAEBZgneOPKBHRrDDHtrHMkPGiumkge4MT6eN0Hi0ES7fSwavjdQMG1MSWBz+Of+9Rhw==", "da508e85-79cd-4596-8cab-751a808f76f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a75f606a-08f1-4e81-b97d-27899e19edb8", new DateTime(2025, 8, 8, 1, 33, 6, 82, DateTimeKind.Local).AddTicks(9047), "AQAAAAIAAYagAAAAEHktGI8380DEuo9E93KnWx/2GQVIduIemAfKjg0Gsi6e9ofGgixwE17q0o3BNWI1wA==", "72dc9b38-ebfd-4887-9d85-24c71ab789d0" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "OrderId" },
                values: new object[] { new DateOnly(2025, 8, 18), null });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0005fdc9-9efb-43c9-8bec-e3768346fffe"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("0154b24e-8688-471e-9284-be322d93c6e0"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("04546941-3203-4529-8a46-7e76d14ab8ee"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("05af2755-47dc-4d02-9bd2-1022162f472a"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("06d49c8a-0bdc-4fa7-9c00-ba912934f19a"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("08216fe9-7629-427c-acc7-f4bf404f2742"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("09150869-7941-4903-ba40-57ce9751ecd0"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("0f5c4147-2452-4598-aa15-7dc479be69e1"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("126150fd-fdeb-4ae8-aae2-f5e16e4a5b0b"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("149e671b-6d84-474d-9144-90bd405d58a1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("1c7ed7e3-9f7f-41c1-b803-eff843039fd7"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("248247ed-5384-4c46-bd5b-8ce8b3a6e265"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("262fe8c3-efe7-406b-a064-028969abf2f3"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("2c22d81b-e331-47f4-b817-b8684d7b803a"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("2c578188-3a05-447e-ad98-9d0b229b7717"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("357c4e48-0725-43bd-91a7-21de237792d6"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("3678dc64-fd23-41dd-a36f-5e0ae3f56cb0"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("396b2098-2e31-4dfd-a2e6-a14555c29dc3"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("3b1982f5-031f-429f-9e72-abf19ae1a20c"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("3b604c18-b9c5-416f-87bc-dbb616fbc45f"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("3ccaa16f-6f57-489d-907c-abbcd9856908"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("43183153-2ef7-45de-8707-6719a4b293e8"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("466b08c0-9384-4d12-a7c8-e764928bf114"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("4c5fee14-bba2-4d4a-b1ee-ba25a8ecd19b"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("4cb49bca-fec8-4523-976b-996207353fb0"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("4d759603-f70a-49dd-a650-c9a6cdd12b86"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("54eb9e7e-cc88-4b74-929a-aafb7e762e87"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("5a775ebd-b63c-40cf-acb2-5d262e71294e"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("5d90402c-8064-46d9-80b3-f83a2b1ac68b"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("5db82f24-04f2-4adc-9591-802928cd2ba3"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("60803b42-6732-4925-9258-5d7e2b1ce981"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("61718c9a-72d3-4a14-8a70-59514e2c190b"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("62c2f70d-2abb-415b-974f-f518ecf46ae0"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("6992acf4-a907-4bc2-99a4-806eba7badf4"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("6b94a4de-5a68-4524-a198-726a2c35a383"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("794bcc3a-aea9-46d8-9bec-5b7c64082fd9"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("7ed04581-5981-4ab9-a911-63b25576dbbb"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("88c9624b-ff6e-405b-bf3b-361ba47877c6"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("91efc038-8cf4-46da-9910-823dd360c534"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("96b495c0-ede7-4e09-abfd-73a1940b051d"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("96f6e004-a77a-4d46-abb1-ef062e5e2a06"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("97130583-edf8-464a-9d50-cd14c862fd67"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("9c0da57e-e9b2-41a3-83a0-42ea3e9556bb"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("9f6ea512-9c5d-41c6-9353-ccb89ed1f071"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("9fb188b0-c62b-4809-9338-89d281fbe4ff"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("a05db195-9554-401d-9118-934d78a24549"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("a3933f41-8fdb-4ae2-9075-9f95d08abb6a"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("a5f6ce14-2b01-40ce-9d31-7617c8aecde0"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("b760c09e-19fa-446d-a7bd-4f4843b0033f"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("bafca5e1-90f4-4920-9db8-fef65334a6e5"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("bf1e8d33-7fc6-434b-9c50-03207fb768de"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("cc57f6e8-8c2e-443e-9059-b504c2f544b4"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("cca31620-28df-4958-bbaa-935ab4a655d8"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("d8e47b63-ec5e-4d89-a61e-7df11b37c2ef"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("de1ce27f-127d-4c54-8919-3bac99f204f5"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("e175d2d1-f5dc-4150-b572-e53b104a8fd9"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("edd1504d-effb-4015-a542-f77e71b3b544"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("f1a667c2-5510-4703-9333-d71a3b8cce67"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("f1d1223c-f829-468d-951e-56ba12703ec4"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("f32a5eb2-f1ce-48f4-99c8-b9ffe668ac29"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("f33b9161-566b-4f7e-895d-ac684df04746"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("fc27e703-7ad7-4581-a179-865573fb9025"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("11e14503-7dee-4823-ab62-cbbcb57f8515"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("318583ef-1665-4cab-98e2-ed3dc5093617"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("35ea932b-471a-4a3b-8d3b-98326d26183d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("390b347a-f92d-4f0e-b072-490ec87e4e55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("3fedf816-734a-4461-82cb-9ba2ce7d1e8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("404d56dd-0d31-4bef-99f2-ee162539c84f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("4ae29746-55a3-468c-9799-c36c559ff6f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("5a652573-865b-4cde-a81a-db3aec54d879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("6c122ddd-d9c5-45f4-8d2d-d3ea1a1f3d99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("7ab75336-49e0-4b8c-8736-773b5cd4a58a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("8368c1bd-cdf4-49ee-966c-6107704a5f16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("90fc9275-824a-45ab-a6d6-946ee7239ca1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("9936c155-d306-49e3-bd40-fd2bed62003a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("9aa5b8a3-92fa-4cb7-83b1-ae9ac2d6f5f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("ad79bf35-07af-46dc-9724-32bb6fdb7eb1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("b01389f6-378b-4644-95d9-42a230a366da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("b0c80427-d9b7-4768-90f8-3a413fe90ea5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("bb2cf2b1-6c43-4994-b7cb-e3b74101f8ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("c7b2062a-aed5-4715-88df-2df1ddf031b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("d6304374-d840-47b4-b536-b2f812da6061"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("da141549-cad8-4c68-b750-f4c5af6bd4a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("efbb83e2-6711-48a7-8273-5c64bb4aadac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("f721b07d-f1a8-48db-9d8f-439e315aec9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("f77b86cf-6bf9-49d4-bc3a-269a2c0cab6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("f7857906-76e3-4f1b-ba9d-c0ebe7f1a5ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 8, 1, 33, 6, 67, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("8aded8b9-5ee1-49fb-8185-badba6a388fb"), "This game is good, but it has some bugs", new DateTime(2025, 8, 8, 1, 33, 6, 73, DateTimeKind.Local).AddTicks(7770), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("a81839a0-8d6f-44dc-ae6f-c48b76d47efc"), "This game gives me a cozy vibe", new DateTime(2025, 8, 8, 1, 33, 6, 73, DateTimeKind.Local).AddTicks(7763), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("edd8080b-3c22-41df-ac77-2fb4c7052319"), "This is the best game I have ever seen", new DateTime(2025, 8, 8, 1, 33, 6, 73, DateTimeKind.Local).AddTicks(7755), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_OrderId",
                table: "Discounts",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_Orders_OrderId",
                table: "Discounts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
