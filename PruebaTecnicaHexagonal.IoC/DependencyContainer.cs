using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.RepositoryEFCore;
using PruebaTecnicaHexagonal.UseCases;

namespace PruebaTecnicaHexagonal.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPruebaTecnicaHexagonalDependencies(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositoriesServices(configuration);
            services.AddUseCasesServices();
            services.AddPresentersServices();

            return services;
        }
    }
}
