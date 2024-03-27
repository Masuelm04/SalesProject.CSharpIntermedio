using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class CategoriaDb : DaoBase<Categoria>, ICategoriaDb
    {
        private readonly SalesContext context;
        public CategoriaDb(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
