using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20230131_MVCIdentity.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b68078a7-3d6f-4dfd-b815-559dd298c38e", "dd3fc3fe-714f-4139-9ab0-348669e6b4f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "463abc9b-8ed1-446f-bb70-9e3f9a8275c5", "e666558d-13c9-4d76-8d2c-6d7cfe201598" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "463abc9b-8ed1-446f-bb70-9e3f9a8275c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b68078a7-3d6f-4dfd-b815-559dd298c38e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd3fc3fe-714f-4139-9ab0-348669e6b4f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e666558d-13c9-4d76-8d2c-6d7cfe201598");

            migrationBuilder.AlterColumn<int>(
                name: "ViewTime",
                table: "articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "articles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "377fef48-9425-4a94-8df4-2017ba4944de", "1ecb000d-9433-4d51-83d9-9c5ec85fe453", "Standard", "STANDARD" },
                    { "c17dc975-4228-44d5-b6e5-52b432dfec6b", "89883746-ce33-4dc3-8492-d39ed901b872", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FilePath", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e6ac55d-a4d2-44e6-91e5-d1bb27b8cf2f", 0, "397d5806-df4b-4937-b3b8-59b1c61c5a57", "standard@standard.com", true, null, "Standard", "Standard", false, null, "STANDARD@STANDARD.COM", "STANDARD@STANDARD.COM", "AQAAAAEAACcQAAAAEDulUJWF9XMu4oOeXLO3+tflZVx+SRF1Z+Pf5uW+OF2YMwHiT+7hWNbwiyZlOkexQw==", null, false, "25cf3d16-b4f7-4b73-98b0-b77833aa0e87", false, "standard@standard.com" },
                    { "26106023-8ac6-4b64-9f54-d67bfa9a1e69", 0, "26f92751-28fc-44ff-a74f-30ea1a96f530", "admin@admin.com", true, null, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGFza1wgAfgnH1yhfQXM1NTl3n074CwsQGIWaWfpmE+Dto6DXFK+gDRWZqoHOMmBVg==", null, false, "7a29ea15-0f69-4b8e-8335-7679208e98ea", false, "admin@admin.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "26106023-8ac6-4b64-9f54-d67bfa9a1e69");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "377fef48-9425-4a94-8df4-2017ba4944de", "1e6ac55d-a4d2-44e6-91e5-d1bb27b8cf2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c17dc975-4228-44d5-b6e5-52b432dfec6b", "26106023-8ac6-4b64-9f54-d67bfa9a1e69" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "377fef48-9425-4a94-8df4-2017ba4944de", "1e6ac55d-a4d2-44e6-91e5-d1bb27b8cf2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c17dc975-4228-44d5-b6e5-52b432dfec6b", "26106023-8ac6-4b64-9f54-d67bfa9a1e69" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "377fef48-9425-4a94-8df4-2017ba4944de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c17dc975-4228-44d5-b6e5-52b432dfec6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e6ac55d-a4d2-44e6-91e5-d1bb27b8cf2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26106023-8ac6-4b64-9f54-d67bfa9a1e69");

            migrationBuilder.AlterColumn<int>(
                name: "ViewTime",
                table: "articles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ViewCount",
                table: "articles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "463abc9b-8ed1-446f-bb70-9e3f9a8275c5", "fdde9fdc-334b-47a3-86f7-6afce2bc7671", "Admin", "ADMIN" },
                    { "b68078a7-3d6f-4dfd-b815-559dd298c38e", "390362e6-a1eb-4c5b-91ee-9fbf1cb59787", "Standard", "STANDARD" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FilePath", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dd3fc3fe-714f-4139-9ab0-348669e6b4f9", 0, "dbe6b806-ba8d-4a93-8e83-10f15bdf5b51", "standard@standard.com", true, null, "Standard", "Standard", false, null, "STANDARD@STANDARD.COM", "STANDARD@STANDARD.COM", "AQAAAAEAACcQAAAAENACEcQ3xgKIcKRqNHZXVeHdhohWaAc7IWJuicoyVrCtqnsQLaakIuvRqJ5rYg29Ig==", null, false, "575fef13-4695-4bfc-9edc-00d5ccde34c3", false, "standard@standard.com" },
                    { "e666558d-13c9-4d76-8d2c-6d7cfe201598", 0, "04952cb2-8d01-452e-9506-147ec28ca4c3", "admin@admin.com", true, null, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEPscyp3OS13iHrr01UI0gj456MlPwlW+0MGIvhxDtPSeNHm3qroPX6Nzcgs8jnXAvw==", null, false, "3792c8ea-32b3-4499-af13-6cde8c6b4669", false, "admin@admin.com" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "e666558d-13c9-4d76-8d2c-6d7cfe201598");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b68078a7-3d6f-4dfd-b815-559dd298c38e", "dd3fc3fe-714f-4139-9ab0-348669e6b4f9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "463abc9b-8ed1-446f-bb70-9e3f9a8275c5", "e666558d-13c9-4d76-8d2c-6d7cfe201598" });
        }
    }
}
