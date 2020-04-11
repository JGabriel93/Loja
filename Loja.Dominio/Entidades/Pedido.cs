using System;
using System.Collections.Generic;
using System.Linq;
using Loja.Dominio.ObjetoDeValor;

namespace Loja.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public long Id { get; set; }
        public long UsuarioId { get; set; }
        public long EnderecoId { get; set; }
        public int FormaPagamentoId { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItensPedidos.Any())
                AdicionarCritica("É preciso selecionar itens para fazer um pedido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Não foi informada uma forma de pagamento");
        }
    }
}
