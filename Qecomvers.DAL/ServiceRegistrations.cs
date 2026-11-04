using Microsoft.Extensions.DependencyInjection;
using Qecomvers.Core.Entities;
using Qecomvers.Core.Repositories;
using Qecomvers.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.DAL
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddScoped<ISiteItemsRepository, SiteItemsRepository>();
            services.AddScoped<IUserRepository<AppUser>, UserRepository>();

            return services;
        }

        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            return services;
        }
    }
}
