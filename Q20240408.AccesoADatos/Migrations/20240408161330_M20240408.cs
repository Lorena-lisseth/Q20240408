using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Q20240408.AccesoADatos.Migrations
{
    public partial class M20240408 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreQ = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ApellidoQ = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaNacimientoQ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoQ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusQ = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
