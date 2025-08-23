using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Myblog.Migrations
{
    /// <inheritdoc />
    public partial class dotstarkMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6075bcc2-ed52-42b8-a6ae-1c688407a15c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7924040-8db1-468f-9b8e-c6992af35ccd");

            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b64a620-a858-4ff0-a4db-2c1f940bf00d", null, "superadmin", "superadmin" },
                    { "c3c07e82-5003-4fd1-999a-88458ee49ffe", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b64a620-a858-4ff0-a4db-2c1f940bf00d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3c07e82-5003-4fd1-999a-88458ee49ffe");

            migrationBuilder.DropColumn(
                name: "RejectionReason",
                table: "Blogs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6075bcc2-ed52-42b8-a6ae-1c688407a15c", null, "admin", "admin" },
                    { "c7924040-8db1-468f-9b8e-c6992af35ccd", null, "superadmin", "superadmin" }
                });
        }
    }
}
