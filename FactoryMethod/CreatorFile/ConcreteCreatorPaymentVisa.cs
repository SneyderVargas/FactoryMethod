using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public class ConcreteCreatorPaymentVisa : CreatorPayment
    {
        public override IPaymentFactory PaymentFactory()
        {
            return new PaymentFactory("Visa");
        }
    }
}
