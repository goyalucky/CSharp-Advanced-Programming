/* Validate a Social Security Number (SSN)
Example Input: "My SSN is 123-45-6789."
Expected Output:
● ✅ "123-45-6789" is valid
● ❌ "123456789" is invalid */


using System;
using System.Text.RegularExpressions;

public class ValidateSecurityNumber
{
    public static void Start()
    {
        string[] ssns = {
            "123-45-6789",   
            "123456789",     
            "123-456-789",   
            "000-12-3456"    
        };
        foreach (string ssn in ssns)
        {
            Console.WriteLine($"{ssn}" + (IsValidSSN(ssn) ? "Valid" : "Invalid"));
        }
    }

    // validates SSN format 
    static bool IsValidSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        return System.Text.RegularExpressions.Regex.IsMatch(ssn, pattern);
    }
}
