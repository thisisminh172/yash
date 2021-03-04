using Microsoft.EntityFrameworkCore.Migrations;

namespace yash.Data.Migrations
{
    public partial class add_quantity_column_in_orderdetail_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "GoldId", "Quantity" },
                values: new object[] { 2, 4 });
        }
    }
}
