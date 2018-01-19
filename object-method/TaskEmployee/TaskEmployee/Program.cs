using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.PrintEmployeeInfo();

            Employee[] employees = new Employee[3];
            employees[0] = new Employee();
            employees[1] = new Employee();
            employees[2] = new Employee();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
