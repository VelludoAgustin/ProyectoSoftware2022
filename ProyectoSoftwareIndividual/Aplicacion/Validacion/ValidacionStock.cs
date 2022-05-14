using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Aplicacion.Validacion
{
    public class ValidacionStock
    {
        public bool Comprobar(Libros libro)
        {
            return (libro.Stock > 0);
        }
    }
}
