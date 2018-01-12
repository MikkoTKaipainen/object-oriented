using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    //Tehty yhteistyössä Timon kanssa
    class Car
    {
        //Fields
        public string Brand;
        public int Speed;

        //Methods
        public void AskData()
        {
            Console.Write("Car Brand: ");
            Brand = Console.ReadLine();
            Console.Write("Car Speed: ");
            Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Your car is: {Brand} \nYour speed is: {Speed}");
        }

        public void ShowCarInfo2()
        {

            Console.WriteLine($"Your car is still: {Brand} \nYour accelerated speed is: {Speed}");
        }

        public void ShowCarInfo3()
        {
            Console.WriteLine($"Your car is yet one more time: {Brand} \nYour decreased speed is : {Speed}");
        }

        public void Accelerate(int speed)
        {
            if (speed >= 0)
            Speed += speed;
        }

        public void Brake()
        {
            Speed = (Speed / 10) * 9;
        }

    }
}
