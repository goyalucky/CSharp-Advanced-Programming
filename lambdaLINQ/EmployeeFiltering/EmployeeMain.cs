using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeFiltering
{
   public class EmployeeMain
    {
        public static void Start()
        {
            /* Given a collection of objects representing employees with properties like Name, Department, and JoiningDate, use a lambda expression 
to filter employees who joined in the last six months and are from a specific department. */

            // Sample employee list
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Lucky", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-2) },
                new Employee { Name = "Rishabh", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-4) },
                new Employee { Name = "Abhay", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-8) },
                new Employee { Name = "Prashant", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-1) },
                new Employee { Name = "jaykant", Department = "Finance", JoiningDate = DateTime.Now.AddMonths(-3) }
            };

            // Filter criteria
            string targetDepartment = "IT";
            DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);

            // Lambda expression to filter employees
            var filteredEmployees = employees.Where(e => e.Department == targetDepartment && e.JoiningDate >= sixMonthsAgo).ToList();

            // Display results
            Console.WriteLine($"Employees from {targetDepartment} department who joined in last 6 months:\n");
            
            if (filteredEmployees.Count == 0)
            {
                Console.WriteLine("No employees found.");
            }
            else
            {
                foreach (var emp in filteredEmployees)
                {
                    Console.WriteLine($"Name: {emp.Name}, Department: {emp.Department}, Joining Date: {emp.JoiningDate:dd-MM-yyyy}");
                }
            }
            Console.ReadLine(); // Keeps console open
        }
    }
}