using Microsoft.EntityFrameworkCore.Migrations;

namespace LaClinica.Datos.Migrations
{
    public partial class DniAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DNI",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DNI",
                table: "Personas");
        }
    }
}
