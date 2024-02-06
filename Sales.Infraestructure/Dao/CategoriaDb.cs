using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class CategoriaDb : ICategoriaDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categoria GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
