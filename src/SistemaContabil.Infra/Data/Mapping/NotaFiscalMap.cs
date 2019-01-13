using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaContabil.Core.Aggregates.Fiscal.Entities;

namespace SistemaContabil.Infra.Data.Mapping
{
    public class NotaFiscalMap : IEntityTypeConfiguration<NotaFiscalEntity>
    {
        public void Configure(EntityTypeBuilder<NotaFiscalEntity> builder)
        {
            builder.ToTable("NotaFiscal");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CnpjDestinatarioNf)
                .HasColumnName("CnpjDestinatarioNf")
                .HasColumnType("varchar(30)");

            builder.Property(x => x.CnpjEmissorNf)
            .HasColumnName("CnpjEmissorNf")
            .HasColumnType("varchar(30)");

            builder.Property(x => x.DataNf)
            .HasColumnName("DataNf");

            builder.Property(x => x.NumeroNf)
            .HasColumnName("NumeroNf");

            builder.Property(x => x.ValorTotal)
            .HasColumnName("ValorTotal")
            .HasColumnType("decimal(16,2)");

            builder.Ignore(x => x.CascadeMode);
            builder.Ignore(x => x.ValidationResult);
            builder.Ignore(x => x.SequenceTable);
        }
    }
}
