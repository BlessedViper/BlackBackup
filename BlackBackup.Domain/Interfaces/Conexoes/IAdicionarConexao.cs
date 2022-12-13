using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Conexoes
{
    public interface IAdicionaConexao
    {
        void Adicionar(Bucket bucket);
    }
}
