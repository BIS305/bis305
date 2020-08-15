
using System;
using static System.Console;
class NumbericDatatypes {
    static void Main()
    {
        int intTest = Convert.ToInt32(1 / (double)3); // Integer - 0 digits (to the right of the decimal point)
        float sngTest = (float)(1 / (double)3); // Single (or Single Floating Point) - 7 digits (32 bit)
        double dblTest = 1.0D / 3; // Double (or Double Floating Point) - 15-16 digits (64 bit)
        decimal decTest = 1M / 3M; // Decimal - 28-29 digits (128 bit)
        long lngTest = Convert.ToInt64(1 / (double)3); // Long (Integer) - 0 digits

        // Using composite formatting in the Console.WriteLine procedure below. Composite formatting - a fixed text intermixed with indexed placeholders, 
        // called format items, that correspond to the objects in the list.
        // See https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting for more info

        // Note that precision is the main difference between these numeric datatypes.
        WriteLine("Integer: " + intTest.ToString());
        // subtract 2 from the String length to account for the leading 0 and decimal point
        WriteLine("Single: " + sngTest + " with a length of: " + (sngTest.ToString().Length - 2) + " after the decimal point.");
        WriteLine("Double: " + dblTest + " with a length of: " + (dblTest.ToString().Length - 2) + " after the decimal point.");
        WriteLine("Decimal: " + decTest + " with a length of: " + (decTest.ToString().Length - 2) + " after the decimal point.");
        WriteLine("Long: " + lngTest.ToString());
        WriteLine("Ouput: {0} {1}", lngTest, intTest);
        ReadLine();
    }
}