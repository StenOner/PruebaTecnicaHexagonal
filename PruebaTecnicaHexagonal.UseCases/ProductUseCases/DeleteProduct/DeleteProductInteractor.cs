using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.DeleteProduct;

namespace PruebaTecnicaHexagonal.UseCases.ProductUseCases.DeleteProduct
{
    public class DeleteProductInteractor : IDeleteProductInputPort
    {
        readonly IProductRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IDeleteCategoryOutputPort _outputPort;

        public DeleteProductInteractor(IProductRepository repository, IUnitOfWork unitOfWork, IDeleteCategoryOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public async Task Handle(Guid id)
        {
            _repository.Delete(id);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle();
        }
    }
}
