using System;

namespace Decorador
{
    public class GuardarHistorialCxp : HerramientaBase
    {
        public GuardarHistorialCxp(IHerramientaCxP herramientaCxP)
            : base(herramientaCxP)
        {
        }

        protected override void EjecutarAccionExtra()
        {
            Console.WriteLine("Se guarda el  historial de la cxp.");
        }
    }
}
