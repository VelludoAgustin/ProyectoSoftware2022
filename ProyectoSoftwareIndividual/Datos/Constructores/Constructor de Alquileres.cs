using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Constructores
{
    public class ConstructorDeAlquileres
    {
        public void CreacionAlquilerOReserva(Cliente clienteId, Libros isbnId, EstadoDeAlquileres estado)
        {
            using (var context = new ProyectoSoftwareLibreriaContext())
            {
                var std1 = new Alquileres()
                {
                    ClienteId = clienteId.ClienteID,
                    ISBNId = isbnId.ISBN,
                    EstadoId = estado.EstadoID //si es 2 es alquiler, si es 1 es reserva
                };
                context.Alquileres.Add(std1);

                isbnId.Stock--;
                context.Update<Libros>(isbnId);

                context.SaveChanges();
            }
        }
    }
}
