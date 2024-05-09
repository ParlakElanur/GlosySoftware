using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.GenericRepository;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repository
{
    public class ProductRepository : EfRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) { }
    }
}
