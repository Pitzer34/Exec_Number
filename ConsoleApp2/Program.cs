using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //找出數值區間內的所有質數
            //假設區間1~99
            Console.WriteLine("區間1~99質數為:");
            //int sum = 0;
            for (int number = 1; number <= 99; number++)
            {
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                    sum += 1;
                    }
                }
                if (sum == 2)
                {
                    Console.Write(number+",");
                }
            
            }
            
            

        }
    }
}
