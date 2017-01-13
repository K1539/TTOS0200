/*
 * ee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
 * Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. 
 * Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. 
 * Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. 
 * Tulosta lopuksi arvausten määrä näytölle. 
 * PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: 
 * Computers are lousy random number generators.
 * 
 * Jere Liikka 13.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan Random luku
            Random ArvoNumero = new Random();
            int ArvottuNumero = ArvoNumero.Next(1, 100);
            int ArvausLkm = 0;  //Arvausten lkm

            while (true)  //niin kauan kunnes break;
            {
                Console.Write("Arvaa luku > ");
                int ArvausLuku = int.Parse(Console.ReadLine());
                if (ArvausLuku > ArvottuNumero)
                {
                    Console.WriteLine("Luku on pienempi");
                    ArvausLkm++;

                }
                if (ArvausLuku < ArvottuNumero)
                {
                    Console.WriteLine("Luku on isompi");
                    ArvausLkm++;
                }
                if (ArvausLuku == ArvottuNumero)
                {
                    Console.WriteLine("Hienoa, arvasit luvun {0} kerralla.", ArvausLkm);
                    break;
                }
            }
        }
    }
}
