/* Extract All Capitalized Words from a Sentence
Example Text: "The Eiffel Tower is in Paris and the Statue of Liberty is in New York."
Expected Output:
● Eiffel, Tower, Paris, Statue, Liberty, New, York */

using System;
using System.Text.RegularExpressions;

public class CapitalizedWordExtractor
{
    public static void Start()
    {
        // Input sentence
        string text ="The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        // Extract capitalized words
        string[] words = ExtractCapitalizedWords(text);

        // Print result
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    // Extracts words that start with a capital letter
    static string[] ExtractCapitalizedWords(string text)
    {
        // Pattern: word starting with capital letter
        string pattern = @"\b[A-Z][a-z]*\b";

        // Find all matches
        var matches = System.Text.RegularExpressions.Regex.Matches(text, pattern);

        // Store matches in array
        string[] result = new string[matches.Count];

        for (int i = 0; i < matches.Count; i++)
        {
            result[i] = matches[i].Value;
        }

        return result;
    }
}
