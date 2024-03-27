
namespace Sales.Infraestructure.Exceptions
{
    public class ProductoException : Exception
    {
        public ProductoException(string message) : base(message) 
        {
            SaveError(message);
        }
        void SaveError(string message)
        {
            Console.WriteLine(message);
        }
    }
}
