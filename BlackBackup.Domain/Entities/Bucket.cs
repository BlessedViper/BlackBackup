using System.Text;
using System.Text.Json.Serialization;

namespace BlackBackup.Domain.Entities
{
    public class Bucket
    {
        public Bucket(string applicationKeyId, string applicationKey)
        {
            IdChaveAplicacao = applicationKeyId;
            ChaveAplicacao = applicationKey;
            Credencial = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{applicationKeyId}:{applicationKey}"));
        }
        public int Id { get; private set; }
        public string IdChaveAplicacao { get; private set; }
        public string ChaveAplicacao { get; private set; }
        public string Credencial { get; private set; }
        [JsonPropertyName("BucketName")]
        public string NomeBucket { get; private set; }
        [JsonPropertyName("BucketId")]
        public string BucketId { get; set; }
        public string? Apelido { get; set; }
    }
}
