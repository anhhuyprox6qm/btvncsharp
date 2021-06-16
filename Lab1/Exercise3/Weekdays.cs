using System;
using System.Text;

namespace Exercise3
{
    public class WeekdaysController
    {
        public static void CacThuTrongTuan()
        {
            while (true)
            {
                Console.OutputEncoding=Encoding.UTF8;
                Console.WriteLine("Vui lòng chọn 1-7:");
                var choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Thứ 2");
                        break;
                    case 2:
                        Console.WriteLine("Thứ 3");
                        break;
                    case 3:
                        Console.WriteLine("Thứ 4");
                        break;
                    case 4:
                        Console.WriteLine("Thứ 5");
                        break;
                    case 5:
                        Console.WriteLine("Thứ 6");
                        break;
                    case 6:
                        Console.WriteLine("Thứ 7");
                        break;
                    case 7:
                        Console.WriteLine("Chủ Nhật");
                        break;
                }
            }
        }
    }
}