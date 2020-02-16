using System;

namespace Decorador
{
    public class EnviarCorreoUsuario : HerramientaBase
    {
        public EnviarCorreoUsuario(IHerramientaCxP herramientaCxP)
            : base(herramientaCxP)
        {
        }

        protected override void EjecutarAccionExtra()
        {
            Console.WriteLine("Se envia correo.");
        }
    }
}
