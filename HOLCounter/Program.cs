using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mittu 'h', 'o', ja 'l' tähte on lauses "Hello World!" 

            Console.WriteLine("Kirjuta 'Tere maailm' võõrkeeles");
            string vastus = Console.ReadLine().ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < vastus.Length; i++)
            {
                if(vastus[i] == 'h')
                {
                    hCounter++;
                }
                else if(vastus[i] == 'o')
                {
                    oCounter++;
                }
                else if(vastus[i] == 'l')
                {
                    lCounter++;
                }
            }
            Console.WriteLine($"Selles lauses on {hCounter} 'h', {oCounter} 'o' ja {lCounter} 'l' tähte");




        }
    }
}
