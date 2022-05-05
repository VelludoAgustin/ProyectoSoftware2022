using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual
{
    public class ConstructorEstadoDeAlquileres
    {
        public void InicializacionDeEstados()
        {
            using (var context = new ProyectoSoftwareLibreriaContext())
            {
                var std1 = new EstadoDeAlquileres()
                {
                    Descripcion = "Reservado"
                };
                context.EstadoDeAlquileres.Add(std1);

                var std2 = new EstadoDeAlquileres()
                {
                    Descripcion = "Alquilado"
                };
                context.EstadoDeAlquileres.Add(std2);

                var std3 = new EstadoDeAlquileres()
                {
                    Descripcion = "Cancelado"
                };
                context.EstadoDeAlquileres.Add(std3);

                context.SaveChanges();
            }
        }
    }
}