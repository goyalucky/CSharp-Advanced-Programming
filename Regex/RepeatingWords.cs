/* Find Repeating Words in a Sentence
Example Input: "This is is a repeated repeated word test."
Expected Output:
● is, repeated */

using System;
using System.Text.RegularExpressions;

public class RepeatingWords
{
    public static void Start()
    {
        string text = "This is is a repeated repeated word test.";

        // Pattern to find consecutive repeating words
        string pattern = @"\b(\w+)\s+\1\b";

        // Find matches
        MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(text, pattern);

        Console.WriteLine("Repeating words:");
        foreach (Match m in matches)
        {
            Console.WriteLine(m.Groups[1].Value);
        }
    }
}
