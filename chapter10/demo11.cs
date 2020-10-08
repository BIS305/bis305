using static System.Console;
static class DemoExtensionMethod
{
   static void Main()
   {
      int acctNum = 49;
      int revisedAcctNum = acctNum.AddCheckDigit();
      WriteLine("Original account number was {0}", acctNum);
      WriteLine("Revised account number is {0}", revisedAcctNum);
   }
   public static int AddCheckDigit(this int num)
   {
      int first = num / 10;
      int second = num % 10;
      int third = (first + second) % 10;
      int result = num * 10 + third;
      return result;
   }
}

// static class DemoObjectExtensionMethod
// {
//     static void Main()
//     {
//         Customer cust = new Customer("Mark", "123 Main St.");
//         WriteLine("Customer: {0}", cust.ConcatCustomerNameAddress());
//     }

//     public static string ConcatCustomerNameAddress(this Customer customer)
//     {
//         return customer.Name + " lives at " + customer.Address;
//     }
// }

// class Customer
// {
//     public string Name { get; set; }
//     public string Address { get; set; }

//     public Customer(string name, string address)
//     {
//         this.Name = name;
//         this.Address = address;
//     }
// }
