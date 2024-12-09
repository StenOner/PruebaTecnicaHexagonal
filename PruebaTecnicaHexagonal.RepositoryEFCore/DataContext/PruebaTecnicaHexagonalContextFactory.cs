using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PruebaTecnicaHexagonal.RepositoryEFCore.DataContext
{
    public class PruebaTecnicaHexagonalContextFactory : IDesignTimeDbContextFactory<PruebaTecnicaHexagonalContext>
    {
        public PruebaTecnicaHexagonalContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<PruebaTecnicaHexagonalContext>();
            OptionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=PruebaTecnicaHexagonal");

            return new PruebaTecnicaHexagonalContext(OptionsBuilder.Options);
        }
    }
}
