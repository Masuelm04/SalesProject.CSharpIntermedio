using Microsoft.Extensions.Logging;
using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;
using Sales.Infraestructure.Models;

namespace Sales.Infraestructure.Dao
{
    public class ProductoDb : DaoBase<Producto>, IProductoDb
    {
        private readonly SalesContext context;
        private readonly ILogger<ProductoDb> logger;
        public ProductoDb(SalesContext context, ILogger<ProductoDb> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }

        public List<ProductoModel> GetProductsByCategoryId(int categoryId)
        {
            List<ProductoModel> products = new List<ProductoModel>();

            try
            {
                products = (from pdt in this.context.Productos
                            join ctg in this.context.Categorias on pdt.IdCategoria equals ctg.Id
                            where pdt.Eliminado == false && ctg.Eliminado == false
                            && pdt.IdCategoria == categoryId
                            orderby pdt.FechaRegistro descending
                            select new ProductoModel()
                            {
                                ProductoId = pdt.Id,
                                CodigoBarra = pdt.CodigoBarra,
                                Marca = pdt.Marca,
                                Stock = pdt.Stock,
                                NombreCategoria = ctg.Descripcion,
                            }).ToList();
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo los productos", ex.ToString());
            }

            return products;
        }

        public async override Task<DataResult> Save(Producto entity)
        {
            return await base.Save(entity);
        }
    }
}
