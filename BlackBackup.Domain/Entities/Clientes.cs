namespace BlackBackup.Domain.Entities
{
    public class Clientes
    {
        public Clientes(int idInstancia, string nome)
        {
            IdInstancia = idInstancia;
            Nome = nome;
        }

        public int IdInstancia { get; private set; }
        public string Nome { get; private set; }
    }
}
