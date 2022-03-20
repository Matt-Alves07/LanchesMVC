using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "lanches");

            migrationBuilder.CreateTable(
                name: "categoria",
                schema: "lanches",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lanches",
                schema: "lanches",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    descricaocurta = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    descricaodetalhada = table.Column<string>(type: "text", nullable: true),
                    preco = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    imagemurl = table.Column<string>(type: "text", nullable: true),
                    imagemthumbnailurl = table.Column<string>(type: "text", nullable: true),
                    islanchepreferido = table.Column<bool>(type: "boolean", nullable: false),
                    emestoque = table.Column<bool>(type: "boolean", nullable: false),
                    categoriaid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lanches", x => x.id);
                    table.ForeignKey(
                        name: "FK_lanches_categoria_categoriaid",
                        column: x => x.categoriaid,
                        principalSchema: "lanches",
                        principalTable: "categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lanches_categoriaid",
                schema: "lanches",
                table: "lanches",
                column: "categoriaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lanches",
                schema: "lanches");

            migrationBuilder.DropTable(
                name: "categoria",
                schema: "lanches");
        }
    }
}
