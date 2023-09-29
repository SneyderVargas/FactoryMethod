using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public abstract class Creator
    {
        public abstract IVentasRepo FactoryMethod();
        public string  calcular()
        {
            var venta = FactoryMethod();
            return ("Se instancia correctamente en Creator: " + venta.calcular());
        }
    }
}
