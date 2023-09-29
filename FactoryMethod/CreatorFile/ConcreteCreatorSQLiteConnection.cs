using FactoryMethod.Interfeces.Repositories;

namespace FactoryMethod.CreatorFile
{
    public class ConcreteCreatorSQLiteConnection : CreatorDataBaseConnection
    {
        public override IDatabaseConnectionFactory FactoryMethod()
        {
            return new SQLiteConnectionFactory();
        }
    }
}
