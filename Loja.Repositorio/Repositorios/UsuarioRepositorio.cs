using Loja.Dominio.Contratos;
using Loja.Dominio.Entidades;
using Loja.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(LojaContexto lojaContexto) : base(lojaContexto)
        {
        }
    }
}
