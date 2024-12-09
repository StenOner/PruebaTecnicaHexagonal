using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.Presenters.CategoryPresenters;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.CreateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetAllCategories;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetCategoryById;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.UpdateCategory;

namespace PruebaTecnicaHexagonal.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentersServices(
            this IServiceCollection services)
        {
            services.AddScoped<ICreateCategoryOutputPort, CreateCategoryPresenter>();
            services.AddScoped<IDeleteCategoryOutputPort, DeleteCategoryPresenter>();
            services.AddScoped<IGetAllCategoriesOutputPort, GetAllCategoriesPresenter>();
            services.AddScoped<IGetCategoryByIdOutputPort, GetCategoryByIdPresenter>();
            services.AddScoped<IUpdateCategoryOutputPort, UpdateCategoryPresenter>();

            return services;
        }
    }
}
