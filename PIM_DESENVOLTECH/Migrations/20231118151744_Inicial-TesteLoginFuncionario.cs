using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class InicialTesteLoginFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "loginsId",
                table: "Funcionario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_loginsId",
                table: "Funcionario",
                column: "loginsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Login_loginsId",
                table: "Funcionario",
                column: "loginsId",
                principalTable: "Login",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Login_loginsId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_loginsId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "loginsId",
                table: "Funcionario");
        }
    }
}
