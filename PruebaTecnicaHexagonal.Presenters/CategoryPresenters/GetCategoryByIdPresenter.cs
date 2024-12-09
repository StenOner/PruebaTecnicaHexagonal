using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetCategoryById;

namespace PruebaTecnicaHexagonal.Presenters.CategoryPresenters
{
    public class GetCategoryByIdPresenter : IGetCategoryByIdOutputPort, IPresenter<CategoryDTO>
    {
        public CategoryDTO Content { get; private set; }

        public Task Handle(CategoryDTO category)
        {
            Content = category;
            return Task.CompletedTask;
        }
    }
}
