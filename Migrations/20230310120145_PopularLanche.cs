using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanche : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO public.\"Lanches\"(\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") "+
                "VALUES ('Pão com presunto', 'Pão caseiro presunto', 'Pão de brioche, com presunto seara e amateigado',12.00, 'https://t3.ftcdn.net/jpg/01/82/43/26/360_F_182432679_9IUAzFEU7jzTFJcnZChiVP4mnGhU21v2.jpg', 'https://t3.ftcdn.net/jpg/01/82/43/26/360_F_182432679_9IUAzFEU7jzTFJcnZChiVP4mnGhU21v2.jpg', False, True, 5);");
            migrationBuilder.Sql("INSERT INTO public.\"Lanches\"(\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('Pão com ovo', 'Pão caseiro com ovo frito', 'Pão de brioche, com ovo classe A e amateigado',12.00, 'https://t3.ftcdn.net/jpg/01/82/43/26/360_F_182432679_9IUAzFEU7jzTFJcnZChiVP4mnGhU21v2.jpg', 'https://t3.ftcdn.net/jpg/01/82/43/26/360_F_182432679_9IUAzFEU7jzTFJcnZChiVP4mnGhU21v2.jpg',True, True, 4);");
            migrationBuilder.Sql("INSERT INTO public.\"Lanches\"(\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('Pão com presunto e ovo', 'Pão caseiro com ovo e presunto', 'Pão de brioche, com presunto seara e amateigado e ovo classe A', 14.00, 'https://t3.ftcdn.net/jpg/01/82/43/26/360_F_182432679_9IUAzFEU7jzTFJcnZChiVP4mnGhU21v2.jpg', 'https://t3.ftcdn.net/jpg/01/82/43/26/360_F_182432679_9IUAzFEU7jzTFJcnZChiVP4mnGhU21v2.jpg', False, False, 5);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Lanches\";");
        }
    }
}
