namespace ProyectoSoftwareIndividual.Menu
{
    public class OpcionesMenu
    {
        public void ImprimirMenu()
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Bienvenido al alquiler de libros, que desea realizar en este momento?");
            Console.WriteLine("1-Registrar nuevo Cliente");
            Console.WriteLine("2-Registrar nuevo Alquiler");
            Console.WriteLine("3-Registrar nueva Reserva");
            Console.WriteLine("4-Enlistar las reservas con el detalle de los libros");
            Console.WriteLine("5-Enlistar la información de los libros de aquellos que se tenga stock");
            Console.WriteLine("0-Para Salir Del Programa");
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }
}
