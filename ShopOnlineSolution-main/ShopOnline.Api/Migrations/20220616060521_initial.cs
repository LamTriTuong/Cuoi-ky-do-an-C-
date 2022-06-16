using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Balo" },
                    { 2, "fas fa-couch", "Jacket" },
                    { 3, "fas fa-headphones", "suit" },
                    { 4, "fas fa-shoe-prints", "T-shirt" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Tuong" },
                    { 2, "Tinh" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "Phan thuong game thu top 100 td", "/photos/Balo/TD.jpg", "Balo Challenger", 350m, 100 },
                    { 2, 1, "Balo of FPX Team", "/photos/Balo/FPX.jpg", "Balo Fpx", 400m, 45 },
                    { 3, 1, "Balo of IvitusGaming", "/photos/Balo/IG.jpg", "Balo IG ", 450m, 30 },
                    { 4, 1, "Balo of SKTelecomT1", "/photos/Balo/T1.jpg", "Balo T1", 350m, 60 },
                    { 5, 1, "Balo of TeamSoloMid", "/photos/Balo/TSM.jpg", "Balo TSM", 0m, 400 },
                    { 6, 3, "The jacket for Damwon Gaming", "/photos/Jacket/dw.jpg", "Jacket DW", 700m, 120 },
                    { 7, 3, "The Jacket for EdwardGaming Team", "/photos/Jacket/edg.jpg", "EDG Jacket", 800m, 200 },
                    { 8, 3, "The jacket for the match of G2 team", "/photos/Jacket/g2.jpg", "G2 Jacket", 650m, 300 },
                    { 9, 3, "The jacket for GenG team - The Team 1st of Korea", "/photos/Jacket/geng.jpg", "GenG Jacket", 600m, 20 },
                    { 10, 3, "It the Best", "/photos/Jacket/fnc.jpg", "Fnc Jacket", 800m, 15 },
                    { 11, 3, "For Ahri Cosplayer", "/photos/suit/ahri.jpg", "Ahri suit", 1500m, 60 },
                    { 12, 2, "For Cosplayer KDA", "/photos/suit/kda.jpg", "Kda suit", 1700m, 212 },
                    { 13, 2, "Cosplay suit champ Leblanc", "/photos/suit/lb.jpg", "Leblanc Suit", 2000m, 112 },
                    { 14, 2, "Very beautiful suit for cosplayer", "/photos/suit/lulu.jpg", "LuLu Suit", 1700m, 90 },
                    { 15, 2, "make u feel like real neeko", "/photos/suit/nekko.jpg", "Neeko Suit", 2100m, 95 },
                    { 16, 2, "The T-Shirt of TeamLiquid for the match", "/photos/T-Shirt/tlts.jpg", "TL T-Shirt", 150m, 100 },
                    { 17, 2, "The T-Shirt with logo of Could 9 Team", "/photos/T-Shirt/c9ts.jpg", "C9 T-Shirt", 200m, 73 },
                    { 18, 4, "The T-Shirt for fans of FPX Team", "/photos/T-Shirt/fxpts.jpg", "FPX T-Shirt", 250m, 50 },
                    { 19, 4, "T-Shirt Gamer of G2 Team using for match", "/photos/T-Shirt/g2ts.jpg", "G2 Team T-shirt", 150m, 60 },
                    { 20, 4, "GenG is the best team in Korea", "/photos/T-Shirt/gets.jpg", "GenG T-Shirt", 200m, 70 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
