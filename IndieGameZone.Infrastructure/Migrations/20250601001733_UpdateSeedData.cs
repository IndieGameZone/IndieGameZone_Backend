using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ef51667-ff8d-4873-979b-a3b9a5dbe1b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcf41a71-dd69-43db-af34-a8ca8592b079"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcb43570-6859-41f4-8d72-ce59a31f5858"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("72229e67-bba2-41ae-9fee-84c97d01d1fb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("78530cfe-1488-49ab-befb-0ee332cfe7a1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("83f90ed3-38f1-40a9-88e5-8ce4a728a4a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9f3617ec-c56d-4423-ad07-43c904ef6542"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a39f8614-3936-48cf-bb4a-01c590486bdc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b92d60b0-0447-4ef2-9233-088b4d91cce5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c620e06f-49b2-4cc7-8be5-19d63e8d915a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cb631ff7-d19b-40a5-b948-a3b138703e19"));

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d8f0c15-cdb8-4f99-a84e-d749474f9f98"), "Comment 500 Times" },
                    { new Guid("0f7b9b0f-f527-43cc-92f1-92fe4d03d09d"), "Omniscient (View every game page)" },
                    { new Guid("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"), "Like 50 Posts" },
                    { new Guid("187f58aa-ecc1-4e65-9b76-f3fe37213ae3"), "Wishlist 500 Games" },
                    { new Guid("1a7902b5-b931-4050-a0bc-4df6bbd0b2a1"), "Philanthropist (Gift 10 games)" },
                    { new Guid("1fc7e4c8-6a14-4b10-a54f-28c14a5bfae4"), "Early Adopter (Joined at launch)" },
                    { new Guid("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"), "Comment 100 Times" },
                    { new Guid("24e0f221-e9a0-4c4d-a71d-1ed16ad6d36a"), "Wishlist 100 Games" },
                    { new Guid("2d3fcb09-5a7c-4268-9d86-248eb28a166d"), "Like 500 Posts" },
                    { new Guid("348ea355-5d52-4120-8794-b9022b4d3172"), "Wishlist 250 Games" },
                    { new Guid("45a6e417-48aa-4ad8-8b89-0bc72c4edb62"), "Ultimate Streak (365-day streak)" },
                    { new Guid("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"), "Post 100 Threads" },
                    { new Guid("5291fbd1-9926-4904-92bc-7f36c738c189"), "Post 50 Threads" },
                    { new Guid("52cb47a2-2d10-4662-a36d-4f3fefca498b"), "Complete Profile (Fill all fields)" },
                    { new Guid("56e5cd8d-2d46-45dc-9006-f71920beea40"), "Buy 10 Games" },
                    { new Guid("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"), "Follow 100 Developers" },
                    { new Guid("61a86ea6-3db1-4a99-afe8-dbd178470cc2"), "Wishlist 50 Games" },
                    { new Guid("6a95c38c-e765-4a9b-9adf-d640eeedb214"), "Buy 500 Games" },
                    { new Guid("6b8a7ab1-bb17-4958-91c6-ff6d7a2ea880"), "Streak Master (30-day login streak)" },
                    { new Guid("6e1ea6cb-8d1d-4b4b-9316-195270d92c0f"), "Wishlist 1000 Games (Platinum)" },
                    { new Guid("6fc5791d-b726-41df-b524-d5286f316d69"), "Bug Hunter (Report 10 bugs)" },
                    { new Guid("70e2f6b1-b748-4ce7-8b71-84995c37cd3c"), "Like 250 Posts" },
                    { new Guid("72b6b5e2-bff5-49ec-9770-b7a0bfa452f8"), "Critic (Write 50 reviews)" },
                    { new Guid("79447ee2-7653-4b48-90db-8c4a607b9db9"), "Legendary Tastemaker (Get 1000 likes on a post)" },
                    { new Guid("8232bff1-9cc1-4b1d-aabd-03cf0b3b2448"), "Post 500 Threads" },
                    { new Guid("8d1c8d65-2d84-4c86-a5b1-16de0aee3a34"), "Follow 1000 Developers (Platinum)" },
                    { new Guid("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"), "Like 10 Posts" },
                    { new Guid("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"), "Buy 50 Games" },
                    { new Guid("9e9c76d3-8d24-4f14-aaf1-c85cbb20c29d"), "Reviewer (Write 10 reviews)" },
                    { new Guid("a67ae3f1-e9fd-47cd-bc80-9a51753f52f1"), "Wishlist 10 Games" },
                    { new Guid("a76b7914-3d28-4bb9-8a6e-96f3953447e3"), "Comment 250 Times" },
                    { new Guid("a94e99cb-9a99-4d4f-879b-4fa2f4b8a4c7"), "Buy 1000 Games (Platinum)" },
                    { new Guid("ae30b8aa-cf63-474d-b42c-9b8e4479b31b"), "Follow 500 Developers" },
                    { new Guid("b0ea7c96-6d5c-4199-9029-7f04e7502f66"), "Post 10 Threads" },
                    { new Guid("b186aeb1-033f-4937-a24c-d11b1989e7e2"), "Follow 50 Developers" },
                    { new Guid("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"), "Follow 10 Developers" },
                    { new Guid("bbf75b11-92d5-4bcf-8c2e-bb0c6a9b50e5"), "Comment 1000 Times (Platinum)" },
                    { new Guid("bdde7288-0ec3-4726-9760-c802f4527c45"), "Like 1000 Posts (Platinum)" },
                    { new Guid("ccae8845-7497-4cb9-9a0c-cd5102ce08f2"), "Tastemaker (Get 100 likes on a post)" },
                    { new Guid("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"), "Like 100 Posts" },
                    { new Guid("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"), "Comment 50 Times" },
                    { new Guid("de08b771-763c-4e33-a97f-c627a2e790df"), "Buy 100 Games" },
                    { new Guid("e1719829-fd9f-4a14-bfe4-6d524b01300b"), "Post 1000 Threads (Platinum)" },
                    { new Guid("e4a10952-4869-499e-90f2-743ef6ad2c0c"), "Explorer (Visit all categories)" },
                    { new Guid("ec14ae35-0147-470e-a927-03b999924b53"), "Follow 250 Developers" },
                    { new Guid("ee7743cf-fdb3-4abf-85b1-9fa84b33fd06"), "Top Fan (Like 100+ posts in a month)" },
                    { new Guid("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"), "Comment 10 Times" },
                    { new Guid("f9d84647-6f77-4684-a39c-f5e671c181a1"), "Post 250 Threads" },
                    { new Guid("fbdc5b33-eef1-42aa-897f-e8f7de9f3179"), "Buy 250 Games" },
                    { new Guid("fef0c70d-cf7b-4c90-9865-383e660fda8a"), "First Purchase" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b18f50e-1548-479f-958e-054ea10880a7", new DateTime(2025, 6, 1, 0, 17, 32, 110, DateTimeKind.Utc).AddTicks(7792), "AQAAAAIAAYagAAAAEB7CnYoBVRnUG7dWI3uatei1IrTt6WMm94gR70/f1XSz8tgPrK7F4/Dn+7SIIJ8dYQ==", "ffc6134f-09b9-450e-987c-060d02c81253" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa8c3c03-5052-4e4c-af72-be339743dbd9", new DateTime(2025, 6, 1, 0, 17, 32, 159, DateTimeKind.Utc).AddTicks(6024), "AQAAAAIAAYagAAAAEKGSC3jmQ+GHHFjLd5xV+Z0lpnV1aGWWCLT0iy7InDQqt53tB7AP4r2WkplDoMhtiw==", "713ef8e0-6955-4bcb-bcd8-c5720422ca79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42b76f03-de47-4bd2-96c3-7d82ab3e7143", new DateTime(2025, 6, 1, 0, 17, 32, 209, DateTimeKind.Utc).AddTicks(6477), "AQAAAAIAAYagAAAAEKJt9wPkrDwwTzBVxLn0ACresBbczo6sg4tpKv5Q50k5EB7zwo/KrJk50e+cO1OBHw==", "64d280fa-773b-49dc-afdf-222e4bd3c0dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66626e74-832b-40b5-be54-fe6a5f03fc05", new DateTime(2025, 6, 1, 0, 17, 32, 62, DateTimeKind.Utc).AddTicks(2589), "AQAAAAIAAYagAAAAECAsFlgYn6v38GUdE0D86YidhdhCRuZVdUyHZSzi/J8u2j73wDVbpsMhrQLjv6fw/Q==", "9e1c21e8-9502-407c-9494-2862ea00a4f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d6a1b04-c033-4128-a9ca-ad39a4a9beaf", new DateTime(2025, 6, 1, 0, 17, 32, 261, DateTimeKind.Utc).AddTicks(3179), "AQAAAAIAAYagAAAAEAJl0LjZxpM4L4a3omZtBwkY7oG5VGBbJdg8iVsJEM9Zq50iiJsfTxZdeQKJLLxR/Q==", "9b07d113-c84c-44c1-9728-9ee86007467c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e2f980-c9a0-4a5a-ab81-7dcb927386a1", new DateTime(2025, 6, 1, 0, 17, 32, 11, DateTimeKind.Utc).AddTicks(5916), "AQAAAAIAAYagAAAAELyaTVrXx4W62Ron5mA5Kq6Q2FMGeYZkE7+DeIbGFfd+d9DLARWF8l4Hi4EDaXkJfQ==", "c61958af-d955-4190-b66a-b15520281c06" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("592e7334-c896-46f6-ad6c-a781a2ab7219"),
                column: "Name",
                value: "Card Game");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39b71d75-ed24-461a-8dbf-e4fa9ae425fc"), "Platformer" },
                    { new Guid("5e1afbc9-31dd-417d-ae49-baa45d6d5797"), "Educational" },
                    { new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), "Visual Novel" },
                    { new Guid("a5a8e1af-bbea-4029-99fe-42912e7c7ba2"), "Rhythm" },
                    { new Guid("cd1fb8a2-c34e-4fc4-bbbd-9931a0c6ce0e"), "Interactive Fiction" }
                });

            migrationBuilder.InsertData(
                table: "CommercialPackages",
                columns: new[] { "Id", "Description", "Duration", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0efbfb71-599d-4233-a598-1595615810e1"), "Displays a banner on a category page for 7 days.", 7.0, "Category Banner - Weekly", 60000.0 },
                    { new Guid("4bfbc5f2-bef6-44ff-a5c4-baaff953f651"), "Displays a banner on the homepage for 7 days.", 7.0, "Homepage Banner - Weekly", 80000.0 },
                    { new Guid("854bb0e5-ecf6-4bc8-a5f7-1d9e27d27e73"), "Displays a banner on a category page for 1 day.", 1.0, "Category Banner - Daily", 10000.0 },
                    { new Guid("856314ae-b364-4d83-94ba-f11600c88cff"), "Displays a banner on the homepage for 1 day.", 1.0, "Homepage Banner - Daily", 20000.0 },
                    { new Guid("8f451273-fe64-4c67-80e9-84ee20733ddd"), "Displays a banner on the homepage for 30 days.", 30.0, "Homepage Banner - Monthly", 310000.0 },
                    { new Guid("a9758e65-b0d6-4dd1-8272-fe1f2cb4794e"), "Displays a banner on a category page for 30 days.", 30.0, "Category Banner - Monthly", 230000.0 }
                });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 11), new DateOnly(2025, 6, 1) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 7, 17, 31, 998, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.InsertData(
                table: "ReportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c0d2f16-1f4a-4c5e-9c26-2e86e0cfa28f"), "GameReport" },
                    { new Guid("77cf1c6b-bc98-4c98-8a7e-27f2c4b45377"), "UserReport" },
                    { new Guid("8b92d32e-0aa0-4f88-bc43-0e04c4121e0e"), "PostReport" }
                });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a137e663-30d5-4ed9-8aa3-b9b500f18de7"),
                column: "Name",
                value: "Card Game");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("048cbb0b-d39e-4f1d-b1d7-e28aeb6fc6e6"), "Grayscale" },
                    { new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3"), "First-Person" },
                    { new Guid("130d3ae5-7c92-4d37-9082-13226dd0d9af"), "Platformer" },
                    { new Guid("229ef81c-f48f-49ae-a9a1-149f71d54d77"), "Showcase 🎨" },
                    { new Guid("22ad33b0-8358-4054-aa6b-59a2b5296842"), "Isometric" },
                    { new Guid("3e7412cc-2817-4d03-9dcf-7c3c7e619186"), "16-Bit" },
                    { new Guid("48239920-0a09-438e-8320-6b822e01f8bb"), "Two Colors" },
                    { new Guid("5452906a-03b1-45df-b4f0-a65398885171"), "Visual Novel" },
                    { new Guid("569a2ff2-5259-4467-9824-a3f2c5a595f7"), "1-Bit" },
                    { new Guid("611e1869-df31-4ec1-b063-7c9ae49bfb30"), "RPG Maker" },
                    { new Guid("621f12a7-89cb-4b97-83c0-cd3e84774dd4"), "Third-Person" },
                    { new Guid("62c2fe13-f1d2-4905-b3e1-166598e091fb"), "8x8" },
                    { new Guid("6cc4c52b-3b0e-4641-9997-8a1e6c29753b"), "Godot" },
                    { new Guid("7cc2168e-4ad6-409f-9868-bd59df589d8c"), "Guide 📖" },
                    { new Guid("7d5d4e96-d0fa-440e-914f-1667b6ef54c1"), "Unreal Engine" },
                    { new Guid("7e3be5eb-bf83-4450-9ecb-70535267d3ea"), "Flat-Shading" },
                    { new Guid("85a1abde-9980-4cc7-976e-1d4135ffddff"), "Review ★" },
                    { new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac"), "Colorful" },
                    { new Guid("8c202501-893d-427e-9faf-47e2f1d6ba2d"), "Educational" },
                    { new Guid("8db1d14f-c82c-4a06-bd60-456350a62594"), "Non-Eucledian" },
                    { new Guid("8fdfc2fc-b9ae-49a4-9aa5-e986cdf9f65a"), "Neon" },
                    { new Guid("9636813b-f393-4adb-b9a7-44f877f67ae5"), "8-Bit" },
                    { new Guid("9c685bd3-c75f-48df-8043-20c2fe181e7f"), "Watercolor" },
                    { new Guid("a0f1e28b-a439-4e72-aed8-0baddbb515c2"), "Rhythm" },
                    { new Guid("aa580b0a-12c6-4d95-8d4f-c68fdd8cfbd9"), "32x32" },
                    { new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769"), "Cartoon" },
                    { new Guid("b6dd9e32-eaf5-4942-9c18-566421ca2e90"), "Top-Down" },
                    { new Guid("bc50196f-6aa1-49c2-9347-33f4ef15b8d6"), "Black and White" },
                    { new Guid("cd37e2fc-cb7e-45c3-90d6-87c690a2aaf3"), "Ren’Py" },
                    { new Guid("da2b3f32-20fc-4a62-a16f-f87fbe4696fb"), "Question ❓" },
                    { new Guid("e27b19a2-12d7-4a55-a8e4-7ff3487db712"), "Pastel" },
                    { new Guid("e4e35307-2071-4a75-88fc-579db0077703"), "Unity" },
                    { new Guid("e50d38ef-93f6-4f52-a55b-0dbf8188f91f"), "Discussion 💬" },
                    { new Guid("f3527a12-03c3-417d-9dd1-6130e7fcfe3e"), "16x16" },
                    { new Guid("f503a37e-dff0-45a8-8ae8-58ccefa4c9d3"), "Low-Poly" },
                    { new Guid("f57af0bf-7612-4b08-84f3-be98a842f932"), "Interactive Fiction" },
                    { new Guid("f8d13d4f-1a7b-406b-aa6e-4f37d8cebacf"), "Hand-Drawn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0d8f0c15-cdb8-4f99-a84e-d749474f9f98"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0f7b9b0f-f527-43cc-92f1-92fe4d03d09d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("10b1990c-cce0-45ed-bcfd-d86ed7a3ae1c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("187f58aa-ecc1-4e65-9b76-f3fe37213ae3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1a7902b5-b931-4050-a0bc-4df6bbd0b2a1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1fc7e4c8-6a14-4b10-a54f-28c14a5bfae4"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2190f97e-1533-4c91-9152-f7ae9ec6f8c0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("24e0f221-e9a0-4c4d-a71d-1ed16ad6d36a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2d3fcb09-5a7c-4268-9d86-248eb28a166d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("348ea355-5d52-4120-8794-b9022b4d3172"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("45a6e417-48aa-4ad8-8b89-0bc72c4edb62"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("47c0b28f-43d2-496e-bfcb-f9df5aa2048d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5291fbd1-9926-4904-92bc-7f36c738c189"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("52cb47a2-2d10-4662-a36d-4f3fefca498b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("56e5cd8d-2d46-45dc-9006-f71920beea40"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5a8d9a1a-4b12-464b-8a70-d0309c3f355d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("61a86ea6-3db1-4a99-afe8-dbd178470cc2"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6a95c38c-e765-4a9b-9adf-d640eeedb214"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6b8a7ab1-bb17-4958-91c6-ff6d7a2ea880"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6e1ea6cb-8d1d-4b4b-9316-195270d92c0f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6fc5791d-b726-41df-b524-d5286f316d69"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("70e2f6b1-b748-4ce7-8b71-84995c37cd3c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("72b6b5e2-bff5-49ec-9770-b7a0bfa452f8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("79447ee2-7653-4b48-90db-8c4a607b9db9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8232bff1-9cc1-4b1d-aabd-03cf0b3b2448"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8d1c8d65-2d84-4c86-a5b1-16de0aee3a34"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8e8cbf44-001f-4060-bd8a-bc6213a81cc0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9c60bc27-9c8a-4be3-9e0d-1f4e96cb59a7"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9e9c76d3-8d24-4f14-aaf1-c85cbb20c29d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a67ae3f1-e9fd-47cd-bc80-9a51753f52f1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a76b7914-3d28-4bb9-8a6e-96f3953447e3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a94e99cb-9a99-4d4f-879b-4fa2f4b8a4c7"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ae30b8aa-cf63-474d-b42c-9b8e4479b31b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b0ea7c96-6d5c-4199-9029-7f04e7502f66"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b186aeb1-033f-4937-a24c-d11b1989e7e2"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b83dc1f6-cc35-4955-9a5d-3ae89a90e5d6"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("bbf75b11-92d5-4bcf-8c2e-bb0c6a9b50e5"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("bdde7288-0ec3-4726-9760-c802f4527c45"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ccae8845-7497-4cb9-9a0c-cd5102ce08f2"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d49ff353-2b75-4879-8a0b-4d7c16ed4a69"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d55f9b9a-d660-4c9a-bc35-94d7ef5a4eb3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("de08b771-763c-4e33-a97f-c627a2e790df"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e1719829-fd9f-4a14-bfe4-6d524b01300b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e4a10952-4869-499e-90f2-743ef6ad2c0c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ec14ae35-0147-470e-a927-03b999924b53"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ee7743cf-fdb3-4abf-85b1-9fa84b33fd06"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f3e1b3e3-9ac3-41e3-83a6-83b44b76446b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f9d84647-6f77-4684-a39c-f5e671c181a1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fbdc5b33-eef1-42aa-897f-e8f7de9f3179"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fef0c70d-cf7b-4c90-9865-383e660fda8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39b71d75-ed24-461a-8dbf-e4fa9ae425fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e1afbc9-31dd-417d-ae49-baa45d6d5797"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5a8e1af-bbea-4029-99fe-42912e7c7ba2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd1fb8a2-c34e-4fc4-bbbd-9931a0c6ce0e"));

            migrationBuilder.DeleteData(
                table: "CommercialPackages",
                keyColumn: "Id",
                keyValue: new Guid("0efbfb71-599d-4233-a598-1595615810e1"));

            migrationBuilder.DeleteData(
                table: "CommercialPackages",
                keyColumn: "Id",
                keyValue: new Guid("4bfbc5f2-bef6-44ff-a5c4-baaff953f651"));

            migrationBuilder.DeleteData(
                table: "CommercialPackages",
                keyColumn: "Id",
                keyValue: new Guid("854bb0e5-ecf6-4bc8-a5f7-1d9e27d27e73"));

            migrationBuilder.DeleteData(
                table: "CommercialPackages",
                keyColumn: "Id",
                keyValue: new Guid("856314ae-b364-4d83-94ba-f11600c88cff"));

            migrationBuilder.DeleteData(
                table: "CommercialPackages",
                keyColumn: "Id",
                keyValue: new Guid("8f451273-fe64-4c67-80e9-84ee20733ddd"));

            migrationBuilder.DeleteData(
                table: "CommercialPackages",
                keyColumn: "Id",
                keyValue: new Guid("a9758e65-b0d6-4dd1-8272-fe1f2cb4794e"));

            migrationBuilder.DeleteData(
                table: "ReportTypes",
                keyColumn: "Id",
                keyValue: new Guid("1c0d2f16-1f4a-4c5e-9c26-2e86e0cfa28f"));

            migrationBuilder.DeleteData(
                table: "ReportTypes",
                keyColumn: "Id",
                keyValue: new Guid("77cf1c6b-bc98-4c98-8a7e-27f2c4b45377"));

            migrationBuilder.DeleteData(
                table: "ReportTypes",
                keyColumn: "Id",
                keyValue: new Guid("8b92d32e-0aa0-4f88-bc43-0e04c4121e0e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("048cbb0b-d39e-4f1d-b1d7-e28aeb6fc6e6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("130d3ae5-7c92-4d37-9082-13226dd0d9af"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("229ef81c-f48f-49ae-a9a1-149f71d54d77"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("22ad33b0-8358-4054-aa6b-59a2b5296842"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3e7412cc-2817-4d03-9dcf-7c3c7e619186"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("48239920-0a09-438e-8320-6b822e01f8bb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5452906a-03b1-45df-b4f0-a65398885171"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("569a2ff2-5259-4467-9824-a3f2c5a595f7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("611e1869-df31-4ec1-b063-7c9ae49bfb30"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("621f12a7-89cb-4b97-83c0-cd3e84774dd4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("62c2fe13-f1d2-4905-b3e1-166598e091fb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6cc4c52b-3b0e-4641-9997-8a1e6c29753b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7cc2168e-4ad6-409f-9868-bd59df589d8c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7d5d4e96-d0fa-440e-914f-1667b6ef54c1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7e3be5eb-bf83-4450-9ecb-70535267d3ea"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("85a1abde-9980-4cc7-976e-1d4135ffddff"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8c202501-893d-427e-9faf-47e2f1d6ba2d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8db1d14f-c82c-4a06-bd60-456350a62594"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8fdfc2fc-b9ae-49a4-9aa5-e986cdf9f65a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9636813b-f393-4adb-b9a7-44f877f67ae5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9c685bd3-c75f-48df-8043-20c2fe181e7f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a0f1e28b-a439-4e72-aed8-0baddbb515c2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aa580b0a-12c6-4d95-8d4f-c68fdd8cfbd9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b6dd9e32-eaf5-4942-9c18-566421ca2e90"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bc50196f-6aa1-49c2-9347-33f4ef15b8d6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cd37e2fc-cb7e-45c3-90d6-87c690a2aaf3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("da2b3f32-20fc-4a62-a16f-f87fbe4696fb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e27b19a2-12d7-4a55-a8e4-7ff3487db712"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e4e35307-2071-4a75-88fc-579db0077703"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e50d38ef-93f6-4f52-a55b-0dbf8188f91f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f3527a12-03c3-417d-9dd1-6130e7fcfe3e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f503a37e-dff0-45a8-8ae8-58ccefa4c9d3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f57af0bf-7612-4b08-84f3-be98a842f932"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f8d13d4f-1a7b-406b-aa6e-4f37d8cebacf"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f7b5fd3-2bc2-4974-bb14-83cb3faf6eb2", new DateTime(2025, 5, 31, 15, 45, 28, 183, DateTimeKind.Utc).AddTicks(5640), "AQAAAAIAAYagAAAAEFpp1tbHStM2vp5dXH+vHORMaUFxl9n6+iVOiWhPOSjJzZQaiWp3z5h791IpA7gfCA==", "8de2cd85-5312-429e-aa8f-09ed24166910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4b4e56d-76c3-4246-bfb3-256264bd9dad", new DateTime(2025, 5, 31, 15, 45, 28, 241, DateTimeKind.Utc).AddTicks(3391), "AQAAAAIAAYagAAAAEMpt3E6vtqBzcl+22uGtLX4owbonkRYGkxLqkyF0d6uWYZTKFpAjcQIBetyZdYp1sg==", "804d77db-979f-4bbc-8a5b-2184a05bf268" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2d453c9-5978-4ce7-bd3c-bac085158920", new DateTime(2025, 5, 31, 15, 45, 28, 303, DateTimeKind.Utc).AddTicks(8394), "AQAAAAIAAYagAAAAEAltCgfadmBMb87t16rKpxV5PHp2laoXjYNLukouQSZKBFhBEW7w4HGNLkrZxmmNyg==", "879867be-15f7-46e7-85d2-ef31840f6ca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb2e8f4-7c86-4d27-96b8-2749234dec98", new DateTime(2025, 5, 31, 15, 45, 28, 126, DateTimeKind.Utc).AddTicks(8849), "AQAAAAIAAYagAAAAENfTGxjSontpJWmwFM1Gl5xowRdKhBsTy0gzwJzkUpbNt+Y1iE5/Rbu4843QT3uoAg==", "533f8b49-e0de-40a1-be32-7c3d96f71fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fefe2dba-c54e-47f8-bc0a-05b07caaf625", new DateTime(2025, 5, 31, 15, 45, 28, 360, DateTimeKind.Utc).AddTicks(6550), "AQAAAAIAAYagAAAAELtyNBwsYthX6zjEHZtycukG9vMUsZ9yLn2qmfnuoLHYzkpktY3/9PpiGkUGeYTD4A==", "ea0123fd-3922-4063-ac20-e9fe4e4b0df1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "751de255-8fc8-48a3-af61-a221c89ddbf2", new DateTime(2025, 5, 31, 15, 45, 28, 70, DateTimeKind.Utc).AddTicks(5846), "AQAAAAIAAYagAAAAEJJZeqquVNuNF8le/0h7zq/38l/nTE8XWKiNLQgIwngWzG+kO0puFhigmKjvDKazsg==", "70761139-3557-429c-8cae-bf7e7ea5ce90" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("592e7334-c896-46f6-ad6c-a781a2ab7219"),
                column: "Name",
                value: "BoardGame");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3ef51667-ff8d-4873-979b-a3b9a5dbe1b1"), "Horror" },
                    { new Guid("dcf41a71-dd69-43db-af34-a8ca8592b079"), "Open World" },
                    { new Guid("fcb43570-6859-41f4-8d72-ce59a31f5858"), "Stealth" }
                });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 10), new DateOnly(2025, 5, 31) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 5, 31, 22, 45, 28, 55, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a137e663-30d5-4ed9-8aa3-b9b500f18de7"),
                column: "Name",
                value: "BoardGame");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("72229e67-bba2-41ae-9fee-84c97d01d1fb"), "MacOS Game" },
                    { new Guid("78530cfe-1488-49ab-befb-0ee332cfe7a1"), "Open World" },
                    { new Guid("83f90ed3-38f1-40a9-88e5-8ce4a728a4a4"), "Kungfu" },
                    { new Guid("9f3617ec-c56d-4423-ad07-43c904ef6542"), "Stealth" },
                    { new Guid("a39f8614-3936-48cf-bb4a-01c590486bdc"), "Indie" },
                    { new Guid("b92d60b0-0447-4ef2-9233-088b4d91cce5"), "Horror" },
                    { new Guid("c620e06f-49b2-4cc7-8be5-19d63e8d915a"), "Linux Game" },
                    { new Guid("cb631ff7-d19b-40a5-b948-a3b138703e19"), "Windows Game" }
                });
        }
    }
}
