using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace calculoJurosAPI.Services
{
    public class TaxaJurosClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public TaxaJurosClientService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        public async Task<decimal> GetTaxaJuros()
        {
            var client = _httpClientFactory.CreateClient();

            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var resposta = await client.GetAsync("api/taxajuros");

            if (resposta.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<decimal>(await resposta.Content.ReadAsStreamAsync());
            }

            throw new Exception(resposta.RequestMessage.ToString());

        }

    }
}
