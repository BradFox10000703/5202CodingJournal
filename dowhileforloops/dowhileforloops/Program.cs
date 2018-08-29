using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhileforloops
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine("please enter a start number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a end number");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("\tthis is forloops");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"\t{i} \t{i * 10} \t{i * 100} \t{i * 1000}");
                
                
            }
            Console.WriteLine("\tthis is while loops");
            int o = start;
            while (o <= end)
            {

                Console.WriteLine($"\t{o} \t{o * 10} \t{o * 100} \t{o * 1000}");
                o++;
            }
            Console.WriteLine("\tthis is do / while loops");
            int p = start;
            do
            {
                Console.WriteLine($"\t{p} \t{p * 10} \t{p * 100} \t{p * 1000}");
                p++;
            }
            while (p <= end);
        }
    }
}
