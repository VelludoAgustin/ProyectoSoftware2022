using ProyectoSoftwareIndividual.Aplicacion.Servicios;
using ProyectoSoftwareIndividual.PedidoDeDatos;
using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.Controladores
{
    public class ControladorDeCliente
    {
        public void ControladorCrearCliente()
        {
            List<string> datos = new CrearDatosCliente().ObtenerDatosCliente();
            Respuesta respuesta = new ServicioDeCliente().CrearCliente(datos);
            new ImprimirRespuesta().ImprimirLaRespuesta(respuesta);
        }
    }
}
