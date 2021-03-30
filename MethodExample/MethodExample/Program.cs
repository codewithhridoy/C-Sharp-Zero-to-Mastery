using System;

namespace MethodExample
{
    class Program
    {
        
        // Without Parameter
        static void CalculateNumber() 
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"Sum of {num1} + {num2} = {result} ");
        }

        // With Parameters
        static void EvenNumber(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Your given number is even.");
            }
        }

        // Default Parameter dite chaile method er vitor
        // parameter er value assign kore dite hobe

        // Return value
        static int SubTract(int number1 = 10, int number2 = 5)
        {
            return (number1 - number2);
        }
        static void Main(string[] args)
        {
            CalculateNumber();
            EvenNumber(10);
            Console.WriteLine(SubTract(15, 7));
        }
    }
}
