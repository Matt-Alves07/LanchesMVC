using System.Text;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var query = new StringBuilder();
            query.Clear();

            query.Append("INSERT INTO lanches.categoria(nome, descricao) VALUES");
            query.Append("('Normal','Lanche feito com ingredientes normais'),");
            query.Append("('Natural','Lanche feito com ingredientes integrais e/ou naturais'),");
            query.Append("('Bebidas','Bebidas Diversas'),");
            query.Append("('Bebidas Naturais','Sucos feitos a partir de frutas frescas');");

            migrationBuilder.Sql(query.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM lanches.categorias;");
        }
    }
}
