
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

        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
