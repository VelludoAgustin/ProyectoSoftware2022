namespace ProyectoSoftwareIndividual.PedidoDeDatos
{
    public class CrearDatosCliente
    {
        public List<string> ObtenerDatosCliente()
        {
            List<string> listaAtributos = new List<string>();
            Console.Clear();
            Console.WriteLine("ingrese el DNI");
            listaAtributos.Add(Console.ReadLine());
            Console.WriteLine("ingrese el Nombre");
            listaAtributos.Add(Console.ReadLine());
            Console.WriteLine("ingrese el Apellido");
            listaAtributos.Add(Console.ReadLine());
            Console.WriteLine("ingrese el Email");
            listaAtributos.Add(Console.ReadLine());
            Console.Clear();
            return listaAtributos;
        }
    }
}
