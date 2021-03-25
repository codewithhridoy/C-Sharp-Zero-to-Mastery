using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method er seshe () thake
            string firstname = "hridoy";
            string lastname = "Ahmed";

            // Check Equal ==> returns boolean
            Console.WriteLine(firstname.Equals(lastname));

            // Comparison ==> returns boolean
            Console.WriteLine(firstname.Equals(lastname, StringComparison.Ordinal));

            // Length Property (property er seshe bracket hoy na)
            Console.WriteLine(firstname.Length);

            //Empty String
            string isEmpty = string.Empty;

            // Concat
            Console.WriteLine(string.Concat(firstname, lastname));

            // Compare ==> returns 0(True) or 1(False)
            Console.WriteLine(string.Compare(firstname, lastname));

            // Lower, Upper
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(firstname.ToLower());

            // Capitalize using char and substring
            //Substring(starts with, end where) ==> firstname.Substring(1, 6) ==> ridoy
            Console.WriteLine(char.ToUpper(firstname[0]) + firstname.Substring(1));

            // Replace String
            Console.WriteLine(firstname.Replace("hridoy", "Hridoy Ahmed"));

            // Indexing
            Console.WriteLine(firstname.IndexOf("i"));
            Console.WriteLine(firstname[4]);
        }
    }
}
