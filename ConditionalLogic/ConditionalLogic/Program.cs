using System;

namespace ConditionalLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Your number is Zero");
            }
            else if (number > 0)
            {
                Console.WriteLine("Your number is Positive");
            }
            else
            {
                Console.WriteLine("Your number is negative");
            }


        }
    }
}
