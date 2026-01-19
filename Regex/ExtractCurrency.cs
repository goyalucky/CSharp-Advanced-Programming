/* Extract Currency Values from a Text
Example Text: "The price is $45.99, and the discount is $ 10.50."
Expected Output:
● $45.99, 10.50 */


using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    public static void Start()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";

        // Regex pattern for currency
        string pattern = @"\$ ?\d+(\.\d+)?";

        // Find all matches
        MatchCollection matches = System.Text.RegularExpressions.Regex.Matches(text, pattern);

        // Print all extracted currency values
        foreach (Match m in matches)
        {
            // Remove space after $ if any
            Console.WriteLine(m.Value.Replace(" ", ""));
        }
    }
}
