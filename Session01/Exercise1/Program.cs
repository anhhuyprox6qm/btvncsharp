using System;
using System.Security.Cryptography;
using System.Text;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Name, Age, Number;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap ten sinh vien");
            Name= Console.ReadLine();
            Console.WriteLine("Nhap dia chi:");
            Age = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai:");
            Number = Console.ReadLine();


        }
        
    }
}