using PruebaTecnicaHexagonal.DTOs.Category;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.GetAllCategories
{
    public interface IGetAllCategoriesOutputPort
    {
        Task Handle(IEnumerable<CategoryDTO> categories);
    }
}
