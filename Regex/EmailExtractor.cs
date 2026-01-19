/* Extract All Email Addresses from a Text
Example Text: "Contact us at support@example.com and info@company.org"
Expected Output:
● support@example.com
● info@company.org */

using System;
using System.Text.RegularExpressions;

public class EmailExtractor
{
    public static void Start()
    {
        // Input text containing emails
        string text = "Contact us at support@example.com and info@company.org";

        // Get all email matches
        string[] emails = ExtractEmails(text);

        // Print extracted emails
        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }
    }

    // Extracts all email addresses from given text
    static string[] ExtractEmails(string text)
    {
        // Regex pattern for email matching
        string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

        // Find all matches using Regex.Matches
        var matches = System.Text.RegularExpressions.Regex.Matches(text, pattern);

        // Store results in array
        string[] result = new string[matches.Count];

        for (int i = 0; i < matches.Count; i++)
        {
            result[i] = matches[i].Value;
        }
        return result;
    }
}
