using System;
using System.Linq;

namespace PasswordStrength
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            // Null or empty passwords are invalid
            if (string.IsNullOrEmpty(password))
                return false;

            // Check minimum length
            if (password.Length < 8)
                return false;

            // Check for at least one uppercase letter
            if (!password.Any(char.IsUpper))
                return false;

            // Check for at least one digit
            if (!password.Any(char.IsDigit))
                return false;

            return true;
        }
    }
}
