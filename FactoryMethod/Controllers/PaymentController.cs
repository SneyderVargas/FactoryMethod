using FactoryMethod.ClientCode;
using FactoryMethod.CreatorFile;
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
                // payment visa
                var clientPaymentVisa = new ClientPayment();
                var concreteCreatorPaymentVisa = new ConcreteCreatorPaymentVisa();
                clientPaymentVisa.ProcessPayment(concreteCreatorPaymentVisa,100);
                clientPaymentVisa.RefundPayment(concreteCreatorPaymentVisa, 10);

                return Ok("Operación exitosa");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
