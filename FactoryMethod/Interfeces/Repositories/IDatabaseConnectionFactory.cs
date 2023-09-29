using System.Data;

namespace FactoryMethod.Interfeces.Repositories
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
