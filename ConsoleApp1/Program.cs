using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Next year you'll be {age + 1}");
        }
    }
}
