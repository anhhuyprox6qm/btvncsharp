using System;
namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sin = "193 456 787";
            if (sin.Length != 9)
            {
                Console.WriteLine("The program only accepts 9 numbers !");
                return;
            }
            var separateSIN = sin.ToCharArray();
            var sinInNumber = new int[9];
            for (int i = 0; i < separateSIN.Length; i++)
            {
                sinInNumber[i] = int.Parse(separateSIN[i].ToString());
            }
            var sumOfEvennumberOfRows = 0;
            var sumOfOddnumberOfRows = 0;
            for (int i = 0; i < sinInNumber.Length - 1; i++)
            {
                if (i%2 == 0)
                {
                    sumOfOddnumberOfRows += sinInNumber[i];
                }
                else
                {
                    var temp = (sinInNumber[i] * 2).ToString().ToCharArray();
                    for (int j = 0; j < temp.Length; j++)
                    {
                        sumOfEvennumberOfRows += Convert.ToInt32(temp[j].ToString());
                    }
                }
            }
            Console.WriteLine(sumOfOddnumberOfRows);
            Console.WriteLine(sumOfEvennumberOfRows);
        }
    } 
}
