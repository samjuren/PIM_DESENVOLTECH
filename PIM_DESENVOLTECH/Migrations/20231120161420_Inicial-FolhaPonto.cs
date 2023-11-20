using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class InicialFolhaPonto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FolhaPontoIdFolhaPonto",
                table: "Funcionario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFolhaPonto",
                table: "Funcionario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FolhaPonto",
                columns: table => new
                {
                    IdFolhaPonto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraPonto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolhaPonto", x => x.IdFolhaPonto);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_FolhaPonto_FolhaPontoIdFolhaPonto",
                table: "Funcionario");

            migrationBuilder.DropTable(
                name: "FolhaPonto");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_FolhaPontoIdFolhaPonto",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "FolhaPontoIdFolhaPonto",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "IdFolhaPonto",
                table: "Funcionario");
        }
    }
}
