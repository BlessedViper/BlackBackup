using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.B2;
using RestSharp;
using System.Text;

namespace BlackBackup.Application.ConsumoApi.B2
{
    public class AutorizacaoUploadB2 : IAutorizacaoUploadB2
    {
        public B2Response UploadB2Async(B2Response b2Response, string bucketId)
        {
            var body = Encoding.UTF8.GetBytes("{\"bucketId\":\"" + bucketId + "\"}");

            var client = new RestClient(b2Response.ApiUrl);

            var request = new RestRequest("/b2api/v2/b2_list_file_names", Method.Post);

            request.AddHeader("Authorization", b2Response.AuthorizationToken);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddHeader("Content-Length", body.Length);

            return client.Execute<B2Response>(request).Data;
        }
    }
}
