using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<number; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"The Number {i} is Even");
                }
                else
                {
                    Console.WriteLine($"The number {i} is Odd");
                }
            }
        }
    }
}
