using PruebaTecnicaHexagonal.DTOs.ProductDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.CreateProduct
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
