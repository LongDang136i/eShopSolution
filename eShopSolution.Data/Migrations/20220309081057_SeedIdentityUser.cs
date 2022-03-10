using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 15, 10, 57, 140, DateTimeKind.Local).AddTicks(1507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 14, 53, 32, 427, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("d4965cc8-fdab-433f-ae1d-79540827db5a"), "98394cec-30fb-4237-a26a-5d5e2e7f7a2e", "Administrator Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("1cee3d50-87bb-48d5-a493-376829c581c9"), new Guid("d4965cc8-fdab-433f-ae1d-79540827db5a") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FisrtName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1cee3d50-87bb-48d5-a493-376829c581c9"), 0, "eb444667-1c1e-41c2-a4ea-7e2cb259f24a", new DateTime(2000, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "danglong136i@gmail.com", true, "Long", "Dang", false, null, "danglong136i@gmail.com", "admin", "AQAAAAEAACcQAAAAEJPz28x/K40Q3+Hfz/SNmayZKbe8ZFl1iGPPuHzNcb5WPBKGtnvrbAlRMDVjHp4eng==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 15, 10, 57, 161, DateTimeKind.Local).AddTicks(3999));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d4965cc8-fdab-433f-ae1d-79540827db5a"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("1cee3d50-87bb-48d5-a493-376829c581c9"), new Guid("d4965cc8-fdab-433f-ae1d-79540827db5a") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1cee3d50-87bb-48d5-a493-376829c581c9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 14, 53, 32, 427, DateTimeKind.Local).AddTicks(2237),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 3, 9, 15, 10, 57, 140, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 9, 14, 53, 32, 447, DateTimeKind.Local).AddTicks(4219));
        }
    }
}
