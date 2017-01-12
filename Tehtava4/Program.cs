/*
 * Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. 
 * Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
 * Jere Liikka 10.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikasi numeroina > ");
            int Ika = int.Parse(Console.ReadLine());

            if (Ika <= 65)
            {
                if (Ika < 18)
                {
                    Console.WriteLine("Alaikainen");
                }
                if (Ika <= 65 && Ika >= 18)
                {
                    Console.WriteLine("Aikuinen");
                }
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }
    }
}
