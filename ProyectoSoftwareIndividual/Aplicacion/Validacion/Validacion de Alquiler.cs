using ProyectoSoftwareIndividual.Presentacion.Menu;

namespace ProyectoSoftwareIndividual.Validacion
{
    public class ValidacionDeAlquiler
    {
        public Respuesta ValidarAlquiler(string DNICliente, string ISBN)
        {
            Respuesta validar = new Respuesta(true, "Datos ingresados validados");
            try
            {
                int _DNI = int.Parse(DNICliente);
                if (DNICliente == null || DNICliente.Length > 10 || 8 > DNICliente.Length)
                {
                    validar.mensaje = "El DNI no puede ser nulo, menor a 8 digitos o mayor de 10 digitos";
                    validar.resultado = false;
                    return validar;
                }
            }
            catch (Exception)
            {
                validar.mensaje = "El DNI no puede contener caracteres no numericos o ser mayor a 10 digitos";
                validar.resultado = false;
                return validar;
            }
            try
            {
                if (DNICliente == null || ISBN.Length > 50)
                {
                    validar.mensaje = "El ISBN no puede ser nulo o mayor de 50 digitos";
                    validar.resultado = false;
                    return validar;
                }
            }
            catch (Exception)
            {
                validar.mensaje = "ocurrio un error con el ISBN";
                validar.resultado = false;
                return validar;
            }
            return validar;
        }
    }
}
