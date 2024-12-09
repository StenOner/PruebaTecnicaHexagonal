using PruebaTecnicaHexagonal.DTOs.ProductDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.UpdateProduct
{
    public interface IUpdateProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
