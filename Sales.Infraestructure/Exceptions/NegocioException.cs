
namespace Sales.Infraestructure.Exceptions
{
    public class NegocioException : Exception
    {
        public NegocioException(string message) : base(message)
        {
            SaveError(message);
        }
        void SaveError(string message)
        {
            Console.WriteLine(message);
        }
    }
}
