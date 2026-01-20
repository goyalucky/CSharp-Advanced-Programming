using System;

namespace StringUtilsApp
{
    public class StringUtils
    {
        //reverses the string
        public string Reverse(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));

            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Checks whether a string is a palindrome
        public bool IsPalindrome(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));

            string reversed = Reverse(str);
            //  Compare original and reversed (ignoring case)
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Converts a string to uppercase
        public string ToUpperCase(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));
            return str.ToUpper();
        }
    }
}
