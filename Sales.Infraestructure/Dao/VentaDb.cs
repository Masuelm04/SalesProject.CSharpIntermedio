using Microsoft.Extensions.Logging;
using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;
using Sales.Infraestructure.Models;
using System.Runtime.InteropServices;

namespace Sales.Infraestructure.Dao
{
    public class VentaDb : DaoBase<Venta>, IVentaDb
    {
        private readonly SalesContext context;
        private readonly ILogger<VentaDb> logger;
        public VentaDb(SalesContext context, ILogger<VentaDb> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }

        public List<TotalSalesByUserModel> TotalSalesByUserId(int userId)
        {
            List<TotalSalesByUserModel> sales = new List<TotalSalesByUserModel>();

            try
            {
                sales = (from sl in this.context.Ventas
                         where sl.IdUsuario == userId
                         group new { sl.IdUsuario } by sl.IdUsuario
                         into myGroup 
                         orderby myGroup descending
                         select new TotalSalesByUserModel()
                         {
                             Vendedor = userId,
                             CantidadVentasRealizadas = myGroup.Count()
                         }).ToList();
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo las ventas", ex.ToString());
            }

            return sales;
        }
        public async override Task<DataResult> Save(Venta entity)
        {
            return await base.Save(entity);
        }
    }
}
