/* Validate a Hex Color Code
A valid hex color:
● Starts with a #
● Followed by 6 hexadecimal characters (0-9, A-F, a-f). */

using System;
using System.Text.RegularExpressions;

public class HexColorValidator
{
    public static void Start()
    {
        // sample color codes
        string[] colors = {"#FFA500","#ff4500","#123"};
        foreach (string color in colors)
        {
            Console.WriteLine($"{color} " + (IsValidHexColor(color) ? "Valid" : "Invalid"));
        }
    }
    
    // Validates hex color format
    static bool IsValidHexColor(string color)
    {
        // # + 6 hexadecimal characters
        string pattern = @"^#[0-9A-Fa-f]{6}$";
        return System.Text.RegularExpressions.Regex.IsMatch(color, pattern);
    }
}