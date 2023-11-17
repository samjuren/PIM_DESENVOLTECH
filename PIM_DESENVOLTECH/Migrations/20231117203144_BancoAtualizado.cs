using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class BancoAtualizado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logradouro");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "PK_IdPessoa",
                table: "Funcionario",
                newName: "Idade");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Nascimento",
                table: "Funcionario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "NumeroRua",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "NomeCompleto",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "NumeroRua",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "Funcionario");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Funcionario",
                newName: "PK_IdPessoa");

            migrationBuilder.CreateTable(
                name: "Logradouro",
                columns: table => new
                {
                    IdLogradouro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PK_IdFuncionario = table.Column<int>(type: "int", nullable: false),
                    PK_IdPessoa = table.Column<int>(type: "int", nullable: false),
                    NumeroRua = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logradouro", x => x.IdLogradouro);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PK_IdFuncionario = table.Column<int>(type: "int", nullable: false),
                    IdLogradouro = table.Column<int>(type: "int", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.IdPessoa);
                });
        }
    }
}
