using System;

namespace ValueType
{
    internal class ValueType
    {
        public static void Main(string[] args)
        {
            int valuaVal = 5;

            Test(valuaVal);
            Console.WriteLine(" The value of variable is {0}",valuaVal);
            Console.WriteLine();
        }

        static void Test(int valueVal)
        {
            int temp = 5;
            valueVal = temp * 2;
        }
    }
}