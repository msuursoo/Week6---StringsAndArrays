using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lause 'Hello World' tagurpidi

            Console.WriteLine("Kirjuta 'Tere maailm' võõrkeeles, ja arvuti kirjutab seda tagurpidi");
            string vastus = Console.ReadLine();

            for (int i = vastus.Length - 1; i >= 0; i--)
            {
                Console.Write(vastus[i]);
            }
        }
    }
}
