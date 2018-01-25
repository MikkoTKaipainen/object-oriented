using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        public string Name;
        int Id;
        public string Position;
        int Salary;

        public Employee(string name, int id, string position, int salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        public void CompareSalary(Employee person)
        {
            if (Salary < person.Salary)
                Console.WriteLine($"{person.Name}'s salary is larger than {Name}'s salary");
            else
                Console.WriteLine($"{Name}'s salary is larger than {person.Name}'s salary");
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name} \n" +
                $"Id: {Id} \n" +
                $"Position: {Position} \n" +
                $"Salary: {Salary}");
        }


    }
}
