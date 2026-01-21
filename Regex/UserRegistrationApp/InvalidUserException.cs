using System;

namespace UserRegistrationApp
{
    public class InvalidUserException : Exception
    {
        public InvalidUserException(string message) : base(message)
        {
        }
    }
}
