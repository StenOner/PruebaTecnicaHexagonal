using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory;

namespace PruebaTecnicaHexagonal.UseCases.CategoryUseCases.DeleteCategory
{
    public class DeleteCategoryInteractor : IDeleteCategoryInputPort
    {
        readonly ICategoryRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IDeleteCategoryOutputPort _outputPort;

        public DeleteCategoryInteractor(ICategoryRepository repository, IUnitOfWork unitOfWork, IDeleteCategoryOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public async Task Handle(Guid id)
        {
            _repository.Delete(id);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle();
        }
    }
}
