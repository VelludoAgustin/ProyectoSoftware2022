using ProyectoSoftwareIndividual.Aplicacion.Servicios;
using ProyectoSoftwareIndividual.PedidoDeDatos;
using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.Controladores
{
    public class ControladorDeAlquiler
    {
        public void ControladorCrearAlquiler(string RoA)
        {
            List<string> datos = new CrearDatosAlquiler().ObtenerDatosAlquiler(RoA);
            Respuesta respuesta = new ServicioDeAlquilerYReserva().CrearAlquilerOReserva(datos);
            new ImprimirRespuesta().ImprimirLaRespuesta(respuesta);
        }
        public void ControladorListarReservas()
        {
            List<RetornoDeObjetos> lista = new ArmadoListaReservas().DevolverReservas();
            new ImprimirReservas().ImprimirReservasYLibro(lista);
        }
    }
}
