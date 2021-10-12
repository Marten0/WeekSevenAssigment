using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 0)
            {
                int PIN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sisesta kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta parool");
                string userPassword = Console.ReadLine();

                if(PIN == 1532)
                {
                    Console.WriteLine("Tere tulemast!");
                }
                int numCounter = Convert.ToInt32(Console.ReadLine());
                if (numCounter >= 3)
                {
                    Console.WriteLine("Vale PIN proovi uuesti");
                    break;
                } 
                else if(PIN >= 3)
                {
                    Console.WriteLine($"Vale pin {3 - i} katset jäänud.");
                }
                
                {

                }

            }
        }
    }
}
