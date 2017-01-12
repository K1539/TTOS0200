/*Tee ohjelma, joka alustaa sovellukseen käyttöön seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
 * Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
 * Jere Liikka 11.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Taulukko = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < 9; i++)
            {
                if (Taulukko[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
            }
        }
    }
}
