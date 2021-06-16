using System;

namespace Exercise4
{
    internal class Exercise
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nEnter n: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(x + " " + "x" + " " + i + " " + "=" + " " + (x * i));
            } 
        }
    }
}