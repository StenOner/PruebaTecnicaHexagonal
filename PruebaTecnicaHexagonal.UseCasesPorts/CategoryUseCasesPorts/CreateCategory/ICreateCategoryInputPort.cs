using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.CreateCategory
{
    public interface ICreateCategoryInputPort
    {
        Task Handle(CreateCategoryDTO category);
    }
}
