using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoSoftwareIndividual.Migrations
{
    public partial class DataBaseMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_cliente_ClienteID",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Libros_ISBNID",
                table: "Alquileres");

            migrationBuilder.RenameColumn(
                name: "ISBNID",
                table: "Alquileres",
                newName: "ISBNId");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Alquileres",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ISBNID",
                table: "Alquileres",
                newName: "IX_Alquileres_ISBNId");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ClienteID",
                table: "Alquileres",
                newName: "IX_Alquileres_ClienteId");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Libros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaReserva",
                table: "Alquileres",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDevolucion",
                table: "Alquileres",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAlquiler",
                table: "Alquileres",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_cliente_ClienteId",
                table: "Alquileres",
                column: "ClienteId",
                principalTable: "cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Libros_ISBNId",
                table: "Alquileres",
                column: "ISBNId",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_cliente_ClienteId",
                table: "Alquileres");

            migrationBuilder.DropForeignKey(
                name: "FK_Alquileres_Libros_ISBNId",
                table: "Alquileres");

            migrationBuilder.RenameColumn(
                name: "ISBNId",
                table: "Alquileres",
                newName: "ISBNID");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Alquileres",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ISBNId",
                table: "Alquileres",
                newName: "IX_Alquileres_ISBNID");

            migrationBuilder.RenameIndex(
                name: "IX_Alquileres_ClienteId",
                table: "Alquileres",
                newName: "IX_Alquileres_ClienteID");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Libros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaReserva",
                table: "Alquileres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDevolucion",
                table: "Alquileres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAlquiler",
                table: "Alquileres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_cliente_ClienteID",
                table: "Alquileres",
                column: "ClienteID",
                principalTable: "cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alquileres_Libros_ISBNID",
                table: "Alquileres",
                column: "ISBNID",
                principalTable: "Libros",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
