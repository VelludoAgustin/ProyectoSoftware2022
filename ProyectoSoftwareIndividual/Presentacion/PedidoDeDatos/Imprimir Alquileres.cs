using ProyectoSoftwareIndividual.Consultas;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class Imprimir_Reservas
    {
        public void Imprimir_ReservasYLibro()
        {
            var listaAlquileres = new ConsultaListaDeAlquileres().ListarAlquileres();
            foreach (var alquileres in listaAlquileres)
            {
                var Cliente = new ConsultaDeCliente().BuscarClienteEnBaseId(alquileres.ClienteId);
                var Libro = new ConsultaDeLibros().BuscarLibroConISBN(alquileres.ISBNId);
                var Estado = new ConsultaDeEstado().BuscarEstadoID(alquileres.EstadoId);
                if ("Reservado" == Estado.Descripcion)
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
