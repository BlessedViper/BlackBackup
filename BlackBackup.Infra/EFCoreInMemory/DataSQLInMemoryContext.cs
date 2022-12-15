using BlackBackup.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlackBackup.Infra.EFCoreInMemory
{
    public class DataSQLInMemoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opts)
        {
            opts.UseInMemoryDatabase("BlackBackup");
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Backups> Backups { get; set; }
    }
}
