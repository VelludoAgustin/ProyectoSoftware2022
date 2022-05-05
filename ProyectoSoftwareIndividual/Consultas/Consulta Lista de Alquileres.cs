using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class Consulta_Lista_de_Alquileres
    {
        public List<Alquileres> ListarAlquileres()
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                List<Alquileres> lista = Contexto.Alquileres.ToList();
                return lista;
            }
        }
    }
}
