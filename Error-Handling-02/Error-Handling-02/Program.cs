namespace Error_Handling_02
{
    internal class Program
    {
        static void Main()
        {
            int age;

            Console.Write("Please enter your age: ");
            string input = Console.ReadLine(); // Kullanıcıdan giriş al

            // int.TryParse ile girişin geçerli bir tam sayı olup olmadığını kontrol et
            if (int.TryParse(input, out age))
            {
                Console.WriteLine($"Your age is {age}. Validation successful!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
