using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.UpdateCategory
{
    public interface IUpdateCategoryOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
