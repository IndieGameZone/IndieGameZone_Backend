using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("00d3bcb5-c507-4a6e-b874-08d442217146"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("03e4a07d-955f-43a7-a7bf-aa8884ca94fd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("042664f1-b2ce-41a5-b3fd-5188f99657cd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("08394abb-23f7-444e-9145-33b2ed710e28"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a79757a-b011-410b-bc0f-f518681724d0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0b508e73-2c80-4b4d-935a-9970b5aa5904"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("14bbd2da-a65a-4216-8e2b-11667bd4cf90"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("171e60ea-1bc7-4d8c-acea-18aa8fb69108"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("194a148d-ac3c-4da3-90a6-0d846bb161f2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1b44d8e5-3893-4c2f-a9dd-b7a585396c72"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1f5c7c73-9466-4049-b7ca-0d6baed4d01f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2040fdea-bb11-45a8-8e7a-f9cbdc7a06ce"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("205dd8c1-47cc-4dbe-b869-3e5a44a88871"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("22b87c1d-4320-486b-b8d7-2878347a1a83"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("30e83ec3-867c-4ba3-978a-7d448e80270a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3470d896-2d21-4343-ba2b-735521da819c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3c3e16b9-46dc-4075-937b-0f452985ff59"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3f011db1-e849-4fc6-b713-1b64add41ff5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("40ec1312-387b-4e83-accc-7ae0a119ac09"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("41e58531-941c-4250-9ec1-48064bc0e43e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("479a74e4-49cd-4467-b3d5-8af060143684"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("59c51a11-5a47-4f36-9ce7-6ac230f39955"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6739879a-2613-4948-a7eb-c80d3955b555"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("72f01bb0-f562-4bca-bf2b-89dee330433b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("73283753-3c41-48de-b5df-2690b851a8f3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("794c409e-2e13-4511-b80a-d7e4b8fdd2ba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("82d10a93-7154-4b79-8d5a-e1c5d0f3d695"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("89711ff1-93d8-4904-b0e1-3d30674e6a86"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8c47b9da-aad2-49db-b732-6b7a4a2be151"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8c6b4f23-5de1-4b83-904e-46991d612655"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8e12cdc0-d66f-47d8-92d1-ca0c50a79bd4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8faabd1d-5d05-4b21-a885-9dda4e23223c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90d4f312-8da4-4ce0-8800-2f1c9900bf70"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("922bb8e9-9f0b-4bbc-8883-c0e05d257ee3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("99900ed5-e848-462d-8824-b3b503c5db0e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1c2036a-44db-46d8-be33-3c6e1d4ac510"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1edb247-9e6b-45c9-8b81-a09cb35d0a2c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a43c16cb-d15a-42b8-b4e8-c2adb2ad6753"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a79db352-0bac-4f7e-8cce-e63f7eeec8e5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a85ea43f-491d-4e33-b08c-9ff225e3d32f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a956e509-d72d-43ba-9c3d-fba63f6476ac"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aa61fe07-aab9-497b-8965-5b0b5558ca8e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ab56c5b6-849e-4fa1-86a7-6895603355b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b948549b-52d1-4e7a-8dea-2aab19fa7b68"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bc70e7ea-42b9-46ad-9aff-61b50aa9e037"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("be3bf24e-540d-45f1-9922-f816d26c4e08"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c10fb158-be03-4a87-8b15-c5f389208f65"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c13337a4-afd6-4867-b001-ac9c294e4fed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c89d05cf-38d9-4b1f-8729-9d27edc6abc9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c900c3a0-bc18-47fb-a4cd-d159e19b9c70"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cd240a94-36be-4404-88d9-dcb8a0da4100"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d262ee14-b913-4869-a94d-54a98e25193b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d5e52f1e-b5a9-4661-988c-20b8777b78a3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d78205e5-dd0c-420a-ad0a-c504f74639f8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("db5bff12-7a32-48e8-95b6-fc3b2b895c7f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e16d6988-b978-49b5-a93b-1e2fee50ef90"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e99539fd-c2e7-4b72-a765-a16b5d79b19e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("eac351dc-def9-4ee0-bf3a-d6d67f5bad61"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ef5bb676-0494-43a6-8369-6f2d16c8c61f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f0b9e182-ded6-42b5-81cf-3ccaf80e6915"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f2eff664-cac5-41d3-87d9-500447c61fb9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd418120-5a60-425f-8453-725ce0db7de5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("008baa26-a286-4358-8135-305f9a98ea76"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0226e1be-33b3-4eaa-84ec-eabef67a02af"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0ef17789-9f2f-4aca-a874-0d3ac610271d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1b92a3e8-516e-43f9-8148-9d9492c203f3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("20deeeae-50f7-4ce6-83ba-0d418ba537d1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2ea7e098-7459-4d3c-bb50-b54997df31b9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("42311a99-4dd2-46f2-a15f-6929046f11dc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("55591799-fa97-433e-be04-73c496e960da"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("57de6074-ef22-45d2-ba55-4c0e476c89ea"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("724ac5f4-52c4-42f1-9e85-bcd34e4e1be9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("74dbfd35-8a29-42b1-95f3-035c80a8a793"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8357f099-5ee8-4baa-ba1f-3268d5ea550b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a13ac6a7-8285-47a1-a0e1-3a0b3a3cbba4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a2f148f3-368b-471f-9d5d-37d59f45b960"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a36b08aa-3568-4434-b561-29412557a1b0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a808a3b3-dc23-4671-9677-f3961f9116bd"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b6c2867a-0de2-4a45-9df7-75a06a8fdd44"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ba5eda4a-4741-4c0f-903f-c5322bf9a414"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bb51e441-8b77-4046-8852-9c75b0739f34"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bb80e177-08b0-4c79-8b4d-4a84cc3c5336"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("bcc4c23d-3b95-4622-bf28-5e42f7ae0636"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("cd34e89c-fbd4-4caa-a343-737012613ace"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("da26b9bf-0bed-4559-a9ca-f452e8ff1198"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e9e9a8bb-8898-4edc-bdb5-7193e49eff97"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f4f1403b-bc90-4d0c-938e-618f4712beeb"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1c8957cd-cd37-4f87-a042-1479e988cfbd"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e1f6afe7-ead2-4a0e-9b2b-021a83eb8179"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fd8e368c-be23-45ce-b449-732db267e327"));

            migrationBuilder.RenameColumn(
                name: "BankAccount",
                table: "UserProfiles",
                newName: "BankAccountNumber");

            migrationBuilder.RenameColumn(
                name: "AccountName",
                table: "UserProfiles",
                newName: "BankAccountName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65d3be01-d499-42cc-9fc1-48d3da2c9380", new DateTime(2025, 8, 2, 23, 6, 0, 388, DateTimeKind.Local).AddTicks(2340), "AQAAAAIAAYagAAAAEGDHh3dlyz1/1RfCBGhTwKjHcOHPA5AP/oA8fYDYy2FFEPXyG1jmVTKWXI+0VCaUhA==", "8108c24e-6136-4b30-bff7-5c189dd0b84c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7480b5bf-f2ea-4100-b2f4-43ad3455ed9c", new DateTime(2025, 8, 2, 23, 6, 0, 533, DateTimeKind.Local).AddTicks(2869), "AQAAAAIAAYagAAAAEPSrgSbU2OFjiXg2pkOgJHsB70ECoW9o6OZwRHEFrSry3csqqkGcEZhLhjL7mvqKOw==", "dd759e48-655a-4c77-b125-cf09550aa94e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d2ffa9a-1fc8-496d-a686-c5cc5b0d49c9", new DateTime(2025, 8, 2, 23, 6, 0, 581, DateTimeKind.Local).AddTicks(4859), "AQAAAAIAAYagAAAAEGqlpO2RABudVCBY6WXukGjRk6OhKavAxqaH0PO6DjUJaw4QYgBbEdzsKOTwPzn3xQ==", "e567c369-e2d3-4814-9a24-048e81ae17f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c29581-d474-412e-9160-123370f1ec02", new DateTime(2025, 8, 2, 23, 6, 0, 337, DateTimeKind.Local).AddTicks(8680), "AQAAAAIAAYagAAAAEIe4A2rEwRJjM+TN1+FO2f1LraPSz/VLhG8V4n+nomFsBDvnwfuYp+/1Zbcdo7tj2A==", "ed8b8919-989c-4e93-b418-6067c21124df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f09dc7c-27ae-4770-aaf2-cf0b5aad531d", new DateTime(2025, 8, 2, 23, 6, 0, 485, DateTimeKind.Local).AddTicks(210), "AQAAAAIAAYagAAAAELCRPDKGRbRU4lP39RG5ZnHaIcDH4wHt9n7RmmjEHTd0kfEcU7p7rUDYlXaQZi5Tyg==", "cab9ead3-88b8-47cd-935c-0dee3ce048f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "242a8b02-1560-4f34-9d35-b0b21a0d5150", new DateTime(2025, 8, 2, 23, 6, 0, 437, DateTimeKind.Local).AddTicks(3158), "AQAAAAIAAYagAAAAEEhuKAhlq/BE3XwTMxCI46YeR7pMrJg2jIhLVA9Tts9Zfrt5GjJ9lk1YKqC71TMF2A==", "fa764890-ae73-4023-a15b-eade13f92595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cf8412e-d0f8-4170-967a-2e17d2221966", new DateTime(2025, 8, 2, 23, 6, 0, 629, DateTimeKind.Local).AddTicks(5998), "AQAAAAIAAYagAAAAEK4Ze3auwATBNhSbxAuH9hnC+PCijkNIXYhuBbpUSQ8mWR4FgXmp4UBfG+zL0LRoTA==", "626f164a-b33e-476b-a12e-9175c7181d16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2407615a-387a-447b-8593-8bc3b78801ad", new DateTime(2025, 8, 2, 23, 6, 0, 287, DateTimeKind.Local).AddTicks(5245), "AQAAAAIAAYagAAAAECUv+536pr5VaXBSAsBmbPzlI1FTNpwLY4U/OaOE9nqZb0d4nROeEBmZuVTDVZ7Usg==", "0229761c-4fb9-4e43-b9a7-1fd21cec4a6b" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("016a2e64-ec1b-4977-8db0-fb28c76b72b4"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("052ad574-91cb-40c5-8176-fa68f86f1ddf"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("055005d0-8311-4ba6-9d7c-80e042c5f8c5"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("07e72001-1113-47dc-a327-0856615298f7"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("083f5165-53e0-4f5b-b338-d98054d86a9c"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("198a005a-d395-4bb3-8b39-9242f9974e0d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("1c31fba1-584b-4a2a-9ef7-3b5779a3e9ff"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("21810733-a86a-474c-8855-f6c12840c13c"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("28196135-b577-43be-a9fd-bd31a09c03d5"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("2c03caa2-68f9-4cb9-ab8f-525ee9e6167e"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("2d24b812-bfa3-4a46-974c-d53ed14fc907"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("2ffbc50d-ca1f-4a49-80d8-ffc9b8f6eda7"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("30a7563a-cc73-4b15-9009-fe013fd0f797"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("3178d831-5d68-4756-9f9d-defe3e089fbf"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("33f9c572-6ef2-45d7-9cab-e3a9c1fe63ba"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("34918532-f930-429c-b1eb-61bf772b9843"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("34d4795e-2101-464d-80e4-e400de13f523"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("3c62d41a-0069-4442-82fb-6fe50b80c5e6"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("3cb49453-7220-44cc-b51a-79bf77e210b8"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("3f80a6ce-203c-4fe0-b79c-3e111d0eb29b"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("4189d968-3fa6-4b7c-9114-7ffeadc60fe0"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("42710e28-01c0-482b-8cbf-03fb3832e0e2"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("430c2164-c936-49ca-9419-28fe16215c76"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("441933b9-802f-4257-80d9-3f2bf6fde78e"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("51c4596e-6470-4513-9067-8e49e0e6f980"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("565c5928-5131-471b-b96e-0978327ecc88"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("566f92f5-386a-4668-9c5a-1b4c0b212708"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("5aec928c-be3f-4b98-a6db-6183d0011e4d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("5fa2f608-8f2c-4da0-afa6-c2712c1164f7"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("6121f8e1-a709-4fdb-9a03-8f8c1e2ce886"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("6135c185-d77e-4fed-8196-f4e44ed8b678"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("61a9cb4b-a13a-43e0-828c-16ac1aa152de"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("632c39d0-57e3-400f-8593-c93971547714"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("649aec8f-3010-4dc0-8cd4-2b41fba2f7d3"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("66371603-3bae-473f-9eda-e962634de81a"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("6d62ae55-c4d5-466b-81e6-090f02252b69"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("6f5fbd56-5767-4bcd-a78b-83c49d9e8043"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("6f783074-e3b8-4f06-956b-9330afb0b93d"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("73a2808f-0bb5-41cb-823f-8b93e53e47b5"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("7815625f-1192-4640-92b9-e9c63c7a5b51"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("7c09a452-c5b0-4858-9e4f-2bfe6a55e0c4"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("9167b088-b974-4844-84a7-7df3e2827031"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("9198a589-96f3-4006-a8f8-92ddb618f4f7"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("9865ea0b-688d-42b3-8047-29aa36529ac8"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("9ef49af7-1771-450b-bd1c-67b65fbdbc61"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("a4489fb8-263f-4576-b199-dca6905c961b"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("a817232b-d4bc-43aa-b0d4-94dcf3089bcd"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("b123bf45-3bee-4270-84dc-33403fe1f344"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("bb5a1e31-5849-4cbd-b04b-237a842e1396"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("c058f47a-a1ef-41db-9426-da6010f62730"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("c3feabbc-2329-434f-ab94-a80dda3b3f9e"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("caa554dc-ec2e-4511-b0f8-34e60c34235b"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("d53f0f44-7b50-49c9-a5cc-70fbb5d4db2a"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("d614545f-01db-4414-8e0c-22a9cf40a5be"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("d70eec4d-7b33-49f6-80c2-6a0a4cd53d82"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("dd7709f9-efb7-4cdd-862d-bc6b3f0a5e29"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("dec344b0-e306-4fe3-b25e-a2044d0696ee"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("dfab320a-8350-4a36-b486-85bc1a18d299"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("e7be120a-93a0-4225-902c-ac362e04811a"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("f182dd66-9078-4676-92cd-d71b1311ed3a"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("f610f507-509f-401e-8a82-b654b0e313ed"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("fec70052-a366-4118-878e-58504f354882"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("087a0718-efb0-4138-8ef9-ce97b2a0177f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("0d3d8d44-0367-483b-8153-c563e604ba4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("1972cf4e-1df1-4365-ae4c-37be9439e1a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("1f34f7c6-9399-40a1-86c8-5a6e821e7f10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("2a6014a5-a349-41a0-9688-7545c098e0eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("31cabdce-6683-44ea-a79e-1185d4af245b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("32e185b7-39dd-46b9-b896-39d0a0e463ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("4254be0b-de24-45a2-86bf-6a6e399225c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("556cbce8-5dbe-4e84-9ac0-9df4cdb39e15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("5c38efa7-527f-4c1a-9af3-cdf86cfde7a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("6b03d238-72ca-45f4-9b9e-7d12e5a514a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("7a9f4c5e-f4d5-4b09-98b5-0bd0fbb299e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("82b20146-796a-4a50-a40e-5b44d8668869"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("9442ef2f-13cb-418f-92d9-135dd47618ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("a7c2c923-0345-491c-9ed1-351c6e6e4ef9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("b4158212-d898-432f-8c24-3c92c59db152"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("b57433f7-9819-47ee-bbd4-126b21a0f4cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("b5c1d150-7768-4f16-9fa4-c5aa53311b90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("c6065548-b953-4edf-90a6-65a026196fb3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("c69c3b36-19c8-4b36-ad81-a5f568b66f95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("d50156b0-c1dd-4dc3-9bbc-84e84574a698"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("ddaf471d-fb97-4d7a-b34c-f625d5e7fb0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("df18ab63-2f62-430c-afab-323c0f530b74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("e43932a6-c58f-4db0-a8b2-5ac01dfc6646"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("e95ad6df-3dc9-4b30-af4d-824495cf941a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 23, 6, 0, 269, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("72a024dd-cef4-4b15-994b-8c5552f3b9be"), "This game is good, but it has some bugs", new DateTime(2025, 8, 2, 23, 6, 0, 277, DateTimeKind.Local).AddTicks(1108), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("916e58d3-c5d9-4dc4-a04a-fe8ac015ee6c"), "This game gives me a cozy vibe", new DateTime(2025, 8, 2, 23, 6, 0, 277, DateTimeKind.Local).AddTicks(1106), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("bab7f611-2ae2-48db-b2ea-b26078626ca4"), "This is the best game I have ever seen", new DateTime(2025, 8, 2, 23, 6, 0, 277, DateTimeKind.Local).AddTicks(1090), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("016a2e64-ec1b-4977-8db0-fb28c76b72b4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("052ad574-91cb-40c5-8176-fa68f86f1ddf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("055005d0-8311-4ba6-9d7c-80e042c5f8c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("07e72001-1113-47dc-a327-0856615298f7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("083f5165-53e0-4f5b-b338-d98054d86a9c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("198a005a-d395-4bb3-8b39-9242f9974e0d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1c31fba1-584b-4a2a-9ef7-3b5779a3e9ff"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("21810733-a86a-474c-8855-f6c12840c13c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("28196135-b577-43be-a9fd-bd31a09c03d5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2c03caa2-68f9-4cb9-ab8f-525ee9e6167e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2d24b812-bfa3-4a46-974c-d53ed14fc907"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2ffbc50d-ca1f-4a49-80d8-ffc9b8f6eda7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("30a7563a-cc73-4b15-9009-fe013fd0f797"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3178d831-5d68-4756-9f9d-defe3e089fbf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("33f9c572-6ef2-45d7-9cab-e3a9c1fe63ba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("34918532-f930-429c-b1eb-61bf772b9843"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("34d4795e-2101-464d-80e4-e400de13f523"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3c62d41a-0069-4442-82fb-6fe50b80c5e6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3cb49453-7220-44cc-b51a-79bf77e210b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3f80a6ce-203c-4fe0-b79c-3e111d0eb29b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4189d968-3fa6-4b7c-9114-7ffeadc60fe0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("42710e28-01c0-482b-8cbf-03fb3832e0e2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("430c2164-c936-49ca-9419-28fe16215c76"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("441933b9-802f-4257-80d9-3f2bf6fde78e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("51c4596e-6470-4513-9067-8e49e0e6f980"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("565c5928-5131-471b-b96e-0978327ecc88"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("566f92f5-386a-4668-9c5a-1b4c0b212708"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5aec928c-be3f-4b98-a6db-6183d0011e4d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5fa2f608-8f2c-4da0-afa6-c2712c1164f7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6121f8e1-a709-4fdb-9a03-8f8c1e2ce886"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6135c185-d77e-4fed-8196-f4e44ed8b678"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("61a9cb4b-a13a-43e0-828c-16ac1aa152de"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("632c39d0-57e3-400f-8593-c93971547714"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("649aec8f-3010-4dc0-8cd4-2b41fba2f7d3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("66371603-3bae-473f-9eda-e962634de81a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6d62ae55-c4d5-466b-81e6-090f02252b69"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6f5fbd56-5767-4bcd-a78b-83c49d9e8043"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6f783074-e3b8-4f06-956b-9330afb0b93d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("73a2808f-0bb5-41cb-823f-8b93e53e47b5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7815625f-1192-4640-92b9-e9c63c7a5b51"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7c09a452-c5b0-4858-9e4f-2bfe6a55e0c4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9167b088-b974-4844-84a7-7df3e2827031"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9198a589-96f3-4006-a8f8-92ddb618f4f7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9865ea0b-688d-42b3-8047-29aa36529ac8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9ef49af7-1771-450b-bd1c-67b65fbdbc61"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a4489fb8-263f-4576-b199-dca6905c961b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a817232b-d4bc-43aa-b0d4-94dcf3089bcd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b123bf45-3bee-4270-84dc-33403fe1f344"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bb5a1e31-5849-4cbd-b04b-237a842e1396"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c058f47a-a1ef-41db-9426-da6010f62730"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c3feabbc-2329-434f-ab94-a80dda3b3f9e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("caa554dc-ec2e-4511-b0f8-34e60c34235b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d53f0f44-7b50-49c9-a5cc-70fbb5d4db2a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d614545f-01db-4414-8e0c-22a9cf40a5be"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d70eec4d-7b33-49f6-80c2-6a0a4cd53d82"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dd7709f9-efb7-4cdd-862d-bc6b3f0a5e29"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dec344b0-e306-4fe3-b25e-a2044d0696ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dfab320a-8350-4a36-b486-85bc1a18d299"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e7be120a-93a0-4225-902c-ac362e04811a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f182dd66-9078-4676-92cd-d71b1311ed3a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f610f507-509f-401e-8a82-b654b0e313ed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fec70052-a366-4118-878e-58504f354882"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("087a0718-efb0-4138-8ef9-ce97b2a0177f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0d3d8d44-0367-483b-8153-c563e604ba4c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1972cf4e-1df1-4365-ae4c-37be9439e1a3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1f34f7c6-9399-40a1-86c8-5a6e821e7f10"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2a6014a5-a349-41a0-9688-7545c098e0eb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("31cabdce-6683-44ea-a79e-1185d4af245b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("32e185b7-39dd-46b9-b896-39d0a0e463ff"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4254be0b-de24-45a2-86bf-6a6e399225c6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("556cbce8-5dbe-4e84-9ac0-9df4cdb39e15"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5c38efa7-527f-4c1a-9af3-cdf86cfde7a4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6b03d238-72ca-45f4-9b9e-7d12e5a514a7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7a9f4c5e-f4d5-4b09-98b5-0bd0fbb299e4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("82b20146-796a-4a50-a40e-5b44d8668869"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9442ef2f-13cb-418f-92d9-135dd47618ac"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a7c2c923-0345-491c-9ed1-351c6e6e4ef9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b4158212-d898-432f-8c24-3c92c59db152"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b57433f7-9819-47ee-bbd4-126b21a0f4cd"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b5c1d150-7768-4f16-9fa4-c5aa53311b90"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c6065548-b953-4edf-90a6-65a026196fb3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c69c3b36-19c8-4b36-ad81-a5f568b66f95"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d50156b0-c1dd-4dc3-9bbc-84e84574a698"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ddaf471d-fb97-4d7a-b34c-f625d5e7fb0d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("df18ab63-2f62-430c-afab-323c0f530b74"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e43932a6-c58f-4db0-a8b2-5ac01dfc6646"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e95ad6df-3dc9-4b30-af4d-824495cf941a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("72a024dd-cef4-4b15-994b-8c5552f3b9be"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("916e58d3-c5d9-4dc4-a04a-fe8ac015ee6c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("bab7f611-2ae2-48db-b2ea-b26078626ca4"));

            migrationBuilder.RenameColumn(
                name: "BankAccountNumber",
                table: "UserProfiles",
                newName: "BankAccount");

            migrationBuilder.RenameColumn(
                name: "BankAccountName",
                table: "UserProfiles",
                newName: "AccountName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39cd0063-a114-4149-b322-46c460c70cfa", new DateTime(2025, 8, 2, 22, 32, 9, 753, DateTimeKind.Local).AddTicks(2967), "AQAAAAIAAYagAAAAEKuqoZpSYZl72pJkhEgQYkJNJVQPVjUHHUGWSkqlhVU1thBKQuG0fSs8B0ZAzo/ddQ==", "c3dbceb7-b385-43e3-a7c3-a605b285689a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85c37a6b-db21-49c0-b559-507edbd049ab", new DateTime(2025, 8, 2, 22, 32, 9, 923, DateTimeKind.Local).AddTicks(8839), "AQAAAAIAAYagAAAAEKh+j1pPNlA1GCMNot/gj9q0X3+WdP3ee9XghwxcedknBRmIaYYX1IX33kxCVPRDuQ==", "ab6afc65-21f3-4fec-ba37-cf9ebefea883" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e6aaa2-e4b8-4672-b330-592379b3bfe4", new DateTime(2025, 8, 2, 22, 32, 9, 981, DateTimeKind.Local).AddTicks(3571), "AQAAAAIAAYagAAAAED7KeO5frAkouv8twqgVVBHxgXyVH5Ns3ZCMFs+FLbw4CGpZ/pxfWn+EhgF+Rb5FTA==", "771ca6d5-6f31-4802-bd07-61ff4683dbdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6914104c-0477-44f1-a176-f0db46c53307", new DateTime(2025, 8, 2, 22, 32, 9, 691, DateTimeKind.Local).AddTicks(1251), "AQAAAAIAAYagAAAAEChd3MNsixn4DWJmJsTd5CY7+O0ZrG46l8EsjEmvgahtk2cLS11ZGl3ES51tj4ylFQ==", "6821660b-c02d-458a-8782-f35b8425fbe9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9e8ab42-169f-4299-b9c1-1813e49fe6b6", new DateTime(2025, 8, 2, 22, 32, 9, 868, DateTimeKind.Local).AddTicks(477), "AQAAAAIAAYagAAAAECpOQGGTLbTPSBNRdjq9jBYIy9tI8I2OUEs43TqZEXr0fCbZ5Zd/Zc2TSQtJ/OxtWA==", "609b335c-73b2-4ae9-8661-e4130ec2e9ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "750600ce-ac91-4886-bfeb-69cc2b189aff", new DateTime(2025, 8, 2, 22, 32, 9, 810, DateTimeKind.Local).AddTicks(4860), "AQAAAAIAAYagAAAAEDAdQDXUU7XdGbrV+eSeJOAwBteB3GIUtgJM7VxfEENLytSWaNVXceNVjPnpEX9CzA==", "845e39cc-4a96-431f-9d9b-a1fe351537bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5bb21e3-53cc-4b15-afaa-fb7d5678df65", new DateTime(2025, 8, 2, 22, 32, 10, 38, DateTimeKind.Local).AddTicks(8124), "AQAAAAIAAYagAAAAEBlFw7vIyIQa8JFYVObkuyB/KkITBqeEroMFD7g9WNltIY4RswIVnD5gnpHqL8hvjg==", "63871d73-c140-45b9-afd4-1d02d06960ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5daea600-a0d7-447a-8e3a-11e3a9c300ca", new DateTime(2025, 8, 2, 22, 32, 9, 631, DateTimeKind.Local).AddTicks(6763), "AQAAAAIAAYagAAAAEKk4G67Q+KZi8QEgHDegOEWXOGzTJj2lSCL6KQRjApfvLHsRAq3daUF8379r5s26AQ==", "78e345de-93e3-4543-a445-814a7fe1891d" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("00d3bcb5-c507-4a6e-b874-08d442217146"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("03e4a07d-955f-43a7-a7bf-aa8884ca94fd"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("042664f1-b2ce-41a5-b3fd-5188f99657cd"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("08394abb-23f7-444e-9145-33b2ed710e28"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("0a79757a-b011-410b-bc0f-f518681724d0"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("0b508e73-2c80-4b4d-935a-9970b5aa5904"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("14bbd2da-a65a-4216-8e2b-11667bd4cf90"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("171e60ea-1bc7-4d8c-acea-18aa8fb69108"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("194a148d-ac3c-4da3-90a6-0d846bb161f2"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("1b44d8e5-3893-4c2f-a9dd-b7a585396c72"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("1f5c7c73-9466-4049-b7ca-0d6baed4d01f"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("2040fdea-bb11-45a8-8e7a-f9cbdc7a06ce"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("205dd8c1-47cc-4dbe-b869-3e5a44a88871"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("22b87c1d-4320-486b-b8d7-2878347a1a83"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("30e83ec3-867c-4ba3-978a-7d448e80270a"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("3470d896-2d21-4343-ba2b-735521da819c"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("3c3e16b9-46dc-4075-937b-0f452985ff59"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("3f011db1-e849-4fc6-b713-1b64add41ff5"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("40ec1312-387b-4e83-accc-7ae0a119ac09"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("41e58531-941c-4250-9ec1-48064bc0e43e"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("479a74e4-49cd-4467-b3d5-8af060143684"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("59c51a11-5a47-4f36-9ce7-6ac230f39955"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("6739879a-2613-4948-a7eb-c80d3955b555"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("72f01bb0-f562-4bca-bf2b-89dee330433b"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("73283753-3c41-48de-b5df-2690b851a8f3"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("794c409e-2e13-4511-b80a-d7e4b8fdd2ba"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("82d10a93-7154-4b79-8d5a-e1c5d0f3d695"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("89711ff1-93d8-4904-b0e1-3d30674e6a86"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("8c47b9da-aad2-49db-b732-6b7a4a2be151"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("8c6b4f23-5de1-4b83-904e-46991d612655"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("8e12cdc0-d66f-47d8-92d1-ca0c50a79bd4"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("8faabd1d-5d05-4b21-a885-9dda4e23223c"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("90d4f312-8da4-4ce0-8800-2f1c9900bf70"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("922bb8e9-9f0b-4bbc-8883-c0e05d257ee3"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("99900ed5-e848-462d-8824-b3b503c5db0e"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("a1c2036a-44db-46d8-be33-3c6e1d4ac510"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("a1edb247-9e6b-45c9-8b81-a09cb35d0a2c"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("a43c16cb-d15a-42b8-b4e8-c2adb2ad6753"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("a79db352-0bac-4f7e-8cce-e63f7eeec8e5"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("a85ea43f-491d-4e33-b08c-9ff225e3d32f"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("a956e509-d72d-43ba-9c3d-fba63f6476ac"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("aa61fe07-aab9-497b-8965-5b0b5558ca8e"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("ab56c5b6-849e-4fa1-86a7-6895603355b8"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("b948549b-52d1-4e7a-8dea-2aab19fa7b68"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("bc70e7ea-42b9-46ad-9aff-61b50aa9e037"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("be3bf24e-540d-45f1-9922-f816d26c4e08"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("c10fb158-be03-4a87-8b15-c5f389208f65"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("c13337a4-afd6-4867-b001-ac9c294e4fed"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("c89d05cf-38d9-4b1f-8729-9d27edc6abc9"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("c900c3a0-bc18-47fb-a4cd-d159e19b9c70"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("cd240a94-36be-4404-88d9-dcb8a0da4100"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("d262ee14-b913-4869-a94d-54a98e25193b"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("d5e52f1e-b5a9-4661-988c-20b8777b78a3"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("d78205e5-dd0c-420a-ad0a-c504f74639f8"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("db5bff12-7a32-48e8-95b6-fc3b2b895c7f"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("e16d6988-b978-49b5-a93b-1e2fee50ef90"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("e99539fd-c2e7-4b72-a765-a16b5d79b19e"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("eac351dc-def9-4ee0-bf3a-d6d67f5bad61"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("ef5bb676-0494-43a6-8369-6f2d16c8c61f"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("f0b9e182-ded6-42b5-81cf-3ccaf80e6915"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("f2eff664-cac5-41d3-87d9-500447c61fb9"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("fd418120-5a60-425f-8453-725ce0db7de5"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("008baa26-a286-4358-8135-305f9a98ea76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("0226e1be-33b3-4eaa-84ec-eabef67a02af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("0ef17789-9f2f-4aca-a874-0d3ac610271d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("1b92a3e8-516e-43f9-8148-9d9492c203f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("20deeeae-50f7-4ce6-83ba-0d418ba537d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("2ea7e098-7459-4d3c-bb50-b54997df31b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("42311a99-4dd2-46f2-a15f-6929046f11dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("55591799-fa97-433e-be04-73c496e960da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("57de6074-ef22-45d2-ba55-4c0e476c89ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("724ac5f4-52c4-42f1-9e85-bcd34e4e1be9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("74dbfd35-8a29-42b1-95f3-035c80a8a793"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("8357f099-5ee8-4baa-ba1f-3268d5ea550b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("a13ac6a7-8285-47a1-a0e1-3a0b3a3cbba4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("a2f148f3-368b-471f-9d5d-37d59f45b960"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("a36b08aa-3568-4434-b561-29412557a1b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("a808a3b3-dc23-4671-9677-f3961f9116bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("b6c2867a-0de2-4a45-9df7-75a06a8fdd44"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("ba5eda4a-4741-4c0f-903f-c5322bf9a414"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("bb51e441-8b77-4046-8852-9c75b0739f34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("bb80e177-08b0-4c79-8b4d-4a84cc3c5336"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("bcc4c23d-3b95-4622-bf28-5e42f7ae0636"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("cd34e89c-fbd4-4caa-a343-737012613ace"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("da26b9bf-0bed-4559-a9ca-f452e8ff1198"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("e9e9a8bb-8898-4edc-bdb5-7193e49eff97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("f4f1403b-bc90-4d0c-938e-618f4712beeb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 2, 22, 32, 9, 610, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c8957cd-cd37-4f87-a042-1479e988cfbd"), "This is the best game I have ever seen", new DateTime(2025, 8, 2, 22, 32, 9, 619, DateTimeKind.Local).AddTicks(7990), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") },
                    { new Guid("e1f6afe7-ead2-4a0e-9b2b-021a83eb8179"), "This game gives me a cozy vibe", new DateTime(2025, 8, 2, 22, 32, 9, 619, DateTimeKind.Local).AddTicks(8000), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("fd8e368c-be23-45ce-b449-732db267e327"), "This game is good, but it has some bugs", new DateTime(2025, 8, 2, 22, 32, 9, 619, DateTimeKind.Local).AddTicks(8003), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") }
                });
        }
    }
}
