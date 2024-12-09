namespace PruebaTecnicaHexagonal.UseCasesPorts.Category.GetCategoryById
{
    public interface IGetCategoryByIdInputPort
    {
        Task Handle(Guid id);
    }
}
