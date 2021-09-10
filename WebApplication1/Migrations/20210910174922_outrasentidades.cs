using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class outrasentidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unidade",
                table: "MateriaPrima");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoID",
                table: "MateriaPrima",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "VlrUnitario",
                table: "MateriaPrima",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "uni",
                table: "MateriaPrima",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true),
                    preco = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MateriaPrima_Produto",
                columns: table => new
                {
                    IdMateriaPrima = table.Column<int>(nullable: false),
                    IdProduto = table.Column<int>(nullable: false),
                    MateriaPrimaId = table.Column<int>(nullable: true),
                    ProdutoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaPrima_Produto", x => new { x.IdMateriaPrima, x.IdProduto });
                    table.ForeignKey(
                        name: "FK_MateriaPrima_Produto_MateriaPrima_MateriaPrimaId",
                        column: x => x.MateriaPrimaId,
                        principalTable: "MateriaPrima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MateriaPrima_Produto_Produto_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrima_ProdutoID",
                table: "MateriaPrima",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrima_Produto_MateriaPrimaId",
                table: "MateriaPrima_Produto",
                column: "MateriaPrimaId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrima_Produto_ProdutoID",
                table: "MateriaPrima_Produto",
                column: "ProdutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPrima_Produto_ProdutoID",
                table: "MateriaPrima",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPrima_Produto_ProdutoID",
                table: "MateriaPrima");

            migrationBuilder.DropTable(
                name: "MateriaPrima_Produto");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_MateriaPrima_ProdutoID",
                table: "MateriaPrima");

            migrationBuilder.DropColumn(
                name: "ProdutoID",
                table: "MateriaPrima");

            migrationBuilder.DropColumn(
                name: "VlrUnitario",
                table: "MateriaPrima");

            migrationBuilder.DropColumn(
                name: "uni",
                table: "MateriaPrima");

            migrationBuilder.AddColumn<string>(
                name: "Unidade",
                table: "MateriaPrima",
                nullable: true);
        }
    }
}
