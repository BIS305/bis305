using System;
using System.Diagnostics;
using static System.Console;

namespace Chapter5Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			//While Loop
            double bankBal = 1000;
            const double INT_RATE = 0.04;
            string inputString;
            char response;

            Write("Do you want to see your balance? Y or N...");
            inputString = ReadLine();
            response = Convert.ToChar(inputString);

            while (response == 'Y')
            {
                WriteLine("Bank balance is {0}", bankBal.ToString("C"));

                bankBal = bankBal + bankBal * INT_RATE;

                Write("Do you want to see next year's balance? Y or N...");

                inputString = ReadLine();

                response = Convert.ToChar(inputString);
            }

            WriteLine("Have a nice day!");

            //// For Loop 
            //int x;
            //const int LIMIT = 10;

            //// Using a while loop to display 1 through 10 
            //x = 1;
            //while (x <= LIMIT)
            //{
            //    WriteLine(x);
            //    ++x;
            //}

            //// Using a for loop to display 1 through 10 
            //for (x = 1; x <= LIMIT; ++x)
            //{
            //    WriteLine(x);
            //}

            ////Do Loop
            //double bankBal = 1000;
            //const double INT_RATE = 0.04;
            //string inputString;
            //char response;

            //do
            //{
            //    WriteLine("Bank balance is {0}", bankBal.ToString("C"));
            //    bankBal = bankBal + bankBal * INT_RATE;
            //    Write("Do you want to see next year's balance? Y or N ...");
            //    inputString = ReadLine();
            //    response = Convert.ToChar(inputString);
            //}
            //while (response == 'Y');

            ////Nested Loops
            //double bankBal;
            //double rate;
            //int year;
            //const double START_BAL = 1000;
            //const double START_INT = 0.04;
            //const double INT_INCREASE = 0.02;
            //const double LAST_INT = 0.08;
            //const int END_YEAR = 5;
            //for (rate = START_INT; rate <= LAST_INT; rate += INT_INCREASE)
            //{
            //    bankBal = START_BAL;
            //    WriteLine("Starting bank balance is {0}", bankBal.ToString("C"));
            //    WriteLine(" Interest Rate: {0}", rate.ToString("P"));
            //    for (year = 1; year <= END_YEAR; ++year)
            //    {
            //        bankBal = bankBal + bankBal * rate;
            //        WriteLine(" After year {0}, bank balance is {1}", year, bankBal.ToString("C"));
            //    }
            //}
           
            //Accumulating Totals
            //double purchase;
            //double total = 0;
            //string inputString;
            //const double QUIT = 0;

            //Write("Enter purchase amount >> ");
            //inputString = ReadLine();
            //purchase = Convert.ToDouble(inputString);

            //while (purchase != QUIT)
            //{
            //    total += purchase;
            //    Write("Enter next purchase amount, or " + QUIT + " to quit >> ");
            //    inputString = ReadLine();
            //    purchase = Convert.ToDouble(inputString);
            //}
            //WriteLine("Your total is {0}", total.ToString("C"));


        }
	}
}
