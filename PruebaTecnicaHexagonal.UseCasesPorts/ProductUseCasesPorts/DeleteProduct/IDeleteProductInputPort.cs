namespace PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.DeleteProduct
{
    public interface IDeleteProductInputPort
    {
        Task Handle(Guid id);
    }
}
