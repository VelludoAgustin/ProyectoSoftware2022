using ProyectoSoftwareIndividual.Consultas;
using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.Aplicacion.Validacion
{
    public class ValidarExistenciaDatosAlquileres
    {
        public RetornoDeObjetos Validar(string dni, string isbn, string estado)
        {
            RetornoDeObjetos retornoDeObjetos = new RetornoDeObjetos();
            Respuesta validar = new Respuesta(true, "");
            var clienteEncontrado = new ConsultaDeCliente().BuscarClienteEnBaseDNI(dni);
            if (clienteEncontrado == null)
            {
                validar.mensaje = "El DNI no se encontro en la base de datos";
                validar.resultado = false;
                retornoDeObjetos.respuesta = validar;
                return retornoDeObjetos;
            }
            var libroEncontrado = new ConsultaDeLibros().BuscarLibroConISBN(isbn);
            if (libroEncontrado == null)
            {
                validar.mensaje = "el ISBN no se encontro en la base de datos";
                validar.resultado = false;
                retornoDeObjetos.respuesta = validar;
                return retornoDeObjetos;
            }
            if (libroEncontrado.Stock == null || libroEncontrado.Stock <= 0)
            {
                validar.mensaje = "El libro se encuentra en la base, pero no se cuenta con stock";
                validar.resultado = false;
                retornoDeObjetos.respuesta = validar;
                return retornoDeObjetos;
            }
            var estadoEncontrado = new ConsultaDeEstado().BuscarEstado(estado);

            validar.mensaje = ("Cliente encontrado: " + clienteEncontrado.Nombre + " " + clienteEncontrado.Apellido + "\n" +
                                "ISBN encontrado: " + libroEncontrado.ISBN + "   Titulo: " + libroEncontrado.Titulo + "    Stock: " + libroEncontrado.Stock);
            retornoDeObjetos.estado = estadoEncontrado;
            retornoDeObjetos.cliente = clienteEncontrado;
            retornoDeObjetos.libro = libroEncontrado;
            retornoDeObjetos.respuesta = validar;
            return retornoDeObjetos;
        }
    }
}
