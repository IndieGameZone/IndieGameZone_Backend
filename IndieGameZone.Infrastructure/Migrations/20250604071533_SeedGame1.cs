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
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("07ea50a1-67a4-4827-a9ec-87076fcf03c3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0949ea2f-3012-41e7-830a-85b71a1a0c46"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0b058f85-e3e0-4cd9-95ad-cb7ec0857e3d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0d14053a-5761-49f1-bc73-86f2fe097373"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("18c5be9a-7a63-4b57-a640-5b5e09400955"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1c40cc4e-4334-4130-b56d-e68657f1df6a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("24c6d152-3e2f-4d02-933d-63e85a27081a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("265b4035-41fc-4a0a-a3b4-e901e82c7689"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2b158ea6-3ab6-46d7-80cc-cf35d93929d7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("32573ac1-e5ab-4546-ad87-0b837270662c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35d27929-a2bb-4573-8a92-4c69dbb5df13"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e0a38d2-fb6c-443f-92ca-2e53e62a61d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("44518daf-b9f8-410b-87ce-8a97bc5abc85"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4fd9dbd9-29f7-4719-9675-eed5e452cdc2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("67a4a329-1816-4762-ab1f-6dbe8a4859a6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7175a006-e7e4-4b0f-a839-a747c71437f8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7e664e60-d9ef-49cf-b15e-04ef7794ff8c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("83a9e011-69aa-4b1e-bf56-8f9f51ac23dd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("86064f5b-fc05-4058-a6eb-46d66352e7c0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a711e6fe-80b6-45d6-a5dc-d058218c899a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b0dcd49b-380c-4117-81ca-3df3c524941a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b124b5d1-4e98-4129-8573-12fcbdd29dab"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("babd105f-82f4-485b-baf3-400b4a7e4ea3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bbc61c64-fa64-4eb8-ab0b-f18014c4c2c3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c70e309b-4038-4f48-80f2-55067f552f71"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d6045d8d-c215-412f-8921-d3d9273b5f84"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e879af8b-6859-4a2a-bb8f-32610b2b6b4c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ec135ce9-55d8-46a1-8b9e-1e109d94594f"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afa7e109-aefa-43b9-8c1e-38eea6077101", new DateTime(2025, 6, 4, 14, 15, 32, 179, DateTimeKind.Local).AddTicks(2932), "AQAAAAIAAYagAAAAEOFYooouEZAlBlje6qileuPDmBukqXxVJ/oyJcqD/jRbQG1kZgxj/lc0ba1kTTCFXg==", "14849b31-7c02-47be-ba16-063f91a6712b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2708975b-66ba-48c7-b552-95f07c3dc027", new DateTime(2025, 6, 4, 14, 15, 32, 237, DateTimeKind.Local).AddTicks(839), "AQAAAAIAAYagAAAAEPCjme9EryyXAcNEoWopkYmQ4Ka5yhOS+948rXF30v1UE2DThQ1c2gIbQ8s7AC1DDA==", "2936b81e-5118-4f2f-893c-c9709cc17e3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87dbfe41-f173-4575-9f17-74e094b04480", new DateTime(2025, 6, 4, 14, 15, 32, 295, DateTimeKind.Local).AddTicks(9253), "AQAAAAIAAYagAAAAEHJN5VjJx551K4Q7JFnFiyGRYvf6maq6OrxkNc8reULRWt0/4mhz6Y10uwfHChNkbw==", "b2eaffb2-485d-4ea3-b9fe-925542e60a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "051d8b91-5161-490f-a251-14b7f912bebb", new DateTime(2025, 6, 4, 14, 15, 32, 120, DateTimeKind.Local).AddTicks(6845), "AQAAAAIAAYagAAAAEGk9x74EQt1SA387TBfY7aeH90Vv+k6UvX3aVWaQokZVWewNXk9y1MjUJU4EKqKk2w==", "11bc65f7-4ec9-40a6-9a70-81ad519df8f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f0b7b9-d733-4a02-8070-77bd877d5586", new DateTime(2025, 6, 4, 14, 15, 32, 352, DateTimeKind.Local).AddTicks(3458), "AQAAAAIAAYagAAAAEMwpXjvmNbiAcofgHeR8VKtIFi94bp+OkF7zqcXQiO1yrdKyyi7KoX8+zvJJfFNBWA==", "84208e76-990e-4881-9560-68218b3c92c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78fbf3be-1433-4836-af99-1f844b01f402", new DateTime(2025, 6, 4, 14, 15, 32, 57, DateTimeKind.Local).AddTicks(2654), "AQAAAAIAAYagAAAAEH2mncQelbR0lEdAA/D37QiZP3r5wp5T0kKjq9XGJ7Cc++dnCLHpfI07RY7+TGbSBw==", "31bec706-1ec3-495a-bfe6-64d43490e416" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 14), new DateOnly(2025, 6, 4) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("06c8b923-82d1-4654-b4e3-85faf59470c5"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("0d278ce6-7f0b-4e69-b558-08f44168d3b8"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("17066100-a226-4002-8c61-081bd1ae24cd"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("189bab57-c14a-4499-bdf7-4dd448d6e0b9"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("1f94aacd-f640-4a1d-808d-29890e14f163"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("3930a303-81c7-4de5-a4de-6cc2b98821ec"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("3ab32ab7-a6fe-49b1-9833-13209da795b1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("51f95788-8118-44b9-aa43-cdffd1a77f20"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("5d5544aa-684c-4dff-bd92-182042ed5982"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("604bd66d-bc92-4e0a-a763-54b1614d55e6"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("6c3ca4c1-ebf5-488c-a46e-b8bab59937ec"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("7a9bdfa2-0405-4061-b962-c9f1e3649406"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("8bfcdf30-c0ad-47ec-ac5e-2103f856e43c"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("8d580953-0b4b-49d2-b335-376c867d8c02"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("8db1ce64-3235-4e8a-9014-a34813825d1b"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("94268a39-64f1-4c26-ba89-ae95bbb278f8"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("9e278a72-f463-46b0-8501-495c32a2e051"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("a1d2232a-3be5-47fa-b8ad-57d140880ed3"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("a43fb7be-2f09-4678-b22e-047b3c863b27"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("b8a3112b-c77e-4e51-aaff-350889d4efd1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("bc1718c0-41e2-4dc7-a840-5de6b5371bd8"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("d0d7f385-de91-44ca-8eee-40ba3681aa87"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("dd8d6b2c-634c-4b5a-b99f-eeca488aa300"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("e90e92c0-6ee6-4589-b99d-202afde62e1f"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("ede4a34f-dd2d-4d4d-abd0-147bfe8ff2c4"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("f5f5ad76-e107-46e5-90af-7a6e751f207c"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("f9098053-137d-4a8a-b9b0-bb434f9547fb"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("f95d32d8-c5d8-4ca8-8480-39dabdb8daa0"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { true, new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { true, new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { true, new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { true, new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { true, new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRestrictionId", "AllowDonation", "AverageSession", "CategoryId", "CensoredAt", "CoverImage", "CreatedAt", "Description", "DeveloperId", "Name", "Price", "Status", "UpdatedAt", "VideoLink" },
                values: new object[,]
                {
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("dfeeb47a-7e69-4927-a65b-b803a8befe9f"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage.png", new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(157), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "Thunderhead", 90000.0, 1, null, "https://www.youtube.com/watch?v=c8JdCXw4l3k" },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 2.0, new Guid("7a03afa3-2635-43bd-a58c-daeb80d3cef7"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage.png", new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(152), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "Bloodmall", 80000.0, 1, null, "https://www.youtube.com/watch?v=1fYf3Rt7guw" },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 0.5, new Guid("2d740ce2-a803-4b32-8df8-ab5139203742"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage.png", new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(172), "", new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"), "DiggingHour", 85000.0, 1, null, "https://www.youtube.com/watch?v=tNoPejgMaB0" },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), false, 1.5, new Guid("77c89b32-78e3-4fea-915f-4b8df819ffa2"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage.png", new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(162), "", new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"), "Evaluation", 90000.0, 1, null, "" },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("c48f1c63-f301-44e9-8766-3d4b60134b5f"), true, 1.0, new Guid("bca8721b-c323-44a1-afcf-876e206ab035"), null, "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage.png", new DateTime(2025, 6, 4, 14, 15, 32, 43, DateTimeKind.Local).AddTicks(167), "", new Guid("34670beb-a794-4419-adf8-0465eea22a78"), "Dominoid", 95000.0, 1, null, "" }
                });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("2ab522a4-7486-4a81-a45c-8df4c5c97b76"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("343336fc-e431-4be6-a37c-155bee0126ab"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("4251bb90-466b-4e2c-87bf-f5bd38dfc5e8"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("45c28990-02f8-4f50-b095-5b5177b7d337"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("4a05ce56-e267-4026-8446-9d7f3625d1e2"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("50ba3f7b-c55b-4eea-bca6-6bfdd0a34476"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("7f9d68f1-4f52-4b95-8aec-1bacbc67fb8c"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("87fb5049-4136-4222-8359-4486e8c3c519"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("89ff10ec-279d-4df0-af2e-f51f49b7e235"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("8e5103c6-658f-456a-8a7f-7a372bf2d18f"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("932eca3e-ff81-4c82-8287-3cf4b82a4bb3"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("a76350d1-c55b-4443-86b1-124b7664c8da"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("b39a1dc6-4567-4ea9-94fb-ac1daa1041ea"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("c2850492-16a2-4032-8a55-7d3e7fbd3731"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("e799d212-f9eb-4ddb-8cf7-6a840a7f62e5"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("ea202560-82ad-47bb-8217-e74ea2fca2aa"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GameLanguages",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId", "File" },
                values: new object[,]
                {
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip" },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip" },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip" },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip" },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip" },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip" }
                });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "GameId", "TagId" },
                values: new object[,]
                {
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") },
                    { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") },
                    { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("06c8b923-82d1-4654-b4e3-85faf59470c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0d278ce6-7f0b-4e69-b558-08f44168d3b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("17066100-a226-4002-8c61-081bd1ae24cd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("189bab57-c14a-4499-bdf7-4dd448d6e0b9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1f94aacd-f640-4a1d-808d-29890e14f163"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2ab522a4-7486-4a81-a45c-8df4c5c97b76"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("343336fc-e431-4be6-a37c-155bee0126ab"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3930a303-81c7-4de5-a4de-6cc2b98821ec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3ab32ab7-a6fe-49b1-9833-13209da795b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4251bb90-466b-4e2c-87bf-f5bd38dfc5e8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("45c28990-02f8-4f50-b095-5b5177b7d337"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4a05ce56-e267-4026-8446-9d7f3625d1e2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("50ba3f7b-c55b-4eea-bca6-6bfdd0a34476"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("51f95788-8118-44b9-aa43-cdffd1a77f20"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5d5544aa-684c-4dff-bd92-182042ed5982"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("604bd66d-bc92-4e0a-a763-54b1614d55e6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6c3ca4c1-ebf5-488c-a46e-b8bab59937ec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7a9bdfa2-0405-4061-b962-c9f1e3649406"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7f9d68f1-4f52-4b95-8aec-1bacbc67fb8c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("87fb5049-4136-4222-8359-4486e8c3c519"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("89ff10ec-279d-4df0-af2e-f51f49b7e235"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8bfcdf30-c0ad-47ec-ac5e-2103f856e43c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8d580953-0b4b-49d2-b335-376c867d8c02"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8db1ce64-3235-4e8a-9014-a34813825d1b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8e5103c6-658f-456a-8a7f-7a372bf2d18f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("932eca3e-ff81-4c82-8287-3cf4b82a4bb3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("94268a39-64f1-4c26-ba89-ae95bbb278f8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9e278a72-f463-46b0-8501-495c32a2e051"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1d2232a-3be5-47fa-b8ad-57d140880ed3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a43fb7be-2f09-4678-b22e-047b3c863b27"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a76350d1-c55b-4443-86b1-124b7664c8da"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b39a1dc6-4567-4ea9-94fb-ac1daa1041ea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b8a3112b-c77e-4e51-aaff-350889d4efd1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bc1718c0-41e2-4dc7-a840-5de6b5371bd8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c2850492-16a2-4032-8a55-7d3e7fbd3731"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d0d7f385-de91-44ca-8eee-40ba3681aa87"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dd8d6b2c-634c-4b5a-b99f-eeca488aa300"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e799d212-f9eb-4ddb-8cf7-6a840a7f62e5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e90e92c0-6ee6-4589-b99d-202afde62e1f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ea202560-82ad-47bb-8217-e74ea2fca2aa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ede4a34f-dd2d-4d4d-abd0-147bfe8ff2c4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f5f5ad76-e107-46e5-90af-7a6e751f207c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f9098053-137d-4a8a-b9b0-bb434f9547fb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f95d32d8-c5d8-4ca8-8480-39dabdb8daa0"));

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("8f29f2a5-146d-44df-95ba-a972e36b7527") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

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
                keyValues: new object[] { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("0a0af88e-6860-445b-b7ce-b10f46e8dea3") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("3ef686ac-5e11-45d8-afab-223d2d149f6f") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("ab6e601e-52c3-45dc-97c3-1c6e84732769") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("b0c8f1d2-3e4a-4c5b-9f6d-7f8e9a0b1c2d") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("37223e27-41ad-44cb-9332-d985dbc9f708") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("ad95ed3f-284a-45d4-adc2-75b4f3681301") });

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumns: new[] { "GameId", "TagId" },
                keyValues: new object[] { new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("fcf4e928-dc77-405c-a13e-1d1d5e308d6b") });

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3387860-7a43-4f9e-9d59-3e5832bec2e9", new DateTime(2025, 6, 3, 23, 37, 4, 33, DateTimeKind.Local).AddTicks(3804), "AQAAAAIAAYagAAAAEFt+TqXG4JbdGynCXMw0jCOU+HojdDKaZE+LE14xtGicrWqQ9bC7cP1SF51UgON7DA==", "cad602e3-8793-4a30-b61f-be4704b3dcf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1881ff10-d1ff-4f43-8c0a-a63231e44858", new DateTime(2025, 6, 3, 23, 37, 4, 88, DateTimeKind.Local).AddTicks(7325), "AQAAAAIAAYagAAAAEDlLreFM3HkGX7JQ+5LKMJ7P99DLrtgf2zeiIwSrKlyz0COSrRNkw7AteOZyzDn7WQ==", "33da47f3-6686-4dfe-980f-4e16942fa4fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab7ab69-f0c8-4b17-8fd2-bcf1c86d0188", new DateTime(2025, 6, 3, 23, 37, 4, 145, DateTimeKind.Local).AddTicks(293), "AQAAAAIAAYagAAAAEMPU/7U75mNegDtnW1peW1gkVnP/FKtoJSrx6JfhfL6gSoG72YC6T7vinRqZwkkqFg==", "a692d5b3-b6ff-4859-97c9-3bb3db272ea6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "092c9cfc-30f0-47f5-a4d7-ca896a6fc2da", new DateTime(2025, 6, 3, 23, 37, 3, 974, DateTimeKind.Local).AddTicks(3105), "AQAAAAIAAYagAAAAEP9lOUxKqjnvi+dpF743sU9WRTnDVBa9P3KVyw4IY7znV3DmU6MfML6+3/GsGt3KXQ==", "e7bb5fa2-5b9f-49fd-80e1-6f1d3ed63712" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97bfa76f-2aeb-425f-b0ac-8ccdb29f5b8b", new DateTime(2025, 6, 3, 23, 37, 4, 199, DateTimeKind.Local).AddTicks(8015), "AQAAAAIAAYagAAAAEK0cjochOBRery5xDYh5U74FmHdjM7mO3Id+WXZQ8YAlRpsxZcGBSlbHBv2Xo1Racw==", "a037032a-c4a9-4ddc-ae58-0735654c9557" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7854ef7d-f596-4fa5-8c12-4a737d6a8716", new DateTime(2025, 6, 3, 23, 37, 3, 905, DateTimeKind.Local).AddTicks(289), "AQAAAAIAAYagAAAAEPQw9wgAu3DQGJ8dqalL8PWPwxufeYMeQ48wwbFiO6SUMDztAATJAa3OOS1QCE1LKQ==", "82369999-b6f2-4228-922b-40d80cd77b38" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 13), new DateOnly(2025, 6, 3) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("07ea50a1-67a4-4827-a9ec-87076fcf03c3"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("0949ea2f-3012-41e7-830a-85b71a1a0c46"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("0b058f85-e3e0-4cd9-95ad-cb7ec0857e3d"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("0d14053a-5761-49f1-bc73-86f2fe097373"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("18c5be9a-7a63-4b57-a640-5b5e09400955"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("1c40cc4e-4334-4130-b56d-e68657f1df6a"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("24c6d152-3e2f-4d02-933d-63e85a27081a"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("265b4035-41fc-4a0a-a3b4-e901e82c7689"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("2b158ea6-3ab6-46d7-80cc-cf35d93929d7"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("32573ac1-e5ab-4546-ad87-0b837270662c"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("35d27929-a2bb-4573-8a92-4c69dbb5df13"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("3e0a38d2-fb6c-443f-92ca-2e53e62a61d4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("44518daf-b9f8-410b-87ce-8a97bc5abc85"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("4fd9dbd9-29f7-4719-9675-eed5e452cdc2"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("67a4a329-1816-4762-ab1f-6dbe8a4859a6"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("7175a006-e7e4-4b0f-a839-a747c71437f8"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("7e664e60-d9ef-49cf-b15e-04ef7794ff8c"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("83a9e011-69aa-4b1e-bf56-8f9f51ac23dd"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("86064f5b-fc05-4058-a6eb-46d66352e7c0"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("a711e6fe-80b6-45d6-a5dc-d058218c899a"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("b0dcd49b-380c-4117-81ca-3df3c524941a"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("b124b5d1-4e98-4129-8573-12fcbdd29dab"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("babd105f-82f4-485b-baf3-400b4a7e4ea3"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("bbc61c64-fa64-4eb8-ab0b-f18014c4c2c3"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("c70e309b-4038-4f48-80f2-55067f552f71"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("d6045d8d-c215-412f-8921-d3d9273b5f84"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("e879af8b-6859-4a2a-bb8f-32610b2b6b4c"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("ec135ce9-55d8-46a1-8b9e-1e109d94594f"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 3, 23, 37, 3, 890, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { false, new DateTime(2025, 6, 3, 23, 37, 3, 891, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { false, new DateTime(2025, 6, 3, 23, 37, 3, 890, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 3, 23, 37, 3, 890, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 3, 23, 37, 3, 890, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { false, new DateTime(2025, 6, 3, 23, 37, 3, 891, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { false, new DateTime(2025, 6, 3, 23, 37, 3, 891, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 3, 23, 37, 3, 891, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "AllowDonation", "CreatedAt" },
                values: new object[] { false, new DateTime(2025, 6, 3, 23, 37, 3, 890, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 6, 3, 23, 37, 3, 891, DateTimeKind.Local).AddTicks(7));
        }
    }
}
