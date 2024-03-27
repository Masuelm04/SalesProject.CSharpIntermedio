using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class UsuarioDb : DaoBase<Usuario>, IUsuarioDb
    {
        private readonly SalesContext context;
        public UsuarioDb(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
