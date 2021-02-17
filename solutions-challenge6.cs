using System;
using System.Collections.Generic;


namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("==== DIGITAL DOGS ====\nHot dog        $1.00\nKetchup        $0.20\nMustard        $0.20\nOnions         $0.25\nCream cheese   $0.50\nMushrooms      $0.30\nJalapenos      $0.30\n");

            string[] toppings = { "ketchup", "mustard", "onions", "cream cheese", "mushrooms", "jalapenos" };
            double[] topping_prices = { .2, .2, .25, .50, .30, .30 };
            double price = 1.00;
            List<string> hotdog = new List<string>();
            string toppings_string = "";

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Do you want " + toppings[i] + " on your hot dog (Y/N)? ");
                if (Console.ReadLine() == "Y")
                {
                    price += topping_prices[i];
                    hotdog.Add(toppings[i]);

                }
                else
                {
                    price += 0;
                }
            }
            int topping_count = 0;
            foreach (string a in hotdog)
            {
                topping_count += 1;
                if (topping_count == hotdog.Count)
                {
                    if (hotdog.Count == 1)
                    {
                        toppings_string += a + ".";
                    }
                    else
                    {
                        toppings_string += "and " + a + ".";
                    }
                }
                else
                {
                    toppings_string += a + ", ";
                }
            }
            price *= 1.06;
            Console.WriteLine("Your hot dog has " + toppings_string);
            Console.WriteLine("Your hot dog costs $" + Math.Round(price, 2).ToString("0.00"));
        }



    }


}

