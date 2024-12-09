using PruebaTecnicaHexagonal.DTOs.Category;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory
{
    public interface ICreateCategoryOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
