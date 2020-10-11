using System;
using System.Threading;

namespace circleRadius
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a Radius:");
            int radius = int.Parse(Console.ReadLine());
            int area = 3.14 * radius * radius;


            Console.WriteLine('The area of a circle of radius ' + radius + ' is:' + area);
        }
    }
}
