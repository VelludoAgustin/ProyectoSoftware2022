using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.PedidoDeDatos;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Controladores
{
    public class Controlador_de_Libros
    {
        public void Controlador_ImprimirLibrosConStock()
        {
            new Imprimir_Libros_con_Stock().Imprimir();
        }
    }
}
