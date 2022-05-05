using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class Consulta_Lista_de_Estados
    {
        public List<EstadoDeAlquileres> ListarEstados()
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                List<EstadoDeAlquileres> lista = Contexto.EstadoDeAlquileres.ToList();
                return lista;
                
                //var ListaEstados = (List<EstadoDeAlquileres>)Contexto.EstadoDeAlquileres.Select(s => new {s.EstadoID, s.Descripcion});
                //return ListaEstados;
            }
        }
    }
}
