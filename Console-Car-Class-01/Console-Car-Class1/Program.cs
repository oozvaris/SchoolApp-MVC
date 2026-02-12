namespace Console_Car_Class1;

internal class Program
{
    static void Main(string[] args)
    {
        // Create objects from the class
        Car car1 = new Car("Toyota", "Red");
        Car car2 = new Car("BMW", "Black");

        // Use the objects and write to console
        Console.WriteLine("=== Car 1 ===");
        car1.Start();
        car1.Accelerate(30);
        car1.Brake(10);
        car1.Stop();

        Console.WriteLine("\n=== Car 2 ===");
        car2.Start();
        car2.Accelerate(50);
        car1.Accelerate(10);
        car2.Brake(70);
        car1.Brake(10);
        car2.Stop();

        Console.Read();
    }
}
