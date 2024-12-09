using PruebaTecnicaHexagonal.DTOs.Category;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.UpdateCategory
{
    public interface IUpdateCategoryInputPort
    {
        Task Handle(Guid id, UpdateCategoryDTO category);
    }
}
