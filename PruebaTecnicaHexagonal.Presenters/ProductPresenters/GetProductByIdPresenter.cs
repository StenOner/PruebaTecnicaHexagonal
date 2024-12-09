using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetProductById;

namespace PruebaTecnicaHexagonal.Presenters.ProductPresenters
{
    public class GetProductByIdPresenter : IGetProductByIdOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; }

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
