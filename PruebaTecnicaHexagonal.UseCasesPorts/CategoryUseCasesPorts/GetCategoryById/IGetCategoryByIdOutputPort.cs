using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetCategoryById
{
    public interface IGetCategoryByIdOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
