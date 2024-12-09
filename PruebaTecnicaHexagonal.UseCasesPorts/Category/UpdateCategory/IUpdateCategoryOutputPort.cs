using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.UpdateCategory
{
    public interface IUpdateCategoryOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
