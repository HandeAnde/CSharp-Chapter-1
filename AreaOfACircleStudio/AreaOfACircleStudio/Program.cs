using System;

namespace AreaOfACircleStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            string radiusStr = Console.ReadLine();
            double radius = double.Parse(radiusStr);
            double area = 3.14 * radius * radius;
            double circumference = 2 * 3.14 * radius;


            Console.WriteLine("The area of a circle with a radius " + radius + " is: " + area);
            Console.WriteLine("The area of a circle with a radius " + radius + " is: " + circumference);
            Console.WriteLine("How many miles per gallon?");
            string mpgStr = Console.ReadLine();
            double mpg = double.Parse(mpgStr);

            double mpgTotal = radius / mpg;

            Console.WriteLine("If your car gets " + mpg + " miles per gallon. It will take " + mpgTotal + " gallons of gas to get around the circle");


        }
    }
}
