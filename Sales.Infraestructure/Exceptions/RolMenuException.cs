
namespace Sales.Infraestructure.Exceptions
{
    public class RolMenuException : Exception
    {
        public RolMenuException(string message) : base(message) 
        {
            SaveError(message);
        }
        void SaveError(string message)
        {
            Console.WriteLine(message);
        }
    }
}
