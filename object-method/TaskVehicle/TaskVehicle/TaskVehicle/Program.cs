using System;

namespace TaskVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car();
            Console.WriteLine(vehicle1.PrintVehicleInfo());

            Car car1 = new Car();
            Console.WriteLine(car1.PrintVehicleInfo());

            Lorry lorry = new Lorry();
            Console.WriteLine(lorry.PrintVehicleInfo());

            Car car2 = (Car) lorry;
            Console.WriteLine(car2.PrintVehicleInfo());

            Console.WriteLine($"Press any key to exit...");
            Console.ReadKey();
        }
    }
}
