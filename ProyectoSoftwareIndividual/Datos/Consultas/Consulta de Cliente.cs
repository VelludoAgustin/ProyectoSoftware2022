using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class ConsultaDeCliente
    {
        public Cliente BuscarClienteEnBaseDNI(string dni)
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                var cliente = contexto.cliente.Where(s => s.DNI == dni).FirstOrDefault();
                return cliente;
            }
        }
        public Cliente BuscarClienteEnBaseId(int id)
        {
            using (var contexto = new ProyectoSoftwareLibreriaContext())
            {
                var cliente = contexto.cliente.Where(s => s.ClienteID == id).FirstOrDefault();
                return cliente;
            }
        }
    }
}
