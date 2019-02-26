using System;

namespace SalesWebMvc.Services.Excption
{
    public class NotFountException : ApplicationException
    {
        public NotFountException(string message) : base(message) { }
    }
}
