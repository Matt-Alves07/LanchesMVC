using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class CarrinhoCompraItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carrinhocompraitens",
                schema: "lanches",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LancheId = table.Column<int>(type: "integer", nullable: true),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrinhocompraitens", x => x.id);
                    table.ForeignKey(
                        name: "FK_carrinhocompraitens_lanches_LancheId",
                        column: x => x.LancheId,
                        principalSchema: "lanches",
                        principalTable: "lanches",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_carrinhocompraitens_LancheId",
                schema: "lanches",
                table: "carrinhocompraitens",
                column: "LancheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carrinhocompraitens",
                schema: "lanches");
        }
    }
}
