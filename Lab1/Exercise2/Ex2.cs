using System;
using System.Text;

namespace Exercise2
{
    public class Ex2
    {
        public static void Main(string[] args)
        {
        int a, b, c;
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập số thứ 1:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số thứ 2:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số thứ 3:");
        c = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Số thứ 1 lớn nhất trong 3 số!");
            }
            else
            {
                Console.WriteLine("Số thứ 3 lớn nhất trong 3 số!");
            }
        }
        else if (b > c)
            Console.WriteLine("Số thứ 2 lớn nhất trong 3 số!");
        else
            Console.WriteLine("Số thứ 3 lớn nhất trong 3 số!");
        Console.ReadKey();
        /*int[] Arr = new int[100];
        int i, max, min, n;
        Console.OutputEncoding=Encoding.UTF8;
        Console.Write("\nTim số lớn nhất, số nhỏ nhất trong mảng:\n");
        Console.Write("------------------------------------------\n");
        Console.Write("Nhập số lượng các số can lưu giữ trong mảng: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập {0} số vào trong mảng:\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("Số - {0}: ", i);
            Arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        max=Arr[0];
        min = Arr[0];
        for (i = 1; i < n; i++)
        {
            if (Arr[i] > max)
            {
                max = Arr[i];
            }
            if (Arr[i] < min)
            {
                min = Arr[i];
            }
        }
        Console.Write("Số lớn nhat trong mảng la: {0}\n", max);
        Console.Write("Số nhỏ nhat trong mảng la: {0}\n\n", min);
        Console.ReadKey();*/
        }
    }
}