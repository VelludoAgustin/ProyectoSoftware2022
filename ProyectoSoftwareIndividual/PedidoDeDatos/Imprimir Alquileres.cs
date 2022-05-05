using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Constructores;
using ProyectoSoftwareIndividual.Validacion;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;
using ProyectoSoftwareIndividual.Consultas;

namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class Imprimir_Reservas
    {
        public void Imprimir_ReservasYLibro()
        {
            var listaAlquileres = new Consulta_Lista_de_Alquileres().ListarAlquileres();
            foreach (var alquileres in listaAlquileres)
            {
                var Cliente = new Consulta_de_Cliente().BuscarClienteEnBaseId(alquileres.ClienteId);
                var Libro = new Consulta_de_Libros().BuscarLibroConISBN(alquileres.ISBNId);
                var Estado = new Consulta_de_Estado().BuscarEstadoID(alquileres.EstadoId);
                if("Reservado"==Estado.Descripcion)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.WriteLine("Nombre de Cliente: " + Cliente.Nombre + " " + Cliente.Apellido);
                    Console.WriteLine("Fecha de Reserva: " + alquileres.FechaAlquiler);
                    Console.WriteLine("ISBN: " + Libro.ISBN);
                    Console.WriteLine("Titulo: " + Libro.Titulo);
                    Console.WriteLine("Autor: " + Libro.Autor);
                    Console.WriteLine("Editorial: " + Libro.Editorial);
                    Console.WriteLine("Edicion: " + Libro.Editorial);
                    Console.WriteLine("Stock: " + Libro.Stock);
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
