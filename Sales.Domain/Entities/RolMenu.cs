
namespace Sales.Domain.Entities
{
    public class RolMenu : Core.BaseEntity
    {
        public int RolMenuId { get; set; }
        public int? IdRol { get; set; }
        public int? IdMenu { get; set; }
    }
}
