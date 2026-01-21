using System.Text.RegularExpressions;

namespace StudentScoreboardApp
{
    public class NameValidator
    {
        public static bool IsValid(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z ]+$");
        }
    }
}
