﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class VentaDb : IVentaDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Venta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Venta GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Venta entity)
        {
            throw new NotImplementedException();
        }
    }
}
