﻿
namespace Sales.Infraestructure.Exceptions
{
    public class TipoDocumentoVentaException : Exception
    {
        public TipoDocumentoVentaException(string message) : base(message)
        {
            SaveError(message);
        }
        void SaveError(string message)
        {

        }
    }
}
