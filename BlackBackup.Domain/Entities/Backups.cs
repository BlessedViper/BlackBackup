namespace BlackBackup.Domain.Entities
{
    public class Backups
    {
        public Backups(int id, string nome, DateTime dataUpload)
        {
            Id = id;
            Nome = nome;
            DataUpload = dataUpload;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataUpload { get; set; }
    }
}
