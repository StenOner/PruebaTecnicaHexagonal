using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.RepositoryEFCore.DataContext;

namespace PruebaTecnicaHexagonal.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly PruebaTecnicaHexagonalContext _context;

        public UnitOfWork(PruebaTecnicaHexagonalContext context)
            => _context = context;

        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
