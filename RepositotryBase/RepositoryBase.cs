using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepositoryBase
{
    internal class RepositoryBase<TEntity, TContext> : IDisposable, IRepositoryBase<TEntity, TContext>
        where TEntity : class where TContext : DbContext
    {
        private DbContext _db;
        private DbSet<TEntity> _dbSet;
        public RepositoryBase()
        {
            _db = (TContext)Activator.CreateInstance(typeof(TContext));
            _dbSet = _db.Set<TEntity>();
        }
        public int Alterar(TEntity entity)
        {
            _db.Entry<TEntity>(entity).State = EntityState.Modified;
            return _db.SaveChanges();
            
        }

        public void Dispose() => _db.Dispose();
       
            

        public void Excluir(TEntity entity)
        {
            _db.Entry<TEntity>(entity).State = EntityState.Deleted;
            _db.SaveChanges();
        }

        public void Incluir(TEntity entity)
        {
            _dbSet.Add(entity);
            _db.SaveChanges();
        }

        public TEntity SelecionarChave(params object[] keyvalues)
        {
           return _dbSet.Find(keyvalues);
        }

        public List<TEntity> Selecionartodos()
        {
            return _dbSet.ToList();
        }

     
    }
}
