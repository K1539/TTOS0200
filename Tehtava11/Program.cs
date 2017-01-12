/*
 * Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
 * *
 * **
 * ***
 * ****
 * *****
 *
 * Käyttäjä antaa syötteenä tähtirivien lukumäärän. Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.
 *
 * Jere Liikka 12.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava11
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            Console.WriteLine("Anna luku > ");
            int Luku = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Luku; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
