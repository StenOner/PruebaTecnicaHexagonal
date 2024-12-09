using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.CreateCategory;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.DeleteCategory;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.GetAllCategories;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.GetCategoryById;
using PruebaTecnicaHexagonal.UseCases.CategoryUseCases.UpdateCategory;
using PruebaTecnicaHexagonal.UseCases.ProductUseCases.CreateProduct;
using PruebaTecnicaHexagonal.UseCases.ProductUseCases.DeleteProduct;
using PruebaTecnicaHexagonal.UseCases.ProductUseCases.GetAllProducts;
using PruebaTecnicaHexagonal.UseCases.ProductUseCases.GetProductById;
using PruebaTecnicaHexagonal.UseCases.ProductUseCases.UpdateProduct;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.CreateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetAllCategories;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetCategoryById;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.UpdateCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.CreateProduct;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.DeleteProduct;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetAllProducts;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetProductById;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.UpdateProduct;

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
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IDeleteProductInputPort, DeleteProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();
            services.AddTransient<IGetProductByIdInputPort, GetProductByIdInteractor>();
            services.AddTransient<IUpdateProductInputPort, UpdateProductInteractor>();

            return services;
        }
    }
}
