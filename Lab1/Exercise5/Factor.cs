using System;
using System.Text;

namespace Exercise5
{
    public class Factor
    {
        public void ThuaSo()
        {
            int kq=1;
            for (int i = 1; i < 21; i++)
            {
                kq=kq * i;
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine($"Thừa số của số {i} là:{kq}");
            }
            
        }
    }
}