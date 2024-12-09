using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.Entities.POCOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetAllProducts;

namespace PruebaTecnicaHexagonal.UseCases.ProductUseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository _repository;
        readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);

        public Task Handle()
        {
            IEnumerable<Product> products = _repository.GetAll();
            _outputPort.Handle(products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio,
                Stock = p.Stock,
                CategoriaId = p.CategoriaId,
                Categoria = new CategoryDTO
                {
                    Descripcion = p.Categoria.Descripcion,
                    Id = p.Categoria.Id,
                    Nombre = p.Categoria.Nombre
                }
            }));

            return Task.CompletedTask;
        }
    }
}
