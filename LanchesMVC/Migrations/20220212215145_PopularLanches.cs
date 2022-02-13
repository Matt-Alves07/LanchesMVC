using System.Text;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var query = new StringBuilder();
            query.Clear();

            query.Append("INSERT INTO lanches.lanches(categoriaid,descricaocurta,descricaodetalhada,emestoque,islanchepreferido,nome,preco,ImagemThumbnailUrl,ImagemUrl) VALUES");
            query.Append("(1,'Pão, hambúrguer, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrguer com ovo frito, presunto e queijo de primeira qualidade acompanhado de batata palha',TRUE,FALSE,'X-Salada',12.50,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg'),");
            query.Append("(2,'Pão integral, alface, tomate, queijo minas e peito de peru','Delicioso pão de forma integral, com salada de alface e tomate, junto de queijo minas e peito de peru frescos',TRUE,TRUE,'Sanduíche Integral',10.00,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg');");

            migrationBuilder.Sql(query.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM lanches.lanches;");
        }
    }
}
