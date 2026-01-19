/* Censor Bad Words in a Sentence
Given a list of bad words, replace them with ****.
Example Input: "This is a damn bad example with some stupid words."
Expected Output: "This is a **** bad example with some **** words." */

using System;
using System.Text.RegularExpressions;
class CensorBadWords
{
    public static void Start()
    {
        string text = "This is a damn bad example with some stupid words.";

        // Bad words list
        string[] badWords = { "damn", "stupid" };

        // Build regex pattern from bad words
        string pattern = @"\b(" + string.Join("|", badWords) + @")\b";

        // Replace bad words with ****
    string result = System.Text.RegularExpressions.Regex.Replace(text,pattern,"****", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        Console.WriteLine(result);
    }
}
