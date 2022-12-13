using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;

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
                _context.Add(bucket);
                _context.SaveChanges();
            }
        }
    }
}
