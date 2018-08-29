using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("please enter you fav pet");
            string input = Console.ReadLine();
            switch (input)
            {

                case "dogs":
                    Console.WriteLine("you have dogs");
                    break;
                case "rabbits":
                    Console.WriteLine("you have rabbits");
                    break;
                case "chickens":
                    Console.WriteLine("you have chickens");
                    break;
                case "parrots":
                    Console.WriteLine("you have parrots");
                    break;
                default:
                    Console.WriteLine("you have entered an unrecognised pet");
                    break;
            }
            Console.ReadLine();
        }
    }
}
