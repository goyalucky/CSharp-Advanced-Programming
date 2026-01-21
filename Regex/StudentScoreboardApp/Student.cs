using System;

namespace StudentScoreboardApp
{
    public class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Roll} | {Name} | {Subject} | {Marks}");
        }
    }
}
