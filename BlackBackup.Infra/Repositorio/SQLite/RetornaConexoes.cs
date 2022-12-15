using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;
using BlackBackup.Infra.EFCoreSQLite;
using Microsoft.EntityFrameworkCore;

namespace BlackBackup.Infra.Repository
{
    public class RetornaConexoes : IRetornaConexoes
    {
        private readonly DataSQLiteContext _context;
        private List<Bucket> _buckets = new List<Bucket>();
        public RetornaConexoes(DataSQLiteContext context)
        {
            _context = context;
        }
        public async Task<List<Bucket>> RetornarConexoesAsync()
        {
            var buckets = await _context.Buckets.ToListAsync();
            foreach (var bucket in buckets)
            {
                bucket.IdChaveAplicacao = Shared.CripInfo.Descriptografar(bucket.IdChaveAplicacao);
                bucket.ChaveAplicacao = Shared.CripInfo.Descriptografar(bucket.ChaveAplicacao);
                _buckets.Add(bucket);
            }
            return _buckets;
        }
    }
}
