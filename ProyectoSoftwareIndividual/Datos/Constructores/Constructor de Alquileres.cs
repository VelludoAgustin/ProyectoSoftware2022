using ProyectoSoftwareIndividual.Contexto;
using ProyectoSoftwareIndividual.Presentacion.Menu;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Constructores
{
    public class ConstructorDeAlquileresYReservas
    {
        public Respuesta CreacionReserva(Cliente clienteId, Libros isbnId, EstadoDeAlquileres estado, Respuesta respuesta)
        {
            try
            {
                using (var context = new ProyectoSoftwareLibreriaContext())
                {
                    var std1 = new Alquileres()
                    {
                        ClienteId = clienteId.ClienteID,
                        ISBNId = isbnId.ISBN,
                        EstadoId = estado.EstadoID, //si es 2 es alquiler, si es 1 es reserva
                        FechaReserva = DateTime.Now,
                    };
                    context.Alquileres.Add(std1);

                    isbnId.Stock--;
                    context.Update<Libros>(isbnId);

                    context.SaveChanges();
                    return new Respuesta(true, "Reserva creada correctamente");
                }
            }
            catch (Exception)
            {
                return new Respuesta(false, "Internal Server Error");
            }
        }
        public Respuesta CreacionAlquiler(Cliente clienteId, Libros isbnId, EstadoDeAlquileres estado, Respuesta respuesta)
        {
            try
            {
                using (var context = new ProyectoSoftwareLibreriaContext())
                {
                    var std1 = new Alquileres()
                    {
                        ClienteId = clienteId.ClienteID,
                        ISBNId = isbnId.ISBN,
                        EstadoId = estado.EstadoID, //si es 2 es alquiler, si es 1 es reserva
                        FechaAlquiler = DateTime.Now,
                        FechaDevolucion = DateTime.Now.AddDays(7)
                    };
                    context.Alquileres.Add(std1);

                    isbnId.Stock--;
                    context.Update<Libros>(isbnId);

                    context.SaveChanges();
                    return new Respuesta(true, respuesta.mensaje + "\n" + "alquiler creado correctamente");
                }
            }
            catch (Exception)
            {
                return new Respuesta(false, "Internal Server Error");
            }
        }
    }
}
