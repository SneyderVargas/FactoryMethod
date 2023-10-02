
using FactoryMethod.ClientCode;
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
        public IActionResult GetVenta([FromQuery] string producto)
        {
            try
            {
                var client = new ClientVenta();
                var burger = new ConcreteCreatorBusger();
                client.Client(burger);

                var client2 = new ClientVenta();
                var pizza = new ConcreteCreatorPizza();
                client2.Client(pizza);

                return Ok("Operación exitosa");
            }catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        

    }
}
