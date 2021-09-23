using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    CompraId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Datacompra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    Imagem = table.Column<string>(nullable: true),
                    preco = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MateriaPrima",
                columns: table => new
                {
                    MateriaPrimaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    quantidade = table.Column<double>(nullable: false),
                    VlrUnitario = table.Column<double>(nullable: false),
                    uniId = table.Column<int>(nullable: true),
                    TipoIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaPrima", x => x.MateriaPrimaId);
                    table.ForeignKey(
                        name: "FK_MateriaPrima_Tipo_TipoIdId",
                        column: x => x.TipoIdId,
                        principalTable: "Tipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MateriaPrima_Unidade_uniId",
                        column: x => x.uniId,
                        principalTable: "Unidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materia_Compras",
                columns: table => new
                {
                    CompraId1 = table.Column<int>(nullable: true),
                    MateriaPrimaId = table.Column<int>(nullable: false),
                    CompraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia_Compras", x => new { x.MateriaPrimaId, x.CompraId });
                    table.ForeignKey(
                        name: "FK_Materia_Compras_MateriaPrima_CompraId",
                        column: x => x.CompraId,
                        principalTable: "MateriaPrima",
                        principalColumn: "MateriaPrimaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materia_Compras_Compra_CompraId1",
                        column: x => x.CompraId1,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materia_Fornecedor",
                columns: table => new
                {
                    FornecedorId1 = table.Column<int>(nullable: true),
                    FornecedorId = table.Column<int>(nullable: false),
                    MateriaPrimaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia_Fornecedor", x => new { x.MateriaPrimaId, x.FornecedorId });
                    table.ForeignKey(
                        name: "FK_Materia_Fornecedor_MateriaPrima_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "MateriaPrima",
                        principalColumn: "MateriaPrimaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materia_Fornecedor_Fornecedor_FornecedorId1",
                        column: x => x.FornecedorId1,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materia_Prooduto",
                columns: table => new
                {
                    MateriaPrimaId1 = table.Column<int>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: false),
                    MateriaPrimaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia_Prooduto", x => new { x.MateriaPrimaId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_Materia_Prooduto_Produto_MateriaPrimaId",
                        column: x => x.MateriaPrimaId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materia_Prooduto_MateriaPrima_MateriaPrimaId1",
                        column: x => x.MateriaPrimaId1,
                        principalTable: "MateriaPrima",
                        principalColumn: "MateriaPrimaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materia_Compras_CompraId",
                table: "Materia_Compras",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_Compras_CompraId1",
                table: "Materia_Compras",
                column: "CompraId1");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_Fornecedor_FornecedorId",
                table: "Materia_Fornecedor",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_Fornecedor_FornecedorId1",
                table: "Materia_Fornecedor",
                column: "FornecedorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_Prooduto_MateriaPrimaId1",
                table: "Materia_Prooduto",
                column: "MateriaPrimaId1");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrima_TipoIdId",
                table: "MateriaPrima",
                column: "TipoIdId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrima_uniId",
                table: "MateriaPrima",
                column: "uniId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materia_Compras");

            migrationBuilder.DropTable(
                name: "Materia_Fornecedor");

            migrationBuilder.DropTable(
                name: "Materia_Prooduto");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "MateriaPrima");

            migrationBuilder.DropTable(
                name: "Tipo");

            migrationBuilder.DropTable(
                name: "Unidade");
        }
    }
}
