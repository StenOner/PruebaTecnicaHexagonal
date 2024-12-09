using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.Entities.POCOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.UpdateProduct;

namespace PruebaTecnicaHexagonal.UseCases.ProductUseCases.UpdateProduct
{
    public class UpdateProductInteractor : IUpdateProductInputPort
    {
        readonly IProductRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IUpdateProductOutputPort _outputPort;

        public UpdateProductInteractor(IProductRepository repository, IUnitOfWork unitOfWork, IUpdateProductOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public async Task Handle(Guid id, UpdateProductDTO product)
        {
            Product productToUpdate = _repository.GetById(id);

            if (product.Nombre is not null)
            {
                productToUpdate.Nombre = product.Nombre;
            }
            if (product.Precio is not null)
            {
                productToUpdate.Precio = product.Precio.Value;
            }
            if (product.Stock is not null)
            {
                productToUpdate.Stock = product.Stock.Value;
            }
            if (product.CategoriaId is not null)
            {
                productToUpdate.CategoriaId = product.CategoriaId.Value;
            }

            _repository.Update(productToUpdate);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new ProductDTO
            {
                Id = productToUpdate.Id,
                Nombre = productToUpdate.Nombre,
                Precio = productToUpdate.Precio,
                Stock = productToUpdate.Stock,
                CategoriaId = productToUpdate.CategoriaId,
                Categoria = new CategoryDTO
                {
                    Descripcion = productToUpdate.Categoria.Descripcion,
                    Id = productToUpdate.Categoria.Id,
                    Nombre = productToUpdate.Categoria.Nombre
                }
            });
        }
    }
}
