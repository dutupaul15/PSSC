using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    internal class InvalidCodeException : Exception
    {
        public InvalidCodeException()
        {
        }

        public InvalidCodeException(string? message) : base(message)
        {
            Console.WriteLine(message);
        }

        public InvalidCodeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
