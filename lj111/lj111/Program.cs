using System;




namespace lj111
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            //char add;
            //char subtract;
            //char muti;
            //char divide;



            Console.WriteLine("hello user please pick from 1-3  to pick a program you would like to run, u can also 4 to +, 5 to *,6 to /, 7 to - please press 10 to exit ");
            int userpick = int.Parse(Console.ReadLine());



            if (userpick == 1)
            {
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

                //Output to console.
                Console.WriteLine(name);
                Console.WriteLine(num);
                Console.WriteLine(cha);
                Console.WriteLine(gender);
                Console.Write("\n\nPress any key to continue");
                Console.ReadKey();
                goto start;   // makes program got back to start
            }
            else if (userpick == 2)
            {

                Console.Write("enter a number to + please:     ");    //input
                string number1 = Console.ReadLine();  //output disply on screen
                int anumber1 = int.Parse(number1);

            
                Console.Write("enter a second number to be + :    ");     //input
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
                Console.Write("\n\nPress any key to continue");
                Console.ReadKey();

                goto start;
            }
            else if (userpick == 3)
            {
                Console.Write("enter first name:  ");   //input
                string firstname = Console.ReadLine();  //reads input
                Console.Write("enter last name:  ");    // input again
                string lastname = Console.ReadLine();   // reads input
                Console.WriteLine("your full name: " + firstname + " " + lastname); //outputs to screen
                Console.Write("\n\nPress any key to continue");
                Console.ReadKey();
                goto start;
            }
            else if (userpick == 4)
            {
                Console.Write("enter a number to + please:     ");    //input
                string number1 = Console.ReadLine();  //output disply on screen
                int anumber1 = int.Parse(number1);

                Console.Write("enter a second number to be + :    ");     //input
                string number2 = Console.ReadLine();      // output disply on screen
                int anumber2 = int.Parse(number2);
                int answer = anumber1 + anumber2; //doz the adding
                Console.WriteLine("\nYour answer is: " + answer);    // displys the answer
                Console.ReadKey();
                goto start;
            }
            else if (userpick == 5)
            {
                Console.Write("enter a number to * please:     ");    //input
                string number1 = Console.ReadLine();  //output disply on screen
                int anumber1 = int.Parse(number1);

                Console.Write("enter a second number to be *:    ");     //input
                string number2 = Console.ReadLine();      // output disply on screen
                int anumber2 = int.Parse(number2);
                int answer = anumber1 * anumber2; //doz the adding
                Console.WriteLine("\nYour answer is: " + answer);    // displys the answer
                Console.ReadKey();
                goto start;
            }
            else if (userpick == 6)
            {
                Console.Write("enter a number to  / :     ");    //input
                string number1 = Console.ReadLine();  //output disply on screen
                Decimal anumber1 = Decimal.Parse(number1);

                Console.Write("enter a second number to be / :    ");     //input
                string number2 = Console.ReadLine();      // output disply on screen
                Decimal anumber2 = Decimal.Parse(number2);
                Decimal answer = anumber1 / anumber2; //doz the adding
                Console.WriteLine("\nYour answer is: " + Math.Round(answer, 2));    // displys the answer
                Console.ReadKey();
                goto start;
            }
            else if (userpick == 7)
            {
                Console.Write("enter a number to - please:     ");    //input
                string number1 = Console.ReadLine();  //output disply on screen
                int anumber1 = int.Parse(number1);

                Console.Write("enter a second number to be - :    ");     //input
                string number2 = Console.ReadLine();      // output disply on screen
                int anumber2 = int.Parse(number2);
                int answer = anumber1 - anumber2; //doz the adding
                Console.WriteLine("\nYour answer is: " + answer);    // displys the answer
                Console.ReadKey();
                goto start;
            }
            else if (userpick == 10)
            {
                Console.WriteLine("push any key exit: ");
                Console.ReadKey();
            }
            // Console.WriteLine("{0} {1}", firstname, lastname);  other ways to code to do the same as line above
            //Console.WriteLine($"{firstname} {lastname}");

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


        }

    }
}
