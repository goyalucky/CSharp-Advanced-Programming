/* Extract Dates in dd/mm/yyyy Format
Example Text: "The events are scheduled for 12/05/2023, 15/08/2024, and
29/02/2020."
Expected Output:
● 12/05/2023, 15/08/2024, 29/02/2020 */

using System;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public static void Start()
    {
        // Input text containing dates
        string text ="The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

        // Extract all matching dates
        string[] dates = ExtractDates(text);

        // Print extracted dates
        foreach (string date in dates)
        {
            Console.WriteLine(date);
        }
    }

    // Extracts dates in dd/mm/yyyy format
    static string[] ExtractDates(string text)
    {
        // Pattern: dd/mm/yyyy
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

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
