using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionResiduos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDatosSemilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PespResiduo",
                table: "Residuos",
                newName: "PesoResiduo");

            migrationBuilder.InsertData(
                table: "Residuos",
                columns: new[] { "IdResiduo", "FechaRecoleccionResiduo", "NameResiduo", "PesoResiduo", "TipoResiduo" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cascara de Guineo", 0.5, "Organico" },
                    { 2, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Botella de Vidrio rota", 1.0, "Vidrio" },
                    { 3, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Botellas de Agua", 1.5, "Plastico" },
                    { 4, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Restos de comida", 2.0, "Organico" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "IdResiduo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "IdResiduo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "IdResiduo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residuos",
                keyColumn: "IdResiduo",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "PesoResiduo",
                table: "Residuos",
                newName: "PespResiduo");
        }
    }
}
