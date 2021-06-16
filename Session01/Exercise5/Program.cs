using System;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a;
            for (int i = 1; i < 20; i++)
            {
                Console.Write("Giai thua cua {0}  la: {1} \n", i, tinhGiaithua(i));  
                Console.WriteLine();
                Console.ReadKey();
            }
        }
        
        static long tinhGiaithua(int n)
        {
            int i;
            long giai_thua = 1;
            if (n == 0 || n == 1)
            {
                return giai_thua;
            }
            else
            {
                for (i = 2; i <= n; i++)
                {
                    giai_thua *= i;
                }
                return giai_thua;
            }
        }
    }
}