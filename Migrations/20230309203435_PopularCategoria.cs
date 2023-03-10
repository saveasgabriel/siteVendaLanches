using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Categorias\"(\"CategoriaNome\", \"Descricao\")VALUES ('Naturais', 'Produtos realizados com ingredientes naturais');");
            migrationBuilder.Sql("INSERT INTO \"Categorias\"(\"CategoriaNome\", \"Descricao\")VALUES ('Industrializados', 'Produtos realizados com ingredientes industriais');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Categorias\";");
        }
    }
}
