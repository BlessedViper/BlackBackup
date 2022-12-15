using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Controller.Conexoes
{
    public interface IRetornaConexaoIdController
    {
        Bucket RetornaConexaoId(int id);
    }
}
