using System;

namespace TaskCar
        //Tehty yhteistyössä Timon kanssa
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car1.AskData();
            car2.AskData();
            car3.AskData();
            Console.WriteLine();
            car1.ShowCarInfo();
            car2.ShowCarInfo();
            car3.ShowCarInfo();
            Console.WriteLine();
            car1.Accelerate(100);
            car2.Accelerate(100);
            car3.Accelerate(100);
            Console.WriteLine();
            car1.ShowCarInfo2();
            car2.ShowCarInfo2();
            car3.ShowCarInfo2();
            Console.WriteLine();
            car1.Brake();
            car2.Brake();
            car3.Brake();
            Console.WriteLine();
            car1.ShowCarInfo3();
            car2.ShowCarInfo3();
            car3.ShowCarInfo3();

            Console.ReadKey();
        }
    }
}
