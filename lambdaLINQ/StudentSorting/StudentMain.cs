/* Sorting + Comparer + OOP
Q7: Student Sorting Without LINQ
Create a Student class:
RollNo
Name
Marks
Task: Store students in a List<Student>.
Sort: First by Marks (descending)
If tie → Name (ascending)
Print sorted list. Use IComparer<Student> or lambda */



using System;
using System.Collections.Generic;

namespace StudentSorting
{
    public class StudentMain
    {
        public static void Start()
        {
            List<Student> students = new List<Student>()
        {
            new Student(101, "lucky", 85),
            new Student(102, "rishabh", 92),
            new Student(103, "abhay", 85),
            new Student(104, "prashant", 78),
            new Student(105, "sohil", 92)
        };

        // Sorting using IComparer (No LINQ)
        students.Sort(new StudentComparer());

        Console.WriteLine("Sorted Student List:");
        foreach (Student s in students)
        {
            Console.WriteLine(s);
        }
        }
    }
}