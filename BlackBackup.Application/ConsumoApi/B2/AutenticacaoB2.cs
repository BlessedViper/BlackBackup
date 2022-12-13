using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.B2;
using RestSharp;

namespace BlackBackup.Application.ConsumoApi.B2
{
    public class AutenticacaoB2 : IAutorizacaoB2
    {
        Uri baseUrl = new("https://api.backblazeb2.com/b2api/v2/");
        public B2Response Autorizacao(string credencial)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("b2_authorize_account", Method.Post);
            request.AddHeader("Authorization", $"Basic {credencial}");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            var response = client.Execute<B2Response>(request).Data;

            return response;
        }
    }
}
