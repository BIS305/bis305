using static System.Console;
class CreateTwoBooks
{
   static void Main()
   {
      Book myBook = new Book();
      Book yourBook = new Book();
      myBook.Title = "Silas Marner";
      myBook.SetPriceAndTax(19.95);
      yourBook.Title = "The Time Traveler's Wife";
      yourBook.SetPriceAndTax(10.00);
      myBook.AdvertisingMessage();
      yourBook.AdvertisingMessage();
   }
}
class Book
{
   private string title;
   private double price;
   private double tax;

   public string Title
   {
     get
     {
        return this.title;
     }
     set
     {
        this.title = value;
     }
   }
   public void AdvertisingMessage()
   {
      WriteLine("Buy it now: {0} for only {1} (including tax).", this.Title, this.price.ToString("C"));
   }

    public void SetPriceAndTax(double price)
    {
        const double TAX_RATE = .06;
        tax = price * TAX_RATE;
        this.price = price + tax;
    }
}
