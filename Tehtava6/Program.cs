/*
 * Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
 * Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
 * Jere Liikka 10.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {
            double KulutusKm = 0.0702;
            double BensanHintaLtr = 1.595;

            Console.Write("Anna matka > ");
            int KuljettuMatka = int.Parse(Console.ReadLine());
            double BensanKulutus = (KulutusKm * KuljettuMatka);
            Console.WriteLine("Bensaa kuluu {0:0.00} litraa, kustannus {1:0.00} euroa.", BensanKulutus, (BensanKulutus * BensanHintaLtr));
        }
    }
}
