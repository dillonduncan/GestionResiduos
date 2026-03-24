using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionResiduos.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Residuos",
                columns: table => new
                {
                    IdResiduo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameResiduo = table.Column<string>(type: "TEXT", nullable: false),
                    TipoResiduo = table.Column<string>(type: "TEXT", nullable: false),
                    PespResiduo = table.Column<double>(type: "REAL", nullable: false),
                    FechaRecoleccionResiduo = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residuos", x => x.IdResiduo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Residuos");
        }
    }
}
