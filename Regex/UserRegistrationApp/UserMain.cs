/* OOP + Custom Exception + Regex
Q5: User Registration System
Create a User class:
UserId
Name
PhoneNumber
Email
Password
Task:
Validate:
Phone using Regex (starts with 6–9, 10 digits)
Email using Regex
Password using Regex: At least 1 uppercase, 1 lowercase, 1 number, min length 8
Throw a Custom Exception if validation fails.Store valid users in List<User>. */


using System;
using System.Collections.Generic;

namespace UserRegistrationApp
{
   public class UserMain
    {
      public static void Start()
        {
            List<User> users = new List<User>();
            User user = new User
            {
                UserId = 1,
                Name = "Lucky",
                PhoneNumber = "9876543210",
                Email = "lucky@gmail.com",
                Password = "Pass1234"
            };

            try
            {
                UserValidator.Validate(user);
                users.Add(user);
                Console.WriteLine("User Registered Successfully\n");
            }
            catch (InvalidUserException ex)
            {
                Console.WriteLine("Registration Failed: " + ex.Message);
            }

            Console.WriteLine("Valid Users:\n");
            foreach (User u in users)
            {
                u.Display();
            }
        }
    }
}
