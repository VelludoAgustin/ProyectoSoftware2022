using ProyectoSoftwareIndividual.Constructores;
using ProyectoSoftwareIndividual.Presentacion.Menu;
using ProyectoSoftwareIndividual.Validacion;

namespace ProyectoSoftwareIndividual.Aplicacion.Servicios
{
    public class ServicioDeCliente
    {
        public Respuesta CrearCliente(List<string> datos)
        {
            Respuesta valido = new ValidacionDeCliente().ValidacionCliente(datos[0], datos[1], datos[2], datos[3]);
            if (!valido.resultado)
                return valido;
            return valido = new ConstructorDeClientes().CreacionCliente(datos[0], datos[1], datos[2], datos[3]);
        }
    }
}
