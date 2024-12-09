using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.CreateCategoryUseCase;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.DeleteCategoryUseCase;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.GetAllCategoriesUseCase;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.GetCategoryByIdUseCase;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.UpdateCategoryseCase;
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
