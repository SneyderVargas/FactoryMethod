namespace FactoryMethod.Interfeces.Repositories
{
    public interface IPaymentFactory
    {
        void ProcessPayment(decimal amount);
        void RefundPayment(decimal amount);
    }
}
