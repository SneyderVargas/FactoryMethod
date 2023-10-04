using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PaymentController : Controller
    {
        [HttpPost]
        public IActionResult Paiment([FromQuery] string producto)
        {
            try
            {
                return Ok("Operación exitosa");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
