using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;
using BlackBackup.Infra.EFCoreSQLite;
using Microsoft.EntityFrameworkCore;

namespace BlackBackup.Infra.Repository
{
    public class EditarConexao : IEditarConexao
    {
        private DataSQLiteContext _context;
        public EditarConexao(DataSQLiteContext context)
        {
            _context = context;
        }
        public void Editar(Bucket bucket)
        {
            bucket.IdChaveAplicacao = Shared.CripInfo.Criptografar(bucket.IdChaveAplicacao);
            bucket.ChaveAplicacao = Shared.CripInfo.Criptografar(bucket.ChaveAplicacao);
            _context.Entry(bucket).State = EntityState.Modified;
            _context.SaveChanges();
            _context.DeatchAllEntities();
        }
    }
}
