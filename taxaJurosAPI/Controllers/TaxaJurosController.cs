using Microsoft.AspNetCore.Mvc;

namespace taxaJurosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        public decimal TaxaJuros()
        {
            return 0.01m;
        }
    }
}
