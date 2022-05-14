using ProyectoSoftwareIndividual.Aplicacion.Validacion;
using ProyectoSoftwareIndividual.Constructores;
using ProyectoSoftwareIndividual.Presentacion.Menu;
using ProyectoSoftwareIndividual.Validacion;


namespace ProyectoSoftwareIndividual.Aplicacion.Servicios
{
    public class ServicioDeAlquilerYReserva
    {
        public Respuesta CrearAlquilerOReserva(List<string> datos)
        {
            Respuesta validado = new ValidacionDeAlquiler().ValidarAlquiler(datos[0], datos[1]);
            if (!validado.resultado)
                return validado;
            RetornoDeObjetos retornoDeObjetos = new ValidarExistenciaDatosAlquileres().Validar(datos[0], datos[1], datos[2]);
            if (!retornoDeObjetos.respuesta.resultado)
                return retornoDeObjetos.respuesta;
            if (retornoDeObjetos.estado.Descripcion == "Reservado")//crea reserva
                return (validado = new ConstructorDeAlquileresYReservas().CreacionReserva(retornoDeObjetos.cliente, retornoDeObjetos.libro, retornoDeObjetos.estado, retornoDeObjetos.respuesta));
            else return (validado = new ConstructorDeAlquileresYReservas().CreacionAlquiler(retornoDeObjetos.cliente, retornoDeObjetos.libro, retornoDeObjetos.estado, retornoDeObjetos.respuesta));
        }
    }
}
