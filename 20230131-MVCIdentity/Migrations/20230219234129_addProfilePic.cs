using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20230131_MVCIdentity.Migrations
{
    public partial class addProfilePic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d0d0b7c-3cfb-4f0d-a393-9abe29fdbb79", "1f58caf7-5645-4b81-bd15-be8d9c4c85fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "611117af-184c-42f7-b829-eb34d4cd8cbe", "b133c02b-5b07-48ce-95d0-73cffd739232" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d0d0b7c-3cfb-4f0d-a393-9abe29fdbb79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "611117af-184c-42f7-b829-eb34d4cd8cbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f58caf7-5645-4b81-bd15-be8d9c4c85fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b133c02b-5b07-48ce-95d0-73cffd739232");

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46aa430e-88fd-4b27-8348-1141eade42d4", "098be841-4f07-4580-83a6-d2c948c819e2", "Admin", "ADMIN" },
                    { "b1e47de0-30c2-4fa7-be13-c0340c7d707c", "48ecdf65-3278-4bd0-8246-2d77331c0557", "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FilePath", "FirstName", "Job", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b9f4126-b4f9-446f-b6fd-8d2267c52857", 0, "f6c0c697-1941-472a-82fe-271d0370e5a1", "admin@admin.com", true, null, "Admin", null, "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJl4g1Po04vkOu9LFvR+lHw+aga0H00QPCA06S9biIvt7lt9HIHktZ8Wv0FUEeVaVQ==", null, false, "8bf11566-e96c-4d41-ba05-8b5948062dac", false, "admin@admin.com" },
                    { "b5d97f89-6daf-42b2-9b20-b642792902f4", 0, "4627b95b-5cb2-4a8d-bd8f-02b78b234a35", "standard@standard.com", true, null, "Standard", null, "Standard", false, null, "STANDARD@STANDARD.COM", "STANDARD@STANDARD.COM", "AQAAAAEAACcQAAAAEEbEx06UVY0RPBQ98Jg6XaUvQj25zc3Q//uLCPaPKm0jJsYW9if3/Me2/LkxGtU4CA==", null, false, "36b59549-453e-4994-972b-1924d0917462", false, "standard@standard.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "1b9f4126-b4f9-446f-b6fd-8d2267c52857");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46aa430e-88fd-4b27-8348-1141eade42d4", "1b9f4126-b4f9-446f-b6fd-8d2267c52857" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b1e47de0-30c2-4fa7-be13-c0340c7d707c", "b5d97f89-6daf-42b2-9b20-b642792902f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46aa430e-88fd-4b27-8348-1141eade42d4", "1b9f4126-b4f9-446f-b6fd-8d2267c52857" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1e47de0-30c2-4fa7-be13-c0340c7d707c", "b5d97f89-6daf-42b2-9b20-b642792902f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46aa430e-88fd-4b27-8348-1141eade42d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1e47de0-30c2-4fa7-be13-c0340c7d707c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b9f4126-b4f9-446f-b6fd-8d2267c52857");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5d97f89-6daf-42b2-9b20-b642792902f4");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d0d0b7c-3cfb-4f0d-a393-9abe29fdbb79", "beea6f3e-1354-49b8-889c-587748423705", "Admin", "ADMIN" },
                    { "611117af-184c-42f7-b829-eb34d4cd8cbe", "82f83dd2-3763-4ee7-a39b-910f75a33fe1", "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FilePath", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f58caf7-5645-4b81-bd15-be8d9c4c85fe", 0, "01fc71de-10e8-46f2-a688-8498d8c3b281", "admin@admin.com", true, null, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENpVecixFfbGE8Bmygis13qU1KBjxWJn/bi3VPIz4W+poCzBTHuCMFlVKeUHvRkO9g==", null, false, "a8ac61c4-44d6-49cc-83dc-b1c1c9c19f6d", false, "admin@admin.com" },
                    { "b133c02b-5b07-48ce-95d0-73cffd739232", 0, "f37c1ad4-6a12-431e-be9a-667d493ccbdb", "standard@standard.com", true, null, "Standard", "Standard", false, null, "STANDARD@STANDARD.COM", "STANDARD@STANDARD.COM", "AQAAAAEAACcQAAAAEOOYS2EYrfUhiVV2joQa/XcJUBzz9JFMnUikHv/rOU55zqcvFeK5AA0VY31J/QD0JQ==", null, false, "3ac1fe26-ba2b-49f1-8322-a5981efc5467", false, "standard@standard.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "1f58caf7-5645-4b81-bd15-be8d9c4c85fe");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d0d0b7c-3cfb-4f0d-a393-9abe29fdbb79", "1f58caf7-5645-4b81-bd15-be8d9c4c85fe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "611117af-184c-42f7-b829-eb34d4cd8cbe", "b133c02b-5b07-48ce-95d0-73cffd739232" });
        }
    }
}
