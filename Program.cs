using System;

namespace ReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name=Console.ReadLine();
            Console.WriteLine("Hello"+name);
            Console.WriteLine("Hello{0}",name);
            Console.WriteLine($"Hello{name}");
        }
    }
}
