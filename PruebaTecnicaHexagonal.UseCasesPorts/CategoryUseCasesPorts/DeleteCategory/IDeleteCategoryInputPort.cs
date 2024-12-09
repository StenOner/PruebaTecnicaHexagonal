namespace PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory
{
    public interface IDeleteCategoryInputPort
    {
        Task Handle(Guid id);
    }
}
