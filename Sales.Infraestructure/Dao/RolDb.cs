﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class RolDb : IRolDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Rol> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rol GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Rol entity)
        {
            throw new NotImplementedException();
        }
    }
}