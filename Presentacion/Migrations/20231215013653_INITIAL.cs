using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentacion.Migrations
{
    /// <inheritdoc />
    public partial class INITIAL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Semestre = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paralelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Grupo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Jornada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paralelos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetalleParalelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParaleloId = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    ProfesorId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleParalelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleParalelos_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleParalelos_Paralelos_ParaleloId",
                        column: x => x.ParaleloId,
                        principalTable: "Paralelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleParalelos_Profesores_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfesoresPorMaterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    ProfesorId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesoresPorMaterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfesoresPorMaterias_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesoresPorMaterias_Profesores_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstudiantesPorParalelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetalleParaleloId = table.Column<int>(type: "int", nullable: false),
                    EstudianteId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudiantesPorParalelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstudiantesPorParalelos_DetalleParalelos_DetalleParaleloId",
                        column: x => x.DetalleParaleloId,
                        principalTable: "DetalleParalelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudiantesPorParalelos_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudiantesPorParaleloId = table.Column<int>(type: "int", nullable: false),
                    GFP1 = table.Column<decimal>(name: "GF_P1", type: "decimal(2,2)", nullable: false),
                    GPP1 = table.Column<decimal>(name: "GP_P1", type: "decimal(2,2)", nullable: false),
                    EXAP1 = table.Column<decimal>(name: "EXA_P1", type: "decimal(2,2)", nullable: false),
                    PROP1 = table.Column<decimal>(name: "PRO_P1", type: "decimal(2,2)", nullable: false),
                    GFP2 = table.Column<decimal>(name: "GF_P2", type: "decimal(2,2)", nullable: false),
                    GPP2 = table.Column<decimal>(name: "GP_P2", type: "decimal(2,2)", nullable: false),
                    EXAP2 = table.Column<decimal>(name: "EXA_P2", type: "decimal(2,2)", nullable: false),
                    PROP2 = table.Column<decimal>(name: "PRO_P2", type: "decimal(2,2)", nullable: false),
                    PROGEN = table.Column<decimal>(name: "PRO_GEN", type: "decimal(2,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificaciones_EstudiantesPorParalelos_EstudiantesPorParaleloId",
                        column: x => x.EstudiantesPorParaleloId,
                        principalTable: "EstudiantesPorParalelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_EstudiantesPorParaleloId",
                table: "Calificaciones",
                column: "EstudiantesPorParaleloId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleParalelos_MateriaId",
                table: "DetalleParalelos",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleParalelos_ParaleloId",
                table: "DetalleParalelos",
                column: "ParaleloId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleParalelos_ProfesorId",
                table: "DetalleParalelos",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudiantesPorParalelos_DetalleParaleloId",
                table: "EstudiantesPorParalelos",
                column: "DetalleParaleloId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudiantesPorParalelos_EstudianteId",
                table: "EstudiantesPorParalelos",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesoresPorMaterias_MateriaId",
                table: "ProfesoresPorMaterias",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesoresPorMaterias_ProfesorId",
                table: "ProfesoresPorMaterias",
                column: "ProfesorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "ProfesoresPorMaterias");

            migrationBuilder.DropTable(
                name: "EstudiantesPorParalelos");

            migrationBuilder.DropTable(
                name: "DetalleParalelos");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Paralelos");

            migrationBuilder.DropTable(
                name: "Profesores");
        }
    }
}
