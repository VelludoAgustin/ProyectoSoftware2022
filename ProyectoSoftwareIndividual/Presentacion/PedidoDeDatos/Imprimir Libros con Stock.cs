using ProyectoSoftwareIndividual.Consultas;

namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class ImprimirLibrosConStock
    {
        public void Imprimir()
        {
            var listaLibros = new ConsultaListaDeLibros().ListarLibros();
            foreach (var Libro in listaLibros)
            {
                if (Libro.Stock > 0)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.WriteLine("ISBN: " + Libro.ISBN);
                    Console.WriteLine("Titulo: " + Libro.Titulo);
                    Console.WriteLine("Autor: " + Libro.Autor);
                    Console.WriteLine("Editorial: " + Libro.Editorial);
                    Console.WriteLine("Edicion: " + Libro.Editorial);
                    Console.WriteLine("Stock: " + Libro.Stock);
                    Console.WriteLine("Imagen: " + Libro.Imagen);
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
