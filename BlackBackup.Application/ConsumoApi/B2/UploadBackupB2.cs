using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.B2;
using RestSharp;
using System.Security.Cryptography;
using System.Text;

namespace BlackBackup.Application.ConsumoApi.B2
{
    public class UploadBackupB2 : IUploadBackupB2
    {
        public void UploadBackup(B2Response b2Response, string bucketId, string caminho, string Nomearquivo)
        {
            FileInfo info = new(caminho);

            byte[] bytes = File.ReadAllBytes(caminho);
            SHA1 sha1 = SHA1.Create();

            byte[] hash = sha1.ComputeHash(bytes, 0, (int)info.Length);

            StringBuilder sb = new StringBuilder();

            foreach (var b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            var sha1Str = sb.ToString();

            var client = new RestClient(b2Response.ApiUrl);
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("X-Bz-Content-Sha1", sha1Str);
            request.AddHeader("X-Bz-Server-Side-Encryption", "AES256");
            request.AddFile("X-Bz-File-Name", bytes, Nomearquivo, "text/plain");

            client.Execute(request);
        }
    }
}
