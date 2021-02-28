using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace yash.Data.Migrations
{
    public partial class add_data_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 200, nullable: true),
                    LastName = table.Column<string>(maxLength: 200, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    Role = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LinkUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diamonds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiamondShape = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diamonds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Golds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoldCarat = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RingSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RingSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    CurrentDate = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 0),
                    CategoryId = table.Column<int>(nullable: false),
                    CertifyId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    GoldId = table.Column<int>(nullable: false, defaultValue: 2),
                    DiamondId = table.Column<int>(nullable: false),
                    DiamondCarat = table.Column<float>(nullable: false),
                    GoldWeight = table.Column<float>(nullable: false, defaultValue: 1f),
                    WastageInPercentage = table.Column<int>(nullable: false, defaultValue: 20),
                    TotalMaking = table.Column<float>(nullable: false),
                    RingSizeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Certifications_CertifyId",
                        column: x => x.CertifyId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Diamonds_DiamondId",
                        column: x => x.DiamondId,
                        principalTable: "Diamonds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Golds_GoldId",
                        column: x => x.GoldId,
                        principalTable: "Golds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ProductTypes_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_RingSizes_RingSizeId",
                        column: x => x.RingSizeId,
                        principalTable: "RingSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ShipName = table.Column<string>(maxLength: 200, nullable: true),
                    ShipAddress = table.Column<string>(maxLength: 200, nullable: true),
                    ShipEmail = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShipPhoneNumber = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    ItemImageUrl = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemImages_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Password", "Role" },
                values: new object[] { 1, "cmt8", "minhl93172@gmail.com", "Minh", "Le", "123", true });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 2, "cmt8", "tuan123@gmail.com", "Tuan", "Bui", "123" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Anniversary" },
                    { 2, "Birthday" },
                    { 3, "Wedding" },
                    { 4, "Engagement" }
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "LinkUrl", "Name" },
                values: new object[,]
                {
                    { 1, "http://www.bis.org.in/", "BIS Hallmark" },
                    { 2, "https://sgl-labs.com/", "SGL" },
                    { 3, "https://www.igi.org/", "IGI" }
                });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "Id", "DiamondShape", "Price" },
                values: new object[,]
                {
                    { 10, "heart", 5536f },
                    { 8, "asscher", 4137f },
                    { 7, "emerald", 4476f },
                    { 6, "radiant", 4443f },
                    { 9, "marquise", 5596f },
                    { 4, "cushion", 4229f },
                    { 3, "oval", 5362f },
                    { 2, "princess", 4799f },
                    { 1, "round", 7291f },
                    { 5, "pear", 5802f }
                });

            migrationBuilder.InsertData(
                table: "Golds",
                columns: new[] { "Id", "GoldCarat", "Price" },
                values: new object[,]
                {
                    { 1, "14kt", 1034.8f },
                    { 2, "18kt", 1338.9f }
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
                table: "RingSizes",
                columns: new[] { "Id", "SizeNumber" },
                values: new object[,]
                {
                    { 16, 21 },
                    { 17, 22 },
                    { 18, 23 },
                    { 19, 24 },
                    { 20, 25 },
                    { 25, 30 },
                    { 22, 27 },
                    { 23, 28 },
                    { 24, 29 },
                    { 15, 20 },
                    { 21, 26 },
                    { 14, 19 },
                    { 2, 7 },
                    { 12, 17 },
                    { 11, 16 },
                    { 10, 15 },
                    { 9, 14 },
                    { 8, 13 },
                    { 7, 12 },
                    { 6, 11 },
                    { 5, 10 },
                    { 4, 9 },
                    { 3, 8 },
                    { 1, 6 },
                    { 13, 18 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "City", "CurrentDate", "DOB", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "State" },
                values: new object[,]
                {
                    { 2, "3 Thang 2", "HCM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuan123@gmail.com", "Tuan", "Bui", "123", null, null },
                    { 1, "CMT8", "HCM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "minh123@gmail.com", "Minh", "Le", "123", null, null },
                    { 3, "Hoang Sa", "HCM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin123@gmail.com", "admin", "admin", "123", null, null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "CertifyId", "DiamondCarat", "DiamondId", "GoldId", "Name", "ProductId", "Quantity", "RingSizeId", "TotalMaking" },
                values: new object[,]
                {
                    { 1, 1, 1, 0.1f, 2, 2, "The Jhonita Two Finger Ring", 1, 5, 6, 26309f },
                    { 2, 2, 2, 0.12f, 3, 2, "The Rudri Ring", 1, 4, 10, 33609f },
                    { 4, 1, 1, 0.07f, 1, 1, "The Arcane Stud Earrings", 2, 4, 10, 15000f },
                    { 5, 2, 2, 0.108f, 1, 2, "The Purva Drop Earrings", 2, 5, 10, 21593f },
                    { 6, 3, 3, 0.04f, 2, 1, "The Mahima Drop Earrings", 2, 4, 10, 23000f },
                    { 7, 1, 1, 0.04f, 3, 2, "The Mulam Pendant", 3, 4, 10, 21752f },
                    { 8, 2, 2, 0.025f, 3, 1, "The Rohal Pendant", 3, 5, 10, 11000f },
                    { 9, 3, 3, 0.029f, 1, 2, "The Ambrosia Pendant", 3, 4, 10, 7962f },
                    { 3, 3, 3, 0.12f, 1, 1, "The Maruwani Ring", 1, 5, 20, 27731f }
                });

            migrationBuilder.InsertData(
                table: "ItemImages",
                columns: new[] { "Id", "IsDefault", "ItemId", "ItemImageUrl", "SortOrder" },
                values: new object[,]
                {
                    { 1, true, 1, "images_product/ring1.png", 1 },
                    { 18, false, 9, "images_product/pendant6.png", 2 },
                    { 17, true, 9, "images_product/pendant5.png", 1 },
                    { 16, false, 8, "images_product/pendant4.png", 2 },
                    { 15, true, 8, "images_product/pendant3.png", 1 },
                    { 14, false, 7, "images_product/pendant2.png", 2 },
                    { 13, true, 7, "images_product/pendant1.png", 1 },
                    { 12, false, 6, "images_product/earring6.png", 2 },
                    { 11, true, 6, "images_product/earring5.png", 1 },
                    { 10, false, 5, "images_product/earring4.png", 2 },
                    { 9, true, 5, "images_product/earring3.png", 1 },
                    { 8, false, 4, "images_product/earring2.png", 2 },
                    { 7, true, 4, "images_product/earring1.png", 1 },
                    { 4, false, 2, "images_product/ring4.png", 2 },
                    { 3, true, 2, "images_product/ring3.png", 1 },
                    { 2, false, 1, "images_product/ring2.png", 2 },
                    { 5, true, 3, "images_product/ring5.png", 1 },
                    { 6, false, 3, "images_product/ring6.png", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ItemId",
                table: "Carts",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemImages_ItemId",
                table: "ItemImages",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CertifyId",
                table: "Items",
                column: "CertifyId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_DiamondId",
                table: "Items",
                column: "DiamondId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GoldId",
                table: "Items",
                column: "GoldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductId",
                table: "Items",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_RingSizeId",
                table: "Items",
                column: "RingSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ItemId",
                table: "OrderDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ItemImages");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Diamonds");

            migrationBuilder.DropTable(
                name: "Golds");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "RingSizes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
