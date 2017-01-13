/*
 * Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. 
 * Tulosta lopuksi lajitellun taulukon sisältö.

Esimerkkitoiminta:


    Luvut taulukossa 1 : 10,20,30,40,50
    Luvut taulukossa 2 : 5,15,25,35,45
    Luvut yhdistetyssä taulukossa : 5,10,15,20,25,30,35,40,45,50

    Jere Liikka 13.1.2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Taulukko1 = { 10, 20, 30, 40, 50 };
            int[] Taulukko2 = { 5, 15, 25, 35, 45 };
            int[] Taulukko3 = new int[10];
            int Kerroin = 0; //kerroin, jolla päästään taulukko2 arvoihin käsiksi

            for (int i = 0; i < 5; i++)
            {
                Taulukko3[i] = Taulukko1[i];
            }
            for (int i = 5; i < 10; i++)
            {
                Taulukko3[i] = Taulukko2[Kerroin];
                Kerroin++;
            }

            for (int i = 0; i < 10; i++)
            {
                Array.Sort(Taulukko3);
                Console.WriteLine(Taulukko3[i]);
            }
        }
    }
}
