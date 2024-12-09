namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetProductById
{
    public interface IGetProductByIdInputPort
    {
        Task Handle(Guid id);
    }
}
