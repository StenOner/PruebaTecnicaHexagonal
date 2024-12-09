using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.GetCategoryById
{
    public interface IGetCategoryByIdOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
