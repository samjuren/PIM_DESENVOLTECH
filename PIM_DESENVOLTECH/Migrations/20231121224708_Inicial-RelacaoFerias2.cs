using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class InicialRelacaoFerias2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RelacaoFerias",
                columns: table => new
                {
                    IdFerias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeriasInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FeriasFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FuncionarioIdFuncionario = table.Column<int>(type: "int", nullable: true),
                    FK_IdFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacaoFerias", x => x.IdFerias);
                    table.ForeignKey(
                        name: "FK_RelacaoFerias_Funcionario_FuncionarioIdFuncionario",
                        column: x => x.FuncionarioIdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelacaoFerias_FuncionarioIdFuncionario",
                table: "RelacaoFerias",
                column: "FuncionarioIdFuncionario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelacaoFerias");
        }
    }
}
