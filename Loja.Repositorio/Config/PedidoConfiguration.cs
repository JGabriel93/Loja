using Loja.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pedido => pedido.Id);

            builder
                .Property(pedido => pedido.UsuarioId)
                .IsRequired();
            
            builder
                .Property(pedido => pedido.FormaPagamentoId)
                .IsRequired();

            builder
                .Property(pedido => pedido.Data)
                .IsRequired();

            builder
                .Property(pedido => pedido.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .HasMany(pedido => pedido.ItensPedidos)
                .WithOne(itensPedido => itensPedido.Pedido);
        }
    }
}