using System;
using System.Collections.Generic;


namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many digits of pi would you like? (Max is 15) ");
            int s_digit = Int32.Parse(Console.ReadLine());
            double pi = 355.0 / 113.0;
            Console.WriteLine("Pi equals " + Math.Round(pi, s_digit));
        }



    }


}

