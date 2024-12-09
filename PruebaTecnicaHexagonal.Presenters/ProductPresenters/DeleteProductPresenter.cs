using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.DeleteProduct;

namespace PruebaTecnicaHexagonal.Presenters.ProductPresenters
{
    public class DeleteProductPresenter : IDeleteProductOutputPort, IPresenter<object>
    {
        public object Content { get; private set; }
        
        public Task Handle()
        {
            return Task.CompletedTask;
        }
    }
}
