using System;

namespace Laba8
{
    public class UnderflowException : Exception
    {
        public UnderflowException(string message) : base(message){}
    }
}