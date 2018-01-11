using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personMikko = new Person();
            personMikko.Name = "Mikko K";
            personMikko.GrowOld();
            personMikko.GrowOld(24);
            Console.WriteLine($"Mikon ikä: {personMikko.GetAge()}");
            personMikko.PrintPersonInfo();


            Person newPerson = new Person("Johnson MacDickfield", 89);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();
        }
    }
}
