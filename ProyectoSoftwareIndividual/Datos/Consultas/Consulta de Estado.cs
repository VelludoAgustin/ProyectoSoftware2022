using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class ConsultaDeEstado
    {
        public EstadoDeAlquileres BuscarEstado(string eleccion)
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                var estado = contexto.EstadoDeAlquileres.Where(s => s.Descripcion == eleccion).FirstOrDefault();
                return estado;
            }
        }
        public EstadoDeAlquileres BuscarEstadoID(int id)
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                var estado = contexto.EstadoDeAlquileres.Where(s => s.EstadoID == id).FirstOrDefault();
                return estado;
            }
        }
    }
}
