using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;
using BlackBackup.Domain.Interfaces.Controller.Conexoes;
using BlackBackup.Infra.EFCoreSQLite;
using BlackBackup.Infra.Repository;

namespace BlackBackup.Controller.Conexoes
{
    public class RetornaConexoesController : IRetornaConexoesController
    {
        public IRetornaConexoes? RetornaConexoesInfra { get; set; }
        public async Task<List<Bucket>> RetornaConexoes()
        {
            using var context = new DataSQLiteContext();
            RetornaConexoesInfra = new RetornaConexoes(context);
            return await RetornaConexoesInfra.RetornarConexoesAsync();
        }
    }
}
