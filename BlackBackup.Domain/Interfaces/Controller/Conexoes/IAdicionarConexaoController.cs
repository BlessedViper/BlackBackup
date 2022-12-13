using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Controller.Conexoes
{
    public interface IAdicionarConexaoController
    {
        void Adicionar(Bucket bucket);
    }
}
