using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.PedidoDeDatos;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Controladores
{
    public class Controlador_de_Cliente
    {
        public void Controlador_CrearCliente()
        {
            var Cliente =new CrearDatosCliente().ObtenerDatosCliente();
        }
    }
}
