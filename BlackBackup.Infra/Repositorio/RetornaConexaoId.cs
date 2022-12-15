using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;

namespace BlackBackup.Infra.Repositorio
{
    public class RetornaConexaoId : IRetornaConexaoId
    {
        private readonly DataSQLiteContext _context;
        public RetornaConexaoId(DataSQLiteContext context)
        {
            _context = context;
        }
        public Bucket RetornaBucket(int id)
        {
            var bucket = _context.Buckets.FirstOrDefault(x => x.Id == id);
            bucket.IdChaveAplicacao = Shared.CripInfo.Descriptografar(bucket.IdChaveAplicacao);
            bucket.ChaveAplicacao = Shared.CripInfo.Descriptografar(bucket.ChaveAplicacao);
            return bucket;
        }
    }
}
