/* Validate a License Plate Number
License plate format: Starts with two uppercase letters, followed by four digits.
Example: "AB1234" is valid, but "A12345" is invalid. */

using System;
using System.Text.RegularExpressions;

public class LicensePlateValidator
{
    public static void Start()
    {
        string[] plates = { "AB1234", "A12345", "XYZ9876"};
        foreach (string i in plates)
        {
            Console.WriteLine($"{i} " + (IsValidLicensePlate(i) ? "Valid" : "Invalid"));
        }
    }
    // Validates license plate format
    static bool IsValidLicensePlate(string i)
    {
        // 2 uppercase letters + 4 digits
        string pattern = @"^[A-Z]{2}[0-9]{4}$";
        return System.Text.RegularExpressions.Regex.IsMatch(i, pattern);
    }
}