using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaCodigoProgramacionBack.Migrations
{
    public partial class codigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "codigos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcionCorta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagenPortada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    linkCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codigos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "codigos");
        }
    }
}
