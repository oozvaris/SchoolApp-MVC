namespace Validation_Error_Handling_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("\nEnter Student ID:");
                // int studentID = Convert.ToInt32(Console.ReadLine());

                // Check if input is a valid number
                int studentID;
                if (!int.TryParse(Console.ReadLine(), out studentID))
                {
                    throw new ArgumentException("Student ID must be a number.");
                }

                Console.WriteLine("Enter Student Name:");
                string studentName = Console.ReadLine();

                // Check if name exceeds 10 characters
                if (studentName.Length > 10)
                {
                    throw new ArgumentException("Student Name must not exceed 10 characters.");
                }

                Console.WriteLine("\nValidation successful!");
                Console.WriteLine("\nStudent Information:");
                Console.WriteLine(String.Format("Student ID: {0}, Student Name: {1}", studentID, studentName));

            }
            catch (Exception ex)
            {
                // Catch any validation errors and show the error message
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
