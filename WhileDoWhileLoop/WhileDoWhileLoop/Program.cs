using System;

namespace WhileDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int i=0;
            Console.WriteLine("While Loop Result: ");
            while (i < number)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 1;
            Console.WriteLine("Do While Loop Result: ");
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);
        }
    }
}
