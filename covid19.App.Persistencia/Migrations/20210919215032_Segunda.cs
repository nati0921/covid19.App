using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace covid19.App.Persistencia.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "asignatura",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "carrera",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "departamento",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fecha",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "seguimiento",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "semestre",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "turno",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "unidad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "diagnosticos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado_covid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosticos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "focos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    num_contagios = table.Column<int>(type: "int", nullable: false),
                    unidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_focos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "salones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aforo = table.Column<int>(type: "int", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numero_puesto = table.Column<int>(type: "int", nullable: false),
                    sede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_sede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cant_salones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sedes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diagnosticos");

            migrationBuilder.DropTable(
                name: "focos");

            migrationBuilder.DropTable(
                name: "salones");

            migrationBuilder.DropTable(
                name: "sedes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "asignatura",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "carrera",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "departamento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "seguimiento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "semestre",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "turno",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "unidad",
                table: "Personas");
        }
    }
}
