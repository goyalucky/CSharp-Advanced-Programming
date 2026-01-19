/* Extract Links from a Web Page
Example Text: "Visit https://www.google.com and http://example.org for more info."
Expected Output:
● https://www.google.com, http://example.org */

using System;
using System.Text.RegularExpressions;

public class LinkExtractor
{
    public static void Start()
    {
        // Input text containing links
        string text =
            "Visit https://www.google.com and http://example.org for more info.";

        // Extract all links
        string[] links = ExtractLinks(text);

        // Print extracted links
        foreach (string link in links)
        {
            Console.WriteLine(link);
        }
    }

    // Extracts all URLs from given text
    static string[] ExtractLinks(string text)
    {
        // Pattern: http:// or https:// followed by non-space characters
        string pattern = @"https?:\/\/[^\s]+";

        // Find all matches
        var matches =
            System.Text.RegularExpressions.Regex.Matches(text, pattern);

        // Store results in array
        string[] result = new string[matches.Count];

        for (int i = 0; i < matches.Count; i++)
        {
            result[i] = matches[i].Value;
        }

        return result;
    }
}
