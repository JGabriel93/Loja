using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Loja.Repositorio.Config
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(estado => estado.Id);

            builder
                .Property(estado => estado.Nome)
                .IsRequired()
                .HasMaxLength(25);

            builder
                .Property(estado => estado.Sigla)
                .IsRequired()
                .HasMaxLength(2);

            builder
                .HasMany(estado => estado.Cidades)
                .WithOne(cidade => cidade.Estado);

            builder
                .HasMany(estado => estado.Enderecos)
                .WithOne(endereco => endereco.Estado);
        }
    }
}