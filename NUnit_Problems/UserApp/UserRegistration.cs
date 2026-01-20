using System;
using System.Text.RegularExpressions;

namespace UserApp
{
    // Handles user registration logic
    public class UserRegistration
    {
        // Registers a user after validating inputs
        public bool Register(string user, string email, string pass)
        {
            // Validate username
            if(string.IsNullOrWhiteSpace(user))
                throw new ArgumentException("Invalid username");

            // Validate email format
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email");

            // Validate password strength
            if (string.IsNullOrWhiteSpace(pass) || pass.Length < 8)
                throw new ArgumentException("Invalid password");

            // If all validations pass, registration succeeds
            return true;
        }
    }
}
