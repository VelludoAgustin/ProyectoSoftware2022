using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class ConsultaListaDeEstados
    {
        public List<EstadoDeAlquileres> ListarEstados()
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                List<EstadoDeAlquileres> lista = contexto.EstadoDeAlquileres.ToList();
                return lista;
            }
        }
    }
}
