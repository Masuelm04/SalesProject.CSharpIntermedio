
namespace Sales.Infraestructure.Exceptions
{
    public class CategoriaException : Exception
    {
        public CategoriaException(string message) : base(message) 
        {
            SaveError(message);
        }
        void SaveError(string message)
        {
            Console.WriteLine(message);
        }
    }
}
