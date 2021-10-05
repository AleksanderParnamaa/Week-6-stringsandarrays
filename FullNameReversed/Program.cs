using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma täisnimi");
            string name = (Console.ReadLine());
            for (int i = name.Length - 1; i > -1; i--)
            {
                Console.WriteLine(name[i]);
            }

        }
    }
}
