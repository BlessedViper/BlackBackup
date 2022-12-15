using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Conexoes
{
    public interface IRetornaConexaoId
    {
        Bucket RetornaBucket(int id);
    }
}
