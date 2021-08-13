using System;

namespace ForPetlja
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int brojac = 1; brojac < 20; brojac++)
            {
                if (brojac % 2 == 0)
                    continue;
                Console.WriteLine($"Sada je {brojac}");
                if (brojac == 15)
                    break;
            }
        }
    }
}
