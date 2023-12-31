﻿// <auto-generated />
using System;
using Api_Lançamentos.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Lançamentos.Data.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    partial class SqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api_Lançamentos.Data.Entities.Lancamento", b =>
                {
                    b.Property<Guid>("IdLancamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdLancamento");

                    b.Property<bool>("Avulso")
                        .HasColumnType("Bit")
                        .HasColumnName("Avulso");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DateTime")
                        .HasColumnName("Data");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)")
                        .HasColumnName("Status");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdLancamento");

                    b.ToTable("Lancamento", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
