using System;
using System.Text;

namespace Exercise4
{
    public class Multiples
    {
        public void BoiSo()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập 1 số nguyên: ");
            var so = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hiển thị 9 bội số đầu tiên:");
            for (int i = 1; i < 10; i++)
            {
                var kq = so * i;
                Console.WriteLine($"{so}*{i}={kq}");
            }
        }
    }
}