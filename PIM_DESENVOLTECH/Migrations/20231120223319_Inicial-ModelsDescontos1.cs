using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIM_DESENVOLTECH.Migrations
{
    /// <inheritdoc />
    public partial class InicialModelsDescontos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "descontosSalariais",
                columns: table => new
                {
                    IdDesconto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioIdFuncionario = table.Column<int>(type: "int", nullable: false),
                    FK_IdFuncionario = table.Column<int>(type: "int", nullable: false),
                    ValeTransporte = table.Column<double>(type: "float", nullable: false),
                    INSS = table.Column<double>(type: "float", nullable: false),
                    ImpostoDeRenda = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_descontosSalariais", x => x.IdDesconto);
                    table.ForeignKey(
                        name: "FK_descontosSalariais_Funcionario_FuncionarioIdFuncionario",
                        column: x => x.FuncionarioIdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_descontosSalariais_FuncionarioIdFuncionario",
                table: "descontosSalariais",
                column: "FuncionarioIdFuncionario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "descontosSalariais");
        }
    }
}
