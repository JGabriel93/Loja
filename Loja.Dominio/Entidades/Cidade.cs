
namespace Loja.Dominio.Entidades
{
    public class Cidade : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }

        public Estado Estado { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
