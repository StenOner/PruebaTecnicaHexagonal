using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.Entities.POCOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.CreateProduct;

namespace PruebaTecnicaHexagonal.UseCases.ProductUseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductInteractor(IProductRepository repository, IUnitOfWork unitOfWork, ICreateProductOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public async Task Handle(CreateProductDTO product)
        {
            if (product.Precio <= 0)
            {
                throw new Exception("Precio debe ser mayor a 0.");
            }
            if (product.Stock < 0)
            {
                throw new Exception("Stock no puede ser menor a 0.");
            }

            Product newProduct = new()
            {
                Nombre = product.Nombre,
                Precio = product.Precio,
                Stock = product.Stock,
                CategoriaId = product.CategoriaId
            };
            _repository.Create(newProduct);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new ProductDTO
            {
                Id = newProduct.Id,
                Nombre = newProduct.Nombre,
                Precio = newProduct.Precio,
                Stock = newProduct.Stock,
                CategoriaId = newProduct.CategoriaId
            });
        }
    }
}
