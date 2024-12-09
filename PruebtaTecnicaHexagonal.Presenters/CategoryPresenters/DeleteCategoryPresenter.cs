using PruebaTecnicaHexagonal.UseCasesPorts.Category.DeleteCategory;

namespace PruebaTecnicaHexagonal.Presenters.CategoryPresenters
{
    public class DeleteCategoryPresenter : IDeleteCategoryOutputPort, IPresenter<object>
    {
        public object Content { get; private set; }
        public Task Handle()
        {
            return Task.CompletedTask;
        }
    }
}
