using System;

namespace SalesWebMvc.Services.Excption
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message) { }
    }
}
