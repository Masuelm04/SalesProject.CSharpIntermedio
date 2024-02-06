
namespace Sales.Domain.Entities
{
    public class Categoria : Core.BaseEntity
    {
        public int CategoriaId { get; set; }
        public string? Descripcion { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
