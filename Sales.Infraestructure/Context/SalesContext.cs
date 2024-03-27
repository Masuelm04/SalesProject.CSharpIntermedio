using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entities;

namespace Sales.Infraestructure.Context
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) 
        {
            
        }

        #region "DbSet"
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Configuracion>? Configuracions { get; set; }
        public DbSet<DetalleVenta>? DetalleVentas { get; set; }
        public DbSet<Menu>? Menus { get; set; }
        public DbSet<Negocio>? Negocios { get; set; }
        public DbSet<NumeroCorrelativo>? NumeroCorrelativos { get; set; }
        public DbSet<Producto>? Productos { get; set; }
        public DbSet<Rol>? Rols { get; set; }
        public DbSet<RolMenu>? RolMenus { get; set; }
        public DbSet<TipoDocumentoVenta>? TipoDocumentoVentas { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Venta>? Ventas { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
