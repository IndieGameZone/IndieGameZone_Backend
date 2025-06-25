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
                name: "FK_Games_AspNetUsers_ModeratorId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_ModeratorId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("00856ffb-9775-4a37-a397-cb72551191a1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("013caa66-448f-4269-9853-01d3b4107908"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("09cbbfba-d3a3-4cec-922f-1644d8e58ecf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("10124e82-0ecf-4500-9933-64306077297a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("134c16da-1f1a-44bb-a7c6-2e9fb7818b17"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("19bd05c0-d577-41a5-b25f-83edea1b4a8a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("246d30d7-a4b0-474f-a9a9-79ac6e8e9563"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("24b7be82-1cac-46ac-af57-1c085d09e714"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2bf6c53d-2c2b-4782-8713-11e9b4904203"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3410f56e-c043-4197-9191-239f1890855d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("35f86fc2-2f6d-4523-8e92-71ec1718c63e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3d31af09-066c-44c3-9530-1b7a5c7d86e4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("43e9bc24-5ca6-4aea-9be7-1f30abb6f78f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4603ce40-a227-4c6d-aa63-0fea342b4c80"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("467a63bd-be18-49e8-9c17-0da37841cb62"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4ace96d4-28c1-40d6-8c8e-12b477bcc06f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4bdf7ea7-10d2-4f37-b50e-abdfac7c942a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4c856f03-a5bf-4b9e-b298-c16538251cee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4f9071fc-d78a-4ff2-a49e-e517d915fc85"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("515a1ced-1e9e-4557-aa57-3d618627be6d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("55929513-1637-472d-800d-7ee6631aa74d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5c0a98b2-ff67-42ae-ad94-a5b73d7bde86"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("61d0ca30-b830-4c09-97f6-aaafe7f2796a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("64b1e2c7-df46-4515-a769-9576884af253"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6ce2d7ef-89a5-4072-bce2-d49361ed1087"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7045892c-4321-4de1-88ef-5a9508f978d6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("73fa38a6-d99c-45c0-a75c-5e6d72f29ded"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("83ffff35-0907-4c4d-acf5-b9a483819d13"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("85ae6e0f-2d02-4486-8061-6e836c1b623d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("877d6049-b1a3-4d00-afdc-ffeba316eb6b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8798bdf2-b46d-4290-9fd5-a8b8063cb020"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8972a273-7d70-4e68-9c1c-13c984e73a15"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("90b4e61b-4ebc-4a8b-bda6-1d13b812d4f5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("97986222-69ed-437a-a983-c16c6ed6e9c3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9d5cc3cf-8f15-44f5-87e2-08a255f9ee1a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a2e89682-1484-4ed8-9457-c57c22f344b0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a5f5bb21-1970-485b-87b1-6e6d06ed169f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aa5a55e8-4d1a-47f8-af8b-693fd6475815"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aabc9b54-0343-41c7-925d-953dba53271c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ab5464b5-b7e3-4c7a-aac6-7329b1e23590"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b090056d-2041-486b-aad8-f2464198426f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b0c95bb2-e831-4315-a470-3c7913faed86"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b53a5acd-f531-42af-9011-5d5c8c581d2a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b6e86683-c66c-42a1-91b9-e0db85c257a7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b83534b1-5da4-419a-a2a9-0c1f3f2511dc"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b9838e70-992c-4f27-b220-86b9fa40af8c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bed9ff6d-17c7-4d0f-bc39-d41fb65aa21c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c016d601-96db-4ebd-876c-d461dc9457cd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c1d6a454-8e5d-464a-9cc9-c474b1fdc750"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c1dbc5f9-d436-480c-8920-c8c349df896c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c5fe2c0f-cbfd-4e1f-a8d5-1f76981ea659"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c652e4b8-c7b8-4c2d-8013-0d385bd48e8b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb78d6f9-289a-4f82-8a1b-3ca2cc8d9459"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d2c6ed4f-46b8-4e94-8b8b-d009d90c808c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d4b81705-bf22-4788-8b7c-1d0856338b61"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d6e5f511-9e9e-4cc9-8dac-27e815a03302"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d9bfbe61-f98e-4cd5-b451-4144a7e75af4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("de5da5f6-ae66-48aa-98b6-2f2e90e1896b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f260d48c-26d6-4410-b1bc-afbe65e6cfcb"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f67d4802-9e91-47da-9721-84db07d73364"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f8243468-2de6-4bf5-bdb3-228ea9f5758e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f8ab8a62-d2c4-438e-ab8f-cb32501f8c6e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("023b922a-b1e2-48b1-8d0f-6cd7de40eeb2"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("039ec54b-9dd2-4ab5-8ac2-5ef921648282"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("105e987a-7034-47ec-a070-2c38f2e1867b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("20178fa1-f8f3-43f9-a81e-d020e75cad63"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("21bc285e-1867-4e1b-8469-7404da69ed2a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2656f60b-69f1-46b2-9f7e-317c9372e722"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("292842bf-6f13-405a-ad95-8e992064c092"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2c5ef9e0-7dc9-4950-93af-797a0b0ed70b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3af746c9-cf03-4707-9a5d-ad3ea0adab73"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("414fcd80-630b-43df-a828-4f5bdbc3edc3"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("4bb167dd-0996-4d7d-8950-bd3737bfd085"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("6364bfbd-08d2-4a92-abdc-7c91d7a3f3a7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("69bb830e-1ec9-4409-a670-6a3bc366b1fa"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("79f706b6-2561-4bde-bb47-6a1ed94224cf"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7fd8e71b-25f6-4878-ace1-1f3f0b0835d1"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8da99c0e-9ad1-45c8-aa9a-84271865211f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("8f80f661-8e1a-4596-9c3c-3fb6e65364f9"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a964c615-bff2-4e29-a0d5-02f4b504735e"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b9586b1c-1895-4153-9dfd-a65dd46960b6"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("c9ac6c78-d1ee-48ae-80d2-4856ebeda4dc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("cf2b8c72-f2ea-40a5-8679-9f08515a759b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d85ba538-4032-40a8-b362-9378692349cc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("da382c78-6edd-4a54-8d7f-220ccbb1ba84"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("ec1d3956-33cf-4a32-9a62-609eddbcea3f"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f85418c6-75b7-4109-b69f-215b85b9866f"));

            migrationBuilder.DropColumn(
                name: "CensorReason",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ModeratorId",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Visibility",
                table: "Games",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Games",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CensoredAt",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CensorStatus",
                table: "Games",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "GameCensorLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CensoredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CensorReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CensorStatus = table.Column<int>(type: "int", nullable: false),
                    ModeratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCensorLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameCensorLogs_AspNetUsers_ModeratorId",
                        column: x => x.ModeratorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "035532f1-99d3-447a-bb6b-956ecd17bcc4", new DateTime(2025, 6, 25, 23, 42, 10, 52, DateTimeKind.Local).AddTicks(5765), "AQAAAAIAAYagAAAAEFAJMCoYcBfrKlLWfsn8Tvbi+TUhH4S5JAzJGzGrFxZs3ZGv7SWcGijhqLSpWkukWQ==", "c4335cc7-20ad-464d-b5e7-841b50cf6874" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c7efb52-c60a-4a21-949e-ee21443d55f6", new DateTime(2025, 6, 25, 23, 42, 10, 248, DateTimeKind.Local).AddTicks(9562), "AQAAAAIAAYagAAAAEMuSh+7hSaec8Z1pxqFzDxeYh+SKgaj7/ABoUwFhl1bg5SLMYYEnbyADyJQfCyZwiA==", "7180b55a-320f-410e-be8c-ced05e90041d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64ffd463-698c-4695-bee6-e4e387704d7b", new DateTime(2025, 6, 25, 23, 42, 10, 304, DateTimeKind.Local).AddTicks(7170), "AQAAAAIAAYagAAAAEH/hrhQJqebca4ebqRdxd/dD63EHP+SmjvIXVoXeih5u7bUpNN2CHh6urySz/8J/JA==", "0b3f98c5-28fc-4223-846a-e0bea3a010e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d42aaf9a-499c-427b-841d-6cfd06d91ace", new DateTime(2025, 6, 25, 23, 42, 9, 997, DateTimeKind.Local).AddTicks(5541), "AQAAAAIAAYagAAAAEFlnXluZDUqkYZ2MluNKcbJx3/URXveL47gjAoDgkGE4aJZNvZxR6yS3NekvNePmow==", "431f022d-99f0-4267-b37e-4e33ed295a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad86f5e6-2297-48ca-ac90-5ebac889ffa4", new DateTime(2025, 6, 25, 23, 42, 10, 188, DateTimeKind.Local).AddTicks(92), "AQAAAAIAAYagAAAAELuEbTjoGn/eTWllyCyMCqp03WX6FvTw1dQdPpXY8TbxVK3BOixT6SqUVyw1BU8EIQ==", "f8283d31-26f4-491b-9089-1ecfd5ff7856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d923ff7-46df-4529-99ba-b66cbeffd7b8", new DateTime(2025, 6, 25, 23, 42, 10, 126, DateTimeKind.Local).AddTicks(2463), "AQAAAAIAAYagAAAAEDgrMUwm0pcNj5i7VjTwwMLNIb3towGPboHa8OpW8B/WJxyRdYgwNky12IeWHXk5Cw==", "90a8bb44-11cc-4a63-879e-e23c0a9a33bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "881daed6-03f8-49f4-b0b2-8ab0cc12b656", new DateTime(2025, 6, 25, 23, 42, 10, 361, DateTimeKind.Local).AddTicks(3094), "AQAAAAIAAYagAAAAEDJELWnWIrZ1zGoA4UVowC5mr6hNybfyvz3dfLRqitQgjJast8ogbbXX+NqA0o8h9g==", "7974b57e-23e8-48ff-aa83-88ac21cd4fcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cefcff3-4b05-46d1-b2cd-dab5763808ff", new DateTime(2025, 6, 25, 23, 42, 9, 940, DateTimeKind.Local).AddTicks(7631), "AQAAAAIAAYagAAAAEAVm77LLFSpjotCvoCpftjqI/XQvbqz/AycCY0VGBmv4bgoG7GSyfkRz9YsnupIDoA==", "05088ddb-5cdd-400b-bc94-a84cac82cf1c" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 7, 5), new DateOnly(2025, 6, 25) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("058a5d68-9c44-44be-a1b3-e2413d9cbea2"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("0a954227-cb40-4839-951c-aaf9e7742d08"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("12ae2fa7-54cc-43e1-b311-662543d508dd"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("136b697b-0c8e-44ec-b5ac-a099ec779d1f"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("1821ad7e-8575-49f8-85c9-746b9f997cd7"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("1c4644b0-a96a-4c3f-881d-497e3e5e29f0"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("2b50f3bc-8863-4974-8e61-6515bbee6c8c"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("3157bb0b-e956-47e4-9238-dd0fee6c4645"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("340d90a4-7360-4868-a293-544bdfc1a654"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("349bb7ed-0dd3-4fd1-a873-eec08b2bad43"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("3b5afb04-a132-4f7f-a4d3-aab2d75c846e"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("3e654b2c-b252-4be7-b248-9bb457e72b6c"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("3f10a3d6-a307-4de1-bf43-f341a3b36152"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("4a135fbf-8600-45db-bea7-3ba07cb0f187"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("51023092-fe58-460f-80c8-19c6cdc55f13"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("5220bf44-5991-40c7-9e06-c1b5a930cf3e"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("522d8c15-7a9a-405e-85db-38edfbba2c4a"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("536f87bb-35d8-4b50-8044-5e792e70a97a"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("5648ffa7-b464-4005-bda3-c08cc3ba4b10"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("5cc872d0-55c7-43ff-a044-bcf01a8af8e9"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("5f4db402-6fc2-424c-a26c-9660801e014c"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("60a1ab07-d6b3-4d7b-82f2-9a8ee28d4861"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("6741f499-ecb3-4565-92a7-ba83138441c5"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("67d524da-3f10-4d8f-96ea-fe9f665d49ee"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" },
                    { new Guid("68087e7a-e591-4a0a-a08b-a61291375a9b"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("68943000-75af-4217-9de2-cca53654fb57"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("6b814a8c-f432-4b08-9a2a-d5bd672421e4"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("6ccc84cc-13b3-4f78-92d0-b25d207b6ac5"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("7049440e-f4a0-4d55-acd5-ca85b9b72a0d"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("7143907c-e7c9-4290-9355-87e62d1a112a"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("7cd1f5f0-f6a9-4eba-988b-926e41aa8609"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("814869e4-6ce5-4e08-b728-5985ae051179"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("8665d447-5aee-40e9-9e3b-7edd1841c459"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("89eb7a7d-9cc0-4998-b169-b5c5d9f081c5"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("8a874c04-24d6-4191-a6be-d08f0a6075e4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("8d4d99b0-4e2d-4d24-9525-62015da17d61"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("9d26d1b2-dce3-4c24-aaee-6eed6697264b"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("a0ff5e4c-54a9-4400-bdcb-0d3ebc6bd655"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("a3cdce01-9d1b-4500-b35c-f8d2a589c486"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("a55a1944-2560-4107-8741-b8010ea655d9"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("a6c3dc0c-2b45-4b95-9d64-bfaa44d4ff9e"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("a8fcdfb6-100b-4be3-8b26-ee6852c9ac80"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("aaaa7165-aada-48a6-ba72-e4ebad12c0f6"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("b0458093-4e73-4d44-a8b5-e0eb9008a83c"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("b3ac4521-4697-4628-b45f-e69430c94758"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("b761f324-1696-4b94-9920-e1e7b64ca07e"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("b78af58c-eb39-44f3-8c46-7dc71fab13e6"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("ba8030ba-a707-4fac-b21c-1aa73dcde0a3"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("bf474b4b-f8c1-411a-8ecb-6c593936c7b8"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("c34a9812-856c-4229-bf62-2ca564e933b4"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("c666cd62-23fe-405f-9a83-9b81760454b1"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("cb5b6ef4-693b-47db-b9f8-962f17cb0df8"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("cb69d998-ed11-4103-815f-ded1eb48af5c"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("cc1f2415-d8b4-4a69-8a69-59a4fa577414"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("d36beccc-c79c-4474-82a1-972704cb3514"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("e3be18cf-2a47-481d-b91e-dbacc88c78c8"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("e58b6ca5-2d5f-476d-be8d-197f6ba67b1b"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("ede6f1e1-8843-426a-9246-8ea33a916a5e"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("f065b83d-dd6e-4794-a4bd-8d1b9d8398bf"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("f4083b7c-88ab-4497-b916-508840248c27"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("fa94d828-d02a-44a8-8b4d-4eedfeea3d01"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("ff32e78b-8fbd-4c7a-93e7-9264b545bcff"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("13cff36e-1dc2-4336-85a8-d0e4dcfe53cb"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("19f732a1-5ea8-4c6f-9ddc-acd2f4a28acb"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("256aa912-5f85-47fa-8fd8-b0adf0d45938"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("2aa4b3dd-c44c-47a9-9360-4d7046886ce5"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("368c4f47-7895-47b2-9447-3b54ddc95cdb"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("3d10a4da-676c-4601-a650-2bb4830df09d"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("42160189-5b18-47b3-9cf4-d1ef5b9c717a"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("48e5859c-4f52-4546-bf79-c4c5dccb18dc"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("54f0ee11-d66a-4fac-8b75-647f015b5bc4"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("5aad299c-f5fa-4a34-8e8c-6facee1b1ee0"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("65353b31-ed7b-4791-b5e3-ca58c306b691"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("7d4366f9-2245-4596-ac27-55a3490ba25c"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("806b164d-71f8-44a3-a637-4e8ae71bbd5b"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 },
                    { new Guid("95411297-ff96-4519-b5d1-36723c1bf704"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("9aee4ef1-dfd6-4549-a319-94be70833998"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("9b77dff2-f382-4c1a-9804-920524c90b50"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("a2672ff5-74c0-4df3-8820-51aca25a9071"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("a33a6ad5-2145-4bf6-a05f-df26eecf24de"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("b06e6390-325c-46c2-a968-eae23ed7ccc7"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("b5a39394-c25c-4892-b1ab-567305253c56"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("cd699dc1-107e-4c73-bfee-b259b2e38ead"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("d3f9a24a-591e-459d-a2cc-8c94ca27c71d"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("dc292486-a7a6-476c-8c1b-f72f367ae6de"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("e4ba2583-06c8-4a0f-8d84-74fa1d81ba68"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("f404ee11-ef5a-4fa1-bfe8-349aec635907"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CensoredAt", "CreatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 23, 42, 9, 928, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.CreateIndex(
                name: "IX_GameCensorLogs_ModeratorId",
                table: "GameCensorLogs",
                column: "ModeratorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameCensorLogs");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("058a5d68-9c44-44be-a1b3-e2413d9cbea2"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("0a954227-cb40-4839-951c-aaf9e7742d08"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("12ae2fa7-54cc-43e1-b311-662543d508dd"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("136b697b-0c8e-44ec-b5ac-a099ec779d1f"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1821ad7e-8575-49f8-85c9-746b9f997cd7"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("1c4644b0-a96a-4c3f-881d-497e3e5e29f0"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("2b50f3bc-8863-4974-8e61-6515bbee6c8c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3157bb0b-e956-47e4-9238-dd0fee6c4645"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("340d90a4-7360-4868-a293-544bdfc1a654"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("349bb7ed-0dd3-4fd1-a873-eec08b2bad43"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3b5afb04-a132-4f7f-a4d3-aab2d75c846e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3e654b2c-b252-4be7-b248-9bb457e72b6c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("3f10a3d6-a307-4de1-bf43-f341a3b36152"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("4a135fbf-8600-45db-bea7-3ba07cb0f187"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("51023092-fe58-460f-80c8-19c6cdc55f13"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5220bf44-5991-40c7-9e06-c1b5a930cf3e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("522d8c15-7a9a-405e-85db-38edfbba2c4a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("536f87bb-35d8-4b50-8044-5e792e70a97a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5648ffa7-b464-4005-bda3-c08cc3ba4b10"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5cc872d0-55c7-43ff-a044-bcf01a8af8e9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("5f4db402-6fc2-424c-a26c-9660801e014c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("60a1ab07-d6b3-4d7b-82f2-9a8ee28d4861"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6741f499-ecb3-4565-92a7-ba83138441c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("67d524da-3f10-4d8f-96ea-fe9f665d49ee"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("68087e7a-e591-4a0a-a08b-a61291375a9b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("68943000-75af-4217-9de2-cca53654fb57"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6b814a8c-f432-4b08-9a2a-d5bd672421e4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("6ccc84cc-13b3-4f78-92d0-b25d207b6ac5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7049440e-f4a0-4d55-acd5-ca85b9b72a0d"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7143907c-e7c9-4290-9355-87e62d1a112a"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("7cd1f5f0-f6a9-4eba-988b-926e41aa8609"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("814869e4-6ce5-4e08-b728-5985ae051179"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8665d447-5aee-40e9-9e3b-7edd1841c459"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("89eb7a7d-9cc0-4998-b169-b5c5d9f081c5"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8a874c04-24d6-4191-a6be-d08f0a6075e4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("8d4d99b0-4e2d-4d24-9525-62015da17d61"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("9d26d1b2-dce3-4c24-aaee-6eed6697264b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a0ff5e4c-54a9-4400-bdcb-0d3ebc6bd655"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a3cdce01-9d1b-4500-b35c-f8d2a589c486"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a55a1944-2560-4107-8741-b8010ea655d9"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a6c3dc0c-2b45-4b95-9d64-bfaa44d4ff9e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("a8fcdfb6-100b-4be3-8b26-ee6852c9ac80"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("aaaa7165-aada-48a6-ba72-e4ebad12c0f6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b0458093-4e73-4d44-a8b5-e0eb9008a83c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b3ac4521-4697-4628-b45f-e69430c94758"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b761f324-1696-4b94-9920-e1e7b64ca07e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("b78af58c-eb39-44f3-8c46-7dc71fab13e6"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ba8030ba-a707-4fac-b21c-1aa73dcde0a3"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("bf474b4b-f8c1-411a-8ecb-6c593936c7b8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c34a9812-856c-4229-bf62-2ca564e933b4"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("c666cd62-23fe-405f-9a83-9b81760454b1"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb5b6ef4-693b-47db-b9f8-962f17cb0df8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cb69d998-ed11-4103-815f-ded1eb48af5c"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("cc1f2415-d8b4-4a69-8a69-59a4fa577414"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("d36beccc-c79c-4474-82a1-972704cb3514"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e3be18cf-2a47-481d-b91e-dbacc88c78c8"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("e58b6ca5-2d5f-476d-be8d-197f6ba67b1b"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ede6f1e1-8843-426a-9246-8ea33a916a5e"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f065b83d-dd6e-4794-a4bd-8d1b9d8398bf"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("f4083b7c-88ab-4497-b916-508840248c27"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("fa94d828-d02a-44a8-8b4d-4eedfeea3d01"));

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: new Guid("ff32e78b-8fbd-4c7a-93e7-9264b545bcff"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("13cff36e-1dc2-4336-85a8-d0e4dcfe53cb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("19f732a1-5ea8-4c6f-9ddc-acd2f4a28acb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("256aa912-5f85-47fa-8fd8-b0adf0d45938"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("2aa4b3dd-c44c-47a9-9360-4d7046886ce5"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("368c4f47-7895-47b2-9447-3b54ddc95cdb"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("3d10a4da-676c-4601-a650-2bb4830df09d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("42160189-5b18-47b3-9cf4-d1ef5b9c717a"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("48e5859c-4f52-4546-bf79-c4c5dccb18dc"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("54f0ee11-d66a-4fac-8b75-647f015b5bc4"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("5aad299c-f5fa-4a34-8e8c-6facee1b1ee0"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("65353b31-ed7b-4791-b5e3-ca58c306b691"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("7d4366f9-2245-4596-ac27-55a3490ba25c"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("806b164d-71f8-44a3-a637-4e8ae71bbd5b"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("95411297-ff96-4519-b5d1-36723c1bf704"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9aee4ef1-dfd6-4549-a319-94be70833998"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("9b77dff2-f382-4c1a-9804-920524c90b50"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a2672ff5-74c0-4df3-8820-51aca25a9071"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("a33a6ad5-2145-4bf6-a05f-df26eecf24de"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b06e6390-325c-46c2-a968-eae23ed7ccc7"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("b5a39394-c25c-4892-b1ab-567305253c56"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("cd699dc1-107e-4c73-bfee-b259b2e38ead"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("d3f9a24a-591e-459d-a2cc-8c94ca27c71d"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("dc292486-a7a6-476c-8c1b-f72f367ae6de"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("e4ba2583-06c8-4a0f-8d84-74fa1d81ba68"));

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumn: "Id",
                keyValue: new Guid("f404ee11-ef5a-4fa1-bfe8-349aec635907"));

            migrationBuilder.AlterColumn<string>(
                name: "Visibility",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CensoredAt",
                table: "Games",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CensorStatus",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "CensorReason",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModeratorId",
                table: "Games",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "125cb593-91d6-411f-a436-ce487f82e145", new DateTime(2025, 6, 24, 13, 58, 11, 517, DateTimeKind.Local).AddTicks(610), "AQAAAAIAAYagAAAAECDh+Z4DN/ouNkUOZnov+RxL1dcLfbPuP33JgSI1kP7uFLqPmkRCAl8fPXpx3yMx4A==", "e67f0430-281a-4278-989d-193cfab1d4d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca3ecafe-236a-46bd-b068-502de60fb717", new DateTime(2025, 6, 24, 13, 58, 11, 695, DateTimeKind.Local).AddTicks(2495), "AQAAAAIAAYagAAAAEPS3xjtqdNGHRUWfUaLjhm5mw1XzY7J9FzNSZyNAjb9G3zbPbYr6EbUc6fM0qnIqTw==", "96d7b6c6-b602-4201-be73-332f32d94d50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34670beb-a794-4419-adf8-0465eea22a78"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51e81483-afc3-4370-a9f0-70ebe676a1e8", new DateTime(2025, 6, 24, 13, 58, 11, 754, DateTimeKind.Local).AddTicks(9268), "AQAAAAIAAYagAAAAEKt+LRVVaQqXcWBOyYi0XW9P86tKHxXo+lBT2zrQJwMZIAJLJpd8FD3xzoJqwQKTPQ==", "4809834d-7bf7-4a7d-b001-5ff78a480aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dbb18d9-8796-46fe-810f-6607e1d0cadf", new DateTime(2025, 6, 24, 13, 58, 11, 454, DateTimeKind.Local).AddTicks(101), "AQAAAAIAAYagAAAAEDVHKo3hWCCl2ivZvJNAnpmaWA3CQIvbxWCtE9umGcVK97JVuVV2hns7CWMc4T6ehg==", "f1400501-6d76-44e8-851c-7c0128a6e5c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("537f05fd-120c-40b0-b2ec-639756f866ab"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56954739-8420-4a96-9eee-1b961d151eec", new DateTime(2025, 6, 24, 13, 58, 11, 634, DateTimeKind.Local).AddTicks(209), "AQAAAAIAAYagAAAAENq1EG3AFP4yZgcqbz2AzFt6ExMMKLUgTD5X0kxZ/Y4hwWb90YIy/rl4TqSDimgcow==", "15ab62e8-fb33-4243-9e9e-8e07aabe5b83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("91b106fa-7b95-480f-a12a-0e0303454332"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "466aa57d-2d15-4456-a411-f7069511b187", new DateTime(2025, 6, 24, 13, 58, 11, 574, DateTimeKind.Local).AddTicks(7962), "AQAAAAIAAYagAAAAEKDuyWFjqo48Oepbs/pzmeh0I9oIa366RIMCoEJUOH0LlGzFKRipNIUvp4rEEsr9Fg==", "10e593ee-2d3c-4e49-8346-c6348c51f158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c25dc5ef-4e98-421e-90d3-7eb76ba269fe"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5c4064c-8170-47f8-a24c-b340dbda96e3", new DateTime(2025, 6, 24, 13, 58, 11, 815, DateTimeKind.Local).AddTicks(1217), "AQAAAAIAAYagAAAAEGOIQgO1O9twIZ9tyqjYRWPAMT30+XCxfiW0DN+ayzlii0Ay5H1QxWwm1pYkTT+Fag==", "7d3178a2-c235-47c0-b032-784c298ebe0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8a6c154-9114-4485-813e-6535be854dbb", new DateTime(2025, 6, 24, 13, 58, 11, 394, DateTimeKind.Local).AddTicks(1876), "AQAAAAIAAYagAAAAEBPsLJXziLocgrkSjdkf+BL/ip7DFwM28SjjkIiI55UBGUKb/6VKmjlzKwlT/ZSlAg==", "384093b3-8ecd-418c-b831-a9fd39d8cadf" });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("02e6a0ab-2720-4368-8b80-9eb3f46eece0"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 7, 4), new DateOnly(2025, 6, 24) });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Image" },
                values: new object[,]
                {
                    { new Guid("00856ffb-9775-4a37-a397-cb72551191a1"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage1.png" },
                    { new Guid("013caa66-448f-4269-9853-01d3b4107908"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage2.png" },
                    { new Guid("09cbbfba-d3a3-4cec-922f-1644d8e58ecf"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop1.png" },
                    { new Guid("10124e82-0ecf-4500-9933-64306077297a"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage3.jpg" },
                    { new Guid("134c16da-1f1a-44bb-a7c6-2e9fb7818b17"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage1.png" },
                    { new Guid("19bd05c0-d577-41a5-b25f-83edea1b4a8a"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage2.png" },
                    { new Guid("246d30d7-a4b0-474f-a9a9-79ac6e8e9563"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage2.png" },
                    { new Guid("24b7be82-1cac-46ac-af57-1c085d09e714"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage2.png" },
                    { new Guid("2bf6c53d-2c2b-4782-8713-11e9b4904203"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage2.png" },
                    { new Guid("3410f56e-c043-4197-9191-239f1890855d"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage3.png" },
                    { new Guid("35f86fc2-2f6d-4523-8e92-71ec1718c63e"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop2.png" },
                    { new Guid("3d31af09-066c-44c3-9530-1b7a5c7d86e4"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic3.png" },
                    { new Guid("43e9bc24-5ca6-4aea-9be7-1f30abb6f78f"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage2.png" },
                    { new Guid("4603ce40-a227-4c6d-aa63-0fea342b4c80"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage1.png" },
                    { new Guid("467a63bd-be18-49e8-9c17-0da37841cb62"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage1.png" },
                    { new Guid("4ace96d4-28c1-40d6-8c8e-12b477bcc06f"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage1.png" },
                    { new Guid("4bdf7ea7-10d2-4f37-b50e-abdfac7c942a"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage2.png" },
                    { new Guid("4c856f03-a5bf-4b9e-b298-c16538251cee"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage3.png" },
                    { new Guid("4f9071fc-d78a-4ff2-a49e-e517d915fc85"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic2.png" },
                    { new Guid("515a1ced-1e9e-4557-aa57-3d618627be6d"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage2.png" },
                    { new Guid("55929513-1637-472d-800d-7ee6631aa74d"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage1.png" },
                    { new Guid("5c0a98b2-ff67-42ae-ad94-a5b73d7bde86"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage1.png" },
                    { new Guid("61d0ca30-b830-4c09-97f6-aaafe7f2796a"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage2.png" },
                    { new Guid("64b1e2c7-df46-4515-a769-9576884af253"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage2.png" },
                    { new Guid("6ce2d7ef-89a5-4072-bce2-d49361ed1087"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage4.png" },
                    { new Guid("7045892c-4321-4de1-88ef-5a9508f978d6"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage2.png" },
                    { new Guid("73fa38a6-d99c-45c0-a75c-5e6d72f29ded"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage1.png" },
                    { new Guid("83ffff35-0907-4c4d-acf5-b9a483819d13"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage2.png" },
                    { new Guid("85ae6e0f-2d02-4486-8061-6e836c1b623d"), new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TomatoImage3.png" },
                    { new Guid("877d6049-b1a3-4d00-afdc-ffeba316eb6b"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage3.png" },
                    { new Guid("8798bdf2-b46d-4290-9fd5-a8b8063cb020"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage1.png" },
                    { new Guid("8972a273-7d70-4e68-9c1c-13c984e73a15"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage3.png" },
                    { new Guid("90b4e61b-4ebc-4a8b-bda6-1d13b812d4f5"), new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BloodmallImage3.png" },
                    { new Guid("97986222-69ed-437a-a983-c16c6ed6e9c3"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage1.jpg" },
                    { new Guid("9d5cc3cf-8f15-44f5-87e2-08a255f9ee1a"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage3.png" },
                    { new Guid("a2e89682-1484-4ed8-9457-c57c22f344b0"), new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStationImage3.png" },
                    { new Guid("a5f5bb21-1970-485b-87b1-6e6d06ed169f"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher3.png" },
                    { new Guid("aa5a55e8-4d1a-47f8-af8b-693fd6475815"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage3.png" },
                    { new Guid("aabc9b54-0343-41c7-925d-953dba53271c"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage2.png" },
                    { new Guid("ab5464b5-b7e3-4c7a-aac6-7329b1e23590"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage3.png" },
                    { new Guid("b090056d-2041-486b-aad8-f2464198426f"), new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop3.png" },
                    { new Guid("b0c95bb2-e831-4315-a470-3c7913faed86"), new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/PacsideImage1.png" },
                    { new Guid("b53a5acd-f531-42af-9011-5d5c8c581d2a"), new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHourImage1.png" },
                    { new Guid("b6e86683-c66c-42a1-91b9-e0db85c257a7"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic1.png" },
                    { new Guid("b83534b1-5da4-419a-a2a9-0c1f3f2511dc"), new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DaughterImage1.png" },
                    { new Guid("b9838e70-992c-4f27-b220-86b9fa40af8c"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage1.png" },
                    { new Guid("bed9ff6d-17c7-4d0f-bc39-d41fb65aa21c"), new Guid("152e3482-be53-44db-93e6-785823f6224e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/AtlyssImage3.png" },
                    { new Guid("c016d601-96db-4ebd-876c-d461dc9457cd"), new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DominoidImage3.png" },
                    { new Guid("c1d6a454-8e5d-464a-9cc9-c474b1fdc750"), new Guid("5763f752-914c-4436-803f-4410118774a3"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShiftImage2.png" },
                    { new Guid("c1dbc5f9-d436-480c-8920-c8c349df896c"), new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic4.png" },
                    { new Guid("c5fe2c0f-cbfd-4e1f-a8d5-1f76981ea659"), new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlaceImage3.png" },
                    { new Guid("c652e4b8-c7b8-4c2d-8013-0d385bd48e8b"), new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), "https://indiegamezone.blob.core.windows.net/indiegamezone/EvaluationImage2.png" },
                    { new Guid("cb78d6f9-289a-4f82-8a1b-3ca2cc8d9459"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage1.png" },
                    { new Guid("d2c6ed4f-46b8-4e94-8b8b-d009d90c808c"), new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), "https://indiegamezone.blob.core.windows.net/indiegamezone/MissingImage1.png" },
                    { new Guid("d4b81705-bf22-4788-8b7c-1d0856338b61"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage2.png" },
                    { new Guid("d6e5f511-9e9e-4cc9-8dac-27e815a03302"), new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), "https://indiegamezone.blob.core.windows.net/indiegamezone/DispatchedImage3.png" },
                    { new Guid("d9bfbe61-f98e-4cd5-b451-4144a7e75af4"), new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), "https://indiegamezone.blob.core.windows.net/indiegamezone/LeftoversImage3.png" },
                    { new Guid("de5da5f6-ae66-48aa-98b6-2f2e90e1896b"), new Guid("34209460-1478-4545-9f15-723eeefc5697"), "https://indiegamezone.blob.core.windows.net/indiegamezone/ThunderheadImage1.png" },
                    { new Guid("f260d48c-26d6-4410-b1bc-afbe65e6cfcb"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher2.png" },
                    { new Guid("f67d4802-9e91-47da-9721-84db07d73364"), new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SheepyImage2.jpg" },
                    { new Guid("f8243468-2de6-4bf5-bdb3-228ea9f5758e"), new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher1.png" },
                    { new Guid("f8ab8a62-d2c4-438e-ab8f-cb32501f8c6e"), new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBoothImage3.png" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "Id", "DisplayName", "File", "GameId", "PlatformId", "Size" },
                values: new object[,]
                {
                    { new Guid("023b922a-b1e2-48b1-8d0f-6cd7de40eeb2"), "Pacside_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/Pacside_Window.rar", new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 163.0 },
                    { new Guid("039ec54b-9dd2-4ab5-8ac2-5ef921648282"), "Bloddymall_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Linux.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 94.900000000000006 },
                    { new Guid("105e987a-7034-47ec-a070-2c38f2e1867b"), "TheStation_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheStation_Window.rar", new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 102.0 },
                    { new Guid("20178fa1-f8f3-43f9-a81e-d020e75cad63"), "QuietPlace_Window.rar", "https://indiegamezone.blob.core.windows.net/indiegamezone/QuietPlace_Window.rar", new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 58.600000000000001 },
                    { new Guid("21bc285e-1867-4e1b-8469-7404da69ed2a"), "BrokenRelic_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Window.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 99.299999999999997 },
                    { new Guid("2656f60b-69f1-46b2-9f7e-317c9372e722"), "Moldwasher_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Moldwasher_Window.zip", new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 31.0 },
                    { new Guid("292842bf-6f13-405a-ad95-8e992064c092"), "Evaluation_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Evaluation_Window.zip", new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("2c5ef9e0-7dc9-4950-93af-797a0b0ed70b"), "DiggingHour_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/DiggingHour_Window.zip", new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 48.0 },
                    { new Guid("3af746c9-cf03-4707-9a5d-ad3ea0adab73"), "Dominoid_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dominoid_Window.zip", new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 109.0 },
                    { new Guid("414fcd80-630b-43df-a828-4f5bdbc3edc3"), "Latestop_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Latestop_Window.zip", new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 87.599999999999994 },
                    { new Guid("4bb167dd-0996-4d7d-8950-bd3737bfd085"), "Thunderhead_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Thunderhead_Window.zip", new Guid("34209460-1478-4545-9f15-723eeefc5697"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 153.0 },
                    { new Guid("6364bfbd-08d2-4a92-abdc-7c91d7a3f3a7"), "Daughter_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Daughter_Window.zip", new Guid("a670e609-db94-42b5-b196-f618e79ce15b"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 181.0 },
                    { new Guid("69bb830e-1ec9-4409-a670-6a3bc366b1fa"), "BrokenRelic_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Macos.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 99.700000000000003 },
                    { new Guid("79f706b6-2561-4bde-bb47-6a1ed94224cf"), "MidnightShift_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/MidnightShift_Window.zip", new Guid("5763f752-914c-4436-803f-4410118774a3"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 84.599999999999994 },
                    { new Guid("7fd8e71b-25f6-4878-ace1-1f3f0b0835d1"), "BrokenRelic_Linux.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/BrokenRelic_Linux.zip", new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"), new Guid("db498cbb-c76f-4166-9836-8ecb462419e6"), 100.0 },
                    { new Guid("8da99c0e-9ad1-45c8-aa9a-84271865211f"), "Leftovers_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Leftovers_Window.zip", new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 33.799999999999997 },
                    { new Guid("8f80f661-8e1a-4596-9c3c-3fb6e65364f9"), "TheDeadseat_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/TheDeadseat_Window.zip", new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 179.0 },
                    { new Guid("a964c615-bff2-4e29-a0d5-02f4b504735e"), "Sheepy_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Sheepy_Window.zip", new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 239.0 },
                    { new Guid("b9586b1c-1895-4153-9dfd-a65dd46960b6"), "Dispatched_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Dispatched_Window.zip", new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 585.0 },
                    { new Guid("c9ac6c78-d1ee-48ae-80d2-4856ebeda4dc"), "Atlyss_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Atlyss_Window.zip", new Guid("152e3482-be53-44db-93e6-785823f6224e"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 126.0 },
                    { new Guid("cf2b8c72-f2ea-40a5-8679-9f08515a759b"), "Missing_Mac.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Mac.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("574cb883-e637-4f18-9518-269e4d22312c"), 246.0 },
                    { new Guid("d85ba538-4032-40a8-b362-9378692349cc"), "Missing_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Missing_Window.zip", new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 138.0 },
                    { new Guid("da382c78-6edd-4a54-8d7f-220ccbb1ba84"), "Tomato_Window.exe", "https://indiegamezone.blob.core.windows.net/indiegamezone/Tomato_Window.exe", new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 224.0 },
                    { new Guid("ec1d3956-33cf-4a32-9a62-609eddbcea3f"), "Bloddymall_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/Bloddymall_Window.zip", new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 93.799999999999997 },
                    { new Guid("f85418c6-75b7-4109-b69f-215b85b9866f"), "SecurityBooth_Window.zip", "https://indiegamezone.blob.core.windows.net/indiegamezone/SecurityBooth_Window.zip", new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"), new Guid("a47b287d-6ed7-4bb0-be73-c2581dcb9b3e"), 127.0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0f78b4ed-b351-4517-89fc-a05f07570e44"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7273), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("152e3482-be53-44db-93e6-785823f6224e"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7509), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("16565861-4a29-40e7-8efa-1594a82e67e8"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7440), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("34209460-1478-4545-9f15-723eeefc5697"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7412), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("381c9309-d036-4c9a-a651-d8ebf631528e"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7279), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5763f752-914c-4436-803f-4410118774a3"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7255), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7238), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6e55d2c1-fe9f-477d-bf58-125d73d0c26d"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7262), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("78b9e146-d318-4fc5-aa13-1ba2e7c304c9"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7406), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("791a4c74-d469-4432-bd76-c5ace021ce8e"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7527), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85ce733a-7a1a-4e52-8513-2638b9c44e55"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7433), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8dd6053e-f3b1-4019-8898-668208f4dd31"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7397), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a28f1bb3-f30d-4895-81b0-58deec580a1d"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7385), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a60c6a31-3d0c-4bb4-9f2a-99020ea026fc"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7502), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a670e609-db94-42b5-b196-f618e79ce15b"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7391), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae4dbda4-695a-44b8-9c93-7785cf1d717e"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7420), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2fd90a7-5714-489e-b952-31b59a058db1"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7267), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca5adbdb-160c-4a60-98b3-e4f464fbf904"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7521), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d11cf96a-0d4f-4834-868c-59b32f047d2a"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7515), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebe90f4b-241a-44d6-8645-4c1f28376f3e"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7426), null });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f6935d98-bd02-4716-a968-3bc870e6233b"),
                columns: new[] { "CensorReason", "CensoredAt", "CreatedAt", "ModeratorId" },
                values: new object[] { null, null, new DateTime(2025, 6, 24, 13, 58, 11, 378, DateTimeKind.Local).AddTicks(7378), null });

            migrationBuilder.CreateIndex(
                name: "IX_Games_ModeratorId",
                table: "Games",
                column: "ModeratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_ModeratorId",
                table: "Games",
                column: "ModeratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
