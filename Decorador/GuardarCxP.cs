using System;

namespace Decorador
{
    public class GuardarCxP : IHerramientaCxP
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Se se guardado la cxp.");
        }
    }
}
