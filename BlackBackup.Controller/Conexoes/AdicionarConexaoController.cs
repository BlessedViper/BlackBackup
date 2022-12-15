using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;
using BlackBackup.Domain.Interfaces.Controller.Conexoes;
using BlackBackup.Infra.EFCoreSQLite;
using BlackBackup.Infra.Repository;

namespace BlackBackup.Controller.Conexoes
{
    public class AdicionarConexaoController : IAdicionarConexaoController
    {
        private IAdicionaConexao? PersistirConexao { get; set; }
        public void Adicionar(Bucket bucket)
        {
            using var context = new DataSQLiteContext();
            PersistirConexao = new AdicionarConexao(context);
            PersistirConexao.Adicionar(bucket);
        }
    }
}
