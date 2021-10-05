using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma Eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi");
            string lastname = Console.ReadLine();
            string fullname = $"{firstname}{lastname}";
            int counter = 0;
          //foreach (char character in fullname)
            {
        //      if (character == 'a')

                {
          //        counter++;
                }
            //  Console.WriteLine($"Sinu nimes on {counter} a-tähte");
            }
            int i = fullname.Length;
            while (i>= 0)
            {
                if (fullname[fullname.Length - 1] == 'a')
                {
                    Console.WriteLine(fullname[fullname.Length - 1]);
                    counter++;
                }
                i--;
            }
            Console.WriteLine($"sinu nimes on {counter} a-tähte");

        }
    }
}
