using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Consultas;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Validacion
{
    public class Validacion_de_Cliente
    {
        public bool ValidacionCliente(string _DNI, string _Nombre, string _Apellido, string _Email)
        {
            bool valid = true;
            try
            { 
                int DNIINT = int.Parse(_DNI);
                if (_DNI.Length>10 || 8>_DNI.Length)
                {
                    valid = false;
                }
                if (_Nombre=="" || _Apellido=="" || _Email=="")
                {
                    valid = false;
                }
                if (_Nombre.Length > 45 || _Apellido.Length > 45 || _Email.Length > 45)
                {
                    valid = false;
                }

                var Repetido = new Consulta_de_Cliente().BuscarClienteEnBaseDNI(_DNI);
                if (Repetido!=null)
                {
                    valid = false;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("uno de los datos es erroneo");
                valid = false;
            }

            return valid;
        }
    }
}
