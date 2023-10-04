namespace FactoryMethod.Interfeces.Repositories
{
    public class PaymentFactory : IPaymentFactory
    {
        private string bankName;

        public PaymentFactory(string bankName)
        {
            this.bankName = bankName;
        }

        public void ProcessPayment(decimal amount)
        {
            // Lógica para procesar un pago con el banco especificado
            Console.WriteLine($"Procesando un pago de {amount:C} con {bankName}");
        }

        public void RefundPayment(decimal amount)
        {
            // Lógica para realizar una devolución con el banco especificado
            Console.WriteLine($"Realizando una devolución de {amount:C} con {bankName}");
        }
    }
}
