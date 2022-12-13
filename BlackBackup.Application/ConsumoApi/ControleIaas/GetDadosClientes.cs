using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.ControleIaas;
using RestSharp;

namespace BlackBackup.Application.ConsumoApi.ControleIaas
{
    public class GetDadosClientes : BaseUrlControleIaas, IGetDadosClientes
    {
        public List<Clientes> GetClientes()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("Clientes", Method.Get);

            var response = client.Execute<List<Clientes>>(request).Data;

            return response;
        }
    }
}
