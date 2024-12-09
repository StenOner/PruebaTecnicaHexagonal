using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.UpdateCategory;

namespace PruebaTecnicaHexagonal.Presenters.CategoryPresenters
{
    public class UpdateCategoryPresenter : IUpdateCategoryOutputPort, IPresenter<CategoryDTO>
    {
        public CategoryDTO Content { get; private set; }

        public Task Handle(CategoryDTO category)
        {
            Content = category;
            return Task.CompletedTask;
        }
    }
}
