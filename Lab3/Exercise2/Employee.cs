using System;
using System.Text;

namespace Exercise2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }

        public virtual void ToString()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName} Address: {Address} Sin: {Sin} Salary: {Salary} $");
        }

        public void Bonus(double percentage)
        {
            Console.WriteLine($"Bonus = {Salary * percentage}");
        }

        public virtual double CalculBonus()
        {
            throw new NotImplementedException();
        }

        public virtual void CalculateVacation()
        {
            throw new NotImplementedException();
        }
    }
}