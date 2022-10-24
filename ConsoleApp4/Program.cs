using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //百元買百雞
            //想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
            //字彙表:公雞(Cock), 母雞(Hen), 小雞(Chicken)


            for (int Cock = 0; Cock <= 100 / 5; Cock++)
            {
                for (int Hen = 0; Hen <= (100 - 5 * Cock) / 3; Hen++)
                {
                    int Chicken = 100 - Cock - Hen;
                    double price = 5 * Cock + 3 * Hen + (double)Chicken / 3.0;
                    
                    if (price == 100)
                    {
                        Console.WriteLine($"公雞{Cock}隻, 母雞{Hen}隻, 小雞{Chicken}隻");
                    }

                }
            }
        }
    }
}
