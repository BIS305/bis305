using System;

namespace ConsoleApp
{
    class VariableAlignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", 1234);
            Console.WriteLine("{0, 5}", 1234);
            Console.WriteLine("{0, 8}", 1234);
            Console.WriteLine("{0} {1}", "Mark", "McFadden");
            Console.WriteLine("{0, -5}{1}", "Mark", "McFadden");
            Console.WriteLine("{0, -6}{1}", "Mark", "McFadden");
            Console.WriteLine("{0, -7}{1}", "Mark", "McFadden");
            Console.WriteLine("[Press any key to quit]");
            Console.ReadLine();
        }
    }
}
