using System;
using System.Text;
using Exercise1;

namespace Lab1
{
    public class UserInformation
    {
        public void ThongTin()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Information information = new Information();
            Console.WriteLine("Tên: ");
            information.Name = Console.ReadLine();
            Console.WriteLine("Đ/C: ");
            information.Address = Console.ReadLine();
            Console.WriteLine("SĐT: ");
            information.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hiển thị thông tin:");
            Console.WriteLine($"Name: {information.Name}, Address: {information.Address}, Phone number: {information.PhoneNumber}");
        }
    }
}