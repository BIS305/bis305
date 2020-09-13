using System;

namespace _4Codespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub Codespaces!");
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Welcome to my codespace!", name);
        }
    }
}
