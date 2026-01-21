using System.Text.RegularExpressions;

namespace UserRegistrationApp
{
    public class UserValidator
    {
        public static void Validate(User user)
        {
            if (!Regex.IsMatch(user.PhoneNumber, @"^[6-9]\d{9}$"))
                throw new InvalidUserException("Invalid Phone Number");

            if (!Regex.IsMatch(user.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new InvalidUserException("Invalid Email");

            if (!Regex.IsMatch(user.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                throw new InvalidUserException("Invalid Password");
        }
    }
}
