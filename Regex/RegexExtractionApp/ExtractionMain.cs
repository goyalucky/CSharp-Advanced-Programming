/* Regex + Collections
Q8: Valid Phone and Email Extraction
Given a List<string> containing:
random text
numbers
emails
phone numbers
Task:
Extract all valid email IDs using Regex.
Extract all valid Indian phone numbers using Regex.
Store valid emails and valid phones in two separate lists.
Print both lists.
No LINQ. */


using System;
using System.Collections.Generic;

namespace RegexExtractionApp
{
    public class ExtractionMain
    {
        public static void Start()
        {
            List<string> input = DataSource.GetInput();
            List<string> validEmails = new List<string>();
            List<string> validPhones = new List<string>();

            Extractor.Extract(input, validEmails, validPhones);

            Console.WriteLine("Valid Emails:");
            foreach (string email in validEmails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("\nValid Indian Phone Numbers:");
            foreach (string phone in validPhones)
            {
                Console.WriteLine(phone);
            }
        }
    }
}
