using System;

namespace UserRegistrationApp
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Display()
        {
            Console.WriteLine($"{UserId} | {Name} | {PhoneNumber} | {Email}");
        }
    }
}
