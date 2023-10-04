using FactoryMethod.CreatorFile;

namespace FactoryMethod.ClientCode
{
    public class ClientPayment
    {
        public void ProcessPayment(CreatorPayment creatorPayment, decimal amount)
        {
            creatorPayment.ProcessPayment(amount);
        }
        public void RefundPayment(CreatorPayment creatorPayment, decimal amount)
        {
            creatorPayment.RefundPayment(amount);
        }
    }
}
