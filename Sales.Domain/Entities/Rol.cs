
namespace Sales.Domain.Entities
{
    public class Rol : Core.BaseEntity
    {
        public int RolId { get; set; }
        public string? Descripcion { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public List<RolMenu> RolMenus { get; set; } = new List<RolMenu>();
    }
}
