using System;
using static System.Console;
class TwoErrors
{
   static void Main()
   {
      int num = 13, denom = 0, result;
      int[] array = {22, 33, 44};
      try
      {
         result = num / denom;
      }
      catch(DivideByZeroException error)
      {
         WriteLine(error.Message);
      }
      finally
      {
         WriteLine("Doing something in the finally block");
      }
   }
}
