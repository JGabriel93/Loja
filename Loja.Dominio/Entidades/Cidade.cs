
using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class Cidade
    {
        public int Id { get; set; }
        public int EstadoId { get; set; }
        public string Nome { get; set; }        

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
