using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GenericRepository
{ 
    public interface IAsyncRepository<TEntity, TEntityId> where TEntity : BaseEntity<TEntityId>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> Get(TEntityId entityId);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntityId entityId);
    }
}
