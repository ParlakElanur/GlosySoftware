using DataAccess.Concrete.Context;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GenericRepository
{
    public class EfRepository<TEntity, TEntityId> : IAsyncRepository<TEntity, TEntityId> where TEntity : BaseEntity<TEntityId>
    {
        protected readonly AppDbContext _context;
        public EfRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> Get(TEntityId entityId)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id.Equals(entityId));
        }

        public async Task Create(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TEntityId entityId)
        {
            var entity = await Get(entityId);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
