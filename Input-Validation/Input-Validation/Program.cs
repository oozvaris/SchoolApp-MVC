namespace Input_Validation
{
    class Program
    {
        static void Main()
        {
            string email;
            int age;

            // Input Validation for Email
            Console.Write("Enter your email: ");
            email = Console.ReadLine();

            if (!IsValidEmail(email))
            {
                Console.WriteLine("Invalid email format. Please try again.");
            }
            else
            {
                // Input Validation for Age
                Console.Write("Enter your age: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out age) )
                {
                    Console.WriteLine($"Your age is {age}. Validation successful!");
                }
                else
                {
                    Console.WriteLine("Invalid age. ");
                }
            }

            Console.ReadLine();
        }

        // Email Validation Method using Regular Expression
        static bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }
    }
}
