using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory
{
    public interface ICreateCategoryInputPort
    {
        Task Handle(CreateCategoryDTO category);
    }
}
