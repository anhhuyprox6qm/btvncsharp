using System;

namespace DataTimeFormat
{
    internal class DataTimeFormat
    {
        public static void Main(string[] args)
        {
            DataTime dt = DataTime.Now; //obtain curent time

            Console.WriteLine("d format: {0:d}", dt);
            Console.WriteLine("D format: {0:D}", dt);

            Console.WriteLine("t format: {0:t}", dt);
            Console.WriteLine("T format: {0:T}", dt);

            Console.WriteLine("f format: {0:f}", dt);
            Console.WriteLine("F format: {0:F}", dt);

            Console.WriteLine("g format: {0:g}", dt);
            Console.WriteLine("G format: {0:G}", dt);

            Console.WriteLine("m format: {0:m}", dt);
            Console.WriteLine("M format: {0:M}", dt);

            Console.WriteLine("r format: {0:r}", dt);
            Console.WriteLine("R format: {0:M}", dt);

            Console.WriteLine("s format: {0:s}", dt);
            Console.WriteLine("S format: {0:D}", dt);

            Console.WriteLine("u format: {0:u}", dt);
            Console.WriteLine("U format: {0:u}", dt);

            Console.WriteLine("y format: {0:y}", dt);
            Console.WriteLine("Y format: {0:Y}", dt);

        }
    }
}