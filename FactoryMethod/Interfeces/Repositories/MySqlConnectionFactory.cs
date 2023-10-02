using MySql.Data.MySqlClient;
using System.Data;

namespace FactoryMethod.Interfeces.Repositories
{
    public class MySqlConnectionFactory : IDatabaseConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new MySqlConnection("Server=localhost; Port=3306; Database=db_proyect; Uid=root; Pwd=123456; persistsecurityinfo=True; SslMode=Required; Allow User Variables=True; Convert Zero Datetime=True; allow zero datetime=no");
        }
    }
}
