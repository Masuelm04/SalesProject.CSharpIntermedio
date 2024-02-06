
namespace Sales.Infraestructure.Exceptions
{
    public class UsuarioException : Exception
    {
        public UsuarioException(string message) : base(message)
        {
            SaveError(message);
        }
        void SaveError(string message)
        {

        }
    }
}
