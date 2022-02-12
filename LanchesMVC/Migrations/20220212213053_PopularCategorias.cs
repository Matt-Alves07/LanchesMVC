using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO lanches.categoria(nome, descricao) VALUES('Normal','Lanche feito com ingredientes normais');");
            migrationBuilder.Sql("INSERT INTO lanches.categoria(nome, descricao) VALUES('Natural','Lanche feito com ingredientes integrais e/ou naturais');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM lanches.categorias;");
        }
    }
}
