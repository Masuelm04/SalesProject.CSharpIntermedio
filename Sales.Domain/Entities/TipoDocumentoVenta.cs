
namespace Sales.Domain.Entities
{
    public class TipoDocumentoVenta : Core.BaseEntity
    {
        public int TipoDocumentoVentaId { get; set; }
        public string? Descripcion { get; set; }
        public List<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
