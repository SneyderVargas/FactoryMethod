using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public abstract class Creator
    {
        public abstract IVentasRepo FactoryMethod();
        public (bool Succeeded, string Message) calcular()
        {
            var venta = FactoryMethod();
            return (true, "Se instancia correctamente en Creator: " + venta.calcular());
        }
    }
}
