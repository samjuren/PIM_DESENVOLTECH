using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class BancoAtualizado3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Funcionario");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroRua",
                table: "Funcionario",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroRua",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
