using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsInventory.Migrations
{
    /// <inheritdoc />
    public partial class Initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductBaseGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGruopId = table.Column<int>(type: "int", nullable: false),
                    ProductGroupCode = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    ProdcutExpireDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecieptId = table.Column<int>(type: "int", nullable: false),
                    ProductEntity = table.Column<int>(type: "int", nullable: false),
                    RecieptCost = table.Column<int>(type: "int", nullable: false),
                    RecieptDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherId = table.Column<int>(type: "int", nullable: false),
                    VoucherDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
