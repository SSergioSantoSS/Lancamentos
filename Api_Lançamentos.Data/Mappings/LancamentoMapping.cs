using Api_Lançamentos.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Lançamentos.Data.Mappings
{
    public class LancamentoMapping  : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder.ToTable("Lancamento");

            builder.HasKey(l => l.IdLancamento);

            builder.Property(l => l.IdLancamento)
                .HasColumnName("IdLancamento")
                .IsRequired();

            builder.Property(l => l.Descricao)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasColumnType("Varchar(200)")
                .HasMaxLength(200);

            builder.Property(l => l.Data)
               .HasColumnName("Data")
                .HasColumnType("DateTime")
                .IsRequired();

            builder.Property(l => l.Valor)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(l => l.Avulso)
               .HasColumnName("Avulso")
                .HasColumnType("Bit")
                .IsRequired();

            builder.Property(l => l.Status)
               .HasColumnName("Status")
                .HasColumnType("Varchar(10)")
                .HasMaxLength(10)                  
                .IsRequired();

        }
    }
}
