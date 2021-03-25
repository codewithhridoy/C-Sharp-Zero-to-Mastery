using System;

namespace TypeConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a double number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an Alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Your Age is " + age);
            Console.WriteLine("Your number is " + number);
            Console.WriteLine("Your Alphabet is " + alphabet);
        }
    }
}
