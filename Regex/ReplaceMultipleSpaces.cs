/* Replace Multiple Spaces with a Single Space
Example Input: "This is an example with multiple spaces."
Expected Output: "This is an example with multiple spaces." */


using System;
using System.Text.RegularExpressions;

public class ReplaceMultipleSpaces
{
    public static void Start()
    {
         string s = "This   is   an   example   with   multiple   spaces.";
         // Replace multiple spaces with a single space
        string output = System.Text.RegularExpressions.Regex.Replace(s, @"\s+", " ");
        Console.WriteLine(output);
    }
}