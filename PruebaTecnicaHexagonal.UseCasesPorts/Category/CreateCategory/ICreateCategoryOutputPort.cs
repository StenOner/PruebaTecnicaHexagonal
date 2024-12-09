using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory
{
    public interface ICreateCategoryOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
