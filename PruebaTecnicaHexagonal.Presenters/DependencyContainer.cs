using Microsoft.Extensions.DependencyInjection;
using PruebaTecnicaHexagonal.Presenters.CategoryPresenters;
using PruebaTecnicaHexagonal.Presenters.ProductPresenters;
using PruebaTecnicaHexagonal.Presenters.ReportPresenters;
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
using PruebaTecnicaHexagonal.UseCasesPorts.ReportUseCasesPorts;

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
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            services.AddScoped<IDeleteProductOutputPort, DeleteProductPresenter>();
            services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();
            services.AddScoped<IGetProductByIdOutputPort, GetProductByIdPresenter>();
            services.AddScoped<IUpdateProductOutputPort, UpdateProductPresenter>();
            services.AddScoped<ICategoriesReportOutputPort, CategoriesReportPresenter>();

            return services;
        }
    }
}
