using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class recriandoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPrima_Produto_MateriaPrima_MateriaPrimaId",
                table: "MateriaPrima_Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPrima_Produto_Produto_ProdutoID",
                table: "MateriaPrima_Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriaPrima_Produto",
                table: "MateriaPrima_Produto");

            migrationBuilder.DropIndex(
                name: "IX_MateriaPrima_Produto_MateriaPrimaId",
                table: "MateriaPrima_Produto");

            migrationBuilder.DropColumn(
                name: "IdMateriaPrima",
                table: "MateriaPrima_Produto");

            migrationBuilder.DropColumn(
                name: "IdProduto",
                table: "MateriaPrima_Produto");

            migrationBuilder.RenameColumn(
                name: "MateriaPrimaId",
                table: "MateriaPrima_Produto",
                newName: "MateriaPrimaID");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoID",
                table: "MateriaPrima_Produto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MateriaPrimaID",
                table: "MateriaPrima_Produto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriaPrima_Produto",
                table: "MateriaPrima_Produto",
                columns: new[] { "MateriaPrimaID", "ProdutoID" });

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPrima_Produto_MateriaPrima_MateriaPrimaID",
                table: "MateriaPrima_Produto",
                column: "MateriaPrimaID",
                principalTable: "MateriaPrima",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPrima_Produto_Produto_ProdutoID",
                table: "MateriaPrima_Produto",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPrima_Produto_MateriaPrima_MateriaPrimaID",
                table: "MateriaPrima_Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPrima_Produto_Produto_ProdutoID",
                table: "MateriaPrima_Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriaPrima_Produto",
                table: "MateriaPrima_Produto");

            migrationBuilder.RenameColumn(
                name: "MateriaPrimaID",
                table: "MateriaPrima_Produto",
                newName: "MateriaPrimaId");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoID",
                table: "MateriaPrima_Produto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MateriaPrimaId",
                table: "MateriaPrima_Produto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdMateriaPrima",
                table: "MateriaPrima_Produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProduto",
                table: "MateriaPrima_Produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriaPrima_Produto",
                table: "MateriaPrima_Produto",
                columns: new[] { "IdMateriaPrima", "IdProduto" });

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrima_Produto_MateriaPrimaId",
                table: "MateriaPrima_Produto",
                column: "MateriaPrimaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPrima_Produto_MateriaPrima_MateriaPrimaId",
                table: "MateriaPrima_Produto",
                column: "MateriaPrimaId",
                principalTable: "MateriaPrima",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPrima_Produto_Produto_ProdutoID",
                table: "MateriaPrima_Produto",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
