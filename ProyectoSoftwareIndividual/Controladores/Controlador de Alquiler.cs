using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.PedidoDeDatos;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Controladores
{
    public class Controlador_de_Alquiler
    {
        public void Controlador_CrearAlquiler(string RoA)
        {
             new CrearDatosAlquiler().ObtenerDatosAlquiler(RoA);
        }
        public void Controlador_ListarReservas()
        {
            new Imprimir_Reservas().Imprimir_ReservasYLibro();
        }
    }
}
