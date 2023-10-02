using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public class ConcreteCreatorMySqlConnection : CreatorDataBaseConnection
    {
        public override IDatabaseConnectionFactory FactoryMethod()
        {
            return new MySqlConnectionFactory();
        }
    }
}
