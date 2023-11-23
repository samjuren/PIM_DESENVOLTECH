using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class InicialAjusteFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_FolhaPonto_FolhaPontoIdFolhaPonto",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_FolhaPontoIdFolhaPonto",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "FK_IdFolhaPonto",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "FolhaPontoIdFolhaPonto",
                table: "Funcionario");

            migrationBuilder.AddColumn<int>(
                name: "FK_IdFuncionario",
                table: "FolhaPonto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioIdFuncionario",
                table: "FolhaPonto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPonto_FuncionarioIdFuncionario",
                table: "FolhaPonto",
                column: "FuncionarioIdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_FolhaPonto_Funcionario_FuncionarioIdFuncionario",
                table: "FolhaPonto",
                column: "FuncionarioIdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "IdFuncionario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FolhaPonto_Funcionario_FuncionarioIdFuncionario",
                table: "FolhaPonto");

            migrationBuilder.DropIndex(
                name: "IX_FolhaPonto_FuncionarioIdFuncionario",
                table: "FolhaPonto");

            migrationBuilder.DropColumn(
                name: "FK_IdFuncionario",
                table: "FolhaPonto");

            migrationBuilder.DropColumn(
                name: "FuncionarioIdFuncionario",
                table: "FolhaPonto");

            migrationBuilder.AddColumn<int>(
                name: "FK_IdFolhaPonto",
                table: "Funcionario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FolhaPontoIdFolhaPonto",
                table: "Funcionario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_FolhaPontoIdFolhaPonto",
                table: "Funcionario",
                column: "FolhaPontoIdFolhaPonto");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_FolhaPonto_FolhaPontoIdFolhaPonto",
                table: "Funcionario",
                column: "FolhaPontoIdFolhaPonto",
                principalTable: "FolhaPonto",
                principalColumn: "IdFolhaPonto");
        }
    }
}
