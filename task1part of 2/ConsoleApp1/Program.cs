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
        {// task1
            //Inputs
            string name;
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            Console.Write("hello, ");
            Console.Write(name);

            Console.ReadLine();
        


            int num;
            Console.WriteLine("please enter your age here");
            num = int.Parse(Console.ReadLine());
            string cha;
            Console.WriteLine("please enter your address here");
            cha = Console.ReadLine();
            string gender;
            Console.WriteLine("please choose male/female");
            gender = Console.ReadLine();

            Console.ReadLine();
            //Output to console.
            Console.WriteLine(name);
            Console.WriteLine(num);
            Console.WriteLine(cha);
            Console.WriteLine(gender);


            //task2

            Console.ReadKey();


           

            

            Console.Write("type the first number to be added: ");
            string num01 = Console.ReadLine();
            int numm01 = int.Parse(num01);

            Console.Write("type the second number to be added: ");
            string num02 = Console.ReadLine();
            int numm02 = int.Parse(num02);

            int ianswer = numm01 + numm02;

            Console.Write("\n\nyour answer is: " + ianswer);

            Console.Write("\n\npress any key to exit. . . ");
            Console.ReadKey();








        }
    }
}
