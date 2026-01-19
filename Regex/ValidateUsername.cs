/* Validate a Username
A valid username:
● Can only contain letters (a-z, A-Z), numbers (0-9), and underscores (_)
● Must start with a letter
● Must be between 5 to 15 characters long */


using System;
using System.Text.RegularExpressions;

public class ValidateUsername
{
    public static void Start()
    {
        // Sample usernames
        string[] usernames = { "user_123", "123user", "us" };

        // Validate each username
        foreach (string username in usernames)
        {
            Console.WriteLine(
                $"{username} " + (IsValidUserName(username) ? "Valid" : "Invalid")
            );
        }
    }

    // Checks if username follows all rules
    static bool IsValidUserName(string username)
    {
        // Regex pattern for username validation
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";
        return System.Text.RegularExpressions.Regex.IsMatch(username, pattern);
    }
}
