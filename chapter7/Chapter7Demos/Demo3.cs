using static System.Console;
class UseTaxMethod
{
   static void Main()
   {
      double myPurchase = 12.99;
      DisplaySalesTax(myPurchase);
      DisplaySalesTax(35.67);
      // DisplaySalesTax(35.67, 0.8);
   }
   private static void DisplaySalesTax(double saleAmount)
   {
      double tax;
      const double RATE = 0.07;
      tax = saleAmount * RATE;
      WriteLine("The tax on {0} is {1}",
         saleAmount.ToString("C"), tax.ToString("C"));
   }

   //Multiple arguments
   private static void DisplaySalesTax(double saleAmount, double taxRate) { 
      double tax; 
      tax = saleAmount * taxRate; 
      WriteLine("The tax on {0} at {1} is {2}", saleAmount.ToString("C"), 
         taxRate.ToString("P"), tax.ToString("C"))
   } 
}