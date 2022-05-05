using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoSoftwareIndividual.Migrations
{
    public partial class DataBaseMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_cliente_ClienteId",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_EstadoDeAlquileres_EstadoId",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Libros_ISBNId",
                table: "Alquileres");

            migrationBuilder.RenameColumn(
                name: "ISBNId",
                table: "Alquileres",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "Alquileres",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Alquileres",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ISBNId",
                table: "Alquileres",
                newName: "IX_Alquileres_ISBN");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_EstadoId",
                table: "Alquileres",
                newName: "IX_Alquileres_Estado");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ClienteId",
                table: "Alquileres",
                newName: "IX_Alquileres_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_cliente_Cliente",
                table: "Alquileres",
                column: "Cliente",
                principalTable: "cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_EstadoDeAlquileres_Estado",
                table: "Alquileres",
                column: "Estado",
                principalTable: "EstadoDeAlquileres",
                principalColumn: "EstadoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Libros_ISBN",
                table: "Alquileres",
                column: "ISBN",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_cliente_Cliente",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_EstadoDeAlquileres_Estado",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Libros_ISBN",
                table: "Alquileres");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Alquileres",
                newName: "ISBNId");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Alquileres",
                newName: "EstadoId");

            migrationBuilder.RenameColumn(
                name: "Cliente",
                table: "Alquileres",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ISBN",
                table: "Alquileres",
                newName: "IX_Alquileres_ISBNId");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_Estado",
                table: "Alquileres",
                newName: "IX_Alquileres_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_Cliente",
                table: "Alquileres",
                newName: "IX_Alquileres_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_cliente_ClienteId",
                table: "Alquileres",
                column: "ClienteId",
                principalTable: "cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_EstadoDeAlquileres_EstadoId",
                table: "Alquileres",
                column: "EstadoId",
                principalTable: "EstadoDeAlquileres",
                principalColumn: "EstadoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Libros_ISBNId",
                table: "Alquileres",
                column: "ISBNId",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
