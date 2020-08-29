using System;
using static System.Console;

namespace MovieDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
			int age = 10;
			char rating = 'R';
			const int CHILD_AGE = 12;
			const int SENIOR_AGE = 65;
			WriteLine("When age is {0} and rating is {1}", age, rating);
			if ((age <= CHILD_AGE || age >= SENIOR_AGE) && rating == 'G')
				WriteLine("Discount applies");
			else
				WriteLine("Full price");

			Write("[Press any key to continue]");
			ReadKey();
		}
    }
}
