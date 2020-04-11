
namespace Loja.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificado qual a referência de produto");

            if (Quantidade == 0)
                AdicionarCritica("A quantidade não foi informada");
        }
    }
}
