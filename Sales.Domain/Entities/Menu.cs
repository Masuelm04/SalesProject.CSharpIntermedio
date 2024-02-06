
namespace Sales.Domain.Entities
{
    public class Menu : Core.BaseEntity
    {
        public int MenuId { get; set; }
        public string? Descripcion { get; set; }
        public int? IdMenuPadre { get; set; }
        public string? Icono { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
        public List<RolMenu> RolMenus { get; set; } = new List<RolMenu>();
    }
}
