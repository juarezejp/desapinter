using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aerolinea",
                columns: table => new
                {
                    IDAerolinea = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ruc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aerolinea", x => x.IDAerolinea);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    IDPais = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.IDPais);
                });

            migrationBuilder.CreateTable(
                name: "Avion",
                columns: table => new
                {
                    IDAvion = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IDAerolinea = table.Column<int>(nullable: false),
                    fabricante = table.Column<string>(nullable: false),
                    tipo = table.Column<string>(nullable: false),
                    capacidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avion", x => x.IDAvion);
                    table.ForeignKey(
                        name: "FK_Avion_Aerolinea_IDAerolinea",
                        column: x => x.IDAerolinea,
                        principalTable: "Aerolinea",
                        principalColumn: "IDAerolinea",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aeropuerto",
                columns: table => new
                {
                    IDAeropuerto = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: false),
                    IDPais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeropuerto", x => x.IDAeropuerto);
                    table.ForeignKey(
                        name: "FK_Aeropuerto_Pais_IDPais",
                        column: x => x.IDPais,
                        principalTable: "Pais",
                        principalColumn: "IDPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pasajero",
                columns: table => new
                {
                    IDPasajero = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: false),
                    apaterno = table.Column<string>(nullable: true),
                    amaterno = table.Column<string>(nullable: false),
                    tipo_documento = table.Column<string>(nullable: false),
                    num_documento = table.Column<int>(nullable: false),
                    fecha_nacimiento = table.Column<DateTime>(nullable: false),
                    IDPais = table.Column<int>(nullable: false),
                    telefono = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    clave = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasajero", x => x.IDPasajero);
                    table.ForeignKey(
                        name: "FK_Pasajero_Pais_IDPais",
                        column: x => x.IDPais,
                        principalTable: "Pais",
                        principalColumn: "IDPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aeropuerto_IDPais",
                table: "Aeropuerto",
                column: "IDPais");

            migrationBuilder.CreateIndex(
                name: "IX_Avion_IDAerolinea",
                table: "Avion",
                column: "IDAerolinea");

            migrationBuilder.CreateIndex(
                name: "IX_Pasajero_IDPais",
                table: "Pasajero",
                column: "IDPais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeropuerto");

            migrationBuilder.DropTable(
                name: "Avion");

            migrationBuilder.DropTable(
                name: "Pasajero");

            migrationBuilder.DropTable(
                name: "Aerolinea");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
