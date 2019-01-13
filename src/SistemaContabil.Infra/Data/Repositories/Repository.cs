using SistemaContabil.Core.SharedKernel.Contracts;
using SistemaContabil.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaContabil.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity<TEntity>
    {
        protected readonly DataBaseContext _dataBaseContext;

        public Repository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            var result = await _dataBaseContext.AddAsync(entity);
            return result.Entity;
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _dataBaseContext.Set<TEntity>()
                .Where(expression);
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            return _dataBaseContext.Set<TEntity>()
                .Find(id);
        }

        public void Remove(Guid guid)
        {
            var result = _dataBaseContext.Set<TEntity>()
                .Find(guid);
 
             _dataBaseContext.Set<TEntity>()
           .Remove(result);
        }

        public void Update(Guid id, TEntity entity)
        {
            var result = _dataBaseContext.Set<TEntity>().Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                _dataBaseContext.Entry(result).Property(p => p.Id).IsModified = false;
                _dataBaseContext.Entry(result).CurrentValues.SetValues(entity);
            }
        }
    }
}
