using System;

namespace ReferenceRype
{
    internal class ReferenceType
    {
        public int valueVal;
        
        public static void Main(string[] args)
        {
            ReferenceType refer = new ReferenceType();
            refer.valueVal = -5;
            Test(refer);
            Console.WriteLine("the value of the varibale is {0}",refer.valueVal);
            Console.WriteLine();
            
        }

        public static void Test(ReferenceType refer)
        {
            int temp = 5;
            refer.valueVal = temp * 2;
        }
    }
}