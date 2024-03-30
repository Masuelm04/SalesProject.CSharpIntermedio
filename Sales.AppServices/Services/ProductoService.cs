using Microsoft.Extensions.Logging;
using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.AppServices.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoDb productoDb;
        private readonly ILogger<ProductoService> logger;
        public ProductoService(IProductoDb productoDb, ILogger<ProductoService> logger)
        {
            this.productoDb = productoDb;
            this.logger = logger;
        }
        public ServiceResult GetProductsByCategoryId(int categoryId)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.productoDb.GetProductsByCategoryId(categoryId);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error obteniendo los productos";
                this.logger.LogError(ex, result.Message);
            }

            return result;
        }
    }
}
