namespace PruebaTecnicaHexagonal.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
