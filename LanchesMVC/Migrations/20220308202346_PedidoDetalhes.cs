using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LanchesMVC.Migrations
{
    public partial class PedidoDetalhes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pedidos");

            migrationBuilder.EnsureSchema(
                name: "pedidosdetalhes");

            migrationBuilder.CreateTable(
                name: "lanches",
                schema: "pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    sobrenome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    endereco = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    complemento = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    cep = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    estado = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cidade = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    telefone = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    totalPedido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalItensPedido = table.Column<int>(type: "integer", nullable: false),
                    datapedido = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dataenvio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lanches", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lanches",
                schema: "pedidosdetalhes",
                columns: table => new
                {
                    PedidoDetalheId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PedidoId = table.Column<int>(type: "integer", nullable: false),
                    LancheId = table.Column<int>(type: "integer", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lanches", x => x.PedidoDetalheId);
                    table.ForeignKey(
                        name: "FK_lanches_lanches_LancheId",
                        column: x => x.LancheId,
                        principalSchema: "lanches",
                        principalTable: "lanches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lanches_lanches_PedidoId",
                        column: x => x.PedidoId,
                        principalSchema: "pedidos",
                        principalTable: "lanches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lanches_LancheId",
                schema: "pedidosdetalhes",
                table: "lanches",
                column: "LancheId");

            migrationBuilder.CreateIndex(
                name: "IX_lanches_PedidoId",
                schema: "pedidosdetalhes",
                table: "lanches",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lanches",
                schema: "pedidosdetalhes");

            migrationBuilder.DropTable(
                name: "lanches",
                schema: "pedidos");
        }
    }
}
