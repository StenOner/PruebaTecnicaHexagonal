using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.DTOs.ProductDTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Guid CategoriaId { get; set; }
        public CategoryDTO Categoria { get; set; }
    }
}
