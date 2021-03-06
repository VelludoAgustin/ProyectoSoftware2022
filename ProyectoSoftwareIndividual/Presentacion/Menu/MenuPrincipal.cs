using ProyectoSoftwareIndividual.Constructores;
using ProyectoSoftwareIndividual.Consultas;
using ProyectoSoftwareIndividual.Controladores;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Menu
{
    public class MenuPrincipal
    {
        public void Menu()
        {
            List<EstadoDeAlquileres> ContadorEstados = new ConsultaListaDeEstados().ListarEstados();
            List<Libros> ContadorLibros = new ConsultaListaDeLibros().ListarLibros();
            if (ContadorEstados.Count == 0)
            {
                new ConstructorEstadoDeAlquileres().InicializacionDeEstados();
            }
            if (ContadorLibros.Count == 0)
            {
                new ConstructorDeLibro().InicializacionDeLibros();
            }

            int opcion = -1;
            while (opcion != 0)
            {
                try
                {
                    while (opcion != 0)
                    {
                        new OpcionesMenu().ImprimirMenu();
                        Console.WriteLine("Ingrese la opcion deseada");
                        opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1://Registrar nuevo Cliente
                                Console.Clear();
                                var opcion1 = new ControladorDeCliente();
                                opcion1.ControladorCrearCliente();
                                Console.Clear();
                                break;
                            case 2://Registrar nuevo Alquiler
                                Console.Clear();
                                var opcion2 = new ControladorDeAlquiler();
                                opcion2.ControladorCrearAlquiler("Alquilado");//2=alquiler
                                Console.Clear();
                                break;
                            case 3://Registrar nuevo Reserva
                                Console.Clear();
                                var opcion3 = new ControladorDeAlquiler();
                                opcion3.ControladorCrearAlquiler("Reservado");
                                Console.Clear();
                                break;
                            case 4://Enlistar las reservas con el detalle de los libros
                                Console.Clear();
                                var opcion4 = new ControladorDeAlquiler();
                                opcion4.ControladorListarReservas();
                                Console.Clear();
                                break;
                            case 5://Enlistar la información de los libros de aquellos que se tenga stock
                                Console.Clear();
                                var opcion5 = new ControladorDeLibros();
                                opcion5.ControladorImprimirLibrosConStock();
                                Console.Clear();
                                break;
                        }
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("No se ha introducido un numero correcto");
                    Console.ReadKey();
                }
            }
        }
    }
}
