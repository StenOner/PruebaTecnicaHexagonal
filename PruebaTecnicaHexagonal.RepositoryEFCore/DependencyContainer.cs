using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.RepositoryEFCore.DataContext;
using PruebaTecnicaHexagonal.RepositoryEFCore.Repositories;

namespace PruebaTecnicaHexagonal.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositoriesServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PruebaTecnicaHexagonalContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PruebaTecnicaHexagonal")));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
