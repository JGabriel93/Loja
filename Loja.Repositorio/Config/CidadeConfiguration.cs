using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Config
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(cidade => cidade.Id);

            builder
                .Property(cidade => cidade.EstadoId)
                .IsRequired();

            builder
                .Property(cidade => cidade.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder
                .HasMany(cidade => cidade.Enderecos)
                .WithOne(endereco => endereco.Cidade);
        }
    }
}