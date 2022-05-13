using ProyectoSoftwareIndividual.Consultas;
using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.Validacion
{
    public class ValidacionDeCliente
    {
        public Respuesta ValidacionCliente(string dni, string nombre, string apellido, string email)
        {
            Respuesta respuesta = new Respuesta(true, "Se validaron los datos correctamente");
            try
            {
                int dniint = int.Parse(dni);
                if (dni.Length > 10 || 8 > dni.Length)
                {
                    respuesta.mensaje = "El DNI no puede ser menor a 8 digitos o mayor de 10 digitos";
                    respuesta.resultado = false;
                    return respuesta;
                }
                if (nombre == "" || nombre.Length > 45 || nombre == null)
                {
                    respuesta.mensaje = "El Nombre no puede ser nulo, vacio o mayor a 45 digitos";
                    respuesta.resultado = false;
                    return respuesta;
                }
                if (apellido == null || apellido.Length > 45 || apellido == "")
                {
                    respuesta.mensaje = "El Apellido no puede ser nulo, vacio o mayor a 45 digitos";
                    respuesta.resultado = false;
                    return respuesta;
                }
                if (email == "" || email.Length > 45 || email == null)
                {
                    respuesta.mensaje = "El Email no puede ser nulo, vacio o mayor a 45 digitos";
                    respuesta.resultado = false;
                    return respuesta;
                }
                var repetido = new ConsultaDeCliente().BuscarClienteEnBaseDNI(dni);
                if (repetido != null)
                {
                    respuesta.mensaje = "El DNI ya se encuentra en la base de datos";
                    respuesta.resultado = false;
                    return respuesta;
                }
            }
            catch (Exception)
            {
                respuesta.mensaje = "El DNI es demaciado largo o contiene un caracter no numerico";
                respuesta.resultado = false;
            }
            return respuesta;
        }
    }
}
