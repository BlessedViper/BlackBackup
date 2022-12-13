namespace BlackBackup.Domain.Entities
{
    public class Servidor
    {
        public Servidor(int id, string ip)
        {
            Id = id;
            Ip = ip;
        }
        public int Id { get; set; }
        public string Ip { get; set; }
    }
}
