
using FactoryMethod.CreatorFile;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VentaController : Controller
    {
        
        [HttpPost]
        public async Task<IActionResult> GetVenta([FromQuery] string producto)
        {
            {
                Console.WriteLine();
            };
            try
            {
                return null;
            }catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.calcular());
            // ...
        }
    }
}
