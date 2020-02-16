namespace Decorador
{
    public abstract class HerramientaBase : IHerramientaCxP
    {
        private readonly IHerramientaCxP herramientaCxP;

        protected HerramientaBase(IHerramientaCxP herramientaCxP) 
        {
            this.herramientaCxP = herramientaCxP;
        }

        public void EjecutarAccion() 
        {
            herramientaCxP.EjecutarAccion();
            EjecutarAccionExtra();
        }

        protected abstract void EjecutarAccionExtra();
    }
}
