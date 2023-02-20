using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20230131_MVCIdentity.Migrations
{
    public partial class addrelationforcategoryuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "081a2f71-ddde-488f-a554-e620a86cf619", "b1952a48-ade0-4e28-af96-cac089df5ef4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "124357ae-7ff5-4369-ab0c-3c36b561128b", "f3e0a430-e705-483f-b57c-c648e9b6e40a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "081a2f71-ddde-488f-a554-e620a86cf619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "124357ae-7ff5-4369-ab0c-3c36b561128b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1952a48-ade0-4e28-af96-cac089df5ef4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3e0a430-e705-483f-b57c-c648e9b6e40a");

            migrationBuilder.CreateTable(
                name: "CategoryUser",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryUser", x => new { x.CategoriesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CategoryUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryUser_categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryUser_UsersId",
                table: "CategoryUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryUser");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "081a2f71-ddde-488f-a554-e620a86cf619", "c894abc2-ba9d-4ee8-8282-1a29e8cd4803", "Admin", "ADMIN" },
                    { "124357ae-7ff5-4369-ab0c-3c36b561128b", "f5c6a21f-1dad-4e9f-82cc-7338dc1b0617", "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FilePath", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b1952a48-ade0-4e28-af96-cac089df5ef4", 0, "054eb5a3-cf79-47e4-b3af-48df3c92a91b", "admin@admin.com", true, null, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENE/xArxK6y8TOx1hdd/NOCp5qSPUkvLmtPwooMA4xP0dh/IyUY7bAQn2diSzCKY/Q==", null, false, "7c1e8c9f-9645-43a5-88ef-5776576afd62", false, "admin@admin.com" },
                    { "f3e0a430-e705-483f-b57c-c648e9b6e40a", 0, "f71ce0e9-57b8-4e53-b0bb-508979678783", "standard@standard.com", true, null, "Standard", "Standard", false, null, "STANDARD@STANDARD.COM", "STANDARD@STANDARD.COM", "AQAAAAEAACcQAAAAEN2J/mOm0pLMoKVQs2LvGbIeLsHQsk8vUeucPbC4fSXOPlUhnVfkCw/4/Tw0b4biew==", null, false, "20ee77a2-4f1f-490c-a553-ff19c40a66f5", false, "standard@standard.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "b1952a48-ade0-4e28-af96-cac089df5ef4");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "081a2f71-ddde-488f-a554-e620a86cf619", "b1952a48-ade0-4e28-af96-cac089df5ef4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "124357ae-7ff5-4369-ab0c-3c36b561128b", "f3e0a430-e705-483f-b57c-c648e9b6e40a" });
        }
    }
}
