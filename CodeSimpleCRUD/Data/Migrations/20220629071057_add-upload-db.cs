using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeSimpleCRUD.Data.Migrations
{
    public partial class adduploaddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product_Ajaxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Descrption = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Pric = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Ajaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Descrption = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Pric = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_Ajaxes");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
