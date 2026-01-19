using System;
using System.Collections.Generic; 

namespace StudentSorting
{
    public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        // Sort by Marks (Descending)
        int markCompare = y.Marks.CompareTo(x.Marks);
        if (markCompare != 0)
            return markCompare;

        // If Marks are same  Sort by Name (Ascending)
        return x.Name.CompareTo(y.Name);
    }
}
}