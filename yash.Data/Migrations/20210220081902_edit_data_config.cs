using Microsoft.EntityFrameworkCore.Migrations;

namespace yash.Data.Migrations
{
    public partial class edit_data_config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Brands_BrandId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Certifications_CertificationId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Diamonds_DiamondId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Golds_GoldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CertificationId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CertificationId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DiamondTypeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GoldTypeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Pairs",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DiamondCarat",
                table: "Diamonds");

            migrationBuilder.DropColumn(
                name: "DiamondType",
                table: "Diamonds");

            migrationBuilder.AlterColumn<string>(
                name: "ShipPhoneNumber",
                table: "Orders",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShipName",
                table: "Orders",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShipEmail",
                table: "Orders",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShipAddress",
                table: "Orders",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "WastageInPercentage",
                table: "Items",
                nullable: false,
                defaultValue: 20,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Items",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "GoldWeight",
                table: "Items",
                nullable: false,
                defaultValue: 1f,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "GoldId",
                table: "Items",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiamondId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<float>(
                name: "DiamondCarat",
                table: "Items",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "RingSizeId",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ItemImageUrl",
                table: "ItemImages",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "ItemImages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "ItemImages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DiamondShape",
                table: "Diamonds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkUrl",
                table: "Certifications",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Role",
                table: "Admins",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admins",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Admins",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Admins",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Admins",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Admins",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 4, "Engagement" },
                    { 1, "Anniversary" },
                    { 2, "Birthday" },
                    { 3, "Wedding" }
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "CertifyType", "LinkUrl" },
                values: new object[,]
                {
                    { 1, "BIS Hallmark", "http://www.bis.org.in/" },
                    { 2, "SGL", "https://sgl-labs.com/" },
                    { 3, "IGI", "https://www.igi.org/" }
                });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "DiamondShape", "Price" },
                values: new object[,]
                {
                    { 1, "round", 7291f },
                    { 2, "princess", 4799f },
                    { 3, "oval", 5362f },
                    { 4, "cushion", 4229f },
                    { 5, "pear", 5802f },
                    { 6, "radiant", 4443f },
                    { 7, "emerald", 4476f },
                    { 8, "asscher", 4137f },
                    { 9, "marquise", 5596f },
                    { 10, "heart", 5536f }
                });

            migrationBuilder.InsertData(
                table: "Golds",
                columns: new[] { "Id", "GoldCarat", "Price" },
                values: new object[,]
                {
                    { 2, "18kt", 1338.9f },
                    { 1, "14kt", 1034.8f }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "RINGS" },
                    { 2, "EARRINGS" },
                    { 3, "PENDANTS" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeNumber" },
                values: new object[,]
                {
                    { 24, 29 },
                    { 23, 28 },
                    { 22, 27 },
                    { 21, 26 },
                    { 20, 25 },
                    { 19, 24 },
                    { 18, 23 },
                    { 17, 22 },
                    { 16, 21 },
                    { 15, 20 },
                    { 14, 19 },
                    { 4, 9 },
                    { 12, 17 },
                    { 11, 16 },
                    { 10, 15 },
                    { 9, 14 },
                    { 8, 13 },
                    { 7, 12 },
                    { 6, 11 },
                    { 5, 10 },
                    { 3, 8 },
                    { 25, 30 },
                    { 1, 6 },
                    { 13, 18 },
                    { 2, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CertifyId",
                table: "Items",
                column: "CertifyId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_RingSizeId",
                table: "Items",
                column: "RingSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Brands_BrandId",
                table: "Items",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Certifications_CertifyId",
                table: "Items",
                column: "CertifyId",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Diamonds_DiamondId",
                table: "Items",
                column: "DiamondId",
                principalTable: "Diamonds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Golds_GoldId",
                table: "Items",
                column: "GoldId",
                principalTable: "Golds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Sizes_RingSizeId",
                table: "Items",
                column: "RingSizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Brands_BrandId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Certifications_CertifyId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Diamonds_DiamondId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Golds_GoldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Sizes_RingSizeId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Items_CertifyId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_RingSizeId",
                table: "Items");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Golds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Golds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DiamondCarat",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "RingSizeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "ItemImages");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "ItemImages");

            migrationBuilder.DropColumn(
                name: "DiamondShape",
                table: "Diamonds");

            migrationBuilder.DropColumn(
                name: "LinkUrl",
                table: "Certifications");

            migrationBuilder.AlterColumn<string>(
                name: "ShipPhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ShipName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ShipEmail",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ShipAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "WastageInPercentage",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 20);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<float>(
                name: "GoldWeight",
                table: "Items",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldDefaultValue: 1f);

            migrationBuilder.AlterColumn<int>(
                name: "GoldId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "DiamondId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CertificationId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiamondTypeId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoldTypeId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pairs",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ItemImageUrl",
                table: "ItemImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiamondCarat",
                table: "Diamonds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiamondType",
                table: "Diamonds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Role",
                table: "Admins",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CertificationId",
                table: "Items",
                column: "CertificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Brands_BrandId",
                table: "Items",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Certifications_CertificationId",
                table: "Items",
                column: "CertificationId",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Diamonds_DiamondId",
                table: "Items",
                column: "DiamondId",
                principalTable: "Diamonds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Golds_GoldId",
                table: "Items",
                column: "GoldId",
                principalTable: "Golds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
