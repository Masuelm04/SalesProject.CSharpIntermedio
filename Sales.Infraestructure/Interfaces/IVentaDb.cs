using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Models;

namespace Sales.Infraestructure.Interfaces
{
    public interface IVentaDb : IDaoBase<Venta>
    {
        List<TotalSalesByUserModel> TotalSalesByUserId(int userId);
    }
}
