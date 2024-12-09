using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.UseCases.Category.CreateCategory;
using PruebaTecnicaHexagonal.UseCases.Category.DeleteCategory;
using PruebaTecnicaHexagonal.UseCases.Category.GetAllCategories;
using PruebaTecnicaHexagonal.UseCases.Category.GetCategoryById;
using PruebaTecnicaHexagonal.UseCases.Category.UpdateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.DeleteCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.GetAllCategories;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.GetCategoryById;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.UpdateCategory;

namespace PruebaTecnicaHexagonal.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddTransient<ICreateCategoryInputPort, CreateCategoryInteractor>();
            services.AddTransient<IDeleteCategoryInputPort, DeleteCategoryInteractor>();
            services.AddTransient<IGetAllCategoriesInputPort, GetAllCategoriesInteractor>();
            services.AddTransient<IGetCategoryByIdInputPort, GetCategoryByIdInteractor>();
            services.AddTransient<IUpdateCategoryInputPort, UpdateCategoryInteractor>();

            return services;
        }
    }
}
