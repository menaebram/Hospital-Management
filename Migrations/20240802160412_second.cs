using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0243aaeb-fdf0-4095-90e0-4b2dce2591bc", null, "receiption", "receiption" },
                    { "06ec5abc-7c23-4622-8b74-5abb083ae5ea", null, "accountant", "accountant" },
                    { "0d3d1f04-c015-44b9-bc9f-58619399ef67", null, "inventory", "inventory" },
                    { "242a6c86-6edc-4877-be71-f632e113792e", null, "pharmacist", "pharmacist" },
                    { "48ade572-7bd3-4d10-b6e7-3d5ac4fd2b28", null, "doctor", "doctor" },
                    { "53c7b54f-b0da-49e2-ab9a-5554305cb4f7", null, "lab", "lab" },
                    { "7ae61dc6-aded-400a-87a1-ecfa8ff74cf3", null, "nurse", "nurse" },
                    { "b147b41a-92b6-4cb0-b258-541feb985109", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0243aaeb-fdf0-4095-90e0-4b2dce2591bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06ec5abc-7c23-4622-8b74-5abb083ae5ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d3d1f04-c015-44b9-bc9f-58619399ef67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "242a6c86-6edc-4877-be71-f632e113792e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48ade572-7bd3-4d10-b6e7-3d5ac4fd2b28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53c7b54f-b0da-49e2-ab9a-5554305cb4f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ae61dc6-aded-400a-87a1-ecfa8ff74cf3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b147b41a-92b6-4cb0-b258-541feb985109");
        }
    }
}
