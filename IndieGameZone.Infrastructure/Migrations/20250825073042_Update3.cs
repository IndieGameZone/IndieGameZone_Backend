using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReportTypes_ReportReasonId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportTypes",
                table: "ReportTypes");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("04e2b25c-4d03-4732-afe6-8f1bbd243d1b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0ebc3005-794f-47db-8535-f1d77abb3171"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1318edda-fe46-41fc-a27f-51b96c5f5812"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("208c4011-7d49-4f7b-bed7-fc45b62aa3ae"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("21a59a75-5ca5-48f8-a841-261b58a84435"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("241e4fc0-c1f2-4605-9eb1-d47627598ac9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("25c3bea2-1d26-45fd-8faa-feda7e8d6fcd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("26a06305-34a1-4a0e-b16d-26b0011a1a5b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("36a8ced4-3295-484c-9e90-45051bf75dad"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3c0a98a9-642d-42ad-aa60-1d911a73f30f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3cd15e2f-8a11-48e8-bc23-49faf9acfaaa"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e3a875e-fcf6-488b-b01d-f55ab3076598"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e723fa2-8a48-4263-b11d-4fb42d7a3d2d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4bbc001b-db0b-4f51-842e-826a28ccc3ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("53ab8c86-6b64-4b2b-bff8-241c7b9dc8f1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("53acc6d8-aee7-4f59-8d6c-65ed46f36c2f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("57f6c528-bb16-4639-93e5-971d2023c327"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5bacf8dd-8c91-4e17-8eeb-d1c521f549d9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5cffe537-35d1-4ab3-a589-b75b0146c20e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5da379c4-a576-409c-8b96-9054196e6f26"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5e0f448c-2fc5-47b9-97a2-66b2009d7f5f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("659b6665-e8aa-4f19-9825-6aaff19b0ab3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6c26fab0-bb29-4d80-893e-6c496e742930"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7580ef29-f2bd-4004-a05f-6dc0a4681c65"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7601612d-061f-4f27-9faa-c7488525173f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("785d86d5-a2d9-485e-bf20-2c2cbdabc5f5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7e196904-fdf6-44f4-9d33-e316097fe267"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("80f06aaf-8622-4cdf-a88b-7f3957777193"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("83848cbe-8861-4310-bbb8-79f36fc47dda"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("92c94061-ec9b-485b-8c7d-d429d7506110"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1d0be16-2240-4169-b018-b602fe77354c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a1f3fd8f-d388-403a-a22a-54bc3f7f3d47"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a4d4e459-2bdf-47ab-8fe8-fc74c9121eed"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a992bec9-5285-4c6b-b6ad-4b204a67280b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aafc84e9-9abc-4ebb-b021-a2749b67ba15"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ad5b5897-2aa5-4428-a91d-3b4165e75c96"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b33e3993-3ea6-404f-aeb7-ab2aaa6fe7ba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b4b1fde9-99a8-4d04-aa47-e0a1b265e163"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b57d2a23-9f30-4639-bf30-748be528f789"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b9f43490-a750-4638-aa1b-2c5e6ec65968"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bea74a4d-27c3-4510-876a-dfdc24064f7a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c0fb6a32-04c7-421e-af54-3f23ef743be5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c582b1df-3095-493a-baa5-7ff34cc50426"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c5cc69c9-8f4b-4804-8929-8b646ae943c0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb16aa3f-3ce5-439b-89a8-528b6eb77e4e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ce2f8390-aa42-4acf-be81-d68068fdc6b2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d099bf02-685c-493c-8efd-accbdcc5efc0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d2ab8e26-a1a8-4c82-8dda-946ec10fe13f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d371137f-445e-47fb-9184-b48074ba480c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("dfdcf562-1c67-4344-8986-4473eee9ab50"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e25af532-7b7e-4f02-94f8-81dfd1e8dc5b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e309564f-657b-4777-9780-04013f7bb898"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e540e27b-10f1-4019-9d25-2e702cde801b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e7124b49-1564-4cd6-aaea-fa4bc8fb9742"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e9eb0459-ca13-429c-9d9a-1200327c1740"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ebab4021-0f39-405d-9f5f-b9e2a353fcc8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ee3a5ef5-1127-49d3-8e36-e7c266be8746"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f55b221d-fc80-49cd-8f8b-c5cc1be46629"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f8c60c29-00d5-4a26-b53d-a673c04e13d7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd1bceff-1bfe-43ce-b246-ade92b970bb0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd2e8b43-1a56-4392-afc3-cbd0eb48611e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fee4e532-2ac9-4c70-adf2-a3abfc93691d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0812a406-1c77-47dc-a6c8-7c3cb5c25d82"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0894c9a6-eea2-474f-bb88-bb204c039db4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("16ffe539-1c0c-4b33-851f-75bc9b05d9c7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("19168000-2342-4b3c-9d4c-e125ed6522fe"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("1dbf27e0-1203-486f-9168-476434f422a4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("22151d53-0f51-4aa2-a179-e1a2483d562a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("30261e01-eda7-44b8-998b-9a58e1975352"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("330be92e-f2a8-45b4-a57c-bbfd2c18cfe0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3d478e0b-cdb8-4af0-b804-1f3de5f5b7c6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4700d947-de0e-43f7-b753-ebaa595485af"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("63491197-cbbd-41cd-bb0a-ab50890b42ed"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6931a81d-92c6-4632-bf60-dc536f01f55a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6c3e56a4-69ec-44bc-b883-a983b2265853"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7e9a520b-8adf-4631-b787-a0c840ab93fe"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("833903a6-ed42-4a26-ab0d-599a1a0c99a1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("900e47a8-54e6-4a8e-9d38-211686986bbc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("93fb54f4-5be6-490d-972b-537cfa8ab31a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9757354b-5cd8-449e-951d-d165da196869"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9966df19-7dab-496b-85ac-f23db0bf3690"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e9589c26-f6be-4255-88c8-7aa35b3d80f9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f050d6d4-2323-4d63-8282-dc18896188fc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f2d1f24f-8457-4d89-8cb8-5f2595bee3b8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f882c178-4e2f-415b-bfc7-d43cb14265f2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f96c842b-e3cf-4881-9992-26cbfd7623e2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("fd2e9f20-7467-44ea-a0fd-200478c73c03"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("296dcfb5-d7ac-41a7-b753-bab756715c85"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("b384a170-a841-4184-9e06-41955748cce8"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f95a2cc9-1509-4f5f-8c47-5aa230cc2d82"));

            migrationBuilder.RenameTable(
                name: "ReportTypes",
                newName: "ReportReasons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportReasons",
                table: "ReportReasons",
                column: "Id");

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("01ba6e38-da40-4b52-9248-4fb352e92e9a"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("01c1655c-6777-4b21-80b2-aaf0af118c84"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("03b2e55e-bf16-4f95-958d-c5dbb1a04c21"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("0ae25ee6-3f66-4a2b-9f30-d3b2c7302170"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("0b22f64d-0b22-4e11-ab4d-6d97f97bad1f"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("0d502816-d10f-4bce-91c1-c3d363aaca6e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("18ceea39-798f-4e14-ba99-2d78001bca21"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("18dc4e33-d17c-43f2-9d9e-571a557f16b1"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("1de254ae-5845-4dd1-b590-e326ef9d2ff8"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("25e7a11d-d006-4931-bd43-99f874228c42"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("2ca5092b-505c-4171-9719-10abf70eb5a6"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("2dccf3ff-21bb-4f64-8d83-6cf0c12bc888"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("3979f95f-3bbb-4da6-9245-d619c7791b08"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("3a3f782e-d64d-420f-9c0d-e247e7d924f0"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("3c749c8c-bd9f-40f3-afc7-fb47f6b6c0b9"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("3d52b772-4abe-4cb1-a3be-0c14cf4796fc"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("3e0c9494-c5e2-4384-aa00-919c5135666f"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("3e260f6f-f4ab-4d9f-99ed-cb076597a50d"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("50d45112-9e40-432c-ac4e-eb93bddcd0d3"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("5641dc28-dd0d-425d-833a-bc56079f1829"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("5bb090d8-df36-4d66-8e7d-bab20b323940"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("6102b9ee-eaa5-4591-bed2-a845d18f1ce8"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("61b3267a-5dd5-484e-bd3f-ca1e85ba54b2"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("637a68c9-4d02-4ddf-8a11-6728d437346d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("69083be1-8076-4a6c-ac56-38c2f399f5e0"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("6be4da13-f04e-460c-b2f8-1d80d8362cba"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("6fa20747-36e1-4340-9e3d-479ec8e07759"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("716d039d-62e0-470a-8000-6500b0e670d4"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("71b22f2e-e816-40ca-a8a8-108b5d434f05"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("7945c530-d22f-4021-935c-80c37a16df3b"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("7a0bb4cb-ffb5-4863-9d6a-23492cf5b0ac"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("7b49b43d-5438-477f-af75-4dfe75163ebd"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("7dc26bd1-8d94-4b40-ab35-834457348810"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("80df3262-3611-4cd9-a6e3-3a2d170449b6"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("82c7f268-ca39-463d-ae8c-2d3bfc540f9d"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("8820cb78-f992-460d-8544-379127373c3a"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("95562aa1-cc7b-4cf0-89f0-e673bbd87421"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("9eba8a0a-522f-40c5-893e-dcef98aaeebc"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("a03ebcd3-20cb-4b50-8684-88acfc1f8463"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("a5b55592-f864-4717-a166-fe6c9f37bca7"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("a827a2f2-bf6a-469e-b2d1-3ddf9e18833d"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("aadbfef7-70bb-46e1-af75-7bced36073b4"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("b2da3f09-1ca1-4321-b960-86dacd2e07ca"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("b7a1c764-2b20-4be1-aeed-178da2ecfc7c"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("b89c6956-1655-400a-9eca-c4c823427da7"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("b9a02153-7fd9-4cce-9985-6af8c3547f34"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("bb9a71a6-b3d2-4748-8fb2-aca8c5b646b1"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("be1bc92e-660d-4e14-84dd-64e5ec20af4e"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("c78e78ea-fb08-47d0-abcf-587f57292c00"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("cb641a6f-07c8-47c2-a8a6-3a5d7a61b671"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("cd68e6a7-bf80-49fd-a681-12b1ba1c2ff3"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("d1e4e4dc-3f20-4454-b964-6203c890dbd3"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("d29e8787-9c6c-4424-8d9e-6fd39f1bd805"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("d37dbfcf-9d16-405f-95d1-c3486a0b956f"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("d60e0477-8dbb-459d-bba1-bbaf1dc40a33"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("d9758335-cbc0-4039-a44d-b5f96565cec7"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("da06ab33-08b4-474c-8b2d-d65281630941"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("e55ded4a-2528-4734-b35c-16244d70a7d6"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("ee57793e-85ab-4817-854c-d44601bc04dc"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("f69692cf-7628-4d99-8642-ab0dc16a4691"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("fd4aca92-938a-403b-83b7-9469e320e00c"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("ff68e65e-9bd9-478f-a676-e8f7b845433e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("0c1038c7-fc62-40f5-8ca0-a1e9065944c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("0eb52573-5fb3-4ed7-bfeb-afda49102b3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("29fb10ba-7685-4e50-95cb-dc39a17c5156"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("3ffad0fc-60ba-49e1-8d19-f82a588b1b42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("48defb9d-27d4-44d3-9187-95c6ba1a2f67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("4ac2df0a-2bac-48c7-989f-980a1a05573d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("4aed16a6-f7df-4239-a5b2-2ec2f5a2a5f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("5ffa3d11-e796-4ead-85a7-bf7e5d844f09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("606703fe-a9e8-4e4a-9c54-8da686945338"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("62b9a15c-7acb-4dac-a940-8888eb2574c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("6c7b7765-1861-4e02-a5fa-f44e6c5094d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("71e3b111-5211-4bf9-aa7f-5e34186fbde6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("739d10de-f1ad-42a2-9f72-37eaa4933622"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("7bb7e275-6746-463f-910e-1e6367f82ddf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("7dfcfc31-9f2b-44a5-939a-eae0d5dcdbcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("89755ca7-0342-41d1-b226-45a0a89ee1e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("8e435465-6cf1-4573-9c1d-48d96c5d9a18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("9fb04e69-13a2-4aff-8b96-1e34a8843d38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("a4dd9c84-85e3-4efc-8b04-5af6cb9ccaff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("a611f3e3-7cc5-4fc6-9737-836859b99ab8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("aa9ed0bf-5fc1-498e-9896-ebfa55189d27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("c5dc0d66-bcfc-4980-9e4f-07d346c2fe78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("da7571b6-5fce-4407-9cd9-f41ee09c7d31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("db13c86b-9423-4127-82eb-333657c9a486"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("ee5c3c61-b432-437f-9863-1442b1580d49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 14, 30, 41, 221, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("12149f22-840c-4c03-8928-8f3f6236c88f"), "This game gives me a cozy vibe", new DateTime(2025, 8, 25, 14, 30, 41, 228, DateTimeKind.Local).AddTicks(3407), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") },
                    { new Guid("9550f7d5-8a13-4a12-8878-ec2f428661ab"), "This game is good, but it has some bugs", new DateTime(2025, 8, 25, 14, 30, 41, 228, DateTimeKind.Local).AddTicks(3410), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("efb8d82b-c914-4f7a-8bbc-8d976605fda2"), "This is the best game I have ever seen", new DateTime(2025, 8, 25, 14, 30, 41, 228, DateTimeKind.Local).AddTicks(3370), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68b49c5f-0c54-4ee3-bbd5-8392abcb453f", new DateTime(2025, 8, 25, 14, 30, 41, 350, DateTimeKind.Local).AddTicks(123), "AQAAAAIAAYagAAAAEEvQwx7wiJTjyWRHv4AywOtEHeXh2va5NcP/Rtdf8m3pbgqn2ottxvODb2BwKvGI9w==", "e656b0ec-b8ff-4806-aa7c-1c59936de85c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe7bede7-70f2-4797-93e0-34d9b70a51f4", new DateTime(2025, 8, 25, 14, 30, 41, 525, DateTimeKind.Local).AddTicks(5854), "AQAAAAIAAYagAAAAEDgA7S7fMXF+5lurlG6+Y1S78b1JS22qxYZ0xT1whRbX+vsHAKpRVKmPLQldEmZIEg==", "617d89d2-8759-4c4f-b739-851748da9b8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d71768e-8d62-4794-a466-c23050a777fb", new DateTime(2025, 8, 25, 14, 30, 41, 579, DateTimeKind.Local).AddTicks(1850), "AQAAAAIAAYagAAAAENEGcLJubW9Am/G2zl3qLL/Z6L52EdOFWCuSuA89L0A2TuMUJuHi0naeGa/ZFs7Dwg==", "7b70d1c6-2b09-4912-9265-d253aeaee3f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b932e209-ce64-4639-9272-182e287fd217", new DateTime(2025, 8, 25, 14, 30, 41, 293, DateTimeKind.Local).AddTicks(7981), "AQAAAAIAAYagAAAAEEp6/E3ngHKPrpF8Fdx/83OkrDg9PQtcM3wYTYlQz84IGkD3v49LCK5MRRIpjPSVtg==", "40705da0-ba40-4377-b707-9266a6ffe312" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "778fd868-0ed0-433a-b834-f7ba7aa48da8", new DateTime(2025, 8, 25, 14, 30, 41, 467, DateTimeKind.Local).AddTicks(9116), "AQAAAAIAAYagAAAAEMvU8eiiZWBJJBcNOY3OuV/GTHD8oHRJr8a3QObYQFfWlUROxxo+F/hgIXHhCEN4+w==", "22e1d518-3b85-4c5b-aae9-5c279de633d4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "898d46c2-1e5a-4371-ab32-f028522ac84d", new DateTime(2025, 8, 25, 14, 30, 41, 404, DateTimeKind.Local).AddTicks(6866), "AQAAAAIAAYagAAAAELB6VyxxrCY9iUkeJs2uj+Ufm0GzjAlKKRk6gSZJ9F9Ox5cd4KdSg5zkWyj9G+4WNg==", "2ad78758-08c5-4007-98ec-d517fb9e06d4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7731a31-954a-4979-acf4-53fd0724f9ab", new DateTime(2025, 8, 25, 14, 30, 41, 633, DateTimeKind.Local).AddTicks(223), "AQAAAAIAAYagAAAAEI13RfTRgTxCY8K4Fyk3bS8+KR3LY6fO7WAvaP2uo8Nb1erwSmSRMHzLsG0wWNmy4A==", "eadc8653-d668-4018-a829-8fc9c267ae0a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4ae1d0d-7397-4f4f-978f-7cda0c511cbd", new DateTime(2025, 8, 25, 14, 30, 41, 238, DateTimeKind.Local).AddTicks(1029), "AQAAAAIAAYagAAAAELeqKK2htJsrEIrcz/TcwHiGd7TAyZHGeyhrzzDf6HtDk/5MC4/SN9xiFDXqKHag2g==", "ce9f38c5-8936-47f5-954b-486af330ad43" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReportReasons_ReportReasonId",
                table: "Reports",
                column: "ReportReasonId",
                principalTable: "ReportReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReportReasons_ReportReasonId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportReasons",
                table: "ReportReasons");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("01ba6e38-da40-4b52-9248-4fb352e92e9a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("01c1655c-6777-4b21-80b2-aaf0af118c84"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("03b2e55e-bf16-4f95-958d-c5dbb1a04c21"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0ae25ee6-3f66-4a2b-9f30-d3b2c7302170"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0b22f64d-0b22-4e11-ab4d-6d97f97bad1f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0d502816-d10f-4bce-91c1-c3d363aaca6e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("18ceea39-798f-4e14-ba99-2d78001bca21"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("18dc4e33-d17c-43f2-9d9e-571a557f16b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1de254ae-5845-4dd1-b590-e326ef9d2ff8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("25e7a11d-d006-4931-bd43-99f874228c42"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2ca5092b-505c-4171-9719-10abf70eb5a6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2dccf3ff-21bb-4f64-8d83-6cf0c12bc888"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3979f95f-3bbb-4da6-9245-d619c7791b08"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3a3f782e-d64d-420f-9c0d-e247e7d924f0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3c749c8c-bd9f-40f3-afc7-fb47f6b6c0b9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3d52b772-4abe-4cb1-a3be-0c14cf4796fc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e0c9494-c5e2-4384-aa00-919c5135666f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e260f6f-f4ab-4d9f-99ed-cb076597a50d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("50d45112-9e40-432c-ac4e-eb93bddcd0d3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5641dc28-dd0d-425d-833a-bc56079f1829"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5bb090d8-df36-4d66-8e7d-bab20b323940"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6102b9ee-eaa5-4591-bed2-a845d18f1ce8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("61b3267a-5dd5-484e-bd3f-ca1e85ba54b2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("637a68c9-4d02-4ddf-8a11-6728d437346d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("69083be1-8076-4a6c-ac56-38c2f399f5e0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6be4da13-f04e-460c-b2f8-1d80d8362cba"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6fa20747-36e1-4340-9e3d-479ec8e07759"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("716d039d-62e0-470a-8000-6500b0e670d4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("71b22f2e-e816-40ca-a8a8-108b5d434f05"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7945c530-d22f-4021-935c-80c37a16df3b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7a0bb4cb-ffb5-4863-9d6a-23492cf5b0ac"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7b49b43d-5438-477f-af75-4dfe75163ebd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7dc26bd1-8d94-4b40-ab35-834457348810"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("80df3262-3611-4cd9-a6e3-3a2d170449b6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("82c7f268-ca39-463d-ae8c-2d3bfc540f9d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8820cb78-f992-460d-8544-379127373c3a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("95562aa1-cc7b-4cf0-89f0-e673bbd87421"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9eba8a0a-522f-40c5-893e-dcef98aaeebc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a03ebcd3-20cb-4b50-8684-88acfc1f8463"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a5b55592-f864-4717-a166-fe6c9f37bca7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a827a2f2-bf6a-469e-b2d1-3ddf9e18833d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aadbfef7-70bb-46e1-af75-7bced36073b4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b2da3f09-1ca1-4321-b960-86dacd2e07ca"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b7a1c764-2b20-4be1-aeed-178da2ecfc7c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b89c6956-1655-400a-9eca-c4c823427da7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b9a02153-7fd9-4cce-9985-6af8c3547f34"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bb9a71a6-b3d2-4748-8fb2-aca8c5b646b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("be1bc92e-660d-4e14-84dd-64e5ec20af4e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c78e78ea-fb08-47d0-abcf-587f57292c00"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb641a6f-07c8-47c2-a8a6-3a5d7a61b671"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cd68e6a7-bf80-49fd-a681-12b1ba1c2ff3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d1e4e4dc-3f20-4454-b964-6203c890dbd3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d29e8787-9c6c-4424-8d9e-6fd39f1bd805"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d37dbfcf-9d16-405f-95d1-c3486a0b956f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d60e0477-8dbb-459d-bba1-bbaf1dc40a33"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d9758335-cbc0-4039-a44d-b5f96565cec7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("da06ab33-08b4-474c-8b2d-d65281630941"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e55ded4a-2528-4734-b35c-16244d70a7d6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ee57793e-85ab-4817-854c-d44601bc04dc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f69692cf-7628-4d99-8642-ab0dc16a4691"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fd4aca92-938a-403b-83b7-9469e320e00c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ff68e65e-9bd9-478f-a676-e8f7b845433e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0c1038c7-fc62-40f5-8ca0-a1e9065944c3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("0eb52573-5fb3-4ed7-bfeb-afda49102b3a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("29fb10ba-7685-4e50-95cb-dc39a17c5156"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3ffad0fc-60ba-49e1-8d19-f82a588b1b42"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("48defb9d-27d4-44d3-9187-95c6ba1a2f67"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4ac2df0a-2bac-48c7-989f-980a1a05573d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4aed16a6-f7df-4239-a5b2-2ec2f5a2a5f3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5ffa3d11-e796-4ead-85a7-bf7e5d844f09"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("606703fe-a9e8-4e4a-9c54-8da686945338"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("62b9a15c-7acb-4dac-a940-8888eb2574c0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6c7b7765-1861-4e02-a5fa-f44e6c5094d8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("71e3b111-5211-4bf9-aa7f-5e34186fbde6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("739d10de-f1ad-42a2-9f72-37eaa4933622"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7bb7e275-6746-463f-910e-1e6367f82ddf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7dfcfc31-9f2b-44a5-939a-eae0d5dcdbcc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("89755ca7-0342-41d1-b226-45a0a89ee1e6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8e435465-6cf1-4573-9c1d-48d96c5d9a18"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9fb04e69-13a2-4aff-8b96-1e34a8843d38"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a4dd9c84-85e3-4efc-8b04-5af6cb9ccaff"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a611f3e3-7cc5-4fc6-9737-836859b99ab8"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("aa9ed0bf-5fc1-498e-9896-ebfa55189d27"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c5dc0d66-bcfc-4980-9e4f-07d346c2fe78"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("da7571b6-5fce-4407-9cd9-f41ee09c7d31"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("db13c86b-9423-4127-82eb-333657c9a486"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ee5c3c61-b432-437f-9863-1442b1580d49"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("12149f22-840c-4c03-8928-8f3f6236c88f"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("9550f7d5-8a13-4a12-8878-ec2f428661ab"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("efb8d82b-c914-4f7a-8bbc-8d976605fda2"));

            migrationBuilder.RenameTable(
                name: "ReportReasons",
                newName: "ReportTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportTypes",
                table: "ReportTypes",
                column: "Id");

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("04e2b25c-4d03-4732-afe6-8f1bbd243d1b"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("0ebc3005-794f-47db-8535-f1d77abb3171"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("1318edda-fe46-41fc-a27f-51b96c5f5812"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("208c4011-7d49-4f7b-bed7-fc45b62aa3ae"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("21a59a75-5ca5-48f8-a841-261b58a84435"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("241e4fc0-c1f2-4605-9eb1-d47627598ac9"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("25c3bea2-1d26-45fd-8faa-feda7e8d6fcd"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("26a06305-34a1-4a0e-b16d-26b0011a1a5b"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("36a8ced4-3295-484c-9e90-45051bf75dad"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("3c0a98a9-642d-42ad-aa60-1d911a73f30f"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("3cd15e2f-8a11-48e8-bc23-49faf9acfaaa"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("3e3a875e-fcf6-488b-b01d-f55ab3076598"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("3e723fa2-8a48-4263-b11d-4fb42d7a3d2d"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("4bbc001b-db0b-4f51-842e-826a28ccc3ee"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("53ab8c86-6b64-4b2b-bff8-241c7b9dc8f1"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("53acc6d8-aee7-4f59-8d6c-65ed46f36c2f"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("57f6c528-bb16-4639-93e5-971d2023c327"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("5bacf8dd-8c91-4e17-8eeb-d1c521f549d9"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("5cffe537-35d1-4ab3-a589-b75b0146c20e"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("5da379c4-a576-409c-8b96-9054196e6f26"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("5e0f448c-2fc5-47b9-97a2-66b2009d7f5f"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("659b6665-e8aa-4f19-9825-6aaff19b0ab3"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("6c26fab0-bb29-4d80-893e-6c496e742930"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("7580ef29-f2bd-4004-a05f-6dc0a4681c65"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("7601612d-061f-4f27-9faa-c7488525173f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("785d86d5-a2d9-485e-bf20-2c2cbdabc5f5"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("7e196904-fdf6-44f4-9d33-e316097fe267"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("80f06aaf-8622-4cdf-a88b-7f3957777193"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("83848cbe-8861-4310-bbb8-79f36fc47dda"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("92c94061-ec9b-485b-8c7d-d429d7506110"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("a1d0be16-2240-4169-b018-b602fe77354c"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("a1f3fd8f-d388-403a-a22a-54bc3f7f3d47"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("a4d4e459-2bdf-47ab-8fe8-fc74c9121eed"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("a992bec9-5285-4c6b-b6ad-4b204a67280b"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("aafc84e9-9abc-4ebb-b021-a2749b67ba15"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("ad5b5897-2aa5-4428-a91d-3b4165e75c96"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("b33e3993-3ea6-404f-aeb7-ab2aaa6fe7ba"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("b4b1fde9-99a8-4d04-aa47-e0a1b265e163"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("b57d2a23-9f30-4639-bf30-748be528f789"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("b9f43490-a750-4638-aa1b-2c5e6ec65968"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("bea74a4d-27c3-4510-876a-dfdc24064f7a"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("c0fb6a32-04c7-421e-af54-3f23ef743be5"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("c582b1df-3095-493a-baa5-7ff34cc50426"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("c5cc69c9-8f4b-4804-8929-8b646ae943c0"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("cb16aa3f-3ce5-439b-89a8-528b6eb77e4e"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("ce2f8390-aa42-4acf-be81-d68068fdc6b2"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("d099bf02-685c-493c-8efd-accbdcc5efc0"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("d2ab8e26-a1a8-4c82-8dda-946ec10fe13f"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("d371137f-445e-47fb-9184-b48074ba480c"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("dfdcf562-1c67-4344-8986-4473eee9ab50"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("e25af532-7b7e-4f02-94f8-81dfd1e8dc5b"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("e309564f-657b-4777-9780-04013f7bb898"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("e540e27b-10f1-4019-9d25-2e702cde801b"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("e7124b49-1564-4cd6-aaea-fa4bc8fb9742"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("e9eb0459-ca13-429c-9d9a-1200327c1740"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("ebab4021-0f39-405d-9f5f-b9e2a353fcc8"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("ee3a5ef5-1127-49d3-8e36-e7c266be8746"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("f55b221d-fc80-49cd-8f8b-c5cc1be46629"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("f8c60c29-00d5-4a26-b53d-a673c04e13d7"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("fd1bceff-1bfe-43ce-b246-ade92b970bb0"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("fd2e8b43-1a56-4392-afc3-cbd0eb48611e"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("fee4e532-2ac9-4c70-adf2-a3abfc93691d"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "File", "GameId", "IsActive", "PlatformId", "Size", "Version" },
                values: new object[,]
                {
                    { new Guid("0812a406-1c77-47dc-a6c8-7c3cb5c25d82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0, "" },
                    { new Guid("0894c9a6-eea2-474f-bb88-bb204c039db4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997, "" },
                    { new Guid("16ffe539-1c0c-4b33-851f-75bc9b05d9c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0, "" },
                    { new Guid("19168000-2342-4b3c-9d4c-e125ed6522fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0, "" },
                    { new Guid("1dbf27e0-1203-486f-9168-476434f422a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0, "" },
                    { new Guid("22151d53-0f51-4aa2-a179-e1a2483d562a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001, "" },
                    { new Guid("30261e01-eda7-44b8-998b-9a58e1975352"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0, "" },
                    { new Guid("330be92e-f2a8-45b4-a57c-bbfd2c18cfe0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" },
                    { new Guid("3d478e0b-cdb8-4af0-b804-1f3de5f5b7c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006, "" },
                    { new Guid("4700d947-de0e-43f7-b753-ebaa595485af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0, "" },
                    { new Guid("63491197-cbbd-41cd-bb0a-ab50890b42ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0, "" },
                    { new Guid("6931a81d-92c6-4632-bf60-dc536f01f55a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0, "" },
                    { new Guid("6c3e56a4-69ec-44bc-b883-a983b2265853"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0, "" },
                    { new Guid("7e9a520b-8adf-4631-b787-a0c840ab93fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0, "" },
                    { new Guid("833903a6-ed42-4a26-ab0d-599a1a0c99a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997, "" },
                    { new Guid("900e47a8-54e6-4a8e-9d38-211686986bbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997, "" },
                    { new Guid("93fb54f4-5be6-490d-972b-537cfa8ab31a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0, "" },
                    { new Guid("9757354b-5cd8-449e-951d-d165da196869"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0, "" },
                    { new Guid("9966df19-7dab-496b-85ac-f23db0bf3690"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0, "" },
                    { new Guid("e9589c26-f6be-4255-88c8-7aa35b3d80f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994, "" },
                    { new Guid("f050d6d4-2323-4d63-8282-dc18896188fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994, "" },
                    { new Guid("f2d1f24f-8457-4d89-8cb8-5f2595bee3b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003, "" },
                    { new Guid("f882c178-4e2f-415b-bfc7-d43cb14265f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), true, new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0, "" },
                    { new Guid("f96c842b-e3cf-4881-9992-26cbfd7623e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0, "" },
                    { new Guid("fd2e9f20-7467-44ea-a0fd-200478c73c03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), true, new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0, "" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 25, 0, 44, 23, 681, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "GameId", "Rating", "UserId" },
                values: new object[,]
                {
                    { new Guid("296dcfb5-d7ac-41a7-b753-bab756715c85"), "This game is good, but it has some bugs", new DateTime(2025, 8, 25, 0, 44, 23, 691, DateTimeKind.Local).AddTicks(2337), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 3.0, new Guid("537f05fd-120c-40b0-b2ec-639756f866ab") },
                    { new Guid("b384a170-a841-4184-9e06-41955748cce8"), "This is the best game I have ever seen", new DateTime(2025, 8, 25, 0, 44, 23, 691, DateTimeKind.Local).AddTicks(2315), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 5.0, new Guid("23879117-e09e-40f1-b78f-1493d81baf49") },
                    { new Guid("f95a2cc9-1509-4f5f-8c47-5aa230cc2d82"), "This game gives me a cozy vibe", new DateTime(2025, 8, 25, 0, 44, 23, 691, DateTimeKind.Local).AddTicks(2325), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), 4.0, new Guid("91b106fa-7b95-480f-a12a-0e0303454332") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f91ba9ea-a1a1-4de4-b22f-ca68363d4a71", new DateTime(2025, 8, 25, 0, 44, 23, 997, DateTimeKind.Local).AddTicks(5580), "AQAAAAIAAYagAAAAEK+sfSdNGWX8RAYLF7SI6hY/Y2henL7kZnDI8vYDxDu7sUbV6FEyXJfkdGdWsPBvaA==", "fba6f5f2-f2ec-46ad-848c-1873fedb84f6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2114359-3e67-4862-b54e-8188c7511b8f", new DateTime(2025, 8, 25, 0, 44, 24, 182, DateTimeKind.Local).AddTicks(3270), "AQAAAAIAAYagAAAAEIEw2q5/1CQIRic3RpP6TF54sEVihvZDS+GKX4yGgIkL4UsNEsuBs6DgijCYpAbwYQ==", "78937b1b-28a0-4c11-840b-d45db6253be0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b743b6f1-5428-472d-bd69-1444dc3bb091", new DateTime(2025, 8, 25, 0, 44, 24, 243, DateTimeKind.Local).AddTicks(6487), "AQAAAAIAAYagAAAAEL2GpGNAlAf5w9ikRnnkgSvyutW/23OWW5hrZxnM1doKlOuPQ6vRO9Zpdb2qrpO+MQ==", "b2237d8c-cc06-40bd-a3a7-38b4df1e023d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b9d9c53-4834-4cfe-b8b8-52e0c51c27bb", new DateTime(2025, 8, 25, 0, 44, 23, 935, DateTimeKind.Local).AddTicks(6127), "AQAAAAIAAYagAAAAECvGLMko7MeLX/U40jcO75iGdUtXKgopylkLpXyDt+SWJYOxZ41JM08ybGhPB8LQoA==", "42e30334-d570-4737-b599-c955c6145148" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8437445-7f79-4a77-a096-59703720d51c", new DateTime(2025, 8, 25, 0, 44, 24, 120, DateTimeKind.Local).AddTicks(8116), "AQAAAAIAAYagAAAAEDXCHjYLPFFpqqa2CKuFak1nbltfhLkpD3tc9jjCIw7moeJGud8iUauKoD6rVoTBEw==", "bba48f04-765c-4138-b246-44dc3d5408c8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65c98076-cd91-49cf-a8a4-d9b93cc93c38", new DateTime(2025, 8, 25, 0, 44, 24, 55, DateTimeKind.Local).AddTicks(6611), "AQAAAAIAAYagAAAAEGs1qoYPXy2SiWfxKAiC4JgEL1kK4xS9WmLUMSfgTnOOh80q6lXp3BUEj6Ft6u42IQ==", "c30f0178-396f-4359-a3f8-6d8d396e5cc7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bb65833-6a72-4880-98a5-6a43ec62a087", new DateTime(2025, 8, 25, 0, 44, 24, 304, DateTimeKind.Local).AddTicks(5674), "AQAAAAIAAYagAAAAEAsB9qwD98mhFyhrwf7/m/imCWIs++Mo2uvAul4pfoS81YCINPdc7S/RwXgHDVxu0Q==", "6341a9fb-00b6-469d-9674-709a052f476b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "734a6d62-a5f9-4e6c-b313-46f88772d950", new DateTime(2025, 8, 25, 0, 44, 23, 876, DateTimeKind.Local).AddTicks(5353), "AQAAAAIAAYagAAAAEM8B3ey4SKxtxN5O31YuHZB9CDzsKxVlnaf6i7H6cI8sKy5rKAdihn50Fen7f98Bdw==", "5c1a37d6-f56d-4a05-b605-cde01c68fabc" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReportTypes_ReportReasonId",
                table: "Reports",
                column: "ReportReasonId",
                principalTable: "ReportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
