/*
 * Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. 
 * Luvut tulee sijoittaa taulukkoon. 
 * Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
 * 
 * Jere Liikka 12.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Taulukko = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku > ");
                int Luku = int.Parse(Console.ReadLine());

                Taulukko[i] = Luku;
            }
            Console.Write("Luvut ovat ");
            for (int j = 4; j >= 0; j--)
            {
                Console.Write(Taulukko[j]);
                if (Taulukko[j] > 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
