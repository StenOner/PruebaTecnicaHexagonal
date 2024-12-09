namespace PruebaTecnicaHexagonal.DTOs.ProductDTOs
{
    public class UpdateProductDTO
    {
        public string? Nombre { get; init; }
        public decimal? Precio { get; init; }
        public int? Stock { get; init; }
        public Guid? CategoriaId { get; init; }
    }
}
