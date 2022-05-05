using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoSoftwareIndividual.Migrations
{
    public partial class DataBaseMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Libros_LibroId",
                table: "Alquileres");

            migrationBuilder.RenameColumn(
                name: "LibroId",
                table: "Alquileres",
                newName: "ISBNID");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_LibroId",
                table: "Alquileres",
                newName: "IX_Alquileres_ISBNID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Libros_ISBNID",
                table: "Alquileres",
                column: "ISBNID",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Libros_ISBNID",
                table: "Alquileres");

            migrationBuilder.RenameColumn(
                name: "ISBNID",
                table: "Alquileres",
                newName: "LibroId");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ISBNID",
                table: "Alquileres",
                newName: "IX_Alquileres_LibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Libros_LibroId",
                table: "Alquileres",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
