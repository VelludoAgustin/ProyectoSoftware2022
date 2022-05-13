using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class ConsultaListaDeAlquileres
    {
        public List<Alquileres> ListarAlquileres()
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                List<Alquileres> lista = contexto.Alquileres.ToList();
                return lista;
            }
        }
    }
}
