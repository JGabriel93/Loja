using Loja.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(formaPagamento => formaPagamento.Id);

            builder
                .Property(formaPagamento => formaPagamento.Nome)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(formaPagamento => formaPagamento.Descricao)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .HasMany(formaPagamento => formaPagamento.Pedidos)
                .WithOne(pedido => pedido.FormaPagamento);
        }
    }
}