using static System.Console;
class ConversionWithParseAndTryParse
{
   static void Main()
   {
      string entryString;
      int score;
      Write("Enter your test score >> ");
      entryString = ReadLine();
      score = int.Parse(entryString);
	  //int.TryParse(entryString, out score);
      WriteLine("You entered {0}", score);
   }
}
