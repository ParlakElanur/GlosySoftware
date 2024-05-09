using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IAsyncRepository<TEntity, TEntityId> where TEntity : BaseEntity<TEntityId>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> Get(TEntityId entityId);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntityId entityId, TEntity entity);
        Task<TEntity> Delete(TEntityId entityId);
    }
}
