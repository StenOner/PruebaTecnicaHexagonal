using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.UpdateProduct;

namespace PruebaTecnicaHexagonal.Presenters.ProductPresenters
{
    public class UpdateProductPresenter : IUpdateProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
