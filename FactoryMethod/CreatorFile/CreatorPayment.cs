using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public abstract class CreatorPayment
    {
        public abstract IPaymentFactory PaymentFactory();

        public void ProcessPayment(decimal amount)
        {
            var payment = PaymentFactory();
            payment.ProcessPayment(amount);
        }
        public void RefundPayment(decimal amount)
        {
            var payment = PaymentFactory();
            payment.RefundPayment(amount);

        }
    }
}
