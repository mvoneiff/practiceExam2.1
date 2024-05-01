using System;
namespace PracticeFinal
{
    public class InvalidPropertyValueException : Exception
    {
        public InvalidPropertyValueException(string message) : base(message)
        {
        }
    }
}

