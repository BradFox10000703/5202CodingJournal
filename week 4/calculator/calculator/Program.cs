using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string pick;


            Console.WriteLine("please enter a number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please choose /,*,-,+");
            pick = Console.ReadLine();

            Console.WriteLine("please enter a second number");
            y = Convert.ToInt32(Console.ReadLine());

            switch ( pick)
            {
                case "+":
                    Console.WriteLine($"{x} + {y} = {x+y} ");
                    //Console.WriteLine("{0} + {1} = {2}", x, y, (x + y));
                    //Console.WriteLine(x + " + " + y + " = " + (x + y));
                    break;
                case "-":
                    Console.WriteLine($"{x} - {y} = {x - y} ");
                    break;
                case "*":
                    Console.WriteLine($"{x} * {y} = {x * y} ");
                    break;
                case "/":
                    Console.WriteLine($"{x} / {y} = {x / y} ");
                    break;
                default:
                    Console.WriteLine("are you dumb that cant be done mate");
                    break;
                    


            }
            Console.ReadKey();



        }
    }
}
