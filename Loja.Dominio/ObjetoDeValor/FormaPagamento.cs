using Loja.Dominio.Entidades;
using Loja.Dominio.Enumerados;
using System.Collections.Generic;

namespace Loja.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public bool Boleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool CartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool Deposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool Indefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Indefinido; }
        }
    }
}
