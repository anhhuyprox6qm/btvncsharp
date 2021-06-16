using System;
using System.Text;

namespace Ex2
{
    internal class Ex2
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập 3 số nguyên để tìm số lớn nhất:");
            Console.WriteLine("Nhập số thứ 1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ 2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ 3:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a>c)
                {
                    Console.WriteLine("Số thứ 1 là số lớn nhất trong 3 số!");
                }
                else
                {
                    Console.WriteLine("Số thứ 3 là số lớn nhất trong 3 số!");
                }
            }
            else if (b > c)

                Console.WriteLine("Số thứ 2 là số lớn nhất trong 3 số!");
            else
                Console.WriteLine("Số thứ 3 là số lớn nhất trong 3 số!");
            Console.ReadKey();
        }
    }
}