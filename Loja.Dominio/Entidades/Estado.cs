using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class Estado : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public ICollection<Cidade> Cidades { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
