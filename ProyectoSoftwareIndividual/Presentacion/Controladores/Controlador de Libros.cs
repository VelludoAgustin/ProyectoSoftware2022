using ProyectoSoftwareIndividual.PedidoDeDatos;

namespace ProyectoSoftwareIndividual.Controladores
{
    public class ControladorDeLibros
    {
        public void ControladorImprimirLibrosConStock()
        {
            new ImprimirLibrosConStock().Imprimir();
        }
    }
}
