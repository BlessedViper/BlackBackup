using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Conexoes
{
    public interface IExcluirConexao
    {
        void Excluir(Bucket bucket);
    }
}
