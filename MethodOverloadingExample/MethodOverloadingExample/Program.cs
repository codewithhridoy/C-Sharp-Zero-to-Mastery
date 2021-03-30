using System;

namespace MethodOverloadingExample
{
    class Program
    {
        // Same method name but different type parameters.
        
        static int CalculateNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        static double CalculateNumber(double num1, double num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            int result1 = CalculateNumber(10, 50);
            double result2 = CalculateNumber(100.50, 5.75);

            Console.WriteLine("First Result = " + result1);
            Console.WriteLine("Second Result = " + result2);
        }
    }
}
