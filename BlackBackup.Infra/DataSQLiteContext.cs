using BlackBackup.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BlackBackup.Infra
{
    public class DataSQLiteContext : DbContext
    {
        private readonly string _connect = $@"{Application.StartupPath}\Data.db; Version=3;";
        protected override void OnConfiguring(DbContextOptionsBuilder opts)
        {
            opts.UseSqlite(_connect);
        }
        public DbSet<Bucket>? Buckets { get; set; }

        public void DeatchAllEntities()
        {
            var changedEntrieCopy = this.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();
            foreach (var entry in changedEntrieCopy)
                entry.State = EntityState.Detached;
        }
    }
}
