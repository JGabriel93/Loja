using Loja.Dominio.Contratos;
using Loja.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly LojaContexto LojaContexto;

        public BaseRepositorio(LojaContexto lojaContexto)
        {
            LojaContexto = lojaContexto;
        }

        public void Adicionar(TEntity entity)
        {
            LojaContexto.Set<TEntity>().Add(entity);
            LojaContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            LojaContexto.Set<TEntity>().Update(entity);
            LojaContexto.SaveChanges();
        }        

        public TEntity ObterPorId(int id)
        {
            return LojaContexto.Set<TEntity>().Find(id);
        }

        public TEntity ObterPorId(long id)
        {
            return LojaContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return LojaContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            LojaContexto.Set<TEntity>().Remove(entity);
            LojaContexto.SaveChanges();
        }

        public void Dispose()
        {
            LojaContexto.Dispose();
        }
    }
}
