﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class RolDb : DaoBase<Rol>, IRolDb
    {
        private readonly SalesContext context;
        public RolDb(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
