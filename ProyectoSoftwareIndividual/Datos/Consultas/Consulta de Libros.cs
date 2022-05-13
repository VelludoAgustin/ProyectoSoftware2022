using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class ConsultaDeLibros
    {
        public Libros BuscarLibroConISBN(string isbn)
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                var libro = contexto.Libros.Where(s => s.ISBN == isbn).FirstOrDefault();
                return libro;
            }
        }
    }
}
