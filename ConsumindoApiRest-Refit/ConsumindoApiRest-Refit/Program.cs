using Refit;
using System;
using System.Threading.Tasks;

namespace ConsumindoApiRest_Refit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepCliente = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.Write("Informe seu cep: ");
                string cepInformado = Console.ReadLine().ToString();

                Console.WriteLine($"Consultando informações do CEP: {cepInformado}");

                var address = await cepCliente.GetAddressAsync(cepInformado);

                Console.Write($"\nLogradouro: {address.Logradouro} " +
                    $"\nBairro: {address.Bairro} " +
                    $"\nCidade: {address.Localidade}");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro na consulta de cep? {e.Message}");
            }
        }
    }
}
