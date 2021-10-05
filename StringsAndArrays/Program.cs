using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma Eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine($"Sinu nimi on {firstname.Length} tähte pikk");
        }
    }
}
