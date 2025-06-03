using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedGame1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e4cc8cbe-9b71-416d-967c-b88ad852be45"));

            migrationBuilder.DropColumn(
                name: "GameTypeId",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe96e0c7-d21c-4448-b967-60b07314f885", new DateTime(2025, 6, 3, 15, 59, 40, 468, DateTimeKind.Local).AddTicks(6230), "AQAAAAIAAYagAAAAEBjWrGY5pNuHeco9DWgAicW97/CzgIY9slVr2TaLcafVzVWjiw/oVJj518t3xmEvlQ==", "60de04b4-e35c-4036-8011-9f3926d4b162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7eeff78-9f8e-4dfb-a246-ec400d0625e9", new DateTime(2025, 6, 3, 15, 59, 40, 523, DateTimeKind.Local).AddTicks(1732), "AQAAAAIAAYagAAAAECnAWaBanf9KzXZBvVWYrngNUSm5uFBHYIUYpkFGLFEKjegDntXf9M8IiAO62iI1Ag==", "566eac88-447b-4800-8f85-49630d4ecac7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b80869d8-b874-4d0e-9d37-bc8a04bb6666", new DateTime(2025, 6, 3, 15, 59, 40, 578, DateTimeKind.Local).AddTicks(6133), "AQAAAAIAAYagAAAAEMrJOfnPMl5l6kwwoxoJoOdooel7S4PUeis/F1LTcfSAKti7ZcMdZwO6nDz0QDSZSA==", "882cf6a4-8b2a-43e2-9ace-f35e1558254d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d91184b8-d294-4dff-aeee-3cc809071fae", new DateTime(2025, 6, 3, 15, 59, 40, 409, DateTimeKind.Local).AddTicks(5651), "AQAAAAIAAYagAAAAEFTNZACCScb2w9So+40TIQJtbD728xeR8p0XdLpfUfCDMJXVNs2kk7v7JMNNHY/4BQ==", "08721586-4d2b-4758-b173-026593d455fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a5b3dd2-fac8-4724-8a51-11034309e6c9", new DateTime(2025, 6, 3, 15, 59, 40, 635, DateTimeKind.Local).AddTicks(5802), "AQAAAAIAAYagAAAAELhql7FOZSQPqONLBXCpYa37wqY5qieBJsMokYp6Mjxr8g9EWm7T6QuqbeALSYd12Q==", "adeebb24-f816-48e9-b2c2-12dcb3d26241" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1642477c-7062-4ef1-8f10-8a71e8fd1e62", new DateTime(2025, 6, 3, 15, 59, 40, 350, DateTimeKind.Local).AddTicks(4722), "AQAAAAIAAYagAAAAEJLxVFUNe5n+pA8xVDOYPEQ0DNGfBT4N0BWer0o1gV4SJzN+fbz1J7ww1AlbjUIZTA==", "bf1e9468-d49f-4ca8-8f8a-8da75411aa12" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 13), new DateOnly(2025, 6, 3) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 3, 15, 59, 40, 335, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRestrictionId", "AllowDonation", "AverageSession", "CategoryId", "CensoredAt", "CoverImage", "CreatedAt", "Description", "DeveloperId", "Name", "Price", "Status", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftCoverImage.png", new DateTime(2025, 6, 3, 15, 59, 40, 335, DateTimeKind.Local).AddTicks(9456), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "MidnightShift", 150000.0, 1, null, "https://www.youtube.com/watch?v=v1oeNEKiwTg" },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 3.0, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelicCoverImage.png", new DateTime(2025, 6, 3, 15, 59, 40, 335, DateTimeKind.Local).AddTicks(9463), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "Broken Relic", 200000.0, 1, null, "https://www.youtube.com/watch?v=ColSNi0XD6Q" },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/MoldwasherCoverImage.png", new DateTime(2025, 6, 3, 15, 59, 40, 335, DateTimeKind.Local).AddTicks(9471), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "Moldwasher", 120000.0, 1, null, "https://www.youtube.com/watch?v=6KGgPoY7TbY" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301"), "Singleplayer" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("0a0affde-17ee-42d3-81f8-dbb8be6da1ff"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("0d80c700-66a9-45f8-9a77-a9dc43f34dc6"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("196a0915-bf03-41bd-a3ee-d3d0da8e73d5"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("304ef258-1f9d-4523-b7e6-7d30f38b8567"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("5ed7fe66-4824-4a5f-96f7-4a5942e10506"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("91d31197-8c70-4495-9d3d-4f0ab06894cd"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("b054113c-17ce-48ee-8c37-7c69d4ece355"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("c16dca16-a581-43b0-ad7f-ea25a654128f"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("c52cf2d4-f060-471e-a7ba-b60da8cad43f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("e74d65e1-98ba-4860-8f73-0f8eabb07080"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GameLanguages",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId", "File" },
                values: new object[,]
                {
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip" },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip" },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip" },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip" },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip" }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "GameId", "TagId" },
                values: new object[,]
                {
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac") },
                    { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a0affde-17ee-42d3-81f8-dbb8be6da1ff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0d80c700-66a9-45f8-9a77-a9dc43f34dc6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("196a0915-bf03-41bd-a3ee-d3d0da8e73d5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("304ef258-1f9d-4523-b7e6-7d30f38b8567"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5ed7fe66-4824-4a5f-96f7-4a5942e10506"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("91d31197-8c70-4495-9d3d-4f0ab06894cd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b054113c-17ce-48ee-8c37-7c69d4ece355"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c16dca16-a581-43b0-ad7f-ea25a654128f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c52cf2d4-f060-471e-a7ba-b60da8cad43f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e74d65e1-98ba-4860-8f73-0f8eabb07080"));

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

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
                keyValues: new object[] { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("8c13bf31-2b82-4452-9a5c-2968c01e1dac") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("e4e35307-2071-4a75-88fc-579db0077703") });

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301"));

            migrationBuilder.AddColumn<Guid>(
                name: "GameTypeId",
                table: "Games",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a689c0d-a5db-4a12-b266-8e077c5c0670", new DateTime(2025, 6, 2, 9, 25, 52, 60, DateTimeKind.Local).AddTicks(2316), "AQAAAAIAAYagAAAAEPHkGDSVrJpN2D3zAuff5Btj8+D8u0DQsJj9BtmOmOhEKOtTxmGbc0HaCZZwhQg4fg==", "97570f3e-11ed-4317-8793-c968aa71c518" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc66032-616e-4fe3-be46-d8cc31fc14e0", new DateTime(2025, 6, 2, 9, 25, 52, 111, DateTimeKind.Local).AddTicks(1073), "AQAAAAIAAYagAAAAELEkhdr33ZDmW54/3eULnNe1XXwF56GOt+xoOlp2ibN1Xc7VazeQUqrbHP8ypa0jHg==", "b1d4ff72-7f02-4820-85b1-4fe95bfe2b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54cc1816-6dd1-486d-87db-184974f67c9c", new DateTime(2025, 6, 2, 9, 25, 52, 160, DateTimeKind.Local).AddTicks(9188), "AQAAAAIAAYagAAAAEBJvmUWRp3NTErRWTiqFX6so11KSbLgUCL4Plpnca2zvy058ulHJWgsM2LxTZFb+cA==", "2158a4c9-a6ff-44e4-a3c0-d288c636272a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "088726f7-c6a2-4283-b9c5-d62e4149b76a", new DateTime(2025, 6, 2, 9, 25, 52, 9, DateTimeKind.Local).AddTicks(9567), "AQAAAAIAAYagAAAAEJOoIHTwvikAvftvF/dcLVOy5RomYgOk6fg42qXRiwkbOEBWdg4EdVpe1pBiMsVpXg==", "16039620-1ff5-4576-bff2-9786adb27e3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "525f44f7-ad99-4596-86f8-d54da17c1977", new DateTime(2025, 6, 2, 9, 25, 52, 216, DateTimeKind.Local).AddTicks(8473), "AQAAAAIAAYagAAAAEAKYYQoeDAFoW62T+oLzLbgdHWDthTHjkCM2ZhoaCiGZOqBUJjXSoRWm8MT8XKCAqg==", "23b6762c-a9fe-43d1-8a98-b4eed1f5194b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc2307c-b0e2-484a-84c5-20624ed0cca2", new DateTime(2025, 6, 2, 9, 25, 51, 960, DateTimeKind.Local).AddTicks(366), "AQAAAAIAAYagAAAAEEDQ9lDw2sqg8CxscO3P3TxsGVx/65+PGRtbe+stjv56vwLvEmgn/YiUGGRjvMxJ/A==", "67a35ffd-bfe3-485a-ac7b-974ff8865cf6" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 12), new DateOnly(2025, 6, 2) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CreatedAt", "GameTypeId" },
                values: new object[] { new DateTime(2025, 6, 2, 9, 25, 51, 946, DateTimeKind.Local).AddTicks(7158), new Guid("92f9b646-d1db-4bd1-93ed-e5dc73ccd37e") });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e4cc8cbe-9b71-416d-967c-b88ad852be45"), "Singleplayer" });
        }
    }
}
