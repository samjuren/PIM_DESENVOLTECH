using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class InicialModelsDescontos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Funcionario",
                newName: "FK_IdLogin");

            migrationBuilder.RenameColumn(
                name: "IdFolhaPonto",
                table: "Funcionario",
                newName: "FK_IdFolhaPonto");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdm",
                table: "Login",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FK_IdLogin",
                table: "Funcionario",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "FK_IdFolhaPonto",
                table: "Funcionario",
                newName: "IdFolhaPonto");

            migrationBuilder.AlterColumn<int>(
                name: "IsAdm",
                table: "Login",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
