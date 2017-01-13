/*
 * Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). 
 * Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
 * 
 * Jere Liikka 13.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita merkkijono > ");
            string AnnettuSana = Console.ReadLine();
            string KaannettySana = new string(AnnettuSana.Reverse().ToArray());
                        
            if (AnnettuSana == KaannettySana)
            {
                Console.WriteLine("Sana on palindromi!");
            }
            else
            {
                Console.WriteLine("Sana ei ole palindromi.");
            }
            
        }
    }
}
