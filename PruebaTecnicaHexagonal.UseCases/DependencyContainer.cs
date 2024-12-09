using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.CreateCategory;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.DeleteCategory;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.GetAllCategories;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.GetCategoryById;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.UpdateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.CreateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetAllCategories;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetCategoryById;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.UpdateCategory;

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
