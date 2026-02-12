using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Car_Class1
{
    public class Car
    {
        // Properties (data)
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Speed { get; private set; }

        // Constructor
        public Car(string brand, string color)
        {
            Brand = brand;
            Color = color;
            Speed = 0;
        }

        // Methods (behavior)
        public void Start()
        {
            Console.WriteLine($"{Brand} ({Color}) is starting...");
        }

        public void Accelerate(int amount)
        {
            Speed += amount;
            Console.WriteLine($"{Brand} accelerated by {amount}. Speed = {Speed} km/h");
        }

        public void Brake(int amount)
        {
            Speed -= amount;
            if (Speed < 0) Speed = 0;
            Console.WriteLine($"{Brand} braked by {amount}. Speed = {Speed} km/h");
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine($"{Brand} stopped. Speed = {Speed} km/h");
        }
    }

}
