using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AppATLComplementa.Nucleo.Repositorios
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        TEntity Traer(int id);
        IEnumerable<TEntity> TraerTodos();
        IEnumerable<TEntity> Encuentra(Expression<Func<TEntity, bool>> predicado);

        // This method was not in the videos, but I thought it would be useful to add.
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicado);

        void Anexar(TEntity entidad);
        void AnexarRango(IEnumerable<TEntity> entidades);

        void Eliminar(TEntity entidad);
        void EliminarRango(IEnumerable<TEntity> entidades);
    }
}