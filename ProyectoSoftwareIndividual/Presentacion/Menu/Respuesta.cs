namespace ProyectoSoftwareIndividual.Presentacion.Menu
{
    public class Respuesta
    {
        public bool resultado;
        public string? mensaje;
        public Respuesta(bool resultadoParametro, string mensajeParametro)
        {
            this.resultado = resultadoParametro;
            this.mensaje = mensajeParametro;
        }
    }
}
