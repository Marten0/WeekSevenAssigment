using System;

namespace FullNmeInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere {firstName} {lastName}.");
        }
    }
}
