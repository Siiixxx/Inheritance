using Inheritance.Entities;
using System;
using System.ComponentModel;
using System.Globalization;

namespace Inheritance
{

    class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the numbers of employee:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double charge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, value, charge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, value));
                }       

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);

            }


        }
    }
}