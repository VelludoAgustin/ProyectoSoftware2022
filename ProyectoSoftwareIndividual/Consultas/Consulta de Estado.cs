using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class Consulta_de_Estado
    {
        public EstadoDeAlquileres BuscarEstado(string Eleccion)
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                var Estado = Contexto.EstadoDeAlquileres.Where(s => s.Descripcion == Eleccion).FirstOrDefault();
                return Estado;
            }
        }
        public EstadoDeAlquileres BuscarEstadoID(int _id)
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                var Estado = Contexto.EstadoDeAlquileres.Where(s => s.EstadoID == _id).FirstOrDefault();
                return Estado;
            }
        }
    }
}
