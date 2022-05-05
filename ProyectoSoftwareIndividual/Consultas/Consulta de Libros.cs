using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class Consulta_de_Libros
    {
        public Libros BuscarLibroConISBN(string _ISBN)
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                var Libro = Contexto.Libros.Where(s => s.ISBN == _ISBN).FirstOrDefault();
                return Libro;
            }
        }
    }
}
