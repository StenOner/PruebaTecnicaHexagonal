using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.UpdateCategory
{
    public interface IUpdateCategoryInputPort
    {
        Task Handle(Guid id, UpdateCategoryDTO category);
    }
}
