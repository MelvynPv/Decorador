using System;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarCxP guardarCxP = new GuardarCxP();

            Console.WriteLine("Se guarda CxP");
            guardarCxP.EjecutarAccion();

            Console.WriteLine("Modificacion 1");
            GuardarHistorialCxp guardarHistorialCxp = new GuardarHistorialCxp(guardarCxP);
            guardarHistorialCxp.EjecutarAccion();

            Console.WriteLine("Modificacion 2");
            EnviarCorreoUsuario enviarCorreoUsuario = new EnviarCorreoUsuario(guardarCxP);
            enviarCorreoUsuario.EjecutarAccion();

            Console.WriteLine("Modificacion 3");
            enviarCorreoUsuario = new EnviarCorreoUsuario(guardarHistorialCxp);
            enviarCorreoUsuario.EjecutarAccion();

        }
    }
}
