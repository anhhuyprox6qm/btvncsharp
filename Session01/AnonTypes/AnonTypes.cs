using System;

namespace AnonTypes
{
    internal class AnonTypes
    {
        public static void Main(string[] args)
        {
            var pl = new {Name = " A", Price = 3};
            Console.WriteLine("Name = {0}\nPrice = {1}",pl.Name.ToLower(),pl.Price);
            Console.ReadLine();
        }
    }
}