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
    public class CrearDatosAlquiler
    {
        public void ObtenerDatosAlquiler(string RoA)
        {
            bool Validado=false;

            Console.WriteLine("Ingrese DNI del Cliente");
            string DNICliente = Console.ReadLine();
            Console.Clear();

            List <Libros> libros = new Consulta_Lista_de_Libros().ListarLibros();
            foreach (Libros libro in libros)
            {
                Console.WriteLine("ISBN: "+libro.ISBN+"   /Titulo: "+libro.Titulo);
            }
            Console.WriteLine("Ingrese ISBN del Libro");
            string ISBNLibro = Console.ReadLine();
            Console.Clear();


            Validado = new Validacion_de_Alquiler().ValidarAlquiler(DNICliente, ISBNLibro);

            if (Validado == true)
            {
                var ClienteEncontrado = new Consulta_de_Cliente().BuscarClienteEnBaseDNI(DNICliente);
                if (ClienteEncontrado == null)
                {
                    Validado = false;
                    Console.WriteLine("no se encontro el DNI en la base");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Cliente encontrado: " + ClienteEncontrado.Nombre + " " + ClienteEncontrado.Apellido);
                    Console.ReadKey();
                }

                var LibroEncontrado = new Consulta_de_Libros().BuscarLibroConISBN(ISBNLibro);
                if (LibroEncontrado == null)
                {
                    Validado = false;
                    Console.WriteLine("no se encontro el ISBN en la base");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("ISBN encontrado: " + LibroEncontrado.ISBN + "   Titulo: " + LibroEncontrado.Titulo);
                    Console.ReadKey();
                }

                if(LibroEncontrado.Stock==null)
                {
                    Console.WriteLine("No se tiene Stock del libro");
                    Console.ReadKey();
                    Validado = false;
                    return;
                }
                if(LibroEncontrado.Stock<=0)
                {
                    Console.WriteLine("No se tiene Stock del libro");
                    Console.ReadKey();
                    Validado = false;
                    return;
                }

                if(Validado==true)
                {
                    var Estado = new Consulta_de_Estado().BuscarEstado(RoA);
                    new Constructor_de_Alquileres().CreacionAlquilerOReserva(ClienteEncontrado, LibroEncontrado, Estado);
                }
            }
            else
            {
                Console.WriteLine("No se completo el Alquiler o Reserva");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }
    }
}
