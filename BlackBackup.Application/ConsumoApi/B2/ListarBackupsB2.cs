using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.B2;
using RestSharp;
using System.Text;

namespace BlackBackup.Application.ConsumoApi.B2
{
    public class ListarBackupsB2 : IListaBackupsB2
    {
        public List<Backups> Listar<Backups>(B2Response responseB2, string bucketId)
        {
            var body = Encoding.UTF8.GetBytes("{\"bucketId\":\"" + bucketId + "\"}");

            var client = new RestClient(responseB2.ApiUrl);

            var request = new RestRequest("/b2api/v2/b2_list_file_names", Method.Post);

            request.AddHeader("Authorization", responseB2.AuthorizationToken);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddHeader("Content-Length", body.Length);

            return client.Execute<List<Backups>>(request).Data;
        }
    }
}
