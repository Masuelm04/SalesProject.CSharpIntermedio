
namespace Sales.Infraestructure.Exceptions
{
    public class RolException : Exception
    {
        public RolException(string message) : base(message)
        {
            SaveError(message);
        }
        void SaveError(string message)
        {

        }
    }
}
