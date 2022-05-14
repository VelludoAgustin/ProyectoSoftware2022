using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class ImprimirReservas
    {
        public void ImprimirReservasYLibro(List<RetornoDeObjetos> lista)
        {
            foreach (var reserva in lista)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Nombre de Cliente: " + reserva.cliente.Nombre + " " + reserva.cliente.Nombre);
                Console.WriteLine("Fecha de Reserva: " + reserva.alquileres.FechaReserva);
                Console.WriteLine("ISBN: " + reserva.libro.ISBN);
                Console.WriteLine("Titulo: " + reserva.libro.Titulo);
                Console.WriteLine("Autor: " + reserva.libro.Autor);
                Console.WriteLine("Editorial: " + reserva.libro.Editorial);
                Console.WriteLine("Edicion: " + reserva.libro.Editorial);
                Console.WriteLine("Stock actual: " + reserva.libro.Stock);
                Console.WriteLine("Imagen :" + reserva.libro.Imagen);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
