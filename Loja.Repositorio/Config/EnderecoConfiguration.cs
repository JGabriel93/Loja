using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Config
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(endereco => endereco.Id);

            builder
                .Property(endereco => endereco.CidadeId)
                .IsRequired();

            builder
                .Property(endereco => endereco.EstadoId)
                .IsRequired();

            builder
                .Property(endereco => endereco.Cep)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(endereco => endereco.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(endereco => endereco.Numero)
                .IsRequired();

            builder
                .Property(endereco => endereco.Complemento)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(endereco => endereco.Pedidos)
                .WithOne(pedido => pedido.Endereco);
        }
    }
}