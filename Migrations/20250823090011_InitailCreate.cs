using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Myblog.Migrations
{
    /// <inheritdoc />
    public partial class InitailCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b64a620-a858-4ff0-a4db-2c1f940bf00d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3c07e82-5003-4fd1-999a-88458ee49ffe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7913fcaf-13a8-4cf9-9c79-2c25a15a8e00", null, "admin", "admin" },
                    { "e6dadc22-bde6-4dd6-b40d-0a2d2ce303d6", null, "superadmin", "superadmin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7913fcaf-13a8-4cf9-9c79-2c25a15a8e00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6dadc22-bde6-4dd6-b40d-0a2d2ce303d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b64a620-a858-4ff0-a4db-2c1f940bf00d", null, "superadmin", "superadmin" },
                    { "c3c07e82-5003-4fd1-999a-88458ee49ffe", null, "admin", "admin" }
                });
        }
    }
}
