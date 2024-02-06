
namespace Sales.Infraestructure.Exceptions
{
    public class VentaException : Exception
    {
        public VentaException(string message) : base(message) 
        {
            SaveError(message);
        }
        void SaveError(string message)
        {

        }
    }
}
