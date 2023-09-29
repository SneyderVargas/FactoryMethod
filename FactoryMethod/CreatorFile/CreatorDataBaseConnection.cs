using FactoryMethod.Interfeces.Repositories;
using System.Data;

namespace FactoryMethod.CreatorFile
{
    public abstract class CreatorDataBaseConnection
    {
        public abstract IDatabaseConnectionFactory FactoryMethod();

        public IDbConnection CreateConnection()
        {
            var conect = FactoryMethod();
            return conect.CreateConnection();
        }
    }
}
