using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // task1
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

            Console.ReadLine();

            Console.Write("enter a number to be added:    ");    //input
            string number1 = Console.ReadLine();  //output disply on screen
            int anumber1 = int.Parse(number1);

            Console.Write("enter a second number to be added:    ");     //input
            string number2 = Console.ReadLine();      // output disply on screen
            int anumber2 = int.Parse(number2);

            int answer = anumber1 + anumber2; //doz the adding
            Console.WriteLine("\nYour answer is: " + answer);    // displys the answer

            int answerTimes = anumber1 * anumber2;
            Console.WriteLine("Your numbers multiplied equal " + answerTimes);
            Decimal answerdivid = anumber1 / anumber2;
            Console.WriteLine("Your numbers devided equal " + answerdivid);
            int answersubtract = anumber1 - anumber2;
            Console.WriteLine("Your numbers subtracted equal " + answersubtract);
            // task 3
            Console.Write("enter first name:  ");
            string firstname = Console.ReadLine();
            Console.Write("enter last name:  ");
            string lastname = Console.ReadLine();
           // string fullname = firstname + lastname;
            Console.WriteLine("your full name: " + firstname + " " + lastname);
            Console.WriteLine("{0} {1}", firstname, lastname);
            Console.WriteLine($"{firstname} {lastname}");
           
            /*
            Console.Write("\n\nPress any key to go to next question");
            Console.ReadKey();
            Console.ReadLine();
            Console.ReadLine();


            Console.Write("enter a number:    ");    //input
            string number01 = Console.ReadLine();  //output disply on screen
            int anumber01 = int.Parse(number01);

            Console.Write("enter a second number:    ");     //input
            string number02 = Console.ReadLine();      // output disply on screen
            anumber2 = int.Parse(number02);

            Console.WriteLine("what is " + number01 + "times" + number02 + "?");

            int aanswer = anumber01 * anumber2; //doz the adding

            

            Console.Write("\nYour answer is: " + aanswer);    // displys the answer
            */
            Console.Write("\n\nPress any key to exit");
            Console.ReadKey();





        }
    }
}
