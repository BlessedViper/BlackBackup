namespace BlackBackup.Domain.Entities
{
    public class Instancia
    {
        public Instancia(int id, int idServer, string instance, string banco, string usuario, string senha)
        {
            Id = id;
            IdServer = idServer;
            Instance = instance;
            Banco = banco;
            Usuario = usuario;
            Senha = senha;
        }

        public int Id { get; set; }
        public int IdServer { get; set; }
        public string Instance { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
