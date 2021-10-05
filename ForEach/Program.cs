using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "Hello world!";
            int counter = 0;
            foreach(char character in HelloWorld)
            {
                counter = counter + 1;
            }
            Console.WriteLine($"{HelloWorld} on {counter} sümbolit pikk");
        }
    }
}
