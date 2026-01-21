/* OOP + Dictionary + Regex
Q10: Student Scoreboard With Dictionary
Create class Student:
Roll
Name
Subject
Marks
Task:
Store students in a Dictionary<string, List<Student>> where key = subject.
Insert student details based on subject.
For each subject:
Find top scorer (manual loop)
Validate Name using Regex (only alphabets allowed). */


using System;
using System.Collections.Generic;

namespace StudentScoreboardApp
{
    public class StudentMain
    {
        public static void Start()
        {
            Dictionary<string, List<Student>> scoreboard =
                new Dictionary<string, List<Student>>();

            AddStudent(scoreboard, new Student { Roll = 1, Name = "Rahul", Subject = "Math", Marks = 85 });
            AddStudent(scoreboard, new Student { Roll = 2, Name = "Neha", Subject = "Math", Marks = 92 });
            AddStudent(scoreboard, new Student { Roll = 3, Name = "Aman", Subject = "Science", Marks = 88 });
            AddStudent(scoreboard, new Student { Roll = 4, Name = "Priya", Subject = "Science", Marks = 91 });

            Console.WriteLine("\nTop Scorers:\n");

            foreach (string subject in scoreboard.Keys)
            {
                Student top = GetTopScorer(scoreboard[subject]);
                Console.WriteLine($"Subject: {subject}");
                top.Display();
                Console.WriteLine();
            }
        }

        static void AddStudent(Dictionary<string, List<Student>> dict, Student s)
        {
            if (!NameValidator.IsValid(s.Name))
            {
                Console.WriteLine("Invalid Name: " + s.Name);
                return;
            }

            if (!dict.ContainsKey(s.Subject))
            {
                dict[s.Subject] = new List<Student>();
            }
            dict[s.Subject].Add(s);
        }

        static Student GetTopScorer(List<Student> students)
        {
            Student top = students[0];
            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].Marks > top.Marks)
                {
                    top = students[i];
                }
            }
            return top;
        }
    }
}
