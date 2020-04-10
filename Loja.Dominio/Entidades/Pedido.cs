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
        public int FormaPagamentoId { get; set; }
        public DateTime Data { get; set; }        
        public DateTime DataPrevisaoEntrega { get; set; }  
        
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> Itens { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!Itens.Any())
                AdicionarCritica("É preciso selecionar itens para fazer um pedido");  
        }
    }
}
