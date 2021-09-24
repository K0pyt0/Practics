using System;
namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}