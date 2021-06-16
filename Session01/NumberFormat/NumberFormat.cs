using System;

namespace NumberFormat
{
    internal class NumberFormat
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("curency formating - {0:c}   {1:c}",88.8, 888.8);
            Console.WriteLine("Interger formatting - {0:D5}",88);
            Console.WriteLine("Exponential formatting -{0:E}", 888.88);
            Console.WriteLine("Fixed-point formatting - {0:F3}",888.8888);
            Console.WriteLine("General formating - {0:G}", 888.8888);
            Console.WriteLine("Number formating -{0:N}", 888888.8);
            Console.WriteLine("Hexadecimal formating - {0:X4}", 88);
        }
    }
}