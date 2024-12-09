using PruebaTecnicaHexagonal.DTOs.Category;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.UpdateCategory
{
    public interface IUpdateCategoryOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
