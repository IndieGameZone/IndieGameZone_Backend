using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndieGameZone.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlatformEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6fbbd0d-fb64-48f5-ad9e-c32eebc5f1ea", "AQAAAAIAAYagAAAAEDROM3G/WOKatDc2kP6DtBjXR94nLgI7/6Aj12LThgXnfJyXmFftqP2FRkpO8aAoBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50b9d501-1d78-4b7d-b321-a584682e856b", "AQAAAAIAAYagAAAAEJdOeRsNHCYKpaKmn6KRvsbIwfief4NS5HdPYtU2M8npMrFT2IriW5iltCIah/i3eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "06ae0a28-0567-4e58-95ba-7925b475d745", new DateTime(2025, 5, 25, 13, 46, 32, 931, DateTimeKind.Local).AddTicks(7875), "AQAAAAIAAYagAAAAEDu/UUId8RG9v5oqilO+yEUnBCYPYCgRDWMd5QJHLh/8/IAb50sR9lamAtRtAXhXMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "f644e443-8573-4f60-a75b-dcc9d4c08311", new DateTime(2025, 5, 25, 13, 46, 32, 872, DateTimeKind.Local).AddTicks(4170), "AQAAAAIAAYagAAAAEONzGRVxB3pTscvGjS8hLkQMSDyJ7r4YguhzZ1k2siQ8ECMsZJS62ZDmPGdYT3rL8g==" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 25, 13, 46, 32, 855, DateTimeKind.Local).AddTicks(4771), new DateTime(2025, 5, 25, 13, 46, 32, 855, DateTimeKind.Local).AddTicks(4785) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23879117-e09e-40f1-b78f-1493d81baf49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71da9681-738b-471f-82b8-d5a5832152d9", "AQAAAAIAAYagAAAAEMTL586wv41t7FvG0snFnE8aBTZaHW9xdmYg+opoWkp38qKbKUp0WVz3sXlMDZtgOg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("293191b7-f7b2-4f28-8857-5afa96866a2f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37670a2a-cbe8-486d-beda-24c26cf5cd80", "AQAAAAIAAYagAAAAEIW48I0KGdQ8ViJOkAl5uVQSdJ31OGZyt+tM7BV36aFwwP5c0kPXJTfD7WIYS297jQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe77296-fdb3-4d71-8b99-ef8380c32037"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "1649cbaf-a16d-47f8-931e-a01e232942ec", new DateTime(2025, 5, 23, 19, 25, 10, 400, DateTimeKind.Local).AddTicks(1710), "AQAAAAIAAYagAAAAEKyXXiqJf9MKEhFhidixGuBE2FO6/k+kF/mbo90OT51IbrDU21LEbWcgLQZPck62sA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e5d8947f-6794-42b6-ba67-201f366128b8"),
                columns: new[] { "ConcurrencyStamp", "JoinedDate", "PasswordHash" },
                values: new object[] { "b185cd29-cb9f-4976-8b78-3bf8c3676c3c", new DateTime(2025, 5, 23, 19, 25, 10, 339, DateTimeKind.Local).AddTicks(6809), "AQAAAAIAAYagAAAAEMU2ky1e7lsBH7zl1IGw2iWxqSw3zNIr71w+dCuIdo02WfWS4AIPpANEEnVZHSBh0w==" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65745560-c7e9-48c3-bc36-8c88d66458c7"),
                columns: new[] { "ReleasedDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 23, 19, 25, 10, 325, DateTimeKind.Local).AddTicks(7269), new DateTime(2025, 5, 23, 19, 25, 10, 325, DateTimeKind.Local).AddTicks(7281) });
        }
    }
}
