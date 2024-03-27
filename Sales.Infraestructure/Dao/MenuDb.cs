using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class MenuDb : DaoBase<Menu>, IMenuDb
    {
        private readonly SalesContext context;
        public MenuDb(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
