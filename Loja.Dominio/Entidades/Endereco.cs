
using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class Endereco : Entidade
    {
        public long Id { get; set; }
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public string Cep { get; set; }
        public string Descricao { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("O Cep deve ser preenchido");
        }
    }
}
