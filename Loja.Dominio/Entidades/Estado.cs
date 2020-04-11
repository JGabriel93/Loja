using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
