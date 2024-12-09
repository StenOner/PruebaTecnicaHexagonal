using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.CreateProduct;

namespace PruebaTecnicaHexagonal.Presenters.ProductPresenters
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
