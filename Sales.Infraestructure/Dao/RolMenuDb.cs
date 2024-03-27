﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class RolMenuDb : DaoBase<RolMenu>, IRolMenuDb
    {
        private readonly SalesContext context;
        public RolMenuDb(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
