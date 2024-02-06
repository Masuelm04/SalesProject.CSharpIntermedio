using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class TipoDocumentoVentaDb : ITipoDocumentoVentaDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<TipoDocumentoVenta> GetAll()
        {
            throw new NotImplementedException();
        }

        public TipoDocumentoVenta GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(TipoDocumentoVenta entity)
        {
            throw new NotImplementedException();
        }
    }
}
