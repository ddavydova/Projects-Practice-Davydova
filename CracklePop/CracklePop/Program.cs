using System;

namespace CracklePop
{
    class Program
    {
        //Write a program that prints out the numbers 1 to 100 (inclusive). If the number is divisible by 3,
        //print Crackle instead of the number. If it's divisible by 5, print Pop. If it's divisible by both 
        //3 and 5, print CracklePop. You can use any language.
        static void Main(string[] args)
        {
            Start: 

            int answer;

            Console.WriteLine("Please, enter a number between 1 and 100:");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer<1 && answer>100 || answer<1 || answer>100)
            {
                Console.WriteLine("The number is out of the listed range, try again!");
                goto Start;
            }
            else
            {
                if (answer % 3 == 0 && answer % 5 == 0)
                {
                    Console.WriteLine("CracklePop!");
                    Environment.Exit(-1);
                }
                else if (answer % 3 == 0 && answer % 5 != 0)
                {
                    Console.WriteLine("Crackle");
                    Environment.Exit(-1);
                }
                else if (answer % 3 != 0 && answer % 5 == 0)
                {
                    Console.WriteLine("Pop");
                    Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine("Your number is weird, try again later :)");
                    Environment.Exit(-1);
                }
            }
         


          //  bool newNumber = Int32.TryParse(answer, out number);
          //  if (newNumber)
          //  {
          //      if( < 1 && newNumber >100)
           //     {

           //     }
          //  }
          //  else
          //      Console.WriteLine("Could not be parsed.");

         //   if (int.TryParse(answer, out number) == false)
         //  {
         //     Console.WriteLine("Sorry, invalid number, goodbye!");
         //      Environment.Exit(-1);
         //  }

           //  if (number < 1 && number > 100)
           //  {
           //      Console.WriteLine("Please, enter a number between 1 and 100");}
           
        }
    }
}
