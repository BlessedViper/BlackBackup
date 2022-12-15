using BlackBackup.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlackBackup.Infra.EFCoreSQLite.Configuracao
{
    public class ConfiguracaoBucket : IEntityTypeConfiguration<Bucket>
    {
        public void Configure(EntityTypeBuilder<Bucket> builder)
        {
            builder.ToTable("Buckets");

            builder
                .Property(a => a.Id)
                .HasColumnType("int")
                .HasColumnName("id");

            builder
                .Property(a => a.IdChaveAplicacao)
                    .HasColumnName("IdChaveAplicacao")
                    .HasColumnType("VARCHAR(200)");
            builder
                .Property(a => a.ChaveAplicacao)
                    .HasColumnName("ChaveAplicacao")
                    .HasColumnType("VARCHAR(200)");

            builder
                .Property(a => a.NomeBucket)
                    .HasColumnName("NomeBucket")
                    .HasColumnType("VARCHAR(200)");
            builder
                .Property(a => a.BucketId)
                    .HasColumnName("BucketId")
                    .HasColumnType("VARCHAR(200)");
            builder
                .Property(a => a.Apelido)
                    .HasColumnName("Apelido")
                    .HasColumnType("VARCHAR(200)");
        }
    }
}
