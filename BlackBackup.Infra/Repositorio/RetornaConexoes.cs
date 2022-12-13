using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;
using Microsoft.EntityFrameworkCore;

namespace BlackBackup.Infra.Repository
{
    public class RetornaConexoes : IRetornaConexoes
    {
        private readonly DataSQLiteContext _context;
        public RetornaConexoes(DataSQLiteContext context)
        {
            _context = context;
        }
        public async Task<List<Bucket>> RetornarConexoes()
        {
            return await _context.Buckets.ToListAsync();
        }
    }
}
