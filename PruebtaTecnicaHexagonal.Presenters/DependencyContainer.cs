using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.DeleteCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.GetAllCategories;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.GetCategoryById;
using PruebaTecnicaHexagonal.Presenters.CategoryPresenters;

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
            services.AddScoped<IDeleteCategoryOutputPort, DeleteCategoryPresenter>();

            return services;
        }
    }
}
