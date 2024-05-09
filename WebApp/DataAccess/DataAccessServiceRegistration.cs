using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Concrete.Repository;
using DataAccess.GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration 
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection")));

            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

    }
}
