using PruebaTecnicaHexagonal.DTOs.ProductDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetAllProducts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handle(IEnumerable<ProductDTO> products);
    }
}
