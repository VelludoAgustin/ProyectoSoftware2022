using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Constructores
{
    public class Constructor_de_Alquileres
    {
        public void CreacionAlquilerOReserva(Cliente _ClienteId, Libros _ISBNId, EstadoDeAlquileres _Estado)
        {
            using (var context = new ProyectoSoftwareLibreriaContext())
            {
                var std1 = new Alquileres()
                {
                   ClienteId = _ClienteId.ClienteID,
                   ISBNId = _ISBNId.ISBN,
                   EstadoId = _Estado.EstadoID //si es 2 es alquiler, si es 1 es reserva
                };
                context.Alquileres.Add(std1);

                _ISBNId.Stock--;
                context.Update<Libros>(_ISBNId);

                context.SaveChanges();
            }
        }
    }
}
