using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number for me to write timetables out");
            int times = int.Parse(Console.ReadLine());
            int i = 0;

            Console.WriteLine("\tthis is forloops");
            for (i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {times} = {times * i}");
               


            }

            Console.WriteLine("\tthis is while loops");
            int o = 0;
            while (o <= 12)
            {

                Console.WriteLine($"{o} x {times} = {times * o}");
                o++;
            }
            Console.WriteLine("\tthis is do / while loops");
            int p = 0;
            do
            {
                Console.WriteLine($"{p} x {times} = {times * p}");
                p++;
            }
            while (p <= 12);
            ///////tasks3////////









            Console.ReadKey();
            Console.WriteLine("please enter another number to get squ and cube from");
            int up = int.Parse(Console.ReadLine());
           

            //Console.WriteLine("{0} {1} {2}", up, squ, cub);


            Console.WriteLine("\tthis is forloops");
            for (i = 0; i <= up; i++)
            {
                //Console.WriteLine("{0} {1} {2}", i, (i *i), (i*i*i));
                Console.WriteLine($"{i} {i*i} {i*i*i}");


            }

            Console.WriteLine("\tthis is while loops");
            int j = 0;
            while (j <= up)
            {

                Console.WriteLine($"{j} {j * j} {j * j * j}");
                j++;
            }
            Console.WriteLine("\tthis is do / while loops");
            int k = 0;
            do
            {
                Console.WriteLine($"{k} {k * k} {k * k * k}");
                k++;
            }
            while (k <= up);
        }






    }
}
