using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Conexoes
{
    public interface IRetornaConexoes
    {
        Task<List<Bucket>> RetornarConexoesAsync();
    }
}
