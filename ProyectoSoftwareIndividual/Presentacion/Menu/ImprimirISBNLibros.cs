using ProyectoSoftwareIndividual.Aplicacion.Validacion;
using ProyectoSoftwareIndividual.Consultas;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Presentacion.Menu
{
    public class ImprimirISBNLibros
    {
        public void ImprimirLibros()
        {
            List<Libros> libros = new ConsultaListaDeLibros().ListarLibros();
            foreach (Libros libro in libros)
            {
                bool valido = new ValidacionStock().Comprobar(libro);
                if (valido)
                {
                    Console.WriteLine("ISBN: " + libro.ISBN + "   /Titulo: " + libro.Titulo + "   /Stock: " + libro.Stock);
                }
            }
        }
    }
}
