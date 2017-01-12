/*
 * Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. 
 * Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.
 * ¨Jere Liikka 12.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku > ");
            int Luku = int.Parse(Console.ReadLine());
            int Leveys = Luku - (Luku - 1);

            for (int i = 0; i < Luku ; i++)
            {

            }

            Console.WriteLine("*"); Console.WriteLine("*");
        }
    }
}
