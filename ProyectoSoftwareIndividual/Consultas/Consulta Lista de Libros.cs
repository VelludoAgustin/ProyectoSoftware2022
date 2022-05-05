using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual.Contexto;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Consultas
{
    public class Consulta_Lista_de_Libros
    {
        public List<Libros> ListarLibros()
        {
            using (var Contexto = new ProyectoSoftwareLibreriaContext())
            {
                List<Libros> lista = Contexto.Libros.ToList();
                return lista;

                //var ListaLibros = (List<Libros>)Contexto.Libros.Select(s => new { s.ISBN, s.Titulo, s.Autor, s.Editorial, s.Edicion, s.Stock, s.Imagen});
                //return ListaLibros;
            }
        }
    }
}
