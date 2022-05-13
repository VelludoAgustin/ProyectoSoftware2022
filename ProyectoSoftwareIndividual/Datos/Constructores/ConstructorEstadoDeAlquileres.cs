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
                var estado1 = new EstadoDeAlquileres()
                {
                    Descripcion = "Reservado"
                };
                context.EstadoDeAlquileres.Add(estado1);

                var estado2 = new EstadoDeAlquileres()
                {
                    Descripcion = "Alquilado"
                };
                context.EstadoDeAlquileres.Add(estado2);

                var estado3 = new EstadoDeAlquileres()
                {
                    Descripcion = "Cancelado"
                };
                context.EstadoDeAlquileres.Add(estado3);

                context.SaveChanges();
            }
        }
    }
}