using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //判斷某數值是不是質數
            Console.Write("請輸入正整數:");
            String input = Convert.ToString(Console.ReadLine());
            bool isInt = int.TryParse(input, out int number );

            if (isInt = false)
            {
                Console.WriteLine("非整數");
                return;
            }
            if (number <= 1)
            {
                Console.WriteLine("非正數");
                return;
            }

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += 1;
                }
            }    
            if(sum == 2)        
                {
                    Console.WriteLine(input + "是質數");
                
                }
            else
                {
                    Console.WriteLine(input + "不是質數");
                
                }
            
          






        }
    }
}
