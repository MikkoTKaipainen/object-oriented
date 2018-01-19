using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Position;
        public int Salary;

        public void EmployeeInfo()
        {
            Name = "Jorma";
            Id = 101;
            Position = "Boss";
            Salary = 10000;
        }

        public void CompareSalary()
        {
            
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"{Name} \n" +
                $"{Id} \n" +
                $"{Position} \n" +
                $"{Salary}");
        }


    }
}
