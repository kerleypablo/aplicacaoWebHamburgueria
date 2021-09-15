using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class TabelaFornecedores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fornecedorIdId",
                table: "MateriaPrima",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrima_fornecedorIdId",
                table: "MateriaPrima",
                column: "fornecedorIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPrima_Fornecedor_fornecedorIdId",
                table: "MateriaPrima",
                column: "fornecedorIdId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPrima_Fornecedor_fornecedorIdId",
                table: "MateriaPrima");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_MateriaPrima_fornecedorIdId",
                table: "MateriaPrima");

            migrationBuilder.DropColumn(
                name: "fornecedorIdId",
                table: "MateriaPrima");
        }
    }
}
