using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main()
        {
            // string email = "test@example.com";

            string email = Console.ReadLine() ?? string.Empty;

            // Regular Expression for validating email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }
        }
    }
}
