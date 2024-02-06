using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class UsuarioDb : IUsuarioDb
    {
        public bool Exists(string name)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public DataResult Save(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
