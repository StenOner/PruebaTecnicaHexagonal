using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;

namespace PruebaTecnicaHexagonal.DTOs.ProductDTOs
{
    public class ProductDTO
    {
        public string Nombre { get; init; }
        public decimal Precio { get; init; }
        public int Stock { get; init; }
        public Guid CategoriaId { get; init; }
        public CategoryDTO Categoria { get; init; }
    }
}
