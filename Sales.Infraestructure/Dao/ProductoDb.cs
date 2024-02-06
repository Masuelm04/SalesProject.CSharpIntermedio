using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class ProductoDb : IProductoDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Producto GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
