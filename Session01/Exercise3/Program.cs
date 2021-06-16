using System;
using System.Text;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;
        
                                Console.WriteLine("thứ 2: ");
                                int ngay1 = Int32.Parse(Console.ReadLine());
        
                                Console.WriteLine("thứ 3: ");
                                int ngay2 = Int32.Parse(Console.ReadLine());
        
                                Console.WriteLine("thứ 4: ");
                                int ngày3 = Int32.Parse(Console.ReadLine());
                                
                                Console.WriteLine("thứ 5: ");
                                int ngay4 = Int32.Parse(Console.ReadLine());
                                
                                Console.WriteLine(" thứ 6: ");
                                int ngay5 = Int32.Parse(Console.ReadLine());
                                
                                Console.WriteLine(" thứ 7: ");
                                int ngay6 = Int32.Parse(Console.ReadLine());
                                
                                Console.WriteLine("chủ nhật: ");
                                int ngay7 = Int32.Parse(Console.ReadLine());
        
                                DateTime date = new DateTime(ngay1,ngay2,ngày3,ngay4,ngay5,ngay6,ngay7);            
        
                                Console.WriteLine(date.DayOfWeek);
        
                                Console.ReadKey();
        }
    }
}