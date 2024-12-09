using PruebaTecnicaHexagonal.DTOs.Category;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.GetCategoryById
{
    public interface IGetCategoryByIdOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
