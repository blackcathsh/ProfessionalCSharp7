using System;

namespace BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("", 20000),
                new Employee("", 10000),
                new Employee("", 25000),
                new Employee("", 1000000.38m),
                new Employee("", 23000),
                new Employee("", 50000)
            };

            BubbleSorter.Sort(employees, Employee.CompareSalary);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
