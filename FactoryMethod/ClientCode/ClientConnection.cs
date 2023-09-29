using FactoryMethod.CreatorFile;
using System.Data;

namespace FactoryMethod.ClientCode
{
    public class ClientConnection
    {
        public IDbConnection Conection(CreatorDataBaseConnection creatorDataBaseConnection)
        {
            return creatorDataBaseConnection.CreateConnection();
        }
    }
}
