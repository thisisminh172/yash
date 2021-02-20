using Microsoft.EntityFrameworkCore.Migrations;

namespace yash.Data.Migrations
{
    public partial class change_name_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Sizes_RingSizeId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "RingSizes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RingSizes",
                table: "RingSizes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_RingSizes_RingSizeId",
                table: "Items",
                column: "RingSizeId",
                principalTable: "RingSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_RingSizes_RingSizeId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RingSizes",
                table: "RingSizes");

            migrationBuilder.RenameTable(
                name: "RingSizes",
                newName: "Sizes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Sizes_RingSizeId",
                table: "Items",
                column: "RingSizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
