using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class TipoDocumentoVentaDb : DaoBase<TipoDocumentoVenta>, ITipoDocumentoVentaDb
    {
        private readonly SalesContext context;
        public TipoDocumentoVentaDb(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
