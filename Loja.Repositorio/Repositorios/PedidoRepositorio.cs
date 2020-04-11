using Loja.Dominio.Contratos;
using Loja.Dominio.Entidades;
using Loja.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(LojaContexto lojaContexto) : base(lojaContexto)
        {
        }
    }
}
