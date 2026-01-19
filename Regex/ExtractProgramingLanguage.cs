/* Extract Programming Language Names from a Text
Example Text: "I love Java, Python, and JavaScript, but I haven't tried Go yet."
Expected Output:
● Java, Python, JavaScript, Go */

using System;
using System.Text.RegularExpressions;

public class ExtractProgramingLanguage
{
    public static void Start()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        // list of languages we want to extract
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";
        // find all matches
        MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(text, pattern);
        // print each found language
        foreach (Match m in matches)
        {
            Console.WriteLine(m.Value);
        }
    }
}