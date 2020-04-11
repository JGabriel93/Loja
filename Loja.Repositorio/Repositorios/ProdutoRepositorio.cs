using Loja.Dominio.Contratos;
using Loja.Dominio.Entidades;
using Loja.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(LojaContexto lojaContexto) : base(lojaContexto)
        {
        }
    }
}
