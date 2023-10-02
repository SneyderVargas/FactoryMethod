using FactoryMethod.ClientCode;
using FactoryMethod.CreatorFile;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FactoryMethod.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DataBaseConnectionController : Controller
    {
        [HttpPost]
        public IActionResult Connection([FromQuery] string db) {
            try
            {
                // Sqlite
                var clientConnectionSqlite = new ClientConnection();
                var concreteCreatorSQLiteConnection = new ConcreteCreatorSQLiteConnection();
                IDbConnection sqliteConnect = clientConnectionSqlite.Conection(concreteCreatorSQLiteConnection);

                sqliteConnect.Open();
                sqliteConnect.Close();
                // MySql
                var clientConnectionMySql = new ClientConnection();
                var concreteCreatorMysqlConnection = new ConcreteCreatorMySqlConnection();
                IDbConnection mySqlConnect = clientConnectionMySql.Conection(concreteCreatorMysqlConnection);

                mySqlConnect.Open();
                mySqlConnect.Close();





                return Ok("Operación exitosa");
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
