using PruebaTecnicaHexagonal.DTOs.ProductDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.CreateProduct
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}
