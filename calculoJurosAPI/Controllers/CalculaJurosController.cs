using calculoJurosAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace calculoJurosAPI.Controllers
{
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly CalcularJurosService _calcularJurosService;
        public CalculaJurosController(CalcularJurosService calcularJurosService) => _calcularJurosService = calcularJurosService;

        [Route("calculajuros")]
        [HttpGet]
        public async Task<decimal> CalculaJuros(decimal valorInicial, int meses)
        {
            return await _calcularJurosService.CacularJurosCompostos(valorInicial, meses);
        }

        [Route("showmethecode")]
        [HttpGet]
        public string ShowMeTheCode()
        {
            return "https://github.com/guilhermefrancisco/calculoJurosAPI";
        }

    }
}
