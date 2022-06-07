using Microsoft.EntityFrameworkCore.Migrations;

namespace LaClinica.Datos.Migrations
{
    public partial class RelacionSintomaNivel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NivelId",
                table: "Sintomas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sintomas_NivelId",
                table: "Sintomas",
                column: "NivelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sintomas_Niveles_NivelId",
                table: "Sintomas",
                column: "NivelId",
                principalTable: "Niveles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sintomas_Niveles_NivelId",
                table: "Sintomas");

            migrationBuilder.DropIndex(
                name: "IX_Sintomas_NivelId",
                table: "Sintomas");

            migrationBuilder.DropColumn(
                name: "NivelId",
                table: "Sintomas");
        }
    }
}
