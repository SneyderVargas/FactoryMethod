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
                var clientConnection = new ClientConnection();
                var concreteCreatorSQLiteConnection = new ConcreteCreatorSQLiteConnection();
                IDbConnection sqliteConect = clientConnection.Conection(concreteCreatorSQLiteConnection);
                sqliteConect.Open();



                return Ok("Operación exitosa");
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
