using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace what_is_the_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a furit variety");
            string input = Console.ReadLine();

            switch (input)
            {
                case "apple":
                    Console.WriteLine("apples are $1.25 a kilo");
                    break;
                case "bananas":
                    Console.WriteLine("bananas are $3.15");
                    break;
                case "kiwifruit":
                    Console.WriteLine("kiwifruit are $4.65");
                    break;
                case "oranges":
                    Console.WriteLine("oranges are $2.75");
                    break;
                default:
                    Console.WriteLine("that fruit is not on the system");
                    break;
                    Console.ReadKey();


            }


        }
    }
}
