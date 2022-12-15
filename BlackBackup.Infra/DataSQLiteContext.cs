using BlackBackup.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BlackBackup.Infra
{
    public class DataSQLiteContext : DbContext
    {
        private readonly string _connect = $"Data Source={Application.StartupPath}\\Data\\Data.db";
        protected override void OnConfiguring(DbContextOptionsBuilder opts)
        {
            opts.UseLazyLoadingProxies().UseSqlite(_connect);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfiguracaoBucket());
            modelBuilder.Entity<Bucket>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
        }

        public DbSet<Bucket> Buckets { get; set; }

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
