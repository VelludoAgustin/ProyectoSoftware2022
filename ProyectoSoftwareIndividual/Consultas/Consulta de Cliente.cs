using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class Consulta_de_Cliente
    {
        public Cliente BuscarClienteEnBaseDNI(string _dni)
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                var Cliente = Contexto.cliente.Where(s => s.DNI==_dni).FirstOrDefault();
                return Cliente;
            }
        }
        public Cliente BuscarClienteEnBaseId(int _id)
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                var Cliente = Contexto.cliente.Where(s => s.ClienteID == _id).FirstOrDefault();
                return Cliente;
            }
        }
    }
}
