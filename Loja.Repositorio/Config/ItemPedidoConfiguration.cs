using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Loja.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(itemPedido => itemPedido.Id);

            builder
                .Property(itemPedido => itemPedido.PedidoId)
                .IsRequired();

            builder
                .Property(itemPedido => itemPedido.ProdutoId)
                .IsRequired();

            builder
                .Property(itemPedido => itemPedido.Quantidade)
                .IsRequired();
        }
    }
}