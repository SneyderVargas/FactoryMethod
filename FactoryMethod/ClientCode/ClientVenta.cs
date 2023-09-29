using FactoryMethod.CreatorFile;

namespace FactoryMethod.ClientCode
{
    public class ClientVenta
    {
        public void Client(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.calcular());
            // ...
        }
    }
}
