namespace ProyectoSoftwareIndividual.Presentacion.Menu
{
    public class ImprimirRespuesta
    {
        public void ImprimirLaRespuesta(Respuesta respuesta)
        {
            Console.WriteLine(respuesta.mensaje);
            Console.ReadKey();
        }
    }
}
