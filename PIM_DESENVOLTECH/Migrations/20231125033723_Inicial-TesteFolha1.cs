using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class InicialTesteFolha1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_descontosSalariais_Funcionario_FuncionarioIdFuncionario",
                table: "descontosSalariais");

            migrationBuilder.DropIndex(
                name: "IX_descontosSalariais_FuncionarioIdFuncionario",
                table: "descontosSalariais");

            migrationBuilder.DropColumn(
                name: "FuncionarioIdFuncionario",
                table: "descontosSalariais");


            migrationBuilder.CreateIndex(
                name: "IX_descontosSalariais_FK_IdFuncionario",
                table: "descontosSalariais",
                column: "FK_IdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_descontosSalariais_Funcionario_FK_IdFuncionario",
                table: "descontosSalariais",
                column: "FK_IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_descontosSalariais_Funcionario_FK_IdFuncionario",
                table: "descontosSalariais");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_DescontosId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_descontosSalariais_FK_IdFuncionario",
                table: "descontosSalariais");

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioIdFuncionario",
                table: "descontosSalariais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_descontosSalariais_FuncionarioIdFuncionario",
                table: "descontosSalariais",
                column: "FuncionarioIdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_descontosSalariais_Funcionario_FuncionarioIdFuncionario",
                table: "descontosSalariais",
                column: "FuncionarioIdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
