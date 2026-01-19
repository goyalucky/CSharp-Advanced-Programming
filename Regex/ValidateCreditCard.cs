/* Validate a Credit Card Number (Visa, MasterCard, etc.)
● A Visa card number starts with 4 and has 16 digits.
● A MasterCard starts with 5 and has 16 digits. */

using System;
using System.Text.RegularExpressions;

class ValidateCreditCard
{
    public static void Start()
    {
        string[] cards =
        {
            "4123456789012345", 
            "5123456789012345", 
            "6123456789012345", 
            "4234"              
        };
        foreach (string card in cards)
        {
            Console.WriteLine($"{card}  " + (IsValidCard(card) ? "Valid" : "Invalid"));
        }
    }

    // Validates Visa and MasterCard number format
    static bool IsValidCard(string card)
    {
        // starts with 4 or 5, total 16 digits
        string pattern = @"^(4\d{15}|5\d{15})$";
        return System.Text.RegularExpressions.Regex.IsMatch(card, pattern);
    }
}
