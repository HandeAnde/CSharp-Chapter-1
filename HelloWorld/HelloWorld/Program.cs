using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
        }
    }
}
