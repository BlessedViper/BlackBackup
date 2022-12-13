using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Controller.Conexoes
{
    public interface IRetornaConexoesController
    {
        Task<List<Bucket>> RetornaConexoes();
    }
}
