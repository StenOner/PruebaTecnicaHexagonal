using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.CreateCategory;

namespace PruebaTecnicaHexagonal.Presenters.CategoryPresenters
{
    public class CreateCategoryPresenter : ICreateCategoryOutputPort, IPresenter<CategoryDTO>
    {
        public CategoryDTO Content { get; private set; }

        public Task Handle(CategoryDTO category)
        {
            Content = category;
            return Task.CompletedTask;
        }
    }
}
