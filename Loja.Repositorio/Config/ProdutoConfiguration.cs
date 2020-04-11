using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(produto => produto.Id);

            builder
                .Property(produto => produto.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(produto => produto.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(produto => produto.Preco)
                .IsRequired()
                .HasColumnType("decimal(6,2)");

            builder
                .HasMany(produto => produto.ItensPedidos)
                .WithOne(itensPedido => itensPedido.Produto);
        }
    }
}