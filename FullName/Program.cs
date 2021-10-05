using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma Eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi");
            string lastname = Console.ReadLine();
            Console.WriteLine($" Su eesnimi on {firstname.Length} ja perekonnanimi on {lastname.Length} tähte pikk");
            if (firstname.Length < lastname.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui su eesnimi");
            }
            else if (firstname.Length > lastname.Length)
            {
                Console.WriteLine("su eesnimi on pikem kui su perekonna nimi");
            }
            else
            {
                Console.WriteLine("su nimed on sama pikad");
            }
        }
    }
}
