using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.B2;
using RestSharp;
using System.Text;

namespace BlackBackup.Application.ConsumoApi.B2
{
    public class GetBucketInfo : IBucketInfo
    {
        public Bucket GetInfo(Bucket bucket, B2Response response)
        {
            var client = new RestClient(response.ApiUrl);
            var request = new RestRequest("/b2api/v2/b2_list_buckets", Method.Post);
            string body = "{\"accountId\":\"" + bucket.IdChaveAplicacao + "\"; \"bucketName\":\"" + bucket.NomeBucket + "\"}";
            var data = Encoding.UTF8.GetBytes(body);
            request.AddHeader("Authorization", response.AuthorizationToken);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddHeader("Content-Length", data.Length);
            var responseAtual = client.Execute<Bucket>(request).Data;
            bucket.BucketId = responseAtual.BucketId;
            return bucket;
        }
    }
}
