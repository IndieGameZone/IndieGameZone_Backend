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
                name: "FK_PostImages_Posts_PostId",
                table: "PostImages");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReactions_Posts_PostId",
                table: "PostReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("009f8e61-ea3d-453e-9cf1-967f8b1384b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("06643cb5-18b4-46da-8330-51256fe31b33"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0771411c-2539-4c14-9ad8-02fb6aa1762e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0846fa87-0028-441d-859a-3ee5d6c6e344"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("08722182-9d52-4b2d-8f51-053ad38be497"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a493f3a-1a27-40b8-a854-9a6a4a8d1fa7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("163d64cb-5cbe-479d-953a-8ebb409f844f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("19b8cfc3-b54b-4b5c-a925-c3b1c82bf28f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("210d1c28-2a44-4623-a4de-91c1aedaea73"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("23e8b769-e867-4796-861e-e192d68b7158"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2d01f26d-7c27-4708-a98f-2e1969900828"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("323e6f80-732d-42d0-b5fa-1eb0f7963da2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35c5bb98-846e-4496-88c9-fec0cc6a972c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35d5319f-6e35-4883-90be-22f44aa876cf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("38c1abc2-959b-4225-9192-66d77796de73"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3d24e31b-32b5-4bc1-82bd-d9ea6fe18cf6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("40eee9bc-cd83-442e-bdae-93a04b20271b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4b5e0e25-3f5a-4c32-bbbc-88b66f877028"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4c286218-8c84-49f0-9d0a-2461370edb46"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4d5a36ad-91b3-4664-b840-4d6ee517195d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4e835bf3-819f-421e-a129-348d6294520e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5073474f-8e84-48ab-9722-6774839fccf1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5b08aa07-5149-4352-b496-ec7441d82176"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5c2460ad-14e2-4103-acab-97def8361087"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5e572feb-d4dc-4380-939d-7a0a03314235"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("62edce6f-ad6d-4116-9180-572dd1050595"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6f37f009-9125-43e6-9dc2-06647c92139e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("761611a9-074c-48c5-9ae9-c7a7bcf65b2a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("791e9f23-1ac5-4eef-8b9c-eee8dd43b3bf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8cea1a65-33aa-46cc-846a-32db97db74d3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8d5f8a0a-09ae-4f3d-b951-014f51629144"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("93912374-506f-42bc-9321-73246e165dfe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("98d0dba1-7954-4201-a955-cbae9227f382"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a6ce94b3-345c-4755-a65a-5bf87ae23d36"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a9e861ee-3710-40ee-a56c-907c5b5777ac"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aca47a22-a79b-4b0b-8a1f-e17dbde345be"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ad709598-6265-403a-9c59-7cdf07c80790"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("afd535ea-56bf-405f-83e8-a07d41a7c160"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b5650353-bb33-440b-8815-40cd7c1769b7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b76ce95c-3f78-4924-a205-140d36401e42"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b8f88280-f575-4fd9-8744-d3d956552414"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bc8b7fa7-0a7a-408e-b93a-75adecb89405"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c3d36985-4729-406b-b28f-08be2e3b3c2b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c7ce9ba7-d541-4b97-a954-c2358e9791e4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c87d3df6-e528-407a-907f-055fc2eb2086"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cab389eb-872f-40fd-a0c1-7e372c6ee7ad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cef46336-ab4c-4a25-948f-2c8c9f490115"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d2ecb5ec-1167-479c-ade0-3dbfa95ec7d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d3da5cfd-aa5d-4c4e-bd6c-20d07bd401cc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d76a8a05-df98-45e2-b5be-fb102c999528"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d8976092-1066-4991-9fef-80a9131efec1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("db9d3a57-e5ec-4f5c-a2cb-2ea8536657cb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e0cf9be6-2aea-4596-87a1-253cefdd6115"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e43bee48-eb6e-40c1-a318-5a7f75d4c9a7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e472661d-27fb-491d-a7aa-f3085e48b848"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e558b70a-351f-4c26-a763-2e56bf71339f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e8163e9d-c62e-43ae-9fc6-f920cf88e4af"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e96daac7-e92f-48d2-9efa-553495c4b522"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eb5cead6-f6fc-4f62-a726-013e4e37e9ca"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f1a0903c-9088-47c3-90c2-71946b31fd4e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f8af596b-8ab1-4121-826e-3c42382e9a74"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fa5fff21-b606-46c0-b047-3d37f5bbe603"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0d61f526-0629-4055-8da7-d59cc5f2bfd9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1373d0e6-ec79-43b4-be9c-47962ddf3065"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1470d939-4d9b-4b53-90f6-01d72bd71647"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1aa2abd9-9690-4c80-b00f-bb6d81d17525"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("20184553-52f2-4a07-86cf-f32c61ba0acd"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2511d2f1-a1d8-40a6-9180-a40ffcf25238"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2fafbd6e-a544-4df5-a74e-3dafc32205bd"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("301f7fc0-bacf-40e9-83c0-b02cb2c1015b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("32418550-b812-4c4c-b35c-f8fef19f851f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("387ca009-0164-4879-8c09-03896d6b8909"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3963584d-a576-471f-a8dc-2470326cb9ee"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4d928346-b8ed-416b-bbc4-868e0837b996"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("59dfaf44-0ce2-40c9-a8ea-08601e3aa97d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5a52e4f9-0c37-4e19-9c00-253ae5624fa5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6ef094a8-2903-4cfd-aa2e-5d44f3b5f0b5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("77650535-ed1a-444b-ae18-3e62c861bbc2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7df7ab1e-77f3-4ad8-a7e7-79780e9f32cf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("865b3000-be69-4df5-9f3a-d1e53182c0ec"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("87296c43-b360-490a-982d-9bd42558ad15"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8f52135d-abed-40a8-a136-8891989e929e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("902b7250-301f-4685-82bc-02a6069ce143"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9d7068ec-85ca-45c7-b3a1-c4cf0e42a16d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bec3d67c-a9be-4334-aa34-8ace5392a912"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f8c46368-93a6-4435-823c-a230aac4ac2b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fda08538-7d88-4f80-a02e-859c10357e0a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("40ad2dc1-b570-4220-b849-45b2be47ba6a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("81e131c6-e68d-4be6-8526-686c278f1ddf"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fda2e742-81f8-4c01-8f66-c645cd3719f4"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb9461c-c9c2-4ca1-8e4f-fced19049452", new DateTime(2025, 7, 30, 16, 18, 41, 778, DateTimeKind.Local).AddTicks(1991), "AQAAAAIAAYagAAAAEFXjFWav03pPy2CFYqkvLYRWNzVdMFvk1bT2QFEzwUtxrH/rDM5dIQQlUA6MbE42xA==", "5c887ac3-634c-48c5-9800-e7c017dad627" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66733d9e-a8ea-40b2-94c4-edbbeb41b7c5", new DateTime(2025, 7, 30, 16, 18, 41, 949, DateTimeKind.Local).AddTicks(2981), "AQAAAAIAAYagAAAAEF9hGUJshOJ/Xb29pP3ioEJBZLcKCZ2SLOB3OWvBqBqcxlDkk8S7AJ8LwKUDjhafPg==", "e0e38f54-bd30-43c8-9d1c-299d961281df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd1a9410-962e-4fe1-a2fa-7f9908be709d", new DateTime(2025, 7, 30, 16, 18, 42, 2, DateTimeKind.Local).AddTicks(5416), "AQAAAAIAAYagAAAAEA3RXNHyOjQoWqNe3WcwwR3OKpivP2f7xF66dr8wHpT7KBHJzx91kHAKJfTb3BxvEg==", "7835449b-dd39-4744-9979-bdaeb23d3468" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0472dd-1e45-4f95-a391-bae40abb8211", new DateTime(2025, 7, 30, 16, 18, 41, 720, DateTimeKind.Local).AddTicks(2014), "AQAAAAIAAYagAAAAEJhnm+nWSrZRqG1PtcDUvPFe3xJji3qFZCn4l74OcZCMIDOd7nGhkkNXu9bJEBQbbQ==", "80c230b1-bd7d-4f52-887f-aec76405ea79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "600f4968-1430-44e6-a918-cc1ea3b92a55", new DateTime(2025, 7, 30, 16, 18, 41, 895, DateTimeKind.Local).AddTicks(8257), "AQAAAAIAAYagAAAAEG34Ngd/p4ZcO8R+MO/ZRShohQyneJDpSdZhSPbxPpJfiqasHHhaRP6nnp2DJi83Ow==", "5120d0a4-116c-4f08-964a-36d718df2c6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "551649bc-220d-4b34-afff-13d87b56c1a6", new DateTime(2025, 7, 30, 16, 18, 41, 841, DateTimeKind.Local).AddTicks(3057), "AQAAAAIAAYagAAAAEG4jMxkkk+SH+TzBmX+3KsZfKfpMaDZG1lLVauKovYq+JXHZJssq8TdjYYR5VvVcHw==", "879cb8c0-0e76-4139-9ba4-e30baf037116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "085799b7-80f0-4643-9dda-57fa57afee60", new DateTime(2025, 7, 30, 16, 18, 42, 56, DateTimeKind.Local).AddTicks(459), "AQAAAAIAAYagAAAAEGQT9Ok7KQazOUCcZZUcA7xWnePiKW44OHHJmihQ80jcWb+Zbu35+juG2586dQnA6g==", "01afb29d-e5f8-494c-9cbf-a5fed7eb394d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6169ce45-877d-4ad6-a9fd-9ee7cc129271", new DateTime(2025, 7, 30, 16, 18, 41, 662, DateTimeKind.Local).AddTicks(5521), "AQAAAAIAAYagAAAAEEB3KpHIODGCkz+yg5sFfq1XK0gSwOomv0Nupzb2zW9wVWNa2rory+vxC7ugueuRFg==", "ea8dd5d2-e038-47ad-a233-df2e2eb6add8" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("00d11853-7294-4731-af0f-641e0ee9b623"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("0ea31233-2985-4203-9ac3-d79bd2964d53"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("12c5836e-624a-46b8-8a6c-c92c10d54c07"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("187607e4-8439-40d8-be8d-9f573449de55"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("18790ea0-be3a-4019-90fa-63c5c7d019cc"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("1a35cbc4-d4c3-4790-8936-3bd62c5dfb9e"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("1b5aa06d-e1e3-42b6-936f-8824ed1311e9"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("1bebe9d0-72b8-4365-b682-c1b603070991"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("1dbe4891-302e-47e8-8c9f-d12215b6de4b"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("1e2e4bee-e640-46a6-93b4-b9a4f57652a0"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("1ee7af74-5e68-45f8-a77c-ea4c9391f59e"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("20f56634-5151-4864-9302-b0808e5c110d"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("21548b5a-2b6c-438a-97a9-dc3d0af4a6b8"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("37d4d41f-c7cf-409e-82e4-e7858233c315"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("3b186735-4e00-49e5-a3cd-0bd0f61234bc"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("43e97349-c164-4ace-9243-5db6b9f133ea"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("45916756-e8d4-43cb-b537-e8cbdcd71d2d"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("4a26d7ae-72c8-4967-a296-ae68eec528d1"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("4b008c6f-dd45-40d0-8989-03b69199e890"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("4e87185b-a9a7-4a9c-9c6f-86bd654ab7ab"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("4f7a0aca-4470-46ea-ba7b-a074f72d224f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("50862110-dec8-4d2e-a2e3-2a469b178748"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("5119482b-452e-4e16-b47f-10e95638a63f"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("59d91d23-0a01-4d26-aec1-770af1a99125"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("66f45fdf-9028-4685-90cf-508938f224d1"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("6be2e4d9-a8cd-436d-8680-dd1fefb2f7d4"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("6f6ab4d6-c765-4b72-b166-fc2feabe9444"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("71e946ab-fc3e-4ae3-ac3d-3f532d7fa663"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("7c76a4f2-a075-477a-8e26-6b8a04edc965"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("7d6dc98f-7f0e-4098-ab53-f2a30d5e67b1"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("80b35c43-4e0a-4e04-b941-4bdf8ddd0ebe"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("856118b8-3172-4ea9-9317-2688004913b3"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("88b028d7-66cd-4e45-bbc8-7b62a5829344"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("895a2f01-099a-47aa-876f-9b51be89ad5e"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("90ddfce8-c355-49a9-a51a-ae8db5aaa672"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("96b1b969-a122-4e1d-90c7-3258cd2a40e8"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("977da9c1-2407-4041-a18a-5409e4f91a71"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("9fa36074-7de8-4d57-adfa-c85d68bcfab3"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("a8924f4a-0ac4-4b9b-99cd-5a1158cace2f"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("aa6a3bd7-7b41-4570-afce-02fd2a713c69"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("ad1bf93e-e35a-4b4d-a7ee-9869bfffce7e"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("af6cccf2-bde2-429d-b4d5-60af93e3d924"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("b42e6831-0910-4a26-aff5-960a053c67ac"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("b5a13af4-9871-4d39-8062-c314411be0ba"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("b6a0d77d-b48b-44a3-b6cf-3102384ce306"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("bbd543f5-8416-4d73-8fda-1243102391ee"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("c7009612-39cc-47f2-9000-f4d3869c3675"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("c9c3bd84-b6c8-4306-805d-1245c27c7a5d"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("d39c2ae2-62c3-469d-b1a4-ccd3f7864c74"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("da3b13d5-4733-4389-962f-02326629f114"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("daafc131-d29a-4313-8066-0ba6a68530fe"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("e2636051-2d9b-4406-8774-24c44490b193"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("e639f65b-fe71-480b-89c5-ea9cd8ef31d5"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("e7766c2f-0560-4f52-bd42-0da8ef310809"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("e86c8349-7528-4207-902e-78e572f5eef6"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("ea35d97a-dd8e-4e9d-a8dc-08f59e5c90f5"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("ea53c298-328a-42ae-9228-1e13b5b2b437"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("edee0932-d38b-4249-b536-f5c363dfd710"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("ef5261e8-33ba-4c13-bbf3-da0af8749286"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("f1548392-b03e-4c2b-953c-f894d6f5cdab"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("f253386e-4f95-45aa-8f60-fed6efa391a9"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("faf76753-f110-4a96-9309-fb1472bc8a60"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("3126aef6-3532-4b0c-8feb-6887e3064b95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("3c0837bd-2910-4a77-a297-7a60e6f3d870"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("43160243-767a-402f-bd50-c68819cc84f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("44911795-ebd5-4d7a-a9c3-cb5a4e904a38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("457b6271-a4f4-4834-a67c-2b3e4b44873c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("485cfb54-3c4d-4bc4-a7a4-b6c484cbd42a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("551d6bac-4a8c-4358-b16d-3f5343db8c01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("5d15fdbb-852c-47c3-bbd1-36765639a611"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("5d4a067e-05b7-4ca5-b73b-fc43d1cd7d34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("5f10a492-81f6-412b-829c-83e539f94d1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("60280db1-3a17-4f67-a57a-9f4e7cc3e301"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("7e49dd7d-08f9-4d8b-b517-4366a4f4df3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("89332d0e-427a-472b-9ae4-e023590ba084"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("a41159a4-8c8a-4819-9459-16fdb5de1806"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("b3511025-29df-4fc9-8c18-17d3eb07e7fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("c05a2a16-6d72-4e78-8fa2-03d59e14abcf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("c08070a0-101b-4d46-9753-6ea49ce7d786"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("c2c4d01d-f04e-40aa-a4e1-d14ad33b73f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("c4770344-21cd-4a77-b5c7-a4ccb95a214e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("dc310cd3-b795-4f68-a82b-b28f8b334ec4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("dcb522db-019f-4ae8-9a51-521f1c096869"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("e59eba5e-a7b0-4179-bb82-63b259cf0e99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("e75ccc8c-a305-4c16-a31f-55c3a7c332a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("ebf0202c-7b56-4db6-b05f-0baf53764683"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("f473e336-0bb9-4178-be50-207d47067d90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 18, 41, 644, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("311e631b-4e90-408b-bc62-e331b3577b73"), "This game is good, but it has some bugs", new DateTime(2025, 7, 30, 16, 18, 41, 652, DateTimeKind.Local).AddTicks(4475), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("914e3b81-53fd-4826-b499-36f4f94ed02e"), "This game gives me a cozy vibe", new DateTime(2025, 7, 30, 16, 18, 41, 652, DateTimeKind.Local).AddTicks(4473), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("f28c944a-61f5-4477-b825-10abba305684"), "This is the best game I have ever seen", new DateTime(2025, 7, 30, 16, 18, 41, 652, DateTimeKind.Local).AddTicks(4450), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PostImages_Posts_PostId",
                table: "PostImages",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReactions_Posts_PostId",
                table: "PostReactions",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostImages_Posts_PostId",
                table: "PostImages");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReactions_Posts_PostId",
                table: "PostReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("00d11853-7294-4731-af0f-641e0ee9b623"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0ea31233-2985-4203-9ac3-d79bd2964d53"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("12c5836e-624a-46b8-8a6c-c92c10d54c07"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("187607e4-8439-40d8-be8d-9f573449de55"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("18790ea0-be3a-4019-90fa-63c5c7d019cc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1a35cbc4-d4c3-4790-8936-3bd62c5dfb9e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1b5aa06d-e1e3-42b6-936f-8824ed1311e9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1bebe9d0-72b8-4365-b682-c1b603070991"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1dbe4891-302e-47e8-8c9f-d12215b6de4b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1e2e4bee-e640-46a6-93b4-b9a4f57652a0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1ee7af74-5e68-45f8-a77c-ea4c9391f59e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("20f56634-5151-4864-9302-b0808e5c110d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("21548b5a-2b6c-438a-97a9-dc3d0af4a6b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("37d4d41f-c7cf-409e-82e4-e7858233c315"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3b186735-4e00-49e5-a3cd-0bd0f61234bc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43e97349-c164-4ace-9243-5db6b9f133ea"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("45916756-e8d4-43cb-b537-e8cbdcd71d2d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4a26d7ae-72c8-4967-a296-ae68eec528d1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4b008c6f-dd45-40d0-8989-03b69199e890"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4e87185b-a9a7-4a9c-9c6f-86bd654ab7ab"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4f7a0aca-4470-46ea-ba7b-a074f72d224f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("50862110-dec8-4d2e-a2e3-2a469b178748"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5119482b-452e-4e16-b47f-10e95638a63f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("59d91d23-0a01-4d26-aec1-770af1a99125"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("66f45fdf-9028-4685-90cf-508938f224d1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6be2e4d9-a8cd-436d-8680-dd1fefb2f7d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6f6ab4d6-c765-4b72-b166-fc2feabe9444"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("71e946ab-fc3e-4ae3-ac3d-3f532d7fa663"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7c76a4f2-a075-477a-8e26-6b8a04edc965"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7d6dc98f-7f0e-4098-ab53-f2a30d5e67b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("80b35c43-4e0a-4e04-b941-4bdf8ddd0ebe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("856118b8-3172-4ea9-9317-2688004913b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("88b028d7-66cd-4e45-bbc8-7b62a5829344"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("895a2f01-099a-47aa-876f-9b51be89ad5e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90ddfce8-c355-49a9-a51a-ae8db5aaa672"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("96b1b969-a122-4e1d-90c7-3258cd2a40e8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("977da9c1-2407-4041-a18a-5409e4f91a71"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9fa36074-7de8-4d57-adfa-c85d68bcfab3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a8924f4a-0ac4-4b9b-99cd-5a1158cace2f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aa6a3bd7-7b41-4570-afce-02fd2a713c69"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ad1bf93e-e35a-4b4d-a7ee-9869bfffce7e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("af6cccf2-bde2-429d-b4d5-60af93e3d924"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b42e6831-0910-4a26-aff5-960a053c67ac"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b5a13af4-9871-4d39-8062-c314411be0ba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b6a0d77d-b48b-44a3-b6cf-3102384ce306"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bbd543f5-8416-4d73-8fda-1243102391ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c7009612-39cc-47f2-9000-f4d3869c3675"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c9c3bd84-b6c8-4306-805d-1245c27c7a5d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d39c2ae2-62c3-469d-b1a4-ccd3f7864c74"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("da3b13d5-4733-4389-962f-02326629f114"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("daafc131-d29a-4313-8066-0ba6a68530fe"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e2636051-2d9b-4406-8774-24c44490b193"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e639f65b-fe71-480b-89c5-ea9cd8ef31d5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e7766c2f-0560-4f52-bd42-0da8ef310809"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e86c8349-7528-4207-902e-78e572f5eef6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ea35d97a-dd8e-4e9d-a8dc-08f59e5c90f5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ea53c298-328a-42ae-9228-1e13b5b2b437"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("edee0932-d38b-4249-b536-f5c363dfd710"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ef5261e8-33ba-4c13-bbf3-da0af8749286"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f1548392-b03e-4c2b-953c-f894d6f5cdab"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f253386e-4f95-45aa-8f60-fed6efa391a9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("faf76753-f110-4a96-9309-fb1472bc8a60"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3126aef6-3532-4b0c-8feb-6887e3064b95"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3c0837bd-2910-4a77-a297-7a60e6f3d870"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("43160243-767a-402f-bd50-c68819cc84f2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("44911795-ebd5-4d7a-a9c3-cb5a4e904a38"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("457b6271-a4f4-4834-a67c-2b3e4b44873c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("485cfb54-3c4d-4bc4-a7a4-b6c484cbd42a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("551d6bac-4a8c-4358-b16d-3f5343db8c01"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5d15fdbb-852c-47c3-bbd1-36765639a611"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5d4a067e-05b7-4ca5-b73b-fc43d1cd7d34"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5f10a492-81f6-412b-829c-83e539f94d1a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("60280db1-3a17-4f67-a57a-9f4e7cc3e301"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7e49dd7d-08f9-4d8b-b517-4366a4f4df3a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("89332d0e-427a-472b-9ae4-e023590ba084"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a41159a4-8c8a-4819-9459-16fdb5de1806"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b3511025-29df-4fc9-8c18-17d3eb07e7fe"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c05a2a16-6d72-4e78-8fa2-03d59e14abcf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c08070a0-101b-4d46-9753-6ea49ce7d786"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c2c4d01d-f04e-40aa-a4e1-d14ad33b73f4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c4770344-21cd-4a77-b5c7-a4ccb95a214e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dc310cd3-b795-4f68-a82b-b28f8b334ec4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dcb522db-019f-4ae8-9a51-521f1c096869"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e59eba5e-a7b0-4179-bb82-63b259cf0e99"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e75ccc8c-a305-4c16-a31f-55c3a7c332a0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ebf0202c-7b56-4db6-b05f-0baf53764683"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f473e336-0bb9-4178-be50-207d47067d90"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("311e631b-4e90-408b-bc62-e331b3577b73"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("914e3b81-53fd-4826-b499-36f4f94ed02e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f28c944a-61f5-4477-b825-10abba305684"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63c284f5-81ef-47ea-aea7-5337ca7743fe", new DateTime(2025, 7, 30, 16, 5, 25, 461, DateTimeKind.Local).AddTicks(3041), "AQAAAAIAAYagAAAAEOZdGJJPmaQqarplCTK27/eLX3g1+o8OBrarZuDvzU/BoM6foT42PxaRkhBWmLE+dQ==", "c49b599a-a203-4ade-885f-cadfabfa0588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "934c1d85-c6e5-4207-a054-77d2a0dfd12a", new DateTime(2025, 7, 30, 16, 5, 25, 635, DateTimeKind.Local).AddTicks(9169), "AQAAAAIAAYagAAAAEM+bzMpJHYtBDH4ofqOUwt2eJMO7eZCPKdRGYPPBSXu5orPjHV6A1p6gGQyEBdeZwg==", "57b563f5-2752-411c-966e-f160ba5c34d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a70b8f6-0e64-4117-af96-40fe8716042f", new DateTime(2025, 7, 30, 16, 5, 25, 693, DateTimeKind.Local).AddTicks(4464), "AQAAAAIAAYagAAAAEIwwIgVlpZBzJjp7VsA893tDNpGsWAHgURtVtd3+PrIduISZGNzf40l9am7xLl2O7g==", "bf4ba362-186c-4a74-9529-0dc754233190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e04bea0-edbd-458f-a0da-cb42588b041b", new DateTime(2025, 7, 30, 16, 5, 25, 403, DateTimeKind.Local).AddTicks(478), "AQAAAAIAAYagAAAAEG6lAiSMxVF4hmIAISxZfq43CJm4EMpqkyS3oLkOBoouCTpKOkHGr5ApUiJgatg0aw==", "ffb468cd-74a4-45d2-a6fb-c8787ba77734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c44f8418-9417-488f-b8ed-1f83c9915d55", new DateTime(2025, 7, 30, 16, 5, 25, 581, DateTimeKind.Local).AddTicks(8316), "AQAAAAIAAYagAAAAEAvoZdZxkofVXxZ0xS4sUBeg0UN9W/04y3OoS8bg7LdlBOpGbijCeLc3z04Lcc6UnQ==", "9e4138c0-9c9c-4747-b002-f40370871ef3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c346d8-88c7-4485-9d9f-5b03ff2dd10a", new DateTime(2025, 7, 30, 16, 5, 25, 517, DateTimeKind.Local).AddTicks(9807), "AQAAAAIAAYagAAAAECcNnJPdMwbnvtv3kruQBuB8G2oTm9I0Hs9PXGLcoFbskDaXNerOESwId4YXHXBmag==", "88fb6848-83ca-4af7-9b1e-82c5129e5a04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "655b0ad7-ac20-4396-beac-d2b78fcdfa02", new DateTime(2025, 7, 30, 16, 5, 25, 751, DateTimeKind.Local).AddTicks(8648), "AQAAAAIAAYagAAAAEIaCQMCuLVoGArDIJ3cCk/tPuYTR+EEIfRBle6p9clTJdle5IMZMnijKShJ6iid7pw==", "3dbed1b6-f94f-4c43-a4ef-6c03b5badf85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39cdbb41-078b-4de3-9c52-4fdb61c9e118", new DateTime(2025, 7, 30, 16, 5, 25, 345, DateTimeKind.Local).AddTicks(8041), "AQAAAAIAAYagAAAAEOgKdUa0BHyxIJ2mFzL+1kls7vGVY9TxXTr0sTZEyF8nZCkAmKQhoaTf78k8WIOKKA==", "4ae8312c-eda8-4a24-80b0-c35f9c6eb833" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("009f8e61-ea3d-453e-9cf1-967f8b1384b8"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("06643cb5-18b4-46da-8330-51256fe31b33"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("0771411c-2539-4c14-9ad8-02fb6aa1762e"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("0846fa87-0028-441d-859a-3ee5d6c6e344"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("08722182-9d52-4b2d-8f51-053ad38be497"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("0a493f3a-1a27-40b8-a854-9a6a4a8d1fa7"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("163d64cb-5cbe-479d-953a-8ebb409f844f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("19b8cfc3-b54b-4b5c-a925-c3b1c82bf28f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("210d1c28-2a44-4623-a4de-91c1aedaea73"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("23e8b769-e867-4796-861e-e192d68b7158"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("2d01f26d-7c27-4708-a98f-2e1969900828"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("323e6f80-732d-42d0-b5fa-1eb0f7963da2"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("35c5bb98-846e-4496-88c9-fec0cc6a972c"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("35d5319f-6e35-4883-90be-22f44aa876cf"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("38c1abc2-959b-4225-9192-66d77796de73"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("3d24e31b-32b5-4bc1-82bd-d9ea6fe18cf6"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("40eee9bc-cd83-442e-bdae-93a04b20271b"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("4b5e0e25-3f5a-4c32-bbbc-88b66f877028"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("4c286218-8c84-49f0-9d0a-2461370edb46"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("4d5a36ad-91b3-4664-b840-4d6ee517195d"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("4e835bf3-819f-421e-a129-348d6294520e"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("5073474f-8e84-48ab-9722-6774839fccf1"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("5b08aa07-5149-4352-b496-ec7441d82176"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("5c2460ad-14e2-4103-acab-97def8361087"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("5e572feb-d4dc-4380-939d-7a0a03314235"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("62edce6f-ad6d-4116-9180-572dd1050595"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("6f37f009-9125-43e6-9dc2-06647c92139e"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("761611a9-074c-48c5-9ae9-c7a7bcf65b2a"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("791e9f23-1ac5-4eef-8b9c-eee8dd43b3bf"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("8cea1a65-33aa-46cc-846a-32db97db74d3"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("8d5f8a0a-09ae-4f3d-b951-014f51629144"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("93912374-506f-42bc-9321-73246e165dfe"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("98d0dba1-7954-4201-a955-cbae9227f382"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("a6ce94b3-345c-4755-a65a-5bf87ae23d36"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("a9e861ee-3710-40ee-a56c-907c5b5777ac"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("aca47a22-a79b-4b0b-8a1f-e17dbde345be"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("ad709598-6265-403a-9c59-7cdf07c80790"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("afd535ea-56bf-405f-83e8-a07d41a7c160"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("b5650353-bb33-440b-8815-40cd7c1769b7"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("b76ce95c-3f78-4924-a205-140d36401e42"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("b8f88280-f575-4fd9-8744-d3d956552414"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("bc8b7fa7-0a7a-408e-b93a-75adecb89405"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("c3d36985-4729-406b-b28f-08be2e3b3c2b"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("c7ce9ba7-d541-4b97-a954-c2358e9791e4"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("c87d3df6-e528-407a-907f-055fc2eb2086"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("cab389eb-872f-40fd-a0c1-7e372c6ee7ad"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("cef46336-ab4c-4a25-948f-2c8c9f490115"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("d2ecb5ec-1167-479c-ade0-3dbfa95ec7d4"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("d3da5cfd-aa5d-4c4e-bd6c-20d07bd401cc"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("d76a8a05-df98-45e2-b5be-fb102c999528"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("d8976092-1066-4991-9fef-80a9131efec1"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("db9d3a57-e5ec-4f5c-a2cb-2ea8536657cb"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("e0cf9be6-2aea-4596-87a1-253cefdd6115"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("e43bee48-eb6e-40c1-a318-5a7f75d4c9a7"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("e472661d-27fb-491d-a7aa-f3085e48b848"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("e558b70a-351f-4c26-a763-2e56bf71339f"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("e8163e9d-c62e-43ae-9fc6-f920cf88e4af"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("e96daac7-e92f-48d2-9efa-553495c4b522"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("eb5cead6-f6fc-4f62-a726-013e4e37e9ca"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("f1a0903c-9088-47c3-90c2-71946b31fd4e"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("f8af596b-8ab1-4121-826e-3c42382e9a74"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("fa5fff21-b606-46c0-b047-3d37f5bbe603"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("0d61f526-0629-4055-8da7-d59cc5f2bfd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("1373d0e6-ec79-43b4-be9c-47962ddf3065"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("1470d939-4d9b-4b53-90f6-01d72bd71647"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("1aa2abd9-9690-4c80-b00f-bb6d81d17525"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("20184553-52f2-4a07-86cf-f32c61ba0acd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("2511d2f1-a1d8-40a6-9180-a40ffcf25238"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("2fafbd6e-a544-4df5-a74e-3dafc32205bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("301f7fc0-bacf-40e9-83c0-b02cb2c1015b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("32418550-b812-4c4c-b35c-f8fef19f851f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("387ca009-0164-4879-8c09-03896d6b8909"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("3963584d-a576-471f-a8dc-2470326cb9ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("4d928346-b8ed-416b-bbc4-868e0837b996"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("59dfaf44-0ce2-40c9-a8ea-08601e3aa97d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("5a52e4f9-0c37-4e19-9c00-253ae5624fa5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("6ef094a8-2903-4cfd-aa2e-5d44f3b5f0b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("77650535-ed1a-444b-ae18-3e62c861bbc2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("7df7ab1e-77f3-4ad8-a7e7-79780e9f32cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("865b3000-be69-4df5-9f3a-d1e53182c0ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("87296c43-b360-490a-982d-9bd42558ad15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("8f52135d-abed-40a8-a136-8891989e929e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("902b7250-301f-4685-82bc-02a6069ce143"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("9d7068ec-85ca-45c7-b3a1-c4cf0e42a16d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("bec3d67c-a9be-4334-aa34-8ace5392a912"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("f8c46368-93a6-4435-823c-a230aac4ac2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("fda08538-7d88-4f80-a02e-859c10357e0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 30, 16, 5, 25, 328, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("40ad2dc1-b570-4220-b849-45b2be47ba6a"), "This game is good, but it has some bugs", new DateTime(2025, 7, 30, 16, 5, 25, 335, DateTimeKind.Local).AddTicks(4522), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("81e131c6-e68d-4be6-8526-686c278f1ddf"), "This game gives me a cozy vibe", new DateTime(2025, 7, 30, 16, 5, 25, 335, DateTimeKind.Local).AddTicks(4519), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("fda2e742-81f8-4c01-8f66-c645cd3719f4"), "This is the best game I have ever seen", new DateTime(2025, 7, 30, 16, 5, 25, 335, DateTimeKind.Local).AddTicks(4512), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PostImages_Posts_PostId",
                table: "PostImages",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReactions_Posts_PostId",
                table: "PostReactions",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
