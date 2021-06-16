using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter first name:");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter last name:");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Please enter address:");
            employee.Address = Console.ReadLine();
            Console.WriteLine("Please enter sin:");
            employee.Sin = long.Parse(Console.ReadLine());
            Console.WriteLine("Please enter salary:");
            employee.Salary = double.Parse(Console.ReadLine());
            employee.ToString();
            double a = double.Parse(Console.ReadLine());
            employee.Bonus(a);
        }
    }
}   