namespace Error_Handling_01
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int num = 10;
                int result = num / 0; // This will cause a divide by zero error
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message); // Handle the error
            }
            finally
            {
                Console.WriteLine("This will run regardless of whether an error occurred or not.");
            }
        }

    }
}
