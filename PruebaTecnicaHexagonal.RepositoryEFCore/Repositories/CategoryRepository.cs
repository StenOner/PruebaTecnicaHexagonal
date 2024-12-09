using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.Entities.POCOs;
using PruebaTecnicaHexagonal.RepositoryEFCore.DataContext;

namespace PruebaTecnicaHexagonal.RepositoryEFCore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly PruebaTecnicaHexagonalContext _context;

        public CategoryRepository(PruebaTecnicaHexagonalContext context)
            => _context = context;

        public void Create(Category category)
        {
            _context.Add(category);
        }
        public void Delete(Guid id)
        {
            _context.Remove(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public Category GetById(Guid id)
        {
            var category = _context.Find<Category>(id) ?? new Category();
            return category;
        }

        public void Update(Category category)
        {
            _context.Update(category);
        }
    }
}
