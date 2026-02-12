using System.Text.RegularExpressions;

namespace RegularExpressions_02_Password
{
    internal class Program
    {
        static void Main()
        {
            string password;

            // Ask user for password input
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Password is invalid. It must meet the following criteria:");
            Console.WriteLine("- At least 8 characters long");
            Console.WriteLine("- Contains at least one lowercase letter");
            Console.WriteLine("- Contains at least one uppercase letter");
            Console.WriteLine("- Contains at least one number");
            Console.WriteLine("- Contains at least one special character (e.g., @$!%*?&)");
            Console.Write("Enter a password: ");
            password = Console.ReadLine();

            // Regular Expression for password validation
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must meet the following criteria:");
                Console.WriteLine("- At least 8 characters long");
                Console.WriteLine("- Contains at least one lowercase letter");
                Console.WriteLine("- Contains at least one uppercase letter");
                Console.WriteLine("- Contains at least one number");
                Console.WriteLine("- Contains at least one special character (e.g., @$!%*?&)");
            }
        }
    }
}
