using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Constructores;
using ProyectoSoftwareIndividual.Validacion;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class CrearDatosCliente
    {
        public Cliente ObtenerDatosCliente()
        {
            int Cancelar=0;
            bool valido=false;

            string _DNI = "";
            string _Nombre = "";
            string _Apellido="";
            string _Email = "";

            var validacion = new Validacion_de_Cliente();
            Cliente Cliente = new Cliente();

            while (Cancelar==0)
            {
                Console.Clear();
                Console.WriteLine("ingrese el DNI");
                _DNI = Console.ReadLine();
                Console.WriteLine("ingrese el Nombre");
                _Nombre = Console.ReadLine();
                Console.WriteLine("ingrese el Apellido");
                _Apellido = Console.ReadLine();
                Console.WriteLine("ingrese el Email");
                _Email = Console.ReadLine();

                valido = validacion.ValidacionCliente(_DNI, _Nombre, _Apellido, _Email);

                if(valido==true)
                {
                    Cliente = new Constructor_de_Clientes().CreacionCliente(_DNI, _Nombre, _Apellido, _Email);
                }

                Console.Clear();
                if (valido==false)
                {

                    Console.WriteLine("No se ha completado la creacion\n");
                    Console.WriteLine("si quiere volver a intentarlo escriba 0, si quiere salir escriba 1 \n");
                    try
                    {
                        Cancelar = int.Parse(Console.ReadLine());
                        while (Cancelar!=0 && Cancelar!=1)
                        {
                            Console.WriteLine("no se ha ingresado un valor correcto");
                            Cancelar = int.Parse(Console.ReadLine());
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("no se ha ingresado un valor correcto");
                    }
                    
                }
            }
            Console.Clear();
            return Cliente;
        }
    }
}
