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
            string a = "a";
            string b = "b";
            string c = "c";
            string d = "d";
            string e = "e";
            string f = "f";
            Console.WriteLine("hello user please pick from task a,b,c,d,e,f ");
            string person = (Console.ReadLine());

            if (person == a) //comparing
            {
                int userpick;
                int userpick2;

                Console.WriteLine("please enter a number");
                userpick = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter a second number");
                userpick2 = Convert.ToInt32(Console.ReadLine());

                if (userpick > userpick2)
                {
                    Console.WriteLine("\n 1st number:{0} is greater that {1} ", userpick, userpick2);
                }
                else if (userpick < userpick2)
                {
                    Console.WriteLine("\n 1st number:{0} is smaller that {1} ", userpick, userpick2);
                }
                else if (userpick == userpick2)
                {
                    Console.WriteLine("\n 1st number:{0} is the same as {1}", userpick, userpick2);
                }
            }
            

            if (person == b) //grade testing
            {
                int grade;

                Console.WriteLine("please enter the mark u received");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 90 && grade < 100)
                {
                    Console.WriteLine("you got a+ well done");
                }
                if (grade >= 80 && grade < 89)
                {
                    Console.WriteLine("you got a well done");
                }
                if (grade >= 70 && grade < 79)
                {
                    Console.WriteLine("you got b+ well done");
                }
                if (grade >= 60 && grade < 69)
                {
                    Console.WriteLine("you got b well done");
                }
                if (grade >= 50 && grade < 59)
                {
                    Console.WriteLine("you got c well done");
                }
                if (grade >= 40 && grade < 49)
                {
                    Console.WriteLine("you got d sure you can do better");
                }
                if (grade >= 0 && grade < 39)
                {
                    Console.WriteLine("you got a f you FAIL");
                }
            }

            
            if (person == c) //guessing game
            {
                int guess = 10, usernumb = 0;
                

                
                while (guess != usernumb )
                    {
                    usernumb = 0;
                    Console.WriteLine("please guess a number between 1-10");
                    usernumb = Convert.ToInt32(Console.ReadLine());

                    if (guess == usernumb)
                    {
                        Console.WriteLine("you have guessed corret");
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        break;
                    }
                    else if (guess > usernumb)
                    {
                        Console.WriteLine("please try again");
                    }
                    else if (guess < usernumb)
                    {
                        Console.WriteLine("please try again");

                    }

                }

             
            }
            if(person == d)
            {

                int number;
                //int number2;

                Console.WriteLine("please enter a number");
                number = Convert.ToInt32(Console.ReadLine());
               // Console.WriteLine("please enter another number");
               // number2 = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("this number is even");
                }
                else
                {
                    Console.WriteLine("this number is not even");
                }
            }
            if (person == e)
            {
                int pin01;
                int pin02 = 0;

                Console.WriteLine("please enter a 4 digit number between 1000-9999");
                pin01 = Convert.ToInt32(Console.ReadLine());
                
                    while (pin01 != pin02)
                {
                    if (pin01 == pin02)
                    {

                        Console.WriteLine("thank you your new pin is set");
                        Console.WriteLine("please push enter to exit");
                        Console.ReadLine();
                        break;


                    }

                    if (pin01 <= 1000 && pin01 >= 9999)
                    {
                        Console.WriteLine("please try again your numbers are not between what was asked please pick between 1000-9999");
                    }


                    if (pin01 >= 1000 && pin01 <= 9999)
                    {
                        Console.WriteLine("please reenter the same 4 pin as before");
                        pin02 = Convert.ToInt32(Console.ReadLine());
                    }
                    if (pin01 != pin02)

                    {
                        Console.WriteLine("please try re enter pin again as it is not the same");

                    }
                 
                }
            }

            if (person == f)
            {

            }


            }







        }
    }

