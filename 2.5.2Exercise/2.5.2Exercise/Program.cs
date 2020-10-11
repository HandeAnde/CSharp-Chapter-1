using System;

namespace _2._5._2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length:");
            string lengthStr = Console.ReadLine();
            int length = int.Parse(lengthStr);
            Console.WriteLine("Enter Width:");
            string widthStr = Console.ReadLine();
            int width = int.Parse(widthStr);

            double area = length * width;
            Console.WriteLine("The area of your rectangle with a length of: " + length + " and a width of: " + width + " is: " + area);
        }
    }
}
