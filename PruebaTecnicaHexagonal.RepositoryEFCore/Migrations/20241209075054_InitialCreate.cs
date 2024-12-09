using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaTecnicaHexagonal.RepositoryEFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoriaId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoriaId",
                table: "Products",
                column: "CategoriaId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoriaId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoriaId",
                table: "Products",
                column: "CategoriaId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
