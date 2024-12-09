using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaHexagonal.Entities.POCOs
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a 0")]
        public int Stock { get; set; }

        // Foreign key
        public Guid CategoriaId { get; set; }

        // Navigation property
        public Category Categoria { get; set; } = null!;
    }
}
