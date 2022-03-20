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
            query.Append("(2,'Pão integral, alface, tomate, queijo minas e peito de peru','Delicioso pão de forma integral, com salada de alface e tomate, junto de queijo minas e peito de peru frescos',TRUE,TRUE,'Sanduíche Integral',10.00,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg'),");
            query.Append("(3,'Refrigerante em lata','Todo o sabor de Pepsi, com um toque de limão',TRUE,FALSE,'Pepsi Twist',5.00,'https://assets.instabuy.com.br/ib.item.image.big/b-ea853ba9258649caa273cf305efaeb96.jpeg','https://assets.instabuy.com.br/ib.item.image.big/b-ea853ba9258649caa273cf305efaeb96.jpeg'),");
            query.Append("(3,'Refrigerante em lata','Coca-Cola sabor original',TRUE,TRUE,'Coca-Cola',5.00,'https://araujo.vteximg.com.br/arquivos/ids/4143343-1000-1000/07894900010015.jpg?v=637770769515630000','https://araujo.vteximg.com.br/arquivos/ids/4143343-1000-1000/07894900010015.jpg?v=637770769515630000'),");
            query.Append("(4,'Suco natural','Suco de maracujá da fruta',TRUE,TRUE,'Suco',9.00,'https://coolicias.ao/wp-content/uploads/2020/02/Receita-de-Mousse-de-Maracuj%C3%A1-com-Suco-Concentrado.jpg','https://coolicias.ao/wp-content/uploads/2020/02/Receita-de-Mousse-de-Maracuj%C3%A1-com-Suco-Concentrado.jpg');");

            migrationBuilder.Sql(query.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM lanches.lanches;");
        }
    }
}
