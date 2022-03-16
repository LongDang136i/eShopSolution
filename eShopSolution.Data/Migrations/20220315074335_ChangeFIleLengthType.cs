using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFIleLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d4965cc8-fdab-433f-ae1d-79540827db5a"),
                column: "ConcurrencyStamp",
                value: "ca0e103c-0c90-4409-a3e2-8ed294d45534");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1cee3d50-87bb-48d5-a493-376829c581c9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4200b3c9-f0c9-4eef-a770-3ed937200d77", "AQAAAAEAACcQAAAAEOOa644Siv+HkXpzh8MWlBEpwqboeVJ1m1jUGh5iYtUQ/7JS6ce/LQiCd3bWIStQQg==" });

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
                value: new DateTime(2022, 3, 15, 14, 43, 34, 188, DateTimeKind.Local).AddTicks(853));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d4965cc8-fdab-433f-ae1d-79540827db5a"),
                column: "ConcurrencyStamp",
                value: "8a01aed7-fc41-43b2-862f-0419da4fd0f8");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1cee3d50-87bb-48d5-a493-376829c581c9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "746ffe9f-4688-46e2-ad57-61c3d50bfffc", "AQAAAAEAACcQAAAAEJClvxvSXId8uVoCfQQTBINcVzhhEHsSr6y9QItK8DtofxJ8gqpzO026oJC4dexbJQ==" });

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
                value: new DateTime(2022, 3, 13, 19, 56, 16, 418, DateTimeKind.Local).AddTicks(1764));
        }
    }
}
