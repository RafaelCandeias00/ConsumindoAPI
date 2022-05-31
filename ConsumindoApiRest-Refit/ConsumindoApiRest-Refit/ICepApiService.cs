using Refit;
using System.Threading.Tasks;

namespace ConsumindoApiRest_Refit
{
    interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
