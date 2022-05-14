using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class CrearDatosAlquiler
    {
        public List<string> ObtenerDatosAlquiler(string RoA)
        {
            List<string> datosAlquiler = new List<string>();
            Console.WriteLine("Ingrese DNI del Cliente");
            string dniCliente = Console.ReadLine();
            datosAlquiler.Add(dniCliente);
            Console.Clear();

            new ImprimirISBNLibros().ImprimirLibros();
            Console.WriteLine("Ingrese ISBN del Libro");
            string isbnLibro = Console.ReadLine();
            datosAlquiler.Add(isbnLibro);
            Console.Clear();

            datosAlquiler.Add(RoA);

            return datosAlquiler;
        }
    }
}
