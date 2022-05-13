using ProyectoSoftwareIndividual.Contexto;
using ProyectoSoftwareIndividual.Presentacion.Menu;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Constructores
{
    public class ConstructorDeClientes
    {
        public Respuesta CreacionCliente(string _DNI, string _Nombre, string _Apellido, string _Email)
        {
            try
            {
                using (var context = new ProyectoSoftwareLibreriaContext())
                {
                    var cliente1 = new Cliente()
                    {
                        DNI = _DNI,
                        Nombre = _Nombre,
                        Apellido = _Apellido,
                        Email = _Email
                    };
                    context.cliente.Add(cliente1);
                    context.SaveChanges();
                    return new Respuesta(true, "Ingresado con exito en la base de datos");
                }
            }
            catch (Exception)
            {
                return new Respuesta(false, "Internal server error");
            }
        }
    }
}
