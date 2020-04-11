using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("E-mail não informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informada");
        }
    }
}
