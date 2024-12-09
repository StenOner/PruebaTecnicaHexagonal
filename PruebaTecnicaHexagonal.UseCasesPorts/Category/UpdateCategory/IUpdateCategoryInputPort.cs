using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.UpdateCategory
{
    public interface IUpdateCategoryInputPort
    {
        Task Handle(Guid id, UpdateCategoryDTO category);
    }
}
