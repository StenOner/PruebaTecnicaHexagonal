using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetAllProducts;

namespace PruebaTecnicaHexagonal.Presenters.ProductPresenters
{
    public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDTO>>
    {
        public IEnumerable<ProductDTO> Content { get; private set; }

        public Task Handle(IEnumerable<ProductDTO> products)
        {
            Content = products;
            return Task.CompletedTask;
        }
    }
}
