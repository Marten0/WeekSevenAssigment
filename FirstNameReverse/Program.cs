using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string name = Console.ReadLine();

            if (name.Length >= 5)
            {
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{name[i]}");
                }
            }
            else
            {
                Console.Write($"{name}");
            }



        }
    }
}
