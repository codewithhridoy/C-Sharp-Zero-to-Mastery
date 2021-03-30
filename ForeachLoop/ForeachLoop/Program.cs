using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = { "Tasmia", "Mariz", "Pranto", "Mahdin", "Taseen", "Fiba", "Dola" };

            foreach(string name in studentName)
            {
                Console.WriteLine(name);
            }
      }
    }
}
