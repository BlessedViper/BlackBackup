using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Controller.Conexoes
{
    public interface IExcluirConexaoController
    {
        void ExcluirConexao(Bucket bucket);
    }
}
