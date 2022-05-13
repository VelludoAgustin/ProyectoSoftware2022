using ProyectoSoftwareIndividual.PedidoDeDatos;

namespace ProyectoSoftwareIndividual.Controladores
{
    public class Controlador_de_Libros
    {
        public void Controlador_ImprimirLibrosConStock()
        {
            new Imprimir_Libros_con_Stock().Imprimir();
        }
    }
}
