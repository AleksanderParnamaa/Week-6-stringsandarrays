using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "hello world!";
            string PartToLookFor = "hello";
            bool isthere;
            isthere = helloworld.Contains(PartToLookFor);
            if (isthere)
            {
                Console.WriteLine($"Leidsin {PartToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leidnud {PartToLookFor}");
            }
        }
    }
}
