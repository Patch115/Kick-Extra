using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KDSevice.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autobuss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Matricula = table.Column<string>(nullable: false),
                    Modelo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autobuss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paradas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Incidentes = table.Column<int>(nullable: false),
                    Tipo_incidente = table.Column<string>(nullable: true),
                    Fecha = table.Column<string>(nullable: true),
                    Hora = table.Column<int>(nullable: false),
                    Ruta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paradas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Distancia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupervisorS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido_paterno = table.Column<string>(nullable: true),
                    Apellido_materno = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupervisorS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    NUsuario = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conductors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Conduc = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido_paterno = table.Column<string>(nullable: true),
                    Apellido_materno = table.Column<string>(nullable: true),
                    Tipo_licencia = table.Column<string>(nullable: true),
                    Autobus = table.Column<string>(nullable: false),
                    Aatricula = table.Column<string>(nullable: false),
                    AutoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conductors_Autobuss_AutoId",
                        column: x => x.AutoId,
                        principalTable: "Autobuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Usuario = table.Column<string>(nullable: true),
                    Contraseña = table.Column<int>(nullable: false),
                    SupervisorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_SupervisorS_SupervisorID",
                        column: x => x.SupervisorID,
                        principalTable: "SupervisorS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conductors_AutoId",
                table: "Conductors",
                column: "AutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_SupervisorID",
                table: "Logins",
                column: "SupervisorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conductors");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Paradas");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Autobuss");

            migrationBuilder.DropTable(
                name: "SupervisorS");
        }
    }
}
