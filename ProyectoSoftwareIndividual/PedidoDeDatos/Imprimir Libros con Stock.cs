using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Constructores;
using ProyectoSoftwareIndividual.Validacion;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;
using ProyectoSoftwareIndividual.Consultas;

namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class Imprimir_Libros_con_Stock
    {
        public void Imprimir()
        {
            var listaLibros = new Consulta_Lista_de_Libros().ListarLibros();
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
