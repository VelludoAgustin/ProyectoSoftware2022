using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class ConsultaListaDeLibros
    {
        public List<Libros> ListarLibros()
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                List<Libros> lista = contexto.Libros.ToList();
                return lista;
            }
        }
    }
}
