using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.Entities.POCOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetProductById;

namespace PruebaTecnicaHexagonal.UseCases.ProductUseCases.GetProductById
{
    public class GetProductByIdInteractor : IGetProductByIdInputPort
    {
        readonly IProductRepository _repository;
        readonly IGetProductByIdOutputPort _outputPort;

        public GetProductByIdInteractor(IProductRepository repository, IGetProductByIdOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);

        public Task Handle(Guid id)
        {
            Product product = _repository.GetById(id);
            _outputPort.Handle(new ProductDTO
            {
                Id = product.Id,
                Nombre = product.Nombre,
                Precio = product.Precio,
                Stock = product.Stock,
                CategoriaId = product.CategoriaId,
                Categoria = new CategoryDTO
                {
                    Descripcion = product.Categoria.Descripcion,
                    Id = product.Categoria.Id,
                    Nombre = product.Categoria.Nombre
                }
            });

            return Task.CompletedTask;
        }
    }
}
