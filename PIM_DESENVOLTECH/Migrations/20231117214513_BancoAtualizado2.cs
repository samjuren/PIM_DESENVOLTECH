using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class BancoAtualizado2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Departamento",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeRua",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departamento",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "NomeRua",
                table: "Funcionario");
        }
    }
}
