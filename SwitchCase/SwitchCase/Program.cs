using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you name: ");
            string input = Console.ReadLine();
            
            switch(input)
            {
                case "Hridoy":
                    Console.WriteLine("Admin");
                    break;

                case "Tanveer":
                    Console.WriteLine("Moderator");
                    break;

                default:
                    Console.WriteLine("User");
                    break;
            }
        }
    }
}
