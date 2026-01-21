using System.Text.RegularExpressions;

namespace RegexExtractionApp
{
    public class RegexHelper
    {
        public static bool IsValidEmail(string input)
        {
            return Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidIndianPhone(string input)
        {
            return Regex.IsMatch(input, @"^[6-9]\d{9}$");
        }
    }
}
