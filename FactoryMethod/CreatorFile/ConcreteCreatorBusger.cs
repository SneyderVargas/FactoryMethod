using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public class ConcreteCreatorBusger : Creator
    {
        public override IVentasRepo FactoryMethod()
        {
            return new VentasBurgerRepo();
        }
    }
}
