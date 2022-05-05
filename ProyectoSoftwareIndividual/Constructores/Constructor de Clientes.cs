using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Constructores
{
    public class Constructor_de_Clientes
    {
        public Cliente CreacionCliente(string _DNI, string _Nombre, string _Apellido, string _Email)
        {
            using (var context = new ProyectoSoftwareLibreriaContext())
            {
                var std1 = new Cliente()
                {
                    DNI = _DNI,
                    Nombre = _Nombre,
                    Apellido = _Apellido,
                    Email = _Email
                };
                context.cliente.Add(std1);

                context.SaveChanges();

                return std1;
            }
        }
    }
}
