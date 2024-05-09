using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class EfRepository<TEntity, TEntityId> : IAsyncRepository<TEntity, TEntityId> where TEntity : BaseEntity<TEntityId>
    {
        //private readonly AppDbContext context;
        public EfRepository() { }
        public Task<TEntity> Get(TEntityId entityId)
        {
            throw new NotImplementedException();
        }
        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> Create(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> Delete(TEntityId entityId)
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> Update(TEntityId entityId, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
