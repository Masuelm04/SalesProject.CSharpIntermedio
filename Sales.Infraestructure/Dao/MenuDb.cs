﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class MenuDb : IMenuDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public Menu GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Menu entity)
        {
            throw new NotImplementedException();
        }
    }
}