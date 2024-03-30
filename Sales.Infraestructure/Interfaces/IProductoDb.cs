using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Models;

namespace Sales.Infraestructure.Interfaces
{
    public interface IProductoDb : IDaoBase<Producto>
    {
        List<ProductoModel> GetProductsByCategoryId(int categoryId);
    }
}
