﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class RolMenuDb : IRolMenuDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<RolMenu> GetAll()
        {
            throw new NotImplementedException();
        }

        public RolMenu GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(RolMenu entity)
        {
            throw new NotImplementedException();
        }
    }
}
