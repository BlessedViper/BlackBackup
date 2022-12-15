using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlackBackup.Domain.Entities
{
    public class Bucket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string IdChaveAplicacao { get; set; }
        public string ChaveAplicacao { get; set; }
        [NotMapped]
        public string? Credencial { get; set; }
        [JsonPropertyName("BucketName")]
        public string? NomeBucket { get; set; }
        [JsonPropertyName("BucketId")]
        public string? BucketId { get; set; }
        public string? Apelido { get; set; }
    }
}
