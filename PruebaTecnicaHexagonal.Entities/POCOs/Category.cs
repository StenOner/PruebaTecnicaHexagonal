using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaHexagonal.Entities.POCOs
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(200)]
        public string? Descripcion { get; set; }

        // Navigation property
        public ICollection<Product> Productos { get; set; } = [];
    }
}
