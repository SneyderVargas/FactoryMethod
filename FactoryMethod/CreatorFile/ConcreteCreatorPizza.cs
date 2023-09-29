using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public class ConcreteCreatorPizza : Creator
    {
        public override IVentasRepo FactoryMethod()
        {
            return new VentasPizzaRepo();
        }
    }
}
