/* OOP + Collections + Filtering + Regex
Q1: Employee Filtering Without LINQ
Create an Employee class with:
Id
Name
Department
Email
JoiningDate
Task: Validate Email using Regex.
Store employees in List<Employee>.
Without using LINQ, filter employees: Who joined in the last 6 months Whose Department = “IT” Display the filtered list.Use only loops 
and conditions. */


using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FilterEmployees
{
    public class EmployeeMain
    {
        public static void Start()
        {
            // Collection of employees
        List<Employee> employees = new List<Employee>()
        {
            new Employee(1, "lucky", "IT", "lucky@gmail.com", DateTime.Now.AddMonths(-3)),
            new Employee(2, "abhay", "HR", "abhay@gmail.com", DateTime.Now.AddMonths(-2)),
            new Employee(3, "rishabh", "IT", "rishabh@gmail.com", DateTime.Now.AddMonths(-4)), // Invalid email
            new Employee(4, "sohil", "IT", "sohil@gmail.com", DateTime.Now.AddMonths(-8)),
            new Employee(5, "prashant", "IT", "prashant@gmail.com", DateTime.Now.AddMonths(-1))
        };

        DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);

        Console.WriteLine("Filtered Employees:\n");

        // Filtering without LINQ
        foreach (Employee emp in employees)
        {
            // email validation , Dpartment failure, Last six months joining date
            if (emp.IsValidEmail() && emp.Department == "IT" && emp.JoiningDate >= sixMonthsAgo)
            {
                Console.WriteLine(emp);
            }
        }
        }
    }
}