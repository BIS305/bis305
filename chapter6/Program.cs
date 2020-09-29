using System;
using static System.Console;

namespace Chapter6Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            //find price with for loop
            //int[] validValues = {101,  108,  201,  213,  266, 304,  311,  409,  411,  412};
            //double[] prices =   {0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00};
            //int itemOrdered;
            //double itemPrice = 0;
            //bool isValidItem = false;
            //Write("Please enter an item ");
            //itemOrdered = Convert.ToInt32(ReadLine());
            //for(int x = 0; x < validValues.Length; ++x)
            //{
            //   if(itemOrdered == validValues[x])
            //   {
            //      isValidItem = true;
            //      itemPrice = prices[x];
            //   }
            //}

            //if (isValidItem)
            //{
            //    WriteLine("Price is {0}", itemPrice);
            //}
            //else
            //{
            //    WriteLine("Sorry - item not found");
            //}

            //*********************************************
            ////find price with while loop
            //int x;
            //string inputString;
            //int itemOrdered;
            //double itemPrice = 0;
            //bool isValidItem = false;
            //int[] valItems =  {101,  108,  201,  213,  266, 304,  311,  409,  411,  412};
            //double[] prices = {0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00};
            //Write("Enter item number ");
            //inputString = ReadLine();
            //itemOrdered = Convert.ToInt32(inputString);
            //x = 0;
            //while(x < valItems.Length && itemOrdered != valItems[x])
            //{
            //    ++x;
            //}

            //if(x != valItems.Length)
            //{
            //    isValidItem = true;
            //    itemPrice = prices[x];
            //}

            //if (isValidItem)
            //{
            //    WriteLine("Item {0} sells for {1}", itemOrdered, itemPrice.ToString("C"));
            //}
            //else
            //{
            //    WriteLine("No such item as {0}", itemOrdered);
            //}

            //*********************************************
            //search array for range
            // Assume numOfItems is a declared integer for which a user 
            // has input a value 
            //Write("Enter number of Items: ");
            //int numOfItems = Convert.ToInt32(ReadLine());

            //int[] discountRangeLowLimits = { 1, 13, 50, 100, 200 };
            //double[] discounts = { 0, 0.10, 0.14, 0.18, 0.20 };
            //double customerDiscount;
            //int sub = discountRangeLowLimits.Length - 1;
            //while (sub >= 0 && numOfItems < discountRangeLowLimits[sub])
            //{
            //    --sub;
            //}
            //customerDiscount = discounts[sub];
            //Write("The discount is {0}.", customerDiscount.ToString("C"));

            //*********************************************
            ////Binary search
            //int[] idNumbers = {122, 167, 204, 219, 345};
            //int x;
            //string entryString;
            //int entryId;
            //Write("Enter an Employee ID ");
            //entryString = ReadLine();
            //entryId = Convert.ToInt32(entryString);
            //x = Array.BinarySearch(idNumbers, entryId);
            //if(x < 0)
            //{
            //    WriteLine("ID {0} not found", entryId);
            //}
            //else
            //{
            //    WriteLine("ID {0} found at position {1} ", entryId, x);
            //}

            //*********************************************
            ////Sort array
            //string[] names = {"Olive", "Patty", "Richard", "Ned", "Mindy"};
            //int x;
            //Array.Sort(names);
            //for(x = 0; x < names.Length; ++x)
            //{
            //    WriteLine(names[x]);
            //}

            //*********************************************
            //Reverse sort
            string[] names = {"Zach", "Rose", "Wendy", "Marcia"};
            int x;
            Array.Reverse(names);
            for(x = 0; x < names.Length; ++x)
            {
                WriteLine(names[x]);
            }
            WriteLine("Reverse again");
            WriteLine("");//empty line
            Array.Reverse(names);
            for (x = 0; x < names.Length; ++x)
            {
                WriteLine(names[x]);
            }

            //*********************************************
            //multideminsional array
              //int[ , ] rents = { {400, 450, 510},
              //           {500, 560, 630},
              //           {625, 676, 740},
              //           {1000, 1250, 1600} };
              //int floor;
              //int bedrooms;
              //string inputString;
              //Write("Enter the floor on which you want to live ");
              //inputString = ReadLine();
              //floor = Convert.ToInt32(inputString);
              //Write("Enter the number of bedrooms you need ");
              //inputString = ReadLine();
              //bedrooms = Convert.ToInt32(inputString);
              //WriteLine("The rent is {0}", rents[floor, bedrooms]);
        }
    }
}
