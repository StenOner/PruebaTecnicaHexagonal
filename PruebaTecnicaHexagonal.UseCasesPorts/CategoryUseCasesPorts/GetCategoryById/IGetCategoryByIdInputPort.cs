namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetCategoryById
{
    public interface IGetCategoryByIdInputPort
    {
        Task Handle(Guid id);
    }
}
