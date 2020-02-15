using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using AppATLComplementa.Nucleo.Repositorios;

namespace AppATLComplementa.AccesoDatos.Repositorios
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        private DbSet<TEntity> _entities;

        public Repositorio(DbContext context)
        {
            Context = context;
            _entities = Context.Set<TEntity>();
        }

        public TEntity Traer(int id)
        {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> TraerTodos()
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            //return Context.Set<TEntity>().ToList();
            return _entities.ToList();
        }

        public IEnumerable<TEntity> Encuentra(Expression<Func<TEntity, bool>> predicado)
        {
            return _entities.Where(predicado);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicado)
        {
            return _entities.SingleOrDefault(predicado);
        }

        public void Anexar(TEntity entidad)
        {
            _entities.Add(entidad);
        }

        public void AnexarRango(IEnumerable<TEntity> entidades)
        {
            _entities.AddRange(entidades);
        }

        public void Eliminar(TEntity entidad)
        {
            _entities.Remove(entidad);
        }

        public void EliminarRango(IEnumerable<TEntity> entidades)
        {
            _entities.RemoveRange(entidades);
        }
    }

}
