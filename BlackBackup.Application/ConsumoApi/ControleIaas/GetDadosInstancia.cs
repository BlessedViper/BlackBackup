using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.ControleIaas;
using RestSharp;

namespace BlackBackup.Application.ConsumoApi.ControleIaas
{
    public class GetDadosInstancia : BaseUrlControleIaas, IGetDadosInstancia
    {
        public Instancia GetInstancia(int id)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest($"Instancias/{id}", Method.Get);

            var response = client.Execute<Instancia>(request).Data;

            return response;
        }
    }
}
