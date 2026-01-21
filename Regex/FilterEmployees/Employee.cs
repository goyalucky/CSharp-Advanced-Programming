using System;
using System.Text.RegularExpressions;

namespace FilterEmployees
{
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }

        // Constructor
        public Employee(int id, string name, string department, string email, DateTime joiningDate)
        {
            Id = id;
            Name = name;
            Department = department;
            Email = email;
            JoiningDate = joiningDate;
        }

        // Email validation using Regex
        public bool IsValidEmail()
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(Email, pattern);
        }

        // Display method
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Dept: {Department}, Email: {Email}, Joined: {JoiningDate.ToShortDateString()}";
        }
    }
}
