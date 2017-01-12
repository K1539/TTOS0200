/*
 *Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
 *Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
 *Jere Liikka 10.1.2016 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku >");
            int luku = int.Parse(Console.ReadLine());

            if (luku == 1 || luku == 2 || luku == 3)
            {
                if (luku == 1)
                {
                    Console.WriteLine("Annoit luvun yksi!");
                }
                if (luku == 2)
                {
                    Console.WriteLine("Annoit luvun kaksi!");
                }
                if (luku == 3)
                {
                    Console.WriteLine("Annoit luvun kolme!");
                }
            }
            else
            {
                Console.WriteLine("Joku muu luku!");
            }
        }
    }
}
