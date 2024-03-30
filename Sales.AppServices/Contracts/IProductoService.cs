using Sales.AppServices.Core;

namespace Sales.AppServices.Contracts
{
    public interface IProductoService
    {
        ServiceResult GetProductsByCategoryId(int categoryId);
    }
}
