﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class NegocioDb : INegocioDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Negocio> GetAll()
        {
            throw new NotImplementedException();
        }

        public Negocio GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Negocio entity)
        {
            throw new NotImplementedException();
        }
    }
}