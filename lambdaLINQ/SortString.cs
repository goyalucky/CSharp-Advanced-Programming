using System;
using System.Collections.Generic;
using System.Linq;

public class SortString
{
    public static void Start()
    {
        /* use of a lambda expression within the LINQ OrderBy method to sort a list of strings based on their length in ascending order. 
The resulting sorted list is then printed to the console. */

        List<string> words = new List<string>{"apple", "kiwi", "banana", "guava", "grape" };
        var sortedWords = words.OrderBy(w => w.Length);
        foreach (var word in sortedWords)
        Console.WriteLine(word);
        Console.WriteLine();
    }
}