namespace PruebaTecnicaHexagonal.DTOs.Product
{
    public class UpdateProductDTO
    {
        public string? Nombre { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
        public Guid? CategoriaId { get; set; }
    }
}
