using System.Collections.Generic;

namespace RegexExtractionApp
{
    public class DataSource
    {
        public static List<string> GetInput()
        {
            return new List<string>
            {
                "hello world",
                "9876543210",
                "test@gmail.com",
                "invalid@email",
                "12345",
                "contact@company.in",
                "9123456789",
                "email@.com",
                "hello@domain.com",
                "5678901234"
            };
        }
    }
}
