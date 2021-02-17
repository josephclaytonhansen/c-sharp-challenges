using System;
using System.Collections.Generic;


namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (input1.ToLower() == input2.ToLower())
            {
                Console.WriteLine("They match!");
            }
            else
            {
                Console.WriteLine("They don't match");
            }

        }



    }


}

