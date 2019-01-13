using SistemaContabil.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaContabil.Core.SharedKernel.Contracts
{
    public interface IRepository<TEntity> where TEntity : BaseEntity<TEntity>
    {
        void Update(Guid id, TEntity entity);
        void Remove(Guid guid);
        Task<TEntity> Add(TEntity entity);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetAsync(Guid id);
    }
}
