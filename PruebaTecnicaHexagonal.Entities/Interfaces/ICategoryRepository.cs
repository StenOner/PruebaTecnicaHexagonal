using PruebaTecnicaHexagonal.Entities.POCOs;

namespace PruebaTecnicaHexagonal.Entities.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetById(Guid id);
        IEnumerable<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(Guid id);
    }
}
