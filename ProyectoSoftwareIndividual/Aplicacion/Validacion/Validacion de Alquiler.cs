namespace ProyectoSoftwareIndividual.Validacion
{
    public class Validacion_de_Alquiler
    {
        public bool ValidarAlquiler(string DNICliente, string ISBN)
        {
            bool validar = true;

            //valida cliente
            try
            {
                int _DNI = int.Parse(DNICliente);

                if (DNICliente == null || DNICliente.Length > 10 || 8 > DNICliente.Length)
                {
                    Console.WriteLine("no se ingreso un DNI correcto");
                    validar = false;
                    return validar;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("no se ingreso un DNI correcto");
                validar = false;
                return validar;
            }
            //valida ISBN
            try
            {
                if (DNICliente == null || ISBN.Length > 50)
                {
                    Console.WriteLine("ISBN demaciado largo o vacio");
                    validar = false;
                    return validar;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("no se ingreso un ISBN correcto");
                validar = false;
                return validar;
            }

            return validar;
        }
    }
}
