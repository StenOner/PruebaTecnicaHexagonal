using PruebaTecnicaHexagonal.DTOs.ProductDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetProductById
{
    public interface IGetProductByIdOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
