using System;

namespace TaskVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            Console.WriteLine(vehicle1.PrintVehicleInfo());

            Car car1 = new Car();
            Console.WriteLine(car1.PrintVehicleInfo());
            Console.WriteLine($"Press any key to exit...");
            Console.ReadKey();
        }
    }
}
