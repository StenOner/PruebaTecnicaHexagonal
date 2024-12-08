using PruebaTecnicaHexagonal.Entities.POCOs;

namespace PruebaTecnicaHexagonal.Entities.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(Guid id);
        IEnumerable<Product> GetAll();
        void Create(Product product);
        void Update(Product product);
        void Delete(Guid id);
    }
}
