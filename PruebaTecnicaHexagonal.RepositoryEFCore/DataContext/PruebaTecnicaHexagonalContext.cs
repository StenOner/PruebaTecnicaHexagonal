using Microsoft.EntityFrameworkCore;
using PruebaTecnicaHexagonal.Entities.POCOs;

namespace PruebaTecnicaHexagonal.RepositoryEFCore.DataContext
{
    public class PruebaTecnicaHexagonalContext : DbContext
    {
        public PruebaTecnicaHexagonalContext(
            DbContextOptions<PruebaTecnicaHexagonalContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Productos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.CategoriaId);

            modelBuilder.Entity<Product>()
                .Navigation(p => p.Categoria)
                .AutoInclude();
        }
    }
}
