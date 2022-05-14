using ProyectoSoftwareIndividual.Consultas;
using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.Aplicacion.Servicios
{
    public class ArmadoListaReservas
    {
        public List<RetornoDeObjetos> DevolverReservas()
        {
            List<RetornoDeObjetos> listaRetorno = new List<RetornoDeObjetos>();
            var listaAlquileres = new ConsultaListaDeAlquileres().ListarAlquileres();
            foreach (var alquileres in listaAlquileres)
            {
                RetornoDeObjetos objetos = new RetornoDeObjetos();
                objetos.estado = new ConsultaDeEstado().BuscarEstadoID(alquileres.EstadoId);
                if (objetos.estado.Descripcion == "Reservado")
                {
                    objetos.alquileres = alquileres;
                    objetos.cliente = new ConsultaDeCliente().BuscarClienteEnBaseId(alquileres.ClienteId);
                    objetos.libro = new ConsultaDeLibros().BuscarLibroConISBN(alquileres.ISBNId);

                    listaRetorno.Add(objetos);
                }
            }
            return listaRetorno;
        }
    }
}
