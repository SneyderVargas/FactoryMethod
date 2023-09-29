using Microsoft.Data.Sqlite;
using System.Data;

namespace FactoryMethod.Interfeces.Repositories
{
    public class SQLiteConnectionFactory : IDatabaseConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqliteConnection("Data Source=prueba.db");
        }
    }
}
