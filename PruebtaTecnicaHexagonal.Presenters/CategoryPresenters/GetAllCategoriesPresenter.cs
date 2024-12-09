using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.GetAllCategories;

namespace PruebaTecnicaHexagonal.Presenters.CategoryPresenters
{
    public class GetAllCategoriesPresenter : IGetAllCategoriesOutputPort, IPresenter<IEnumerable<CategoryDTO>>
    {
        public IEnumerable<CategoryDTO> Content { get; private set; }

        public Task Handle(IEnumerable<CategoryDTO> categories)
        {
            Content = categories;
            return Task.CompletedTask;
        }
    }
}
