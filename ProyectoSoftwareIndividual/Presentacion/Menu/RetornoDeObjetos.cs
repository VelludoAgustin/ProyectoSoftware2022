using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Presentacion.Menu
{
    public class RetornoDeObjetos
    {
        public Cliente? cliente;
        public Libros? libro;
        public EstadoDeAlquileres? estado;
        public Alquileres? alquileres;
        public Respuesta? respuesta;
        public void RestornoObjetos(Cliente resultado, Libros mensaje, EstadoDeAlquileres estadoDeAlquileres, Alquileres alquileres, Respuesta respuesta)
        {
            this.cliente = resultado;
            this.libro = mensaje;
            this.estado = estadoDeAlquileres;
            this.respuesta = respuesta;
            this.alquileres = alquileres;
        }
    }
}
