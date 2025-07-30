using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("02f2021e-35d3-445a-9cdf-1b0444697a5f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0378cf03-7417-413e-9043-3a2411d401e4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("07f05a1e-2aea-4e3c-b69d-090842391d00"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0ac81c93-ac8d-47aa-a815-41875166a44f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0dc39d1c-fff5-4be1-8679-2bc71e283a0e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("17da1922-3e55-4d85-b399-3d7f093662d0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1a0c1f7d-1067-4866-8544-f639a8b7377e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1a621199-5027-4b1a-88af-e94d4e8576fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1e9b9000-2d24-4cc6-bf70-4ca627450e29"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("21d6bd82-7a79-4f41-855c-480df61edc08"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("229cf891-7477-4fac-b179-1c60d30a624a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("22d215a2-be0d-4e95-9304-d3c18aff075b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("235df1e6-5a9f-4401-b7b7-df5190cad66f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("284dfa56-00c3-46c9-9c38-9540e71ec198"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2b1ab66c-7724-4cd6-b327-565833d720b3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("324c3481-7953-4ee0-8985-e1a01391b906"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35b170c8-5ed0-4fca-a143-e52ddbd3a2ec"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3706a48f-3e36-4e94-a91b-646564ab8d2e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e7585d4-5bc6-4b74-b89a-61136c160482"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("49bbd784-9ba0-4f68-aeee-432b75fef323"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4b03786f-2cf4-4626-8566-4c29ac012365"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4b267b64-dc5d-4ec0-b4d4-85ff01486089"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("54435fef-e508-4ff5-9fd9-96578c3a39f9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("551debe8-c574-433f-8344-86e90badfff0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5527f5b0-002e-4ea8-a4f7-192823f290c1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("58831473-5a5d-4fa5-bbfe-f5e2689f9396"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5b7bd0ca-7bcf-4a4b-9263-161d93772274"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("69e4d309-d23a-45c0-862e-8c786b4ba24a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6b2e9320-8c33-4cdf-b44e-689e4233914a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6f0ee9a7-4927-4196-aeef-f63c81b4e544"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("762da1e8-3519-49bf-935f-0ff7c185154e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("79a1e7e1-582f-4242-951c-6d729f744729"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7d0e11f4-efb1-4e6b-bd82-7be83fd303d0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8145dfe8-90de-434b-9013-5d15794ce533"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8a080a26-8c56-43c5-9f95-f45ef6ac301c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90449b47-8c87-41b3-89d4-71687320e0d8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("95302c3b-b9f6-4f0f-b2dc-7428e435d044"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9700609c-2c15-4a0c-bfc5-e514516e8b0c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9c1c51c8-0cda-470f-b3db-dd9e43aaaf3b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a46b9a17-bc53-4304-a344-1ad48a2eb92c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a87dbea7-ff17-4bf1-a081-22ddc3539d92"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aaab9df4-83b3-4552-b1d9-ba1a9a4c7b18"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("af13330f-9950-43eb-aaff-7ecbe42cedf1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b5e9031f-6bb4-4c25-a9c3-08e063ea2ee6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bf1854f3-5082-42ba-a4ff-be897ca69ef9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c0a059ed-eaf8-46b1-bb08-e61fb6e9859e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c27c8116-eee0-4e4a-abdc-8982fe06591e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c47e3d69-6a83-4842-8e10-61687bf4df45"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d81a4a03-3760-4181-80db-8e0815901af6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d8fc052d-7084-423a-9d80-417876a0bee7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dc0b4d73-c790-4682-bd20-8013a9a108da"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dff757e7-5781-4fbc-9762-49cd8ea9a26b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e129a98e-b710-4441-b5b8-f323e9ccf740"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e3cf118f-7f85-457c-965e-861666e7e798"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e5948cfc-1523-48b7-a26b-aad5ccaeb451"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e838e4ed-0c73-4115-a147-b1ae929df1c6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f0e69bf5-11a4-4d59-b656-8a690f373df6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f6b87191-77bb-4927-ad19-4b655ed63485"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fcbfeda7-b64e-4eb2-ad49-a46c4f2ab91c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fdaafe92-54b9-44ea-833b-4133058f701d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("feab116c-068e-4b28-8919-adf50218899c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ff9f9492-cb3b-47e3-b071-7671993136df"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1ec0881f-9468-4d82-bbb7-d324cb0c6784"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("284a85a0-c8d3-4963-91e2-884d9a9228e2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("328b5875-8dcd-4b99-9a09-b8578b8563f5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3549247d-28f6-4731-a5a0-917504b80594"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("37d65d2d-f7a5-4f87-bc8d-bae9ec5fc537"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3998d2bb-6672-43ca-b377-82b028a0ead1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("511c29a3-01a6-47bc-a34f-eae3fa34d095"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("590c1bcc-82ee-4aff-9f3e-a009b6e0b1aa"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("666fab9e-c87b-48e6-8c13-e44d8cb21134"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6eac75b3-d68d-4924-939c-ee0834f47d28"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("77eb2750-81bf-4535-9f57-7ed178d00e18"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("87d5d199-9ee1-4264-8b28-7ca5b7a851ed"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("95a39d4e-e208-4346-beef-3f1713e5c3e1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9d17d626-2dc5-4cbd-b961-25507d01b822"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a4231844-5c1f-44da-bea1-3105ba70bc5d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b0e8b522-da8a-4053-ae2b-252c37d490c5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b8771a99-9623-4435-9e58-5216839d7297"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c38c8a73-c44d-4ec2-8c72-3d4fad032ffd"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c7b5ba9b-2350-49b7-9d5c-e0896d34d1e6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d6f03ec1-224e-4315-a8d3-289cb3374159"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d9dc075d-fc90-44bd-b45a-a3bca662db47"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e672fb24-2cac-452b-8b71-f65cfd50abef"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e8043527-26ec-49fe-a957-2862b2cf80fd"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f9cd917c-b329-4a77-b761-b8e83c4aeb1e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fa4c483b-8a77-4b0c-8a77-5b0e83f22a49"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ade1e581-5c0c-4444-9512-b8672399acc5"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e409d9a5-b2ec-4e17-a7e6-c3fe30abebc3"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f7a2649d-34c4-44a2-aa45-fbbfc9fe8b42"));

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

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                column: "EndDate",
                value: new DateOnly(2025, 8, 9));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "0d26d516-1fea-4c5e-b30d-8a6ccef5eaa0", new DateTime(2025, 7, 28, 20, 10, 25, 434, DateTimeKind.Local).AddTicks(7976), "AQAAAAIAAYagAAAAECVAL2AJ32c2gvC7BK1saqQiE/bcjNwjfrxhmv1/MJLH33Qhr21gZ790HgkAGgWh9A==", "abb2fb1b-c1fb-40cd-ad7f-80583f34fc0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25b3872b-b26b-428b-95e9-58f53031416a", new DateTime(2025, 7, 28, 20, 10, 25, 587, DateTimeKind.Local).AddTicks(6958), "AQAAAAIAAYagAAAAEHR+TVOC3uaBPxLiVsB47PgrSS3oyGIy7MNxLE0fw1PgsDTGHuvhlgep2BhJouIJpQ==", "0974d831-a758-4d19-bac5-2fbf3cdba6b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e587d86b-1b82-47b9-9b18-d13f568006a1", new DateTime(2025, 7, 28, 20, 10, 25, 635, DateTimeKind.Local).AddTicks(9392), "AQAAAAIAAYagAAAAEAn0uUTuJQufa09t6wCDWM/IWrYWhodBtoUXsX9K1+p3Do5HReGuPLeeYCp/yM55PQ==", "3ba7a608-fc0d-4401-8ae6-6f3e116801f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74875aec-8f4c-44b6-b6c9-a8dd9ba4cbc4", new DateTime(2025, 7, 28, 20, 10, 25, 386, DateTimeKind.Local).AddTicks(6329), "AQAAAAIAAYagAAAAEHMapc6TkV67LDUnLlWcDHVOqnumzyY5p+bCsx0kLsotd1jfO3cWFOPbA6gMHYGNhA==", "51d623dd-9745-4302-966b-8f60f6c7a579" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc0d7190-9cb2-4e0e-9232-b3a5808c28e8", new DateTime(2025, 7, 28, 20, 10, 25, 538, DateTimeKind.Local).AddTicks(6309), "AQAAAAIAAYagAAAAEF1ELwMEtYZBV257Lf5nR+NmD8sSV6D9uGtD1qE3ppuXPgQPlA+0C6O7kaTRfpkWBA==", "44aa9f35-23df-470f-9e10-0727eedaabcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cc8dc10-3f41-44e2-b4b5-3fabbcfb833e", new DateTime(2025, 7, 28, 20, 10, 25, 490, DateTimeKind.Local).AddTicks(1897), "AQAAAAIAAYagAAAAECBt3bm+yr3YqJ7afm62/VhiZssjA2yb0TR4RpJZkAy3d1d0MWEkAOgc8ZNM1it79A==", "84d0e4d1-a5d0-4e58-8453-22ac94c3818e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3447ca6f-7096-415d-ba5f-10d49a19da26", new DateTime(2025, 7, 28, 20, 10, 25, 684, DateTimeKind.Local).AddTicks(3437), "AQAAAAIAAYagAAAAEBh0oVKvDbMCXzfeLdMFXGiJA/oVPMO8uCN5vxReBkO0Acjg+/1yvrycyBX4MDbMzw==", "6c94aa29-1d07-4b01-b824-0d53fb54ec4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bf57bf6-37f9-457d-972b-e4c67a274d1c", new DateTime(2025, 7, 28, 20, 10, 25, 338, DateTimeKind.Local).AddTicks(6615), "AQAAAAIAAYagAAAAENdobmvRYsxwxxbH15YZG3m6qZr8Q7WO8nvUn8AnSoZ1iHqck5qkFKkawzs57SmDAA==", "ff5d0a46-40db-406d-8e89-2de48001d60e" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                column: "EndDate",
                value: new DateOnly(2025, 8, 7));

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("02f2021e-35d3-445a-9cdf-1b0444697a5f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("0378cf03-7417-413e-9043-3a2411d401e4"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("07f05a1e-2aea-4e3c-b69d-090842391d00"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("0ac81c93-ac8d-47aa-a815-41875166a44f"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("0dc39d1c-fff5-4be1-8679-2bc71e283a0e"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("17da1922-3e55-4d85-b399-3d7f093662d0"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("1a0c1f7d-1067-4866-8544-f639a8b7377e"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("1a621199-5027-4b1a-88af-e94d4e8576fd"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("1e9b9000-2d24-4cc6-bf70-4ca627450e29"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("21d6bd82-7a79-4f41-855c-480df61edc08"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("229cf891-7477-4fac-b179-1c60d30a624a"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("22d215a2-be0d-4e95-9304-d3c18aff075b"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("235df1e6-5a9f-4401-b7b7-df5190cad66f"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("284dfa56-00c3-46c9-9c38-9540e71ec198"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("2b1ab66c-7724-4cd6-b327-565833d720b3"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("324c3481-7953-4ee0-8985-e1a01391b906"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("35b170c8-5ed0-4fca-a143-e52ddbd3a2ec"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("3706a48f-3e36-4e94-a91b-646564ab8d2e"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("3e7585d4-5bc6-4b74-b89a-61136c160482"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("49bbd784-9ba0-4f68-aeee-432b75fef323"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("4b03786f-2cf4-4626-8566-4c29ac012365"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("4b267b64-dc5d-4ec0-b4d4-85ff01486089"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("54435fef-e508-4ff5-9fd9-96578c3a39f9"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("551debe8-c574-433f-8344-86e90badfff0"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("5527f5b0-002e-4ea8-a4f7-192823f290c1"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("58831473-5a5d-4fa5-bbfe-f5e2689f9396"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("5b7bd0ca-7bcf-4a4b-9263-161d93772274"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("69e4d309-d23a-45c0-862e-8c786b4ba24a"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("6b2e9320-8c33-4cdf-b44e-689e4233914a"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("6f0ee9a7-4927-4196-aeef-f63c81b4e544"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("762da1e8-3519-49bf-935f-0ff7c185154e"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("79a1e7e1-582f-4242-951c-6d729f744729"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("7d0e11f4-efb1-4e6b-bd82-7be83fd303d0"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("8145dfe8-90de-434b-9013-5d15794ce533"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("8a080a26-8c56-43c5-9f95-f45ef6ac301c"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("90449b47-8c87-41b3-89d4-71687320e0d8"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("95302c3b-b9f6-4f0f-b2dc-7428e435d044"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("9700609c-2c15-4a0c-bfc5-e514516e8b0c"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("9c1c51c8-0cda-470f-b3db-dd9e43aaaf3b"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("a46b9a17-bc53-4304-a344-1ad48a2eb92c"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("a87dbea7-ff17-4bf1-a081-22ddc3539d92"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("aaab9df4-83b3-4552-b1d9-ba1a9a4c7b18"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("af13330f-9950-43eb-aaff-7ecbe42cedf1"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("b5e9031f-6bb4-4c25-a9c3-08e063ea2ee6"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("bf1854f3-5082-42ba-a4ff-be897ca69ef9"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("c0a059ed-eaf8-46b1-bb08-e61fb6e9859e"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("c27c8116-eee0-4e4a-abdc-8982fe06591e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("c47e3d69-6a83-4842-8e10-61687bf4df45"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("d81a4a03-3760-4181-80db-8e0815901af6"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("d8fc052d-7084-423a-9d80-417876a0bee7"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("dc0b4d73-c790-4682-bd20-8013a9a108da"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("dff757e7-5781-4fbc-9762-49cd8ea9a26b"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("e129a98e-b710-4441-b5b8-f323e9ccf740"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("e3cf118f-7f85-457c-965e-861666e7e798"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("e5948cfc-1523-48b7-a26b-aad5ccaeb451"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("e838e4ed-0c73-4115-a147-b1ae929df1c6"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("f0e69bf5-11a4-4d59-b656-8a690f373df6"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("f6b87191-77bb-4927-ad19-4b655ed63485"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("fcbfeda7-b64e-4eb2-ad49-a46c4f2ab91c"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("fdaafe92-54b9-44ea-833b-4133058f701d"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("feab116c-068e-4b28-8919-adf50218899c"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("ff9f9492-cb3b-47e3-b071-7671993136df"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("1ec0881f-9468-4d82-bbb7-d324cb0c6784"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("284a85a0-c8d3-4963-91e2-884d9a9228e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("328b5875-8dcd-4b99-9a09-b8578b8563f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("3549247d-28f6-4731-a5a0-917504b80594"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("37d65d2d-f7a5-4f87-bc8d-bae9ec5fc537"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("3998d2bb-6672-43ca-b377-82b028a0ead1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("511c29a3-01a6-47bc-a34f-eae3fa34d095"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("590c1bcc-82ee-4aff-9f3e-a009b6e0b1aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("666fab9e-c87b-48e6-8c13-e44d8cb21134"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("6eac75b3-d68d-4924-939c-ee0834f47d28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("77eb2750-81bf-4535-9f57-7ed178d00e18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("87d5d199-9ee1-4264-8b28-7ca5b7a851ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("95a39d4e-e208-4346-beef-3f1713e5c3e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("9d17d626-2dc5-4cbd-b961-25507d01b822"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("a4231844-5c1f-44da-bea1-3105ba70bc5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("b0e8b522-da8a-4053-ae2b-252c37d490c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("b8771a99-9623-4435-9e58-5216839d7297"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("c38c8a73-c44d-4ec2-8c72-3d4fad032ffd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("c7b5ba9b-2350-49b7-9d5c-e0896d34d1e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("d6f03ec1-224e-4315-a8d3-289cb3374159"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("d9dc075d-fc90-44bd-b45a-a3bca662db47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("e672fb24-2cac-452b-8b71-f65cfd50abef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("e8043527-26ec-49fe-a957-2862b2cf80fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("f9cd917c-b329-4a77-b761-b8e83c4aeb1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("fa4c483b-8a77-4b0c-8a77-5b0e83f22a49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 7, 28, 20, 10, 25, 320, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("ade1e581-5c0c-4444-9512-b8672399acc5"), "This game is good, but it has some bugs", new DateTime(2025, 7, 28, 20, 10, 25, 328, DateTimeKind.Local).AddTicks(3280), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("e409d9a5-b2ec-4e17-a7e6-c3fe30abebc3"), "This game gives me a cozy vibe", new DateTime(2025, 7, 28, 20, 10, 25, 328, DateTimeKind.Local).AddTicks(3277), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("f7a2649d-34c4-44a2-aa45-fbbfc9fe8b42"), "This is the best game I have ever seen", new DateTime(2025, 7, 28, 20, 10, 25, 328, DateTimeKind.Local).AddTicks(3262), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
                });
        }
    }
}
