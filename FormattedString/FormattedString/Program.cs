using System;

namespace FormattedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hridoy";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

            string firstname = "Hridoy";
            string lastname = "Ahmed";

            string formattedString = string.Format("Your Name is {0} {1}", firstname, lastname);
            Console.WriteLine(formattedString);
        }
    }
}
