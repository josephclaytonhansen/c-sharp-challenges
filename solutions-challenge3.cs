
using System;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 355.0 / 113.0; //identical to pi within 9 decimal places, more accurate than 22/7

            double radius, area, circum, diameter;


            Console.Write("Enter significant digits: ");
            int sigDigits = Int32.Parse(Console.ReadLine()); //user chooses the value that numbers round to

            Console.Write("Enter radius in inches: ");
            string userInput = Console.ReadLine(); //get radius as string

            radius = Double.Parse(userInput); //convert string to decimal number. Double.parse allows for decimal input
            area = Math.Round(((Pi * (radius / 12 * radius / 12))), sigDigits); //calculate area, and divide by inches

            //note that (Pi * radius * radius) / (12 * 12) would return exactly the same result, or (Pi * radius * radius) / 144
            Console.WriteLine("Area of the circle is " + area.ToString() + " square feet.");

            circum = Math.Round(Pi * 2 * (radius / 12), sigDigits); //still in feet, but it's not square feet, so we only divide by 12 once
            Console.WriteLine("Circumference of the circle is " + circum.ToString() + " feet.");

            diameter = Math.Round((radius / 12 * 2), sigDigits);
            Console.WriteLine("Diameter of the circle is " + diameter.ToString() + " feet.");





        }


    }


}
