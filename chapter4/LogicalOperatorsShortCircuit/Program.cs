//adapted from https://www.c-sharpcorner.com/article/short-circuit-evaluation-in-c-sharp/

using static System.Console;

namespace LogicalOperatorsShortCircuit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Condition1() { 
                return false; 
            }

            bool Condition2() { 
                return true; 
            }

            if (Condition1() & Condition2())
            {
                //inside code will not execute
                //both operands evaluated
            }
            if (Condition2() | Condition1())
            {
                //inside code will execute
                //both operands evaluated
            }

            if (Condition1() && Condition2())
            {
                //inside code will not execute
                //Condition2 not evaluated
            }
            if (Condition2() || Condition1())
            {
                //inside code will execute
                //Condition2 not evaluated
            }
        }
    }
}
