using PruebaTecnicaHexagonal.DTOs.ProductDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.UpdateProduct
{
    public interface IUpdateProductInputPort
    {
        Task Handle(Guid id, UpdateProductDTO product);
    }
}
