using System;

namespace ReadValue
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sob Somoy String Type input nibe dorkar porle amader
            // Convert kore nite hobe


            Console.Write("Enter firstname : ");
            string firstname = Console.ReadLine();
            Console.Write("Enter lastname : ");
            string lastname = Console.ReadLine();

            string fullname = firstname + " " + lastname;

            Console.WriteLine("Hello there, Myself " + fullname);

        }
    }
}
