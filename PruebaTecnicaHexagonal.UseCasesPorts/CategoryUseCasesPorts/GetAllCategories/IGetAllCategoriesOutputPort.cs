using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetAllCategories
{
    public interface IGetAllCategoriesOutputPort
    {
        Task Handle(IEnumerable<CategoryDTO> categories);
    }
}
