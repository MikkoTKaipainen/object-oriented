using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Jorma",1001,"Boss",3000);
            employees[1] = new Employee("Ursula",1002,"Programmer",2800);
            employees[2] = new Employee("Kake",1003,"Recruit",1000);

            for (int i = 0; i < employees.Length; i++)
                employees[i].PrintEmployeeInfo();

            employees[0].CompareSalary(employees[1]);
            employees[1].CompareSalary(employees[2]);
            employees[0].CompareSalary(employees[2]);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
