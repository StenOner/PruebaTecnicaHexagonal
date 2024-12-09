namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.DeleteCategory
{
    public interface IDeleteCategoryInputPort
    {
        Task Handle(Guid id);
    }
}
