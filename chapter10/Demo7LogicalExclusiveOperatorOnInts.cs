using static System.Console;

class DemoLogicalExclusiveOperatorOnInts
{
    static void Main()
    {
        //Demonstrate Logical Exclusive (XOR) ^ Operator for two integers.
        //The ^ operator computes the bitwise logical exclusive OR which returns 1 (True) if the 
        //bits are exclusive or different and 0 (False) if they are the same.
        //Therefore:
        //The result of 1 ^ 0 is 1 (or True).
        //The result of 0 ^ 1 is 1 (or True).
        //The result of 0 ^ 0 is 0 (or False). 
        //The result of 1 ^ 1 is 0 (or False).
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

        int a = 5 ^ 1153645653;
        WriteLine(GetIntBinaryString(5));
        WriteLine(GetIntBinaryString(1153645653));
        WriteLine(GetIntBinaryString(a));
        WriteLine(a);

        // Repeat.
        int b = 25 ^ 1286203810;
        WriteLine(GetIntBinaryString(25));
        WriteLine(GetIntBinaryString(1286203810));
        WriteLine(GetIntBinaryString(b));
        WriteLine(b);

        //Output
        // 00000000000000000000000000000101
        // 01000100110000110011110001010101
        // 01000100110000110011110001010000
        // 1153645648
        // 00000000000000000000000000011001
        // 01001100101010011110100110100010
        // 01001100101010011110100110111011
        // 1286203835
    }

    /// <summary>
    /// Returns binary representation string.
    /// </summary>
    static string GetIntBinaryString(int n)
    {
        char[] b = new char[32];
        int pos = 31;
        int i = 0;

        while (i < 32)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }
}
