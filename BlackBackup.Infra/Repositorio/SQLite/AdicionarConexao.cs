using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;
using BlackBackup.Infra.EFCoreSQLite;

namespace BlackBackup.Infra.Repository
{
    public class AdicionarConexao : IAdicionaConexao
    {
        private readonly DataSQLiteContext _context;
        public AdicionarConexao(DataSQLiteContext context)
        {
            _context = context;
        }
        public void Adicionar(Bucket bucket)
        {
            if (bucket is not null)
            {
                bucket.IdChaveAplicacao = Shared.CripInfo.Criptografar(bucket.IdChaveAplicacao);
                bucket.ChaveAplicacao = Shared.CripInfo.Criptografar(bucket.ChaveAplicacao);
                _context.Add(bucket);
                _context.SaveChanges();
            }
        }
    }
}
