﻿using PruebaTecnicaHexagonal.DTOs.Category;

namespace PruebaTecnicaHexagonal.DTOs.Product
{
    public class ProductDTO
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Guid CategoriaId { get; set; }
        public CategoryDTO Categoria { get; set; }
    }
}