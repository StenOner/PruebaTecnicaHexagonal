using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.CreateCategory
{
    public interface ICreateCategoryOutputPort
    {
        Task Handle(CategoryDTO category);
    }
}
