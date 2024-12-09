using PruebaTecnicaHexagonal.DTOs.Category;

namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory
{
    public interface ICreateCategoryInputPort
    {
        Task Handle(CreateCategoryDTO category);
    }
}
