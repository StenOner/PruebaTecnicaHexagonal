using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory;

namespace PruebaTecnicaHexagonal.UseCases.CategoryUseCases.CreateCategoryUseCase
{
    public class CreateCategoryInteractor : ICreateCategoryInputPort
    {
        readonly ICategoryRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateCategoryOutputPort _outputPort;

        public CreateCategoryInteractor(ICategoryRepository repository, IUnitOfWork unitOfWork, ICreateCategoryOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public async Task Handle(CreateCategoryDTO category)
        {
            Entities.POCOs.Category newCategory = new()
            {
                Nombre = category.Nombre,
                Descripcion = category.Descripcion
            };
            _repository.Create(newCategory);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new CategoryDTO
            {
                Id = newCategory.Id,
                Nombre = newCategory.Nombre,
                Descripcion = newCategory.Descripcion
            });
        }
    }
}
