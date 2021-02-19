using System;
using System.Threading.Tasks;

namespace calculoJurosAPI.Services
{
    public class CalcularJurosService
    {
        private TaxaJurosClientService _taxaJurosClientService;
        public CalcularJurosService(TaxaJurosClientService taxaJurosClientService) => _taxaJurosClientService = taxaJurosClientService;

        public async Task<decimal> CacularJurosCompostos(decimal valorInicial, int meses)
        {
            var taxaJuros = await _taxaJurosClientService.GetTaxaJuros();

            return (decimal)Math.Round((double)valorInicial * Math.Pow(1 + ((double)taxaJuros), meses), 2);
        }
    }
}
