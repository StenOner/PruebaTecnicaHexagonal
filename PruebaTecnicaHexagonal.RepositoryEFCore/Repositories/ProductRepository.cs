using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.Entities.POCOs;
using PruebaTecnicaHexagonal.RepositoryEFCore.DataContext;

namespace PruebaTecnicaHexagonal.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly PruebaTecnicaHexagonalContext _context;

        public ProductRepository(PruebaTecnicaHexagonalContext context)
            => _context = context;

        public void Create(Product product)
        {
            _context.Add(product);
        }

        public void Delete(Guid id)
        {
            _context.Remove(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(Guid id)
        {
            var product = _context.Find<Product>(id) ?? new Product();
            return product;
        }

        public void Update(Product product)
        {
            _context.Update(product);
        }
    }
}
