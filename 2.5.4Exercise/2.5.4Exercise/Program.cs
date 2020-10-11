using System;
using System.Runtime.InteropServices.ComTypes;

namespace _2._5._4Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Search for a word:");
            string word = Console.ReadLine();

            if (alice.ToLower().Contains(word.ToLower()))
            {
                Console.WriteLine("contains");
            } else
            {
                Console.WriteLine("Doesn't Contain");
            }


        }
    }
}
