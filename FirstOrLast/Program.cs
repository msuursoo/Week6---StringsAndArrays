using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvan kumb nendest on pikem, kas ees-või perekonnanimi

            Console.WriteLine("Sisesta oma nimi");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            int lastNameLenght = lastName.Length;

            if(firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi");
            }
            else if(firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi");
            }
            else
            {
                Console.WriteLine("Sinu eesnimi ja perekonnanimi on sama pikkad");
            }
        
        }
    }
}
