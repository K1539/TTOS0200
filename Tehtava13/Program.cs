/*
 * Mäkihypyssä käytetään viittä arvostelutuomaria. 
 * Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, 
 * että summasta on vähennetty pois pienin ja suurin tyylipiste.
 * 
 * Jere Liikka 12.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] PisteLista = new int[5];
            int KaikkiPisteet = 0;
            int LopullisetPisteet = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna pisteet > ");
                int Pisteet = int.Parse(Console.ReadLine());
                PisteLista[i] = Pisteet;
            }
            for (int j = 0; j < 5; j++)
            {
                KaikkiPisteet = KaikkiPisteet + PisteLista[j];
            }
            LopullisetPisteet = KaikkiPisteet - PisteLista.Max() - PisteLista.Min();

            Console.WriteLine("Kokonaispisteet ovat {0}", LopullisetPisteet);
        }
    }
}
