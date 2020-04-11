using Loja.Dominio.Entidades;
using Loja.Dominio.ObjetoDeValor;
using Loja.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace Loja.Repositorio.Contexto
{
    public class LojaContexto : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<FormaPagamento> FormasPagamentos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public LojaContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao = "Boleto bancário" },
                new FormaPagamento() { Id = 2, Nome = "Cartão", Descricao = "Cartão de crédito" },
                new FormaPagamento() { Id = 3, Nome = "Depósito", Descricao = "Depósito bancário" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
