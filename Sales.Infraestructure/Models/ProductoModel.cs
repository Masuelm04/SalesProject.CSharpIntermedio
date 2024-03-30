namespace Sales.Infraestructure.Models
{
    public class ProductoModel
    {
        public int ProductoId { get; set; }
        public string? CodigoBarra { get; set; }
        public string? Marca { get; set; }
        public int? Stock { get; set; }
        public string? NombreCategoria { get; set; }
    }
}
