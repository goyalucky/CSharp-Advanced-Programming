using System.Collections.Generic;

namespace RegexExtractionApp
{
    public class Extractor
    {
        public static void Extract(
            List<string> source,
            List<string> emails,
            List<string> phones)
        {
            foreach (string item in source)
            {
                if (RegexHelper.IsValidEmail(item))
                {
                    emails.Add(item);
                }
                else if (RegexHelper.IsValidIndianPhone(item))
                {
                    phones.Add(item);
                }
            }
        }
    }
}
