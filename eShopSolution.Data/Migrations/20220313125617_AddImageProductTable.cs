using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddImageProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 9, 15, 10, 57, 140, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 9, 15, 10, 57, 140, DateTimeKind.Local).AddTicks(1507),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d4965cc8-fdab-433f-ae1d-79540827db5a"),
                column: "ConcurrencyStamp",
                value: "98394cec-30fb-4237-a26a-5d5e2e7f7a2e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1cee3d50-87bb-48d5-a493-376829c581c9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb444667-1c1e-41c2-a4ea-7e2cb259f24a", "AQAAAAEAACcQAAAAEJPz28x/K40Q3+Hfz/SNmayZKbe8ZFl1iGPPuHzNcb5WPBKGtnvrbAlRMDVjHp4eng==" });

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
    }
}
